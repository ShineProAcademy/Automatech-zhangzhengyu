using System;
using Avalonia.Controls;
using Irihi.Avalonia.Shared.Helpers;

namespace Automatech.AvaloniaApp.Services;

public static class ObservableExtension
{
    public static IDisposable Subscribe<T>(this IObservable<T> observable, Action<T> action)
    {
        if (observable == null)
        {
            return null;
        }

       return observable.Subscribe(new Observer<T>(action));
    }
    
    public class Observer<T> : IObserver<T>
    {
        private Action _onCompleted;
        private Action _onError;
        private Action<T> _onNext;
        
        public Observer(Action<T> onNext, Action onCompleted, Action onError)
        {
            this._onNext = onNext;
            this._onCompleted = onCompleted;
            this._onError = onError;
        }
        
        public Observer(Action<T> onNext, Action onCompleted)
        {
            this._onNext = onNext;
            this._onCompleted = onCompleted;
            this._onError = null;
        }
        
        public Observer(Action<T> onNext)
        {
            this._onNext = onNext;
            this._onCompleted = null;
            this._onError = null;
        }
        
        public void OnCompleted()
        {
            this._onCompleted?.Invoke();
        }

        public void OnError(Exception error)
        {
            this._onError?.Invoke();
        }

        public void OnNext(T value)
        {
           this._onNext?.Invoke(value);
        }
    }
}