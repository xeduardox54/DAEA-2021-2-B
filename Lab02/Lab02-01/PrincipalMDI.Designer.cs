
namespace Lab02_01
{
    partial class PrincipalMDI
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSistemaSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProRegistrarVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProRegistrarCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepReporteVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepReporteCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepInventarioProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepReporteProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepReporteUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepReporteClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 340);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(584, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.mantenimientoToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSistemaSalir});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // mnuSistemaSalir
            // 
            this.mnuSistemaSalir.Name = "mnuSistemaSalir";
            this.mnuSistemaSalir.Size = new System.Drawing.Size(180, 22);
            this.mnuSistemaSalir.Text = "Salir del sistema";
            this.mnuSistemaSalir.Click += new System.EventHandler(this.mnuSistemaSalir_Click);
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuManUsuarios,
            this.mnuManProductos,
            this.mnuManCategorias,
            this.mnuManProveedores,
            this.mnuManClientes});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // mnuManUsuarios
            // 
            this.mnuManUsuarios.Name = "mnuManUsuarios";
            this.mnuManUsuarios.Size = new System.Drawing.Size(180, 22);
            this.mnuManUsuarios.Text = "Usuarios";
            this.mnuManUsuarios.Click += new System.EventHandler(this.mnuManUsuarios_Click);
            // 
            // mnuManProductos
            // 
            this.mnuManProductos.Name = "mnuManProductos";
            this.mnuManProductos.Size = new System.Drawing.Size(180, 22);
            this.mnuManProductos.Text = "Productos";
            this.mnuManProductos.Click += new System.EventHandler(this.mnuManProductos_Click);
            // 
            // mnuManCategorias
            // 
            this.mnuManCategorias.Name = "mnuManCategorias";
            this.mnuManCategorias.Size = new System.Drawing.Size(180, 22);
            this.mnuManCategorias.Text = "Categorías";
            this.mnuManCategorias.Click += new System.EventHandler(this.categoriasToolStripMenuItem_Click);
            // 
            // mnuManProveedores
            // 
            this.mnuManProveedores.Name = "mnuManProveedores";
            this.mnuManProveedores.Size = new System.Drawing.Size(180, 22);
            this.mnuManProveedores.Text = "Proveedores";
            this.mnuManProveedores.Click += new System.EventHandler(this.mnuManProveedores_Click);
            // 
            // mnuManClientes
            // 
            this.mnuManClientes.Name = "mnuManClientes";
            this.mnuManClientes.Size = new System.Drawing.Size(180, 22);
            this.mnuManClientes.Text = "Clientes";
            this.mnuManClientes.Click += new System.EventHandler(this.mnuManClientes_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProRegistrarVenta,
            this.mnuProRegistrarCompra});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // mnuProRegistrarVenta
            // 
            this.mnuProRegistrarVenta.Name = "mnuProRegistrarVenta";
            this.mnuProRegistrarVenta.Size = new System.Drawing.Size(164, 22);
            this.mnuProRegistrarVenta.Text = "Registrar venta";
            // 
            // mnuProRegistrarCompra
            // 
            this.mnuProRegistrarCompra.Name = "mnuProRegistrarCompra";
            this.mnuProRegistrarCompra.Size = new System.Drawing.Size(164, 22);
            this.mnuProRegistrarCompra.Text = "Registrar compra";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRepReporteVentas,
            this.mnuRepReporteCompras,
            this.mnuRepInventarioProductos,
            this.mnuRepReporteProveedores,
            this.mnuRepReporteUsuarios,
            this.mnuRepReporteClientes});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // mnuRepReporteVentas
            // 
            this.mnuRepReporteVentas.Name = "mnuRepReporteVentas";
            this.mnuRepReporteVentas.Size = new System.Drawing.Size(200, 22);
            this.mnuRepReporteVentas.Text = "Reporte de ventas";
            // 
            // mnuRepReporteCompras
            // 
            this.mnuRepReporteCompras.Name = "mnuRepReporteCompras";
            this.mnuRepReporteCompras.Size = new System.Drawing.Size(200, 22);
            this.mnuRepReporteCompras.Text = "Reporte de compras";
            // 
            // mnuRepInventarioProductos
            // 
            this.mnuRepInventarioProductos.Name = "mnuRepInventarioProductos";
            this.mnuRepInventarioProductos.Size = new System.Drawing.Size(200, 22);
            this.mnuRepInventarioProductos.Text = "Inventario de productos";
            // 
            // mnuRepReporteProveedores
            // 
            this.mnuRepReporteProveedores.Name = "mnuRepReporteProveedores";
            this.mnuRepReporteProveedores.Size = new System.Drawing.Size(200, 22);
            this.mnuRepReporteProveedores.Text = "Reporte de proveedores";
            // 
            // mnuRepReporteUsuarios
            // 
            this.mnuRepReporteUsuarios.Name = "mnuRepReporteUsuarios";
            this.mnuRepReporteUsuarios.Size = new System.Drawing.Size(200, 22);
            this.mnuRepReporteUsuarios.Text = "Reporte de usuarios";
            // 
            // mnuRepReporteClientes
            // 
            this.mnuRepReporteClientes.Name = "mnuRepReporteClientes";
            this.mnuRepReporteClientes.Size = new System.Drawing.Size(200, 22);
            this.mnuRepReporteClientes.Text = "Reporte de clientes";
            // 
            // PrincipalMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "PrincipalMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel principal";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuManUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuManProductos;
        private System.Windows.Forms.ToolStripMenuItem mnuManCategorias;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuManProveedores;
        private System.Windows.Forms.ToolStripMenuItem mnuManClientes;
        private System.Windows.Forms.ToolStripMenuItem mnuSistemaSalir;
        private System.Windows.Forms.ToolStripMenuItem mnuProRegistrarVenta;
        private System.Windows.Forms.ToolStripMenuItem mnuProRegistrarCompra;
        private System.Windows.Forms.ToolStripMenuItem mnuRepReporteVentas;
        private System.Windows.Forms.ToolStripMenuItem mnuRepReporteCompras;
        private System.Windows.Forms.ToolStripMenuItem mnuRepInventarioProductos;
        private System.Windows.Forms.ToolStripMenuItem mnuRepReporteProveedores;
        private System.Windows.Forms.ToolStripMenuItem mnuRepReporteUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuRepReporteClientes;
    }
}



