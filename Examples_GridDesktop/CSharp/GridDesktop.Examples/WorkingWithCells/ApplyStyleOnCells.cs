﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Aspose.Cells.GridDesktop;
using Aspose.Cells.GridDesktop.Data;

namespace GridDesktop.Examples.WorkingWithCells
{
    public partial class ApplyStyleOnCells : Form
    {
        public ApplyStyleOnCells()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ExStart:ApplyStyle
            // Accessing the worksheet of the Grid that is currently active
            Worksheet sheet = gridDesktop1.GetActiveWorksheet();

            // Accessing "A1" cell in the worksheet
            GridCell cell = sheet.Cells["A1"];

            // Adding a value to "A1" cell
            cell.Value = "Hello";

            // Getting the Style object for the cell
            Style style = cell.GetStyle();

            // Setting Style properties like border, alignment etc.
            style.SetBorderLine(BorderType.Right, BorderLineType.Thick);
            style.SetBorderColor(BorderType.Right, Color.Blue);
            style.HAlignment = HorizontalAlignmentType.Centred;
            style.Color = Color.Yellow;
            style.CellLocked = true;
            style.VAlignment = VerticalAlignmentType.Top;

            // Setting the style of the cell with the customized Style object
            cell.SetStyle(style);
            // ExEnd:ApplyStyle
            gridDesktop1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // ExStart:SummingUp
            // Accessing first worksheet of the Grid
            Aspose.Cells.GridDesktop.Worksheet sheet = gridDesktop1.Worksheets[0];

            // Accessing "B2" cell and setting its value
            GridCell cell = sheet.Cells["B2"];
            cell.Value = "None";

            // Accessing "D4" cell and setting its value & column width
            cell = sheet.Cells["D4"];
            cell.Value = "out line Borders";
            sheet.Columns[cell.Column].Width = 120;

            // Accessing the Style object of "D4" cell and drawing thin red borders around it
            Aspose.Cells.GridDesktop.Style style = cell.GetStyle();
            style.SetBorderLine(BorderType.Left, BorderLineType.Thin);
            style.SetBorderColor(BorderType.Left, System.Drawing.Color.Red);
            style.SetBorderLine(BorderType.Right, BorderLineType.Thin);
            style.SetBorderColor(BorderType.Right, System.Drawing.Color.Red);
            style.SetBorderLine(BorderType.Top, BorderLineType.Thin);
            style.SetBorderColor(BorderType.Top, System.Drawing.Color.Red);
            style.SetBorderLine(BorderType.Bottom, BorderLineType.Thin);
            style.SetBorderColor(BorderType.Bottom, System.Drawing.Color.Red);
            cell.SetStyle(style);

            // Accessing "B6" cell and setting its value, row height & column width
            cell = sheet.Cells["B6"];
            cell.Value = "Border with\ndifferent colors";
            sheet.Rows[cell.Row].Height = 40;
            sheet.Columns[cell.Column].Width = 110;

            // Accessing the Style object of "B6" cell and drawing thin borders of different colors around it
            style = cell.GetStyle();
            style.SetBorderLine(BorderType.Left, BorderLineType.Thin);
            style.SetBorderColor(BorderType.Left, System.Drawing.Color.Red);
            style.SetBorderLine(BorderType.Right, BorderLineType.Thin);
            style.SetBorderColor(BorderType.Right, System.Drawing.Color.Green);
            style.SetBorderLine(BorderType.Top, BorderLineType.Thin);
            style.SetBorderColor(BorderType.Top, System.Drawing.Color.Yellow);
            style.SetBorderLine(BorderType.Bottom, BorderLineType.Thin);
            style.SetBorderColor(BorderType.Bottom, System.Drawing.Color.Blue);
            cell.SetStyle(style);

            // Accessing "D7" cell and setting its value, row height & column width
            cell = sheet.Cells["D7"];
            cell.Value = "Border with\ndifferent styles";
            sheet.Rows[cell.Row].Height = 40;
            sheet.Columns[cell.Column].Width = 110;

            // Accessing the Style object of "D7" cell and drawing different borders of different colors around it
            style = cell.GetStyle();
            style.SetBorderLine(BorderType.Left, BorderLineType.Thin);
            style.SetBorderColor(BorderType.Left, System.Drawing.Color.Red);
            style.SetBorderLine(BorderType.Right, BorderLineType.Medium);
            style.SetBorderColor(BorderType.Right, System.Drawing.Color.Red);
            style.SetBorderLine(BorderType.Top, BorderLineType.Dashed);
            style.SetBorderColor(BorderType.Top, System.Drawing.Color.Yellow);
            style.SetBorderLine(BorderType.Bottom, BorderLineType.Dotted);
            style.SetBorderColor(BorderType.Bottom, System.Drawing.Color.Black);
            cell.SetStyle(style);

            // Accessing "B8" cell and drawing a single red border to its bottom side
            cell = sheet.Cells["B8"];
            cell.Value = "Only one border";
            style = cell.GetStyle();
            style.SetBorderLine(BorderType.Bottom, BorderLineType.MediumDashDotted);
            style.SetBorderColor(BorderType.Bottom, System.Drawing.Color.Red);
            cell.SetStyle(style);
            // ExEnd:SummingUp
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // ExStart:SetNumberFormat
            // Accessing first worksheet of the Grid
            Aspose.Cells.GridDesktop.Worksheet sheet = gridDesktop1.Worksheets[0];

