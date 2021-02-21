using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MeuControle.Modelos.Estabelecimentos
{
    class ModelosPagamento
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string IdClinicaOdontologica{ get; set; }
        public string ModeloPagamento { get; set; }
        public int DiaPagamento { get; set; }
        public int DiaPeriodoInicial { get; set; }
        public int DiaPeriodoFinal { get; set; }

    }
}
