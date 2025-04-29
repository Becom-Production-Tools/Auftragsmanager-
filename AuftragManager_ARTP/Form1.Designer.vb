<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Filename = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Auftragsnummer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Artikelnummer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Menge = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.X = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Daten = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Index = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZKWArtikelnummer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.path_in = New System.Windows.Forms.TextBox()
        Me.selectedprimerauftrag = New System.Windows.Forms.TextBox()
        Me.movedeletebutton = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.quit = New System.Windows.Forms.Button()
        Me.reload = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.selected = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.ENG1 = New System.Windows.Forms.Button()
        Me.ENG2 = New System.Windows.Forms.Button()
        Me.ENG3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.bBGconfig = New System.Windows.Forms.Button()
        Me.bTrash = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Filename, Me.Auftragsnummer, Me.Artikelnummer, Me.Menge, Me.X, Me.Daten, Me.Index, Me.ZKWArtikelnummer})
        Me.DataGridView1.Location = New System.Drawing.Point(402, 72)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 50
        Me.DataGridView1.Size = New System.Drawing.Size(847, 689)
        Me.DataGridView1.TabIndex = 0
        '
        'Filename
        '
        Me.Filename.HeaderText = "Filename"
        Me.Filename.Name = "Filename"
        Me.Filename.ReadOnly = True
        Me.Filename.Width = 113
        '
        'Auftragsnummer
        '
        Me.Auftragsnummer.HeaderText = "Auftragsnummer"
        Me.Auftragsnummer.Name = "Auftragsnummer"
        Me.Auftragsnummer.ReadOnly = True
        Me.Auftragsnummer.Width = 175
        '
        'Artikelnummer
        '
        Me.Artikelnummer.HeaderText = "Artikelnummer"
        Me.Artikelnummer.Name = "Artikelnummer"
        Me.Artikelnummer.ReadOnly = True
        Me.Artikelnummer.Width = 156
        '
        'Menge
        '
        Me.Menge.HeaderText = "Menge"
        Me.Menge.Name = "Menge"
        Me.Menge.ReadOnly = True
        Me.Menge.Width = 93
        '
        'X
        '
        Me.X.HeaderText = "Kennung"
        Me.X.Name = "X"
        Me.X.ReadOnly = True
        Me.X.Width = 110
        '
        'Daten
        '
        Me.Daten.HeaderText = "Daten"
        Me.Daten.Name = "Daten"
        Me.Daten.ReadOnly = True
        Me.Daten.Width = 85
        '
        'Index
        '
        Me.Index.HeaderText = "Index"
        Me.Index.Name = "Index"
        Me.Index.ReadOnly = True
        Me.Index.Width = 82
        '
        'ZKWArtikelnummer
        '
        Me.ZKWArtikelnummer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ZKWArtikelnummer.HeaderText = "ZKW Artikelnummer"
        Me.ZKWArtikelnummer.Name = "ZKWArtikelnummer"
        Me.ZKWArtikelnummer.ReadOnly = True
        '
        'path_in
        '
        Me.path_in.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.path_in.Location = New System.Drawing.Point(140, 12)
        Me.path_in.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.path_in.Name = "path_in"
        Me.path_in.ReadOnly = True
        Me.path_in.Size = New System.Drawing.Size(250, 26)
        Me.path_in.TabIndex = 1
        '
        'selectedprimerauftrag
        '
        Me.selectedprimerauftrag.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selectedprimerauftrag.Location = New System.Drawing.Point(140, 48)
        Me.selectedprimerauftrag.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.selectedprimerauftrag.Name = "selectedprimerauftrag"
        Me.selectedprimerauftrag.ReadOnly = True
        Me.selectedprimerauftrag.Size = New System.Drawing.Size(250, 26)
        Me.selectedprimerauftrag.TabIndex = 2
        '
        'movedeletebutton
        '
        Me.movedeletebutton.Enabled = False
        Me.movedeletebutton.Font = New System.Drawing.Font("Arial", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.movedeletebutton.Location = New System.Drawing.Point(234, 128)
        Me.movedeletebutton.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.movedeletebutton.Name = "movedeletebutton"
        Me.movedeletebutton.Size = New System.Drawing.Size(156, 69)
        Me.movedeletebutton.TabIndex = 4
        Me.movedeletebutton.Text = "Move"
        Me.movedeletebutton.UseVisualStyleBackColor = True
        '
        'Delete
        '
        Me.Delete.Enabled = False
        Me.Delete.Font = New System.Drawing.Font("Arial", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete.Location = New System.Drawing.Point(234, 286)
        Me.Delete.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(156, 69)
        Me.Delete.TabIndex = 5
        Me.Delete.Text = "Delete"
        Me.Delete.UseVisualStyleBackColor = True
        '
        'quit
        '
        Me.quit.Font = New System.Drawing.Font("Arial", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quit.Location = New System.Drawing.Point(234, 365)
        Me.quit.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.quit.Name = "quit"
        Me.quit.Size = New System.Drawing.Size(156, 69)
        Me.quit.TabIndex = 6
        Me.quit.Text = "Quit"
        Me.quit.UseVisualStyleBackColor = True
        '
        'reload
        '
        Me.reload.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.reload.Font = New System.Drawing.Font("Arial", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reload.Location = New System.Drawing.Point(234, 207)
        Me.reload.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.reload.Name = "reload"
        Me.reload.Size = New System.Drawing.Size(156, 69)
        Me.reload.TabIndex = 7
        Me.reload.Text = "Reload"
        Me.reload.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 15)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 18)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Pfad für Aufträge:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 51)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 18)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Auftrag:"
        '
        'selected
        '
        Me.selected.AutoSize = True
        Me.selected.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selected.Location = New System.Drawing.Point(80, 79)
        Me.selected.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.selected.Name = "selected"
        Me.selected.Size = New System.Drawing.Size(229, 44)
        Me.selected.TabIndex = 12
        Me.selected.Text = "0000000000"
        Me.selected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'ENG1
        '
        Me.ENG1.Font = New System.Drawing.Font("Arial", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ENG1.Location = New System.Drawing.Point(15, 128)
        Me.ENG1.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.ENG1.Name = "ENG1"
        Me.ENG1.Size = New System.Drawing.Size(207, 95)
        Me.ENG1.TabIndex = 13
        Me.ENG1.Text = "ENGMATEC 1"
        Me.ENG1.UseVisualStyleBackColor = True
        '
        'ENG2
        '
        Me.ENG2.Font = New System.Drawing.Font("Arial", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ENG2.Location = New System.Drawing.Point(15, 233)
        Me.ENG2.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.ENG2.Name = "ENG2"
        Me.ENG2.Size = New System.Drawing.Size(207, 95)
        Me.ENG2.TabIndex = 14
        Me.ENG2.Text = "ENGMATEC 2"
        Me.ENG2.UseVisualStyleBackColor = True
        '
        'ENG3
        '
        Me.ENG3.Font = New System.Drawing.Font("Arial", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ENG3.Location = New System.Drawing.Point(15, 339)
        Me.ENG3.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.ENG3.Name = "ENG3"
        Me.ENG3.Size = New System.Drawing.Size(207, 95)
        Me.ENG3.TabIndex = 15
        Me.ENG3.Text = "ENGMATEC 3"
        Me.ENG3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkViolet
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Location = New System.Drawing.Point(18, 578)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(375, 62)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Index NOK"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Blue
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button2.Location = New System.Drawing.Point(18, 646)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(375, 62)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Kein config"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Red
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button3.Location = New System.Drawing.Point(15, 510)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(375, 62)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "Datenmenge NOK"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Pink
        Me.Button4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button4.Location = New System.Drawing.Point(15, 442)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(375, 62)
        Me.Button4.TabIndex = 19
        Me.Button4.Text = "ZKW Artikel NOK"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'bBGconfig
        '
        Me.bBGconfig.Location = New System.Drawing.Point(48, 714)
        Me.bBGconfig.Name = "bBGconfig"
        Me.bBGconfig.Size = New System.Drawing.Size(148, 55)
        Me.bBGconfig.TabIndex = 20
        Me.bBGconfig.Text = "Baugruppen Config"
        Me.bBGconfig.UseVisualStyleBackColor = True
        '
        'bTrash
        '
        Me.bTrash.Location = New System.Drawing.Point(218, 714)
        Me.bTrash.Name = "bTrash"
        Me.bTrash.Size = New System.Drawing.Size(148, 55)
        Me.bTrash.TabIndex = 20
        Me.bTrash.Text = "TRASH Pfad"
        Me.bTrash.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 985)
        Me.Controls.Add(Me.bTrash)
        Me.Controls.Add(Me.bBGconfig)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ENG3)
        Me.Controls.Add(Me.ENG2)
        Me.Controls.Add(Me.ENG1)
        Me.Controls.Add(Me.selected)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.reload)
        Me.Controls.Add(Me.quit)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.movedeletebutton)
        Me.Controls.Add(Me.selectedprimerauftrag)
        Me.Controls.Add(Me.path_in)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents path_in As TextBox
    Friend WithEvents selectedprimerauftrag As TextBox
    Friend WithEvents movedeletebutton As Button
    Friend WithEvents Delete As Button
    Friend WithEvents quit As Button
    Friend WithEvents reload As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents selected As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents ENG3 As Button
    Friend WithEvents ENG2 As Button
    Friend WithEvents ENG1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Filename As DataGridViewTextBoxColumn
    Friend WithEvents Auftragsnummer As DataGridViewTextBoxColumn
    Friend WithEvents Artikelnummer As DataGridViewTextBoxColumn
    Friend WithEvents Menge As DataGridViewTextBoxColumn
    Friend WithEvents X As DataGridViewTextBoxColumn
    Friend WithEvents Daten As DataGridViewTextBoxColumn
    Friend WithEvents Index As DataGridViewTextBoxColumn
    Friend WithEvents ZKWArtikelnummer As DataGridViewTextBoxColumn
    Friend WithEvents bBGconfig As Button
    Friend WithEvents bTrash As Button
End Class
