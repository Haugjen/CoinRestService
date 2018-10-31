using System;

namespace modelLibrary
{
    public class CoinBid
    {
        private int _id;
        private String _genstand;
        private int _bud;
        private String _navn;

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Genstand
        {
            get => _genstand;
            set => _genstand = value;
        }

        public int Bud
        {
            get => _bud;
            set => _bud = value;
        }

        public string Navn
        {
            get => _navn;
            set => _navn = value;
        }

        public CoinBid()
        {
        }

        public CoinBid(int id, string genstand, int bud, string navn)
        {
            // todo lav id automatisk
            _id = id;
            _genstand = genstand;
            _bud = bud;
            _navn = navn;
        }

        public CoinBid(int id, string genstand)
        {
            _id = id;
            _genstand = genstand;
            _bud = 0;
            _navn = "auktion";
        }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Genstand)}: {Genstand}, {nameof(Bud)}: {Bud}, {nameof(Navn)}: {Navn}";
        }
    }
}
