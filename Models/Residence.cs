using System;
using System.Collections.Generic;

namespace MushiwulfApi
{
  public class Residence {
    public string Address { get; set; }
    public decimal Balance { get; set; }
    public string Owner { get; set; }

    public IEnumerable<Transaction> Transactions { get; set; }
  }
}