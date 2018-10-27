﻿namespace DesignPatterns.ProxyPattern.Protection {
  public class SensitiveClass : ISensitiveClass {
    public string SensitiveMethod() => "Sensitive data accesssed";
  }
}
