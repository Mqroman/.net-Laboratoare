using System.Windows.Forms;
using Calculator.CustomForms;

namespace Calculator.Views
{
    using System;

    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.standardGroup = new System.Windows.Forms.GroupBox();
            this.paranthesNumber = new Calculator.CustomForms.ParanthesTextBox();
            this.rightParanthes = new System.Windows.Forms.Button();
            this.leftParanthes = new System.Windows.Forms.Button();
            this.bothParenthesis = new System.Windows.Forms.Button();
            this.secondDisplayBox = new System.Windows.Forms.RichTextBox();
            this.mainDisplayBox = new System.Windows.Forms.RichTextBox();
            this.numberSignButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.dotButton = new System.Windows.Forms.Button();
            this.treeButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.removeFigure = new System.Windows.Forms.Button();
            this.removeOperation = new System.Windows.Forms.Button();
            this.removeNumber = new System.Windows.Forms.Button();
            this.equalButton = new System.Windows.Forms.Button();
            this.divisonButton = new System.Windows.Forms.Button();
            this.multiButton = new System.Windows.Forms.Button();
            this.minusButon = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.historyGroup = new System.Windows.Forms.GroupBox();
            this.historyList = new System.Windows.Forms.ListView();
            this.combineDisplayBox = new System.Windows.Forms.RichTextBox();
            this.clearHistoryButton = new System.Windows.Forms.Button();
            this.standardGroup.SuspendLayout();
            this.historyGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // standardGroup
            // 
            this.standardGroup.Controls.Add(this.paranthesNumber);
            this.standardGroup.Controls.Add(this.rightParanthes);
            this.standardGroup.Controls.Add(this.leftParanthes);
            this.standardGroup.Controls.Add(this.bothParenthesis);
            this.standardGroup.Controls.Add(this.secondDisplayBox);
            this.standardGroup.Controls.Add(this.mainDisplayBox);
            this.standardGroup.Controls.Add(this.numberSignButton);
            this.standardGroup.Controls.Add(this.zeroButton);
            this.standardGroup.Controls.Add(this.dotButton);
            this.standardGroup.Controls.Add(this.treeButton);
            this.standardGroup.Controls.Add(this.twoButton);
            this.standardGroup.Controls.Add(this.oneButton);
            this.standardGroup.Controls.Add(this.fourButton);
            this.standardGroup.Controls.Add(this.fiveButton);
            this.standardGroup.Controls.Add(this.sixButton);
            this.standardGroup.Controls.Add(this.nineButton);
            this.standardGroup.Controls.Add(this.eightButton);
            this.standardGroup.Controls.Add(this.SevenButton);
            this.standardGroup.Controls.Add(this.removeFigure);
            this.standardGroup.Controls.Add(this.removeOperation);
            this.standardGroup.Controls.Add(this.removeNumber);
            this.standardGroup.Controls.Add(this.equalButton);
            this.standardGroup.Controls.Add(this.divisonButton);
            this.standardGroup.Controls.Add(this.multiButton);
            this.standardGroup.Controls.Add(this.minusButon);
            this.standardGroup.Controls.Add(this.plusButton);
            this.standardGroup.Location = new System.Drawing.Point(12, 12);
            this.standardGroup.Name = "standardGroup";
            this.standardGroup.Size = new System.Drawing.Size(369, 426);
            this.standardGroup.TabIndex = 1;
            this.standardGroup.TabStop = false;
            this.standardGroup.Text = "Standard";
            // 
            // paranthesNumber
            // 
            this.paranthesNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.paranthesNumber.CausesValidation = false;
            this.paranthesNumber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.paranthesNumber.Location = new System.Drawing.Point(142, 157);
            this.paranthesNumber.MaxLength = 100;
            this.paranthesNumber.Name = "paranthesNumber";
            this.paranthesNumber.ReadOnly = true;
            this.paranthesNumber.ShortcutsEnabled = false;
            this.paranthesNumber.Size = new System.Drawing.Size(15, 15);
            this.paranthesNumber.TabIndex = 20;
            this.paranthesNumber.WordWrap = false;
            // 
            // rightParanthes
            // 
            this.rightParanthes.BackColor = System.Drawing.SystemColors.Control;
            this.rightParanthes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rightParanthes.FlatAppearance.BorderSize = 0;
            this.rightParanthes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rightParanthes.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.rightParanthes.Location = new System.Drawing.Point(187, 130);
            this.rightParanthes.Name = "rightParanthes";
            this.rightParanthes.Size = new System.Drawing.Size(85, 43);
            this.rightParanthes.TabIndex = 21;
            this.rightParanthes.Text = ")";
            this.rightParanthes.UseVisualStyleBackColor = false;
            this.rightParanthes.Click += new System.EventHandler(this.RightParanthesClick);
            // 
            // leftParanthes
            // 
            this.leftParanthes.BackColor = System.Drawing.SystemColors.Control;
            this.leftParanthes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.leftParanthes.FlatAppearance.BorderSize = 0;
            this.leftParanthes.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.leftParanthes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leftParanthes.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.leftParanthes.Location = new System.Drawing.Point(96, 130);
            this.leftParanthes.Name = "leftParanthes";
            this.leftParanthes.Size = new System.Drawing.Size(85, 43);
            this.leftParanthes.TabIndex = 20;
            this.leftParanthes.Text = "(";
            this.leftParanthes.UseVisualStyleBackColor = false;
            this.leftParanthes.Click += new System.EventHandler(this.LeftParanthesClick);
            // 
            // bothParenthesis
            // 
            this.bothParenthesis.BackColor = System.Drawing.SystemColors.Control;
            this.bothParenthesis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bothParenthesis.FlatAppearance.BorderSize = 0;
            this.bothParenthesis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bothParenthesis.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.bothParenthesis.Location = new System.Drawing.Point(5, 130);
            this.bothParenthesis.Name = "bothParenthesis";
            this.bothParenthesis.Size = new System.Drawing.Size(85, 43);
            this.bothParenthesis.TabIndex = 19;
            this.bothParenthesis.Text = "( )";
            this.bothParenthesis.UseVisualStyleBackColor = false;
            this.bothParenthesis.Click += new System.EventHandler(this.BothParenthesisClick);
            // 
            // secondDisplayBox
            // 
            this.secondDisplayBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.secondDisplayBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.secondDisplayBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondDisplayBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.secondDisplayBox.Location = new System.Drawing.Point(6, 32);
            this.secondDisplayBox.Multiline = false;
            this.secondDisplayBox.Name = "secondDisplayBox";
            this.secondDisplayBox.ReadOnly = true;
            this.secondDisplayBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.secondDisplayBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.secondDisplayBox.Size = new System.Drawing.Size(357, 27);
            this.secondDisplayBox.TabIndex = 0;
            this.secondDisplayBox.Text = "";
            this.secondDisplayBox.WordWrap = false;
            this.secondDisplayBox.TextChanged += new System.EventHandler(this.FormatSecondDisplayText);
            // 
            // mainDisplayBox
            // 
            this.mainDisplayBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.mainDisplayBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainDisplayBox.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.mainDisplayBox.Location = new System.Drawing.Point(6, 65);
            this.mainDisplayBox.Multiline = false;
            this.mainDisplayBox.Name = "mainDisplayBox";
            this.mainDisplayBox.ReadOnly = true;
            this.mainDisplayBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mainDisplayBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.mainDisplayBox.Size = new System.Drawing.Size(357, 59);
            this.mainDisplayBox.TabIndex = 1;
            this.mainDisplayBox.Text = "";
            this.mainDisplayBox.WordWrap = false;
            this.mainDisplayBox.TextChanged += new System.EventHandler(this.FormatMainDisplayText);
            // 
            // numberSignButton
            // 
            this.numberSignButton.BackColor = System.Drawing.SystemColors.Control;
            this.numberSignButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numberSignButton.FlatAppearance.BorderSize = 0;
            this.numberSignButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numberSignButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.numberSignButton.Location = new System.Drawing.Point(5, 375);
            this.numberSignButton.Name = "numberSignButton";
            this.numberSignButton.Size = new System.Drawing.Size(85, 43);
            this.numberSignButton.TabIndex = 15;
            this.numberSignButton.Text = "±";
            this.numberSignButton.UseVisualStyleBackColor = false;
            this.numberSignButton.Click += new System.EventHandler(this.ChangeNumberSign);
            // 
            // zeroButton
            // 
            this.zeroButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.zeroButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zeroButton.FlatAppearance.BorderSize = 0;
            this.zeroButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zeroButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.zeroButton.Location = new System.Drawing.Point(96, 375);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(85, 43);
            this.zeroButton.TabIndex = 16;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = false;
            this.zeroButton.Click += new System.EventHandler(this.NumericButtonClick);
            // 
            // dotButton
            // 
            this.dotButton.BackColor = System.Drawing.SystemColors.Control;
            this.dotButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dotButton.FlatAppearance.BorderSize = 0;
            this.dotButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dotButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.dotButton.Location = new System.Drawing.Point(187, 375);
            this.dotButton.Name = "dotButton";
            this.dotButton.Size = new System.Drawing.Size(85, 43);
            this.dotButton.TabIndex = 17;
            this.dotButton.Text = ".";
            this.dotButton.UseVisualStyleBackColor = false;
            this.dotButton.Click += new System.EventHandler(this.CheckFloatStateHandler);
            // 
            // treeButton
            // 
            this.treeButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.treeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.treeButton.FlatAppearance.BorderSize = 0;
            this.treeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.treeButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.treeButton.Location = new System.Drawing.Point(187, 326);
            this.treeButton.Name = "treeButton";
            this.treeButton.Size = new System.Drawing.Size(85, 43);
            this.treeButton.TabIndex = 15;
            this.treeButton.Text = "3";
            this.treeButton.UseVisualStyleBackColor = false;
            this.treeButton.Click += new System.EventHandler(this.NumericButtonClick);
            // 
            // twoButton
            // 
            this.twoButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.twoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.twoButton.FlatAppearance.BorderSize = 0;
            this.twoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.twoButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.twoButton.Location = new System.Drawing.Point(96, 326);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(85, 43);
            this.twoButton.TabIndex = 14;
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = false;
            this.twoButton.Click += new System.EventHandler(this.NumericButtonClick);
            // 
            // oneButton
            // 
            this.oneButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.oneButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.oneButton.FlatAppearance.BorderSize = 0;
            this.oneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oneButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.oneButton.Location = new System.Drawing.Point(5, 326);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(85, 43);
            this.oneButton.TabIndex = 13;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = false;
            this.oneButton.Click += new System.EventHandler(this.NumericButtonClick);
            // 
            // fourButton
            // 
            this.fourButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fourButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fourButton.FlatAppearance.BorderSize = 0;
            this.fourButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fourButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.fourButton.Location = new System.Drawing.Point(5, 277);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(85, 43);
            this.fourButton.TabIndex = 9;
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = false;
            this.fourButton.Click += new System.EventHandler(this.NumericButtonClick);
            // 
            // fiveButton
            // 
            this.fiveButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fiveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fiveButton.FlatAppearance.BorderSize = 0;
            this.fiveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fiveButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.fiveButton.Location = new System.Drawing.Point(96, 277);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(85, 43);
            this.fiveButton.TabIndex = 10;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = false;
            this.fiveButton.Click += new System.EventHandler(this.NumericButtonClick);
            // 
            // sixButton
            // 
            this.sixButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sixButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sixButton.FlatAppearance.BorderSize = 0;
            this.sixButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sixButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.sixButton.Location = new System.Drawing.Point(187, 277);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(85, 43);
            this.sixButton.TabIndex = 11;
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = false;
            this.sixButton.Click += new System.EventHandler(this.NumericButtonClick);
            // 
            // nineButton
            // 
            this.nineButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nineButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nineButton.FlatAppearance.BorderSize = 0;
            this.nineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nineButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.nineButton.Location = new System.Drawing.Point(187, 228);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(85, 43);
            this.nineButton.TabIndex = 7;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = false;
            this.nineButton.Click += new System.EventHandler(this.NumericButtonClick);
            // 
            // eightButton
            // 
            this.eightButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.eightButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eightButton.FlatAppearance.BorderSize = 0;
            this.eightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eightButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.eightButton.Location = new System.Drawing.Point(96, 228);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(85, 43);
            this.eightButton.TabIndex = 6;
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = false;
            this.eightButton.Click += new System.EventHandler(this.NumericButtonClick);
            // 
            // SevenButton
            // 
            this.SevenButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SevenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SevenButton.FlatAppearance.BorderSize = 0;
            this.SevenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SevenButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.SevenButton.Location = new System.Drawing.Point(5, 228);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(85, 43);
            this.SevenButton.TabIndex = 5;
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = false;
            this.SevenButton.Click += new System.EventHandler(this.NumericButtonClick);
            // 
            // removeFigure
            // 
            this.removeFigure.BackColor = System.Drawing.SystemColors.Control;
            this.removeFigure.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeFigure.FlatAppearance.BorderSize = 0;
            this.removeFigure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeFigure.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.removeFigure.Location = new System.Drawing.Point(187, 179);
            this.removeFigure.Name = "removeFigure";
            this.removeFigure.Size = new System.Drawing.Size(85, 43);
            this.removeFigure.TabIndex = 3;
            this.removeFigure.Text = "<=";
            this.removeFigure.UseVisualStyleBackColor = false;
            this.removeFigure.Click += new System.EventHandler(this.RemoveOneNumber);
            // 
            // removeOperation
            // 
            this.removeOperation.BackColor = System.Drawing.SystemColors.Control;
            this.removeOperation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeOperation.FlatAppearance.BorderSize = 0;
            this.removeOperation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeOperation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeOperation.Location = new System.Drawing.Point(96, 179);
            this.removeOperation.Name = "removeOperation";
            this.removeOperation.Size = new System.Drawing.Size(85, 43);
            this.removeOperation.TabIndex = 2;
            this.removeOperation.Text = "C";
            this.removeOperation.UseVisualStyleBackColor = false;
            this.removeOperation.Click += new System.EventHandler(this.RemoveOperationClick);
            // 
            // removeNumber
            // 
            this.removeNumber.BackColor = System.Drawing.SystemColors.Control;
            this.removeNumber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeNumber.FlatAppearance.BorderSize = 0;
            this.removeNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeNumber.Location = new System.Drawing.Point(5, 179);
            this.removeNumber.Name = "removeNumber";
            this.removeNumber.Size = new System.Drawing.Size(85, 43);
            this.removeNumber.TabIndex = 1;
            this.removeNumber.Text = "CE";
            this.removeNumber.UseVisualStyleBackColor = false;
            this.removeNumber.Click += new System.EventHandler(this.ClearMainDisplayHandler);
            // 
            // equalButton
            // 
            this.equalButton.BackColor = System.Drawing.SystemColors.Control;
            this.equalButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.equalButton.FlatAppearance.BorderSize = 0;
            this.equalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.equalButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalButton.Location = new System.Drawing.Point(278, 326);
            this.equalButton.Name = "equalButton";
            this.equalButton.Size = new System.Drawing.Size(85, 93);
            this.equalButton.TabIndex = 18;
            this.equalButton.Tag = "Equal";
            this.equalButton.Text = "=";
            this.equalButton.UseVisualStyleBackColor = false;
            this.equalButton.Click += new System.EventHandler(this.OperationResultHandler);
            // 
            // divisonButton
            // 
            this.divisonButton.BackColor = System.Drawing.SystemColors.Control;
            this.divisonButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.divisonButton.FlatAppearance.BorderSize = 0;
            this.divisonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.divisonButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.divisonButton.Location = new System.Drawing.Point(278, 277);
            this.divisonButton.Name = "divisonButton";
            this.divisonButton.Size = new System.Drawing.Size(85, 43);
            this.divisonButton.TabIndex = 12;
            this.divisonButton.Tag = "Division";
            this.divisonButton.Text = "÷";
            this.divisonButton.UseVisualStyleBackColor = false;
            this.divisonButton.Click += new System.EventHandler(this.OperationButtonClick);
            // 
            // multiButton
            // 
            this.multiButton.BackColor = System.Drawing.SystemColors.Control;
            this.multiButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.multiButton.FlatAppearance.BorderSize = 0;
            this.multiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.multiButton.Location = new System.Drawing.Point(278, 228);
            this.multiButton.Name = "multiButton";
            this.multiButton.Size = new System.Drawing.Size(85, 43);
            this.multiButton.TabIndex = 8;
            this.multiButton.Tag = "Multiplication";
            this.multiButton.Text = "×";
            this.multiButton.UseVisualStyleBackColor = false;
            this.multiButton.Click += new System.EventHandler(this.OperationButtonClick);
            // 
            // minusButon
            // 
            this.minusButon.BackColor = System.Drawing.SystemColors.Control;
            this.minusButon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minusButon.FlatAppearance.BorderSize = 0;
            this.minusButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minusButon.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.minusButon.Location = new System.Drawing.Point(278, 179);
            this.minusButon.Name = "minusButon";
            this.minusButon.Size = new System.Drawing.Size(85, 43);
            this.minusButon.TabIndex = 4;
            this.minusButon.Tag = "Minus";
            this.minusButon.Text = "−";
            this.minusButon.UseVisualStyleBackColor = false;
            this.minusButon.Click += new System.EventHandler(this.OperationButtonClick);
            // 
            // plusButton
            // 
            this.plusButton.BackColor = System.Drawing.SystemColors.Control;
            this.plusButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.plusButton.FlatAppearance.BorderSize = 0;
            this.plusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.plusButton.Location = new System.Drawing.Point(278, 130);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(85, 43);
            this.plusButton.TabIndex = 0;
            this.plusButton.Tag = "Plus";
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = false;
            this.plusButton.Click += new System.EventHandler(this.OperationButtonClick);
            // 
            // historyGroup
            // 
            this.historyGroup.Controls.Add(this.historyList);
            this.historyGroup.Controls.Add(this.combineDisplayBox);
            this.historyGroup.Controls.Add(this.clearHistoryButton);
            this.historyGroup.Location = new System.Drawing.Point(387, 12);
            this.historyGroup.Name = "historyGroup";
            this.historyGroup.Size = new System.Drawing.Size(296, 426);
            this.historyGroup.TabIndex = 0;
            this.historyGroup.TabStop = false;
            this.historyGroup.Text = "Active History";
            // 
            // historyList
            // 
            this.historyList.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.historyList.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.historyList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.historyList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.historyList.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyList.ForeColor = System.Drawing.SystemColors.MenuText;
            this.historyList.FullRowSelect = true;
            this.historyList.HideSelection = false;
            this.historyList.Location = new System.Drawing.Point(7, 20);
            this.historyList.Name = "historyList";
            this.historyList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.historyList.RightToLeftLayout = true;
            this.historyList.ShowGroups = false;
            this.historyList.Size = new System.Drawing.Size(283, 349);
            this.historyList.TabIndex = 0;
            this.historyList.TileSize = new System.Drawing.Size(283, 30);
            this.historyList.UseCompatibleStateImageBehavior = false;
            this.historyList.View = System.Windows.Forms.View.Tile;
            this.historyList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.SelectedHistoryItemsHandler);
            // 
            // combineDisplayBox
            // 
            this.combineDisplayBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.combineDisplayBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.combineDisplayBox.CausesValidation = false;
            this.combineDisplayBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.combineDisplayBox.DetectUrls = false;
            this.combineDisplayBox.Font = new System.Drawing.Font("Segoe UI Black", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.combineDisplayBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.combineDisplayBox.Location = new System.Drawing.Point(7, 375);
            this.combineDisplayBox.Multiline = false;
            this.combineDisplayBox.Name = "combineDisplayBox";
            this.combineDisplayBox.ReadOnly = true;
            this.combineDisplayBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.combineDisplayBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.combineDisplayBox.Size = new System.Drawing.Size(202, 43);
            this.combineDisplayBox.TabIndex = 1;
            this.combineDisplayBox.Text = "";
            this.combineDisplayBox.WordWrap = false;
            // 
            // clearHistoryButton
            // 
            this.clearHistoryButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.clearHistoryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.clearHistoryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearHistoryButton.FlatAppearance.BorderSize = 0;
            this.clearHistoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearHistoryButton.Image = ((System.Drawing.Image)(resources.GetObject("clearHistoryButton.Image")));
            this.clearHistoryButton.Location = new System.Drawing.Point(265, 389);
            this.clearHistoryButton.Name = "clearHistoryButton";
            this.clearHistoryButton.Size = new System.Drawing.Size(25, 25);
            this.clearHistoryButton.TabIndex = 19;
            this.clearHistoryButton.UseVisualStyleBackColor = false;
            this.clearHistoryButton.Click += new System.EventHandler(this.ClearHistoryButtonHandler);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(687, 441);
            this.Controls.Add(this.historyGroup);
            this.Controls.Add(this.standardGroup);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Calculator - Laboratorul 2";
            this.Load += new System.EventHandler(this.MainViewLoaded);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDownEvent);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPressEvent);
            this.standardGroup.ResumeLayout(false);
            this.standardGroup.PerformLayout();
            this.historyGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox standardGroup;
        private System.Windows.Forms.Button divisonButton;
        private System.Windows.Forms.Button multiButton;
        private System.Windows.Forms.Button minusButon;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button equalButton;
        private System.Windows.Forms.Button numberSignButton;
        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.Button dotButton;
        private System.Windows.Forms.Button treeButton;
        private System.Windows.Forms.Button twoButton;
        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.Button fourButton;
        private System.Windows.Forms.Button fiveButton;
        private System.Windows.Forms.Button sixButton;
        private System.Windows.Forms.Button nineButton;
        private System.Windows.Forms.Button eightButton;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Button removeFigure;
        private System.Windows.Forms.Button removeOperation;
        private System.Windows.Forms.Button removeNumber;
        private System.Windows.Forms.RichTextBox secondDisplayBox;
        private System.Windows.Forms.RichTextBox mainDisplayBox;
        private System.Windows.Forms.GroupBox historyGroup;
        private System.Windows.Forms.Button clearHistoryButton;
        private System.Windows.Forms.RichTextBox combineDisplayBox;
        private System.Windows.Forms.Button rightParanthes;
        private System.Windows.Forms.Button leftParanthes;
        private System.Windows.Forms.Button bothParenthesis;
        private ParanthesTextBox paranthesNumber;
        private ListView historyList;
    }
}

