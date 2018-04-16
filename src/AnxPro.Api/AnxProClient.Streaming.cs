using System;
using System.Collections.Generic;
using System.Text;

namespace AnxPro.Api
{
    // Streaming is based on socket.io, and does not support pure websockets (it is long polling). 
    // Java or other language socket.io clients may work if they support long polling.
    public partial class AnxProClient
    {
        //TODO: https://anxv3.docs.apiary.io/#reference/streaming
    }
}
