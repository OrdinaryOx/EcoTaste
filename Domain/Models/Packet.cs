using System.ComponentModel.DataAnnotations;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.Xml;

namespace Domain.Models {
    public class Packet {

        //[Key]?
        private string name { get; set; } = null!;
        private string city; //enum
        private string canteen; //enum
        private DateTime dateTime { get; set; } //ophalen
        private DateTime maxDateTime { get; set; } //max tijd ophalen
        private bool overEighteen { get; set; }
        private decimal price { get; set; }
        private string type { get; set; } //enum
        private Student reservedBy; //reserved by student

    }
}





//Beschrijvende naam(niet leeg)
//• Lijst van producten (indicatie op basis van historie)
//• Stad(Breda, Den Bosch, Tilburg)
//• Kantine(per stad zijn er meerdere kantines, mag via enumeratie)
//• Datum en tijdstip van ophalen
//• Tijdstip tot wanneer een pakket opgehaald kan worden
//• Indicatie 18+
//• Prijs
//• Type maaltijd (brood, warme avondmaaltijd, drank, …, mag via enumeratie)
//• Gereserveerd door(referentie naar student)
