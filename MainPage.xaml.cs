using ColletionView.Model;

namespace ColletionView;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();

        List<Boletos> boletos = new List<Boletos> {
            new Boletos
            {
                IdBoletos = 1,
                HoraPagamento = DateTime.Now,
                DataVencimento = new DateTime(2023,05,24),
                QtdParcelas = 1,
                ValorParcela = 517.68,
               
            },

            new Boletos
            {
                IdBoletos = 1,
                HoraPagamento = DateTime.Now,
                DataVencimento = new DateTime(2023,06,24),
                QtdParcelas = 2,
                ValorParcela = 517.68
            },

             new Boletos
            {
                IdBoletos = 1,
                HoraPagamento = DateTime.Now,
                DataVencimento = new DateTime(2023,07,24),
                QtdParcelas = 3,
                ValorParcela = 517.68
            },
            new Boletos
            {
                IdBoletos = 1,
                HoraPagamento = DateTime.Now,
                DataVencimento = new DateTime(2023,08,24),
                QtdParcelas = 4,
                ValorParcela = 517.68
            },
            new Boletos
            {
                IdBoletos = 1,
                HoraPagamento = DateTime.Now,
                DataVencimento = new DateTime(2023,09,24),
                QtdParcelas = 5,
                ValorParcela = 517.68
            },
            new Boletos
            {
                IdBoletos = 1,
                HoraPagamento = DateTime.Now,
                DataVencimento = new DateTime(2023,10,24),
                QtdParcelas = 6,
                ValorParcela = 517.68
                },
            new Boletos
            {
                IdBoletos = 1,
                HoraPagamento = DateTime.Now,
                DataVencimento = new DateTime(2023,11,24),
                QtdParcelas = 7,
                ValorParcela = 517.68,
                 },
            new Boletos
            {
                IdBoletos = 1,
                HoraPagamento = DateTime.Now,
                DataVencimento = new DateTime(2023,12,24),
                QtdParcelas = 8,
                ValorParcela = 517.68
            },
            new Boletos
            {
                IdBoletos = 1,
                HoraPagamento = DateTime.Now,
                DataVencimento = new DateTime(2024,01,24),
                QtdParcelas = 9,
                ValorParcela = 517.68,
                  },
            new Boletos
            {
                IdBoletos = 1,
                HoraPagamento = DateTime.Now,
                DataVencimento = new DateTime(2024,02,24),
                QtdParcelas = 10,
                ValorParcela = 517.68

            },
            new Boletos
            {
                IdBoletos = 1,
                HoraPagamento = DateTime.Now,
                DataVencimento = new DateTime(2024,03,24),
                QtdParcelas = 11,
                ValorParcela = 517.68

            },
            new Boletos
            {
                IdBoletos = 1,
                HoraPagamento = DateTime.Now,
                DataVencimento = new DateTime(2024,04,24),
                QtdParcelas = 12,
                ValorParcela = 517.68

            },
        };

        int count = 0;

        foreach(var item in boletos)
        {
            count++;
            item.Parcelas = $"{count} / {item.QtdParcelas}";
        }

        colletionBoletos.ItemsSource = boletos;


    }
}

