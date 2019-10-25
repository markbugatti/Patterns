using ChainOfResponsibility.PaymentHandlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ChainOfResponsibility
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            OperationHandler.listBox = MessegesListBox;

            PaymentHandler regularPaymentHandler = new RegularPaymentHandler();
            PaymentHandler preferentialPaymentHandler = new PreferentialPaymentHandler();
            PaymentHandler statePaymentHandler = new StatePaymentHandler();
            PaymentHandler interbankPaymentHandler = new InterbankPaymentHandler();
            regularPaymentHandler.Successor = preferentialPaymentHandler;
            preferentialPaymentHandler.Successor = statePaymentHandler;
            statePaymentHandler.Successor = interbankPaymentHandler;

            Payment statePayment = new Payment(Guid.NewGuid(), (int)PaymentTypes.State, 465.42m);
            Payment preferentialPayment = new Payment(Guid.NewGuid(), (int)PaymentTypes.Preferential, 305.02m);
            Payment interbankPayment = new Payment(Guid.NewGuid(), (int)PaymentTypes.Interbank, 3674.2m);
            Payment regularPayment = new Payment(Guid.NewGuid(), (int)PaymentTypes.Regular, 8303m);

            regularPaymentHandler.Handle(statePayment);
            regularPaymentHandler.Handle(preferentialPayment);
            regularPaymentHandler.Handle(interbankPayment);
            regularPaymentHandler.Handle(regularPayment);
        }
    }

    public enum PaymentTypes {
        Regular,
        Preferential,
        State,
        Interbank
    }
}
