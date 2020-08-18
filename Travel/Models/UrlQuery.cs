using System;
using System.Collections.Generic;
using System.Text;

namespace Travel.Models
{
  public class UrlQuery
  {
    private const int maxPageSize = 50;
    public int PageNumber {get; set;} = 1;

    private int _pageSize = 10;//number of records per page
    public int PageSize
    {
      get
      {
        return _pageSize;
      }
      set
      {
        _pageSize = (value < maxPageSize) ? value : maxPageSize;
      }
    }
  }
}

// //results for user input 3pg
// //pagesize = 20 number of results we want per page.
// OrderBy(thing => thing.Name)
// //skipping first 2 pages(3-1). and pagesize(20*2) is the amt of results you skip.
// .Skip((Tests.PageNumber -1)* Tests.PageSize)
// .Take(tests.PageSize).ToList();

// //page PageNumber

// Travels?pagenumber3&pagesize=20
