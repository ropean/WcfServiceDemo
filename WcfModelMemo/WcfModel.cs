using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace WcfModelMemo
{
  [DataContract]
  public class WcfModel
  {

    [DataMember]
    public string Name { get; set; }

    //Attr cannot be readonly

    //[DataMember]
    //public DateTime Now
    //{
    //  get
    //  {
    //    return DateTime.Now;
    //  }
    //}

  }
}
