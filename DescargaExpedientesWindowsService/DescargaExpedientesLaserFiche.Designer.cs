﻿namespace DescargaExpedientesWindowsService
{
    partial class DescargaExpedientesLaserFiche
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerReadMessageQueue = new System.Windows.Forms.Timer(this.components);
            // 
            // timerReadMessageQueue
            // 
            this.timerReadMessageQueue.Tick += new System.EventHandler(this.timerReadMessageQueue_Tick);
            // 
            // DescargaExpedientesLaserFiche
            // 
            this.ServiceName = "Service1";

        }

        #endregion

        private System.Windows.Forms.Timer timerReadMessageQueue;
    }
}
