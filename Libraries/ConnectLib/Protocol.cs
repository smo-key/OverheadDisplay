using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConnectLib
{
    public abstract class Protocol
    {
        /// <summary>
        /// <para>Protocol constructor used for communication.</para>
        /// </summary>
        public Protocol()
            : base()
        { }

        /// <summary> 
        /// Connect to the device via Bluetooth.
        /// </summary>
        public abstract bool Connect();

        /// <summary> 
        /// Disconnect the device from Bluetooth.
        /// </summary>
        public abstract bool Disconnect();

        /// <summary>
        /// <para>Indicates if connected bia Bluetooth.</para>
        /// </summary>
        public abstract bool IsConnected
        {
            get;
        }

        /// <summary>
        /// <para>Sends a request via Bluetooth.</para>
        /// </summary>
        /// <param name="request">The request to be sent.</param>
        public abstract bool Send(byte[] request);

        /// <summary>
        /// <para>Recieve the reply via Bluetooth.</para>
        /// </summary>
        public abstract byte[] RecieveReply();
    }
}
