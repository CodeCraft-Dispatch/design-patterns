using System;

namespace CCD.Patterns.Tests.Builder;

public class Builder<T>
{
    protected T _instance;

    public Builder()
    {
        _instance = CreateInstance();
    }

    protected virtual T CreateInstance()
    {
        return Activator.CreateInstance<T>();
    }

    public virtual T Build()
    {
        return _instance;
    }
}
