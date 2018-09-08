using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Messaging;

namespace DescargaExpedientesWindowsService
{
    public partial class DescargaExpedientesLaserFiche : ServiceBase
    {
        public MessageQueue ColaDeMensajesDeSolicitudes { get; set; }

        public DescargaExpedientesLaserFiche()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            ColaDeMensajesDeSolicitudes = new MessageQueue("dah-301\\Private$\\hinojosa_SolicitudesDescargasMasivas", QueueAccessMode.Receive);
            
            timerReadMessageQueue.Start();
        }

        protected override void OnStop()
        {
            timerReadMessageQueue.Start();
        }

        private void timerReadMessageQueue_Tick(object sender, EventArgs e)
        {
            Message solicitud = ColaDeMensajesDeSolicitudes.Receive();
            solicitud.Body
        }
    }
}