            // Creating a standard Font object that will be applied on cells
            System.Drawing.Font font = new System.Drawing.Font("MS Serif", 9f, FontStyle.Bold);

            // Accessing and adding values to cells
            GridCell cell = sheet.Cells["B2"];
            cell.Value = "General";
            cell.SetFont(font);
            cell = sheet.Cells["C2"];
            cell.Value = 1000;
            cell = sheet.Cells["D2"];
            cell.Value = "Text";
            cell = sheet.Cells["B4"];
            cell.Value = "Number";
            cell.SetFont(font);

            //Accessing the Style object of "C4" cell and setting its number format to index No.2
            cell = sheet.Cells["C4"];
            cell.Value = 20.00;
            Aspose.Cells.GridDesktop.Style style = cell.GetStyle();

            // For applying "0.00" format
            style.NumberType = 2;
            cell.SetStyle(style);

            // Accessing the Style object of "D4" cell and setting its number format to index No.3
            cell = sheet.Cells["D4"];
            cell.Value = -2000.00;
            style = cell.GetStyle();

            // For "#,##0" format
            style.NumberType = 3;
            cell.SetStyle(style);

            // Accessing a cell and setting its value & font
            cell = sheet.Cells["B6"];
            cell.Value = "Currency";
            cell.SetFont(font);

            // Accessing the Style object of "C6" cell and setting its number format to index No.6
            cell = sheet.Cells["C6"];
            cell.Value = -120.00;
            style = cell.GetStyle();

            // For Applying "\"$\"#,##0_);[Red](\"$\"#,##0)" expression
            style.NumberType = 6;
            cell.SetStyle(style);

            // Accessing the Style object of "D6" cell and setting its number format to index No.41
            cell = sheet.Cells["D6"];
            cell.Value = 2400;
            style = cell.GetStyle();

            // For applying "_(\"$\"* #,##0_);_(\"$\"* (#,##0);_(\"$\"* \"-\"_);_(@_)" expression
            style.NumberType = 41;
            cell.SetStyle(style);

            // Accessing a cell and setting its value & font
            cell = sheet.Cells["B8"];
            cell.Value = "Percent";
            cell.SetFont(font);

            // Accessing the Style object of "C8" cell and setting its number format to index No.9
            cell = sheet.Cells["C8"];
            cell.Value = 0.32;
            style = cell.GetStyle();
            style.NumberType = 9;
            cell.SetStyle(style);

            // Accessing the Style object of "D8" cell and setting its number format to index No.10
            cell = sheet.Cells["D8"];
            cell.Value = 0.64;
            style = cell.GetStyle();

            // For applying "0.00%" format
            style.NumberType = 10;
            cell.SetStyle(style);

            // Accessing a cell and setting its value & font
            cell = sheet.Cells["B10"];
            cell.Value = "Scientific";
            cell.SetFont(font);

            // Accessing the Style object of "C10" cell and setting its number format to index No.11
            cell = sheet.Cells["C10"];
            cell.Value = 0.51;
            style = cell.GetStyle();

            // For applying "0.00E+00" format
            style.NumberType = 11;
            cell.SetStyle(style);

            // Accessing the Style object of "D10" cell and setting its number format to index No.48
            cell = sheet.Cells["D10"];
            cell.Value = 32000;
            style = cell.GetStyle();
            style.NumberType = 48;
            cell.SetStyle(style);

            // Accessing a cell and setting its value & font
            cell = sheet.Cells["B12"];
            cell.Value = "DateTime";
            cell.SetFont(font);

            // Accessing the Style object of "C12" cell and setting a custom number format for it
            cell = sheet.Cells["C12"];
            cell.Value = DateTime.Now;
            style = cell.GetStyle();
            style.Custom = "yyyy-MM-dd";
            cell.SetStyle(style);

            // Accessing the Style object of "D12" cell and setting its number format to Index No.15
            cell = sheet.Cells["D12"];
            sheet.Columns[cell.Column].Width = 100;
            cell.Value = DateTime.Now;
            style = cell.GetStyle();

            // For "d-mmm-yy"
            style.NumberType = 15;
            cell.SetStyle(style);

            // Accessing the Style object of "C13" cell and setting a custom number format for it
            cell = sheet.Cells["C13"];
            cell.Value = DateTime.Now;
            style = cell.GetStyle();
            style.Custom = "hh:mm:ss";
            cell.SetStyle(style);

            // Accessing the Style object of "D13" cell and setting its number format to index No.18
            cell = sheet.Cells["D13"];
            cell.Value = DateTime.Now;
            style = cell.GetStyle();

            // For applying "h:mm AM/PM" format
            style.NumberType = 18;
            cell.SetStyle(style);

            // Accessing the Style object of "C14" cell and setting a custom number format for it
            cell = sheet.Cells["C14"];
            sheet.Columns[cell.Column].Width = 160;
            cell.Value = DateTime.Now;
            style = cell.GetStyle();
            style.Custom = "yyyy-MM-dd hh:mm:ss";
            cell.SetStyle(style);
            // ExEnd:SetNumberFormat
        }
    }
}
