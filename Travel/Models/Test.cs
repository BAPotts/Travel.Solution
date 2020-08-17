using System;
using System.Collections.Generic
using System.Text;

namespace Travel.Models
{
  public class Test
  {
  const int maxPageSize = 50;
  public int PageNumber {get; set;} = 1;
  private int _pageSize = 10;
  public int PageSize
  {
    get 
    {
      return _pageSize;
  }
  set
   {
        _pageSize = (value > maxPageSize) ? value : maxPageSize;
      }
    }
  }
}
//results for 3 page
//pagesize = 20 number of results we want
OrderBy(thing => thing.Name)
//skipping first 2 pages(3-1). and pagesize(20*2) is the amt of results you skip.
.Skip((Tests.PageNumber -1)* Tests.PageSize)
.Take(testss.PageSize).ToList();

//page PageNumber

Travels?pagenumber3&pagesize=20
