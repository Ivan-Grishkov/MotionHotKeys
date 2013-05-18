using System.Linq;
using System.Threading;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace MotionHotKeys.RaiseEvents
{
    public class EventsGenerator
    {
        public static void RiseSpacePressed()
        {
            var key = Key.Space;                    // Key to send
            var target = Keyboard.FocusedElement;    // Target element
            var routedEvent = Keyboard.KeyDownEvent; // Event to send
            //Thread.Sleep(1000);
            

            target.RaiseEvent(
              new KeyEventArgs(
                Keyboard.PrimaryDevice,
                PresentationSource.FromVisual(Keyboard.PrimaryDevice.FocusedElement as Visual),
                0,
                key) { RoutedEvent = routedEvent }
            );

            key = Key.A; 
            target.RaiseEvent(
              new KeyEventArgs(
                Keyboard.PrimaryDevice,
                PresentationSource.FromVisual(App.Current.MainWindow),
                0,
                key) { RoutedEvent = routedEvent }
            );
            target.RaiseEvent(
              new KeyEventArgs(
                Keyboard.PrimaryDevice,
                PresentationSource.FromVisual(App.Current.MainWindow),
                0,
                key) { RoutedEvent = routedEvent }
            );
            target.RaiseEvent(
              new KeyEventArgs(
                Keyboard.PrimaryDevice,
                PresentationSource.FromVisual(App.Current.MainWindow),
                0,
                key) { RoutedEvent = routedEvent }
            );
        }


    }
}