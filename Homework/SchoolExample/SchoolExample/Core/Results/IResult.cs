﻿namespace SchoolExample.Core.Results;

public interface IResult
{
    bool Success { get; }
    string Message { get; }
}
