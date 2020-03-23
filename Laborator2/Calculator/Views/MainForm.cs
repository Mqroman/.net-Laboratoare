using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator.Views
{
    // ReSharper disable once ClassTooBig
    public partial class MainForm : Form
    {
        private readonly Models.Calculator _calculator = new Models.Calculator();
        private bool _resetMainDisplay;
        private readonly IList<string> _historyResultList = new List<string>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainViewLoaded(object sender, EventArgs e)
        {
            InitMainDisplay();
        }

        private void OperationButtonClick(object sender, EventArgs e)
        {
            var operation = (Button)sender;

            if (_calculator.HasOperand())
            {
                var temp = new StringBuilder(secondDisplayBox.Text);
                temp.Length -= 1;
                secondDisplayBox.Clear();
                secondDisplayBox.Text = $@"{temp}{Models.Calculator.Operation[operation.Tag.ToString()]}";
                return;
            }

            if (secondDisplayBox.TextLength > 0)
            {
                if (secondDisplayBox.Text.Substring(secondDisplayBox.TextLength - 1, 1) == ")")
                {
                    secondDisplayBox.Text += $@"{Models.Calculator.Operation[operation.Tag.ToString()]}";
                    ShowPartialOperation();
                    _resetMainDisplay = true;
                    return;
                }
            }

            secondDisplayBox.Text += $@"{mainDisplayBox.Text}{Models.Calculator.Operation[operation.Tag.ToString()]}";
            ShowPartialOperation();
            _resetMainDisplay = true;
        }

        private void InitMainDisplay()
        {
            mainDisplayBox.Clear();
            mainDisplayBox.Text = @"0";
            _resetMainDisplay = true;
        }

        private void ShowPartialOperation()
        {
            var operationString = BuildOperationString();
            var result = Models.Calculator.OperatorsSymbols.Any(x => operationString.ToString().EndsWith(x));
            if(result) operationString.Remove(operationString.Length - 1, 1);
            var value = new DataTable().Compute(operationString.ToString(), null);
            mainDisplayBox.Clear();
            mainDisplayBox.Text = value.ToString();
        }

        private Dictionary<string, string> ShowFinalOperation()
        {
            var operationString = BuildOperationString();
            var value = new DataTable().Compute(operationString.ToString(), null);
            _calculator.ResetCalculatorBuff();
            mainDisplayBox.Clear();
            secondDisplayBox.Clear();
            mainDisplayBox.Text = value.ToString();

            return new Dictionary<string, string>
            {
                {"operationString", operationString.ToString()},
                {"value",value.ToString()}
            };
        }

        private StringBuilder BuildOperationString()
        {
            var partialOperationString = new StringBuilder(secondDisplayBox.Text);

            var result = Models.Calculator.OperatorsSymbols.Any(x => partialOperationString.ToString().EndsWith(x));

            if(result) partialOperationString.Length--;

            if (_calculator.LeftParenthesis <= 0) return partialOperationString;

            for (var i = 0; i < _calculator.LeftParenthesis; i++)
            {
                partialOperationString.Append(")");
            }

            return partialOperationString;
        }

        private void NumericButtonClick(object sender, EventArgs e)
        {
            if (_resetMainDisplay)
            {
                mainDisplayBox.Clear();
                _resetMainDisplay = false;
            }

            _calculator.NumericSelection();
            var number = (Button)sender;
            mainDisplayBox.Text += number.Text;
        }

        private void OperationResultHandler(object sender, EventArgs e)
        {
            var result = Models.Calculator.OperatorsSymbols.Any(x => secondDisplayBox.Text.EndsWith(x));

            if (!result) return;

            secondDisplayBox.Text += mainDisplayBox.Text;
            AddOperationToHistory(ShowFinalOperation());
            _resetMainDisplay = true;
            _calculator.LeftParenthesis = 0;
            paranthesNumber.Text = "";
        }

        private void AddOperationToHistory(IReadOnlyDictionary<string, string> showFinalOperation)
        {
            if (_resetMainDisplay) return;

            if (!Models.Calculator.OperatorsSymbols.Any(x => showFinalOperation["operationString"].Contains(x))) return;

            historyList.Items.Add(
                new ListViewItem(
                    new []
                    {
                        $"{showFinalOperation["operationString"]} = {showFinalOperation["value"]}"
                    }));

            _historyResultList.Add(showFinalOperation["value"]);
            
            historyList.Refresh();
        }

        private void FormatMainDisplayText(object sender, EventArgs e)
        {
            mainDisplayBox.SelectAll();
            mainDisplayBox.SelectionAlignment = HorizontalAlignment.Right;
            mainDisplayBox.SelectionFont = new Font("Tahoma", 20, FontStyle.Bold);
            mainDisplayBox.SelectionColor = Color.Black;
        }

        private void FormatSecondDisplayText(object sender, EventArgs e)
        {
            mainDisplayBox.SelectAll();
            mainDisplayBox.SelectionAlignment = HorizontalAlignment.Right;
            mainDisplayBox.SelectionFont = new Font("Tahoma", 10, FontStyle.Italic);
            mainDisplayBox.SelectionColor = Color.Black;
        }

        private void BothParenthesisClick(object sender, EventArgs e)
        {
            if (secondDisplayBox.Text.Length == 0) return;

            if(secondDisplayBox.Text.Substring(0,1).Contains("("))
            {
                if (secondDisplayBox.Text.Substring(secondDisplayBox.Text.Length-2,1).Equals(")"))
                {
                    return;
                }
            }

            secondDisplayBox.Text = secondDisplayBox.Text.Insert(0, "(");
            secondDisplayBox.Text =
                secondDisplayBox.Text.Insert(secondDisplayBox.Text.Length-1, ")");
            secondDisplayBox.Refresh();
        }

        private void RemoveOperationClick(object sender, EventArgs e)
        {
            _calculator.ResetCalculatorBuff();
            mainDisplayBox.Clear();
            secondDisplayBox.Clear();
            paranthesNumber.Text = "";
            InitMainDisplay();
        }

        private void LeftParanthesClick(object sender, EventArgs e)
        {
            if (secondDisplayBox.TextLength > 0)
            {
                if (secondDisplayBox.Text.Substring(secondDisplayBox.TextLength - 1, 1).Contains(")")) return;
            }

            paranthesNumber.Text = (++_calculator.LeftParenthesis).ToString();
            secondDisplayBox.Text =
                secondDisplayBox.Text.Insert(secondDisplayBox.Text.Length, "(");
            secondDisplayBox.Refresh();
            mainDisplayBox.Clear();
            mainDisplayBox.Text = @"0";
        }

        private void RightParanthesClick(object sender, EventArgs e)
        {
            if (_calculator.LeftParenthesis == 0) return;

            secondDisplayBox.Text += mainDisplayBox.Text;
            secondDisplayBox.Text =
                secondDisplayBox.Text.Insert(secondDisplayBox.Text.Length, ")");
            secondDisplayBox.Refresh();

            if (_calculator.LeftParenthesis == 1)
                paranthesNumber.Text = "";
            else
                paranthesNumber.Text = (--_calculator.LeftParenthesis).ToString();

            _calculator.LeftParenthesis--;
            ShowPartialOperation();
        }


        private void MainFormKeyPressEvent(object sender, KeyPressEventArgs e)
        {
            var selectKeyGroup = Controls.Find("standardGroup", false).FirstOrDefault();

            foreach (var button in selectKeyGroup.Controls.OfType<Button>())
            {
                if (int.TryParse(e.KeyChar.ToString(), out var keyPressNumber))
                {
                    if (button.Text != keyPressNumber.ToString()) continue;
                    
                    button.PerformClick();
                    return;
                }

                if (!Models.Calculator.TryGetOperationKey(e.KeyChar.ToString(), out var keyPressOperation)) continue;
                if (!Equals(button.Tag, keyPressOperation)) continue;
                
                button.PerformClick();
                return;
            }
        }

        private void MainFormKeyDownEvent(object sender, KeyEventArgs e)
        {
            ReturnButton(out var button, e);
            button?.PerformClick();
        }

        private void ReturnButton(out Button button, KeyEventArgs e)
        {
            button = new Button();

            if(e.KeyCode == Keys.Enter)
            {
                button = Controls.Find("equalButton", true).FirstOrDefault() as Button;
                return;
            }

            switch (e.KeyCode.ToString())
            {
                case "Back":
                    button = Controls.Find("removeFigure", true).FirstOrDefault() as Button;
                    break;
                case "Decimal":
                    button = Controls.Find("dotButton", true).FirstOrDefault() as Button;
                    break;
                case "Delete":
                    button = Controls.Find("removeNumber", true).FirstOrDefault() as Button;
                    break;
            }
        }

        private void SelectedHistoryItemsHandler(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var computerSum = new StringBuilder("0");
            foreach (ListViewItem item in historyList.SelectedItems)
            {
                var index = historyList.Items.IndexOf(item);
                computerSum.Append("+");
                computerSum.Append(_historyResultList[index]);
            }

            var value = new DataTable().Compute(computerSum.ToString(), null);
            combineDisplayBox.Text = value.ToString();
            combineDisplayBox.Refresh();
        }

        private void ClearHistoryButtonHandler(object sender, EventArgs e)
        {
            _historyResultList.Clear();
            historyList.Clear();
            combineDisplayBox.Clear();
            historyList.Refresh();
            combineDisplayBox.Refresh();
        }

        private void RemoveOneNumber(object sender, EventArgs e)
        {
            var removeNumber = new StringBuilder(mainDisplayBox.Text);

            if (removeNumber.Length > 1)
            {
                removeNumber.Length--;
            }
            else
            {
                removeNumber.Clear();
                removeNumber.Append("0");
                _resetMainDisplay = true;
            }

            mainDisplayBox.Clear();
            mainDisplayBox.Text = removeNumber.ToString();
        }

        private void ChangeNumberSign(object sender, EventArgs e)
        {
            var changeNumber = mainDisplayBox.Text;

            changeNumber = changeNumber.Contains("-") 
                ? changeNumber.Substring(1) : changeNumber.Insert(0, "-");

            mainDisplayBox.Clear();
            mainDisplayBox.Text = changeNumber;
        }


        private void ClearMainDisplayHandler(object sender, EventArgs e)
        {
            mainDisplayBox.Clear();
            mainDisplayBox.Text = @"0";
            _resetMainDisplay = true;
        }

        private void CheckFloatStateHandler(object sender, EventArgs e)
        {
            if (mainDisplayBox.Text.Equals("0") && _resetMainDisplay)
            {
                _resetMainDisplay = false;
            }

            if (mainDisplayBox.Text.Contains(".")) return;

            mainDisplayBox.Text += @".";
        }
    }
}
