namespace TexaggFormsApp1
{
    partial class Tickets
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
            if (disposing && (components != null))
            {
                components.Dispose();
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label tKTNOLabel;
            System.Windows.Forms.Label pLANTLabel;
            System.Windows.Forms.Label cUSTOMER_NBRLabel;
            System.Windows.Forms.Label dATELabel;
            System.Windows.Forms.Label mATERIALLabel;
            System.Windows.Forms.Label gROSSLabel;
            System.Windows.Forms.Label tARELabel;
            System.Windows.Forms.Label nETLabel;
            System.Windows.Forms.Label tONSLabel;
            System.Windows.Forms.Label tRUCKLabel;
            System.Windows.Forms.Label dRIVERLabel;
            System.Windows.Forms.Label tRKTYPLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.tICKETSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tEXAGG1DataSet = new TexaggFormsApp1.TEXAGG1DataSet();
            this.tICKETSTableAdapter = new TexaggFormsApp1.TEXAGG1DataSetTableAdapters.TICKETSTableAdapter();
            this.tableAdapterManager = new TexaggFormsApp1.TEXAGG1DataSetTableAdapters.TableAdapterManager();
            this.tKTNOTextBox = new System.Windows.Forms.TextBox();
            this.pLANTTextBox = new System.Windows.Forms.TextBox();
            this.cUSTOMER_NBRComboBox = new System.Windows.Forms.ComboBox();
            this.dATEDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.mATERIALComboBox = new System.Windows.Forms.ComboBox();
            this.gROSSTextBox = new System.Windows.Forms.TextBox();
            this.tARETextBox = new System.Windows.Forms.TextBox();
            this.nETTextBox = new System.Windows.Forms.TextBox();
            this.tONSTextBox = new System.Windows.Forms.TextBox();
            this.tRUCKTextBox = new System.Windows.Forms.TextBox();
            this.dRIVERTextBox = new System.Windows.Forms.TextBox();
            this.tRKTYPTextBox = new System.Windows.Forms.TextBox();
            tKTNOLabel = new System.Windows.Forms.Label();
            pLANTLabel = new System.Windows.Forms.Label();
            cUSTOMER_NBRLabel = new System.Windows.Forms.Label();
            dATELabel = new System.Windows.Forms.Label();
            mATERIALLabel = new System.Windows.Forms.Label();
            gROSSLabel = new System.Windows.Forms.Label();
            tARELabel = new System.Windows.Forms.Label();
            nETLabel = new System.Windows.Forms.Label();
            tONSLabel = new System.Windows.Forms.Label();
            tRUCKLabel = new System.Windows.Forms.Label();
            dRIVERLabel = new System.Windows.Forms.Label();
            tRKTYPLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tICKETSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEXAGG1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(722, 439);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tICKETSBindingSource
            // 
            this.tICKETSBindingSource.DataMember = "TICKETS";
            this.tICKETSBindingSource.DataSource = this.tEXAGG1DataSet;
            // 
            // tEXAGG1DataSet
            // 
            this.tEXAGG1DataSet.DataSetName = "TEXAGG1DataSet";
            this.tEXAGG1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tICKETSTableAdapter
            // 
            this.tICKETSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TICKETSTableAdapter = this.tICKETSTableAdapter;
            this.tableAdapterManager.UpdateOrder = TexaggFormsApp1.TEXAGG1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tKTNOLabel
            // 
            tKTNOLabel.AutoSize = true;
            tKTNOLabel.Location = new System.Drawing.Point(186, 91);
            tKTNOLabel.Name = "tKTNOLabel";
            tKTNOLabel.Size = new System.Drawing.Size(47, 13);
            tKTNOLabel.TabIndex = 1;
            tKTNOLabel.Text = "TKTNO:";
            // 
            // tKTNOTextBox
            // 
            this.tKTNOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tICKETSBindingSource, "TKTNO", true));
            this.tKTNOTextBox.Location = new System.Drawing.Point(289, 88);
            this.tKTNOTextBox.Name = "tKTNOTextBox";
            this.tKTNOTextBox.Size = new System.Drawing.Size(200, 20);
            this.tKTNOTextBox.TabIndex = 2;
            // 
            // pLANTLabel
            // 
            pLANTLabel.AutoSize = true;
            pLANTLabel.Location = new System.Drawing.Point(186, 117);
            pLANTLabel.Name = "pLANTLabel";
            pLANTLabel.Size = new System.Drawing.Size(45, 13);
            pLANTLabel.TabIndex = 3;
            pLANTLabel.Text = "PLANT:";
            // 
            // pLANTTextBox
            // 
            this.pLANTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tICKETSBindingSource, "PLANT", true));
            this.pLANTTextBox.Location = new System.Drawing.Point(289, 114);
            this.pLANTTextBox.Name = "pLANTTextBox";
            this.pLANTTextBox.Size = new System.Drawing.Size(200, 20);
            this.pLANTTextBox.TabIndex = 4;
            // 
            // cUSTOMER_NBRLabel
            // 
            cUSTOMER_NBRLabel.AutoSize = true;
            cUSTOMER_NBRLabel.Location = new System.Drawing.Point(186, 143);
            cUSTOMER_NBRLabel.Name = "cUSTOMER_NBRLabel";
            cUSTOMER_NBRLabel.Size = new System.Drawing.Size(97, 13);
            cUSTOMER_NBRLabel.TabIndex = 5;
            cUSTOMER_NBRLabel.Text = "CUSTOMER NBR:";
            // 
            // cUSTOMER_NBRComboBox
            // 
            this.cUSTOMER_NBRComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tICKETSBindingSource, "CUSTOMER_NBR", true));
            this.cUSTOMER_NBRComboBox.FormattingEnabled = true;
            this.cUSTOMER_NBRComboBox.Location = new System.Drawing.Point(289, 140);
            this.cUSTOMER_NBRComboBox.Name = "cUSTOMER_NBRComboBox";
            this.cUSTOMER_NBRComboBox.Size = new System.Drawing.Size(200, 21);
            this.cUSTOMER_NBRComboBox.TabIndex = 6;
            // 
            // dATELabel
            // 
            dATELabel.AutoSize = true;
            dATELabel.Location = new System.Drawing.Point(186, 171);
            dATELabel.Name = "dATELabel";
            dATELabel.Size = new System.Drawing.Size(39, 13);
            dATELabel.TabIndex = 7;
            dATELabel.Text = "DATE:";
            // 
            // dATEDateTimePicker
            // 
            this.dATEDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tICKETSBindingSource, "DATE", true));
            this.dATEDateTimePicker.Location = new System.Drawing.Point(289, 167);
            this.dATEDateTimePicker.Name = "dATEDateTimePicker";
            this.dATEDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dATEDateTimePicker.TabIndex = 8;
            // 
            // mATERIALLabel
            // 
            mATERIALLabel.AutoSize = true;
            mATERIALLabel.Location = new System.Drawing.Point(186, 196);
            mATERIALLabel.Name = "mATERIALLabel";
            mATERIALLabel.Size = new System.Drawing.Size(64, 13);
            mATERIALLabel.TabIndex = 9;
            mATERIALLabel.Text = "MATERIAL:";
            // 
            // mATERIALComboBox
            // 
            this.mATERIALComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tICKETSBindingSource, "MATERIAL", true));
            this.mATERIALComboBox.FormattingEnabled = true;
            this.mATERIALComboBox.Location = new System.Drawing.Point(289, 193);
            this.mATERIALComboBox.Name = "mATERIALComboBox";
            this.mATERIALComboBox.Size = new System.Drawing.Size(200, 21);
            this.mATERIALComboBox.TabIndex = 10;
            // 
            // gROSSLabel
            // 
            gROSSLabel.AutoSize = true;
            gROSSLabel.Location = new System.Drawing.Point(186, 223);
            gROSSLabel.Name = "gROSSLabel";
            gROSSLabel.Size = new System.Drawing.Size(48, 13);
            gROSSLabel.TabIndex = 11;
            gROSSLabel.Text = "GROSS:";
            // 
            // gROSSTextBox
            // 
            this.gROSSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tICKETSBindingSource, "GROSS", true));
            this.gROSSTextBox.Location = new System.Drawing.Point(289, 220);
            this.gROSSTextBox.Name = "gROSSTextBox";
            this.gROSSTextBox.Size = new System.Drawing.Size(200, 20);
            this.gROSSTextBox.TabIndex = 12;
            // 
            // tARELabel
            // 
            tARELabel.AutoSize = true;
            tARELabel.Location = new System.Drawing.Point(186, 249);
            tARELabel.Name = "tARELabel";
            tARELabel.Size = new System.Drawing.Size(39, 13);
            tARELabel.TabIndex = 13;
            tARELabel.Text = "TARE:";
            // 
            // tARETextBox
            // 
            this.tARETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tICKETSBindingSource, "TARE", true));
            this.tARETextBox.Location = new System.Drawing.Point(289, 246);
            this.tARETextBox.Name = "tARETextBox";
            this.tARETextBox.Size = new System.Drawing.Size(200, 20);
            this.tARETextBox.TabIndex = 14;
            // 
            // nETLabel
            // 
            nETLabel.AutoSize = true;
            nETLabel.Location = new System.Drawing.Point(186, 275);
            nETLabel.Name = "nETLabel";
            nETLabel.Size = new System.Drawing.Size(32, 13);
            nETLabel.TabIndex = 15;
            nETLabel.Text = "NET:";
            // 
            // nETTextBox
            // 
            this.nETTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tICKETSBindingSource, "NET", true));
            this.nETTextBox.Location = new System.Drawing.Point(289, 272);
            this.nETTextBox.Name = "nETTextBox";
            this.nETTextBox.Size = new System.Drawing.Size(200, 20);
            this.nETTextBox.TabIndex = 16;
            // 
            // tONSLabel
            // 
            tONSLabel.AutoSize = true;
            tONSLabel.Location = new System.Drawing.Point(186, 301);
            tONSLabel.Name = "tONSLabel";
            tONSLabel.Size = new System.Drawing.Size(40, 13);
            tONSLabel.TabIndex = 17;
            tONSLabel.Text = "TONS:";
            // 
            // tONSTextBox
            // 
            this.tONSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tICKETSBindingSource, "TONS", true));
            this.tONSTextBox.Location = new System.Drawing.Point(289, 298);
            this.tONSTextBox.Name = "tONSTextBox";
            this.tONSTextBox.Size = new System.Drawing.Size(200, 20);
            this.tONSTextBox.TabIndex = 18;
            // 
            // tRUCKLabel
            // 
            tRUCKLabel.AutoSize = true;
            tRUCKLabel.Location = new System.Drawing.Point(186, 327);
            tRUCKLabel.Name = "tRUCKLabel";
            tRUCKLabel.Size = new System.Drawing.Size(47, 13);
            tRUCKLabel.TabIndex = 19;
            tRUCKLabel.Text = "TRUCK:";
            // 
            // tRUCKTextBox
            // 
            this.tRUCKTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tICKETSBindingSource, "TRUCK", true));
            this.tRUCKTextBox.Location = new System.Drawing.Point(289, 324);
            this.tRUCKTextBox.Name = "tRUCKTextBox";
            this.tRUCKTextBox.Size = new System.Drawing.Size(200, 20);
            this.tRUCKTextBox.TabIndex = 20;
            // 
            // dRIVERLabel
            // 
            dRIVERLabel.AutoSize = true;
            dRIVERLabel.Location = new System.Drawing.Point(186, 353);
            dRIVERLabel.Name = "dRIVERLabel";
            dRIVERLabel.Size = new System.Drawing.Size(51, 13);
            dRIVERLabel.TabIndex = 21;
            dRIVERLabel.Text = "DRIVER:";
            // 
            // dRIVERTextBox
            // 
            this.dRIVERTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tICKETSBindingSource, "DRIVER", true));
            this.dRIVERTextBox.Location = new System.Drawing.Point(289, 350);
            this.dRIVERTextBox.Name = "dRIVERTextBox";
            this.dRIVERTextBox.Size = new System.Drawing.Size(200, 20);
            this.dRIVERTextBox.TabIndex = 22;
            // 
            // tRKTYPLabel
            // 
            tRKTYPLabel.AutoSize = true;
            tRKTYPLabel.Location = new System.Drawing.Point(186, 379);
            tRKTYPLabel.Name = "tRKTYPLabel";
            tRKTYPLabel.Size = new System.Drawing.Size(53, 13);
            tRKTYPLabel.TabIndex = 23;
            tRKTYPLabel.Text = "TRKTYP:";
            // 
            // tRKTYPTextBox
            // 
            this.tRKTYPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tICKETSBindingSource, "TRKTYP", true));
            this.tRKTYPTextBox.Location = new System.Drawing.Point(289, 376);
            this.tRKTYPTextBox.Name = "tRKTYPTextBox";
            this.tRKTYPTextBox.Size = new System.Drawing.Size(200, 20);
            this.tRKTYPTextBox.TabIndex = 24;
            // 
            // Tickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 524);
            this.Controls.Add(tKTNOLabel);
            this.Controls.Add(this.tKTNOTextBox);
            this.Controls.Add(pLANTLabel);
            this.Controls.Add(this.pLANTTextBox);
            this.Controls.Add(cUSTOMER_NBRLabel);
            this.Controls.Add(this.cUSTOMER_NBRComboBox);
            this.Controls.Add(dATELabel);
            this.Controls.Add(this.dATEDateTimePicker);
            this.Controls.Add(mATERIALLabel);
            this.Controls.Add(this.mATERIALComboBox);
            this.Controls.Add(gROSSLabel);
            this.Controls.Add(this.gROSSTextBox);
            this.Controls.Add(tARELabel);
            this.Controls.Add(this.tARETextBox);
            this.Controls.Add(nETLabel);
            this.Controls.Add(this.nETTextBox);
            this.Controls.Add(tONSLabel);
            this.Controls.Add(this.tONSTextBox);
            this.Controls.Add(tRUCKLabel);
            this.Controls.Add(this.tRUCKTextBox);
            this.Controls.Add(dRIVERLabel);
            this.Controls.Add(this.dRIVERTextBox);
            this.Controls.Add(tRKTYPLabel);
            this.Controls.Add(this.tRKTYPTextBox);
            this.Controls.Add(this.button1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.tICKETSBindingSource, "TKTNO", true));
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tICKETSBindingSource, "TKTNO", true));
            this.Name = "Tickets";
            this.Text = "Tickets";
            this.Load += new System.EventHandler(this.Tickets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tICKETSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEXAGG1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private TEXAGG1DataSet tEXAGG1DataSet;
        private System.Windows.Forms.BindingSource tICKETSBindingSource;
        private TEXAGG1DataSetTableAdapters.TICKETSTableAdapter tICKETSTableAdapter;
        private TEXAGG1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox tKTNOTextBox;
        private System.Windows.Forms.TextBox pLANTTextBox;
        private System.Windows.Forms.ComboBox cUSTOMER_NBRComboBox;
        private System.Windows.Forms.DateTimePicker dATEDateTimePicker;
        private System.Windows.Forms.ComboBox mATERIALComboBox;
        private System.Windows.Forms.TextBox gROSSTextBox;
        private System.Windows.Forms.TextBox tARETextBox;
        private System.Windows.Forms.TextBox nETTextBox;
        private System.Windows.Forms.TextBox tONSTextBox;
        private System.Windows.Forms.TextBox tRUCKTextBox;
        private System.Windows.Forms.TextBox dRIVERTextBox;
        private System.Windows.Forms.TextBox tRKTYPTextBox;
    }
}