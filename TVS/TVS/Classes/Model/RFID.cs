//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Phidgets;
//using Phidgets.Events;

//namespace TramVerdeelSysteem__TVS_
//{
//    class RFID
//    {
//        private string RFIDnummer;
//        private RFID rfid;

//        public RFID()
//        {
//            rfid = new RFID();

//        }
//        public void ZetScannerAan()
//        {
//            rfid.open();
//            rfid.waitForAttachment();
//            rfid.Attach += new AttachEventHandler(rfid_Attach);
//            rfid.Detach += new DetachEventHandler(rfid_Detach);
//            rfid.Tag += new TagEventHandler(rfid_Tag);
//            rfid.Antenna = true;
//            rfid.LED = true;

//        }
//        public void ZetScannerUit()
//        {
//            rfid.close();
//            rfid = null;
//        }

//    }
//}
