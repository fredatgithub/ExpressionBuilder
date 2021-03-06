﻿namespace ExpressionBuilder.Builder
{
  public enum FilterStatementConnector { And, Or }

  public enum Operation
  {
    Equals,
    Contains,
    StartsWith,
    EndsWith,
    NotEquals,
    GreaterThan,
    GreaterThanOrEquals,
    LessThan,
    LessThanOrEquals
  }
}