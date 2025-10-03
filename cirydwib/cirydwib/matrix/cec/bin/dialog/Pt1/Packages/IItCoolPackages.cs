using System;
using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace cirydwib;

public abstract class ItCoolPackages(Packages newArrayExpression)
{
    public Packages ArrayExpression { get; } = newArrayExpression;
}

public class Packages
{
    public IEnumerator<ElementType> GetEnumerator()
    {
        throw new NotImplementedException();
    }
}

public class ElementType(CheckedExpressionSyntax files)
{
    public CheckedExpressionSyntax Files { get; } = files;
}