using System;
using Avalonia;

namespace Automatech.AvaloniaApp.Services;

public class Subject<T> : IObservable<T>, IObserver<T>
{
    public IDisposable Subscribe(IObserver<T> observer)
    {
        return new UnSubscribe();
    }

    public void OnCompleted()
    {
       
    }

    public void OnError(Exception error)
    {
        
    }

    public void OnNext(T value)
    {
       
    }
    
    public class UnSubscribe : IDisposable
    {
        private IDisposable _disposableImplementation;

        public UnSubscribe()
        {
            
        }

        public void Dispose()
        {
            
        }
    }
}