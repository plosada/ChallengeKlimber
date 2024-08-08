namespace DevelopmentChallenge.Data.Classes.Formas
{
    public class Trapecio : FormaGeometrica
    {
        private readonly decimal _baseMayor;
        private readonly decimal _baseMenor;
        private readonly decimal _altura;
        private readonly decimal _diagonal1;
        private readonly decimal _diagonal2;

        public Trapecio(decimal baseMayor, decimal baseMenor, decimal altura, decimal diagonal1, decimal diagonal2)
        {
            _baseMayor = baseMayor;
            _baseMenor = baseMenor;
            _altura = altura;
            _diagonal1 = diagonal1;
            _diagonal2 = diagonal2;
        }

        public override decimal CalcularArea()
        {
            return (_baseMayor + _baseMenor) * _altura / 2;
        }

        public override decimal CalcularPerimetro()
        {
            return _baseMenor + _baseMayor + _diagonal1 + _diagonal2;
        }

        public override string Nombre(Idioma idioma)
        {
            return idioma.Trapecio();
        }

        public override string NombrePlural(Idioma idioma)
        {
            return idioma.TrapecioPlural();
        }
    }
}
