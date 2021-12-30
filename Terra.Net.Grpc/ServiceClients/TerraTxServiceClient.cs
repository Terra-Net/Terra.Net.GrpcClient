﻿using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terra.Net.Grpc.ServiceClients
{
    public partial class TerraTxServiceClient : Cosmos.Tx.V1Beta1.Service.ServiceClient
    {       
        public TerraTxServiceClient(TerraGrpcClientOptions terraGrpcClientOptions) : base(GrpcChannel.ForAddress(terraGrpcClientOptions.BaseAddress, terraGrpcClientOptions.GrpcChannelOptions))
        {
        }

        public TerraTxServiceClient(GrpcChannel channel) : base(channel)
        {
            
        }
    }
}