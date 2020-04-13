﻿// Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
//
// This program is free software; you can redistribute it and/or modify
// it under the terms of the GNU General Public License, version 2.0, as
// published by the Free Software Foundation.
//
// This program is also distributed with certain software (including
// but not limited to OpenSSL) that is licensed under separate terms,
// as designated in a particular file or component or in included license
// documentation.  The authors of MySQL hereby grant you an
// additional permission to link the program and your derivative works
// with the separately licensed software that they have included with
// MySQL.
//
// Without limiting anything contained in the foregoing, this file,
// which is part of MySQL Connector/NET, is also subject to the
// Universal FOSS Exception, version 1.0, a copy of which can be found at
// http://oss.oracle.com/licenses/universal-foss-exception.
//
// This program is distributed in the hope that it will be useful, but
// WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
// See the GNU General Public License, version 2.0, for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software Foundation, Inc.,
// 51 Franklin St, Fifth Floor, Boston, MA 02110-1301  USA

using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore.Tests.DbContextClasses;
using MySql.Data.EntityFrameworkCore.Extensions;
using System;
using System.Linq;
using Xunit;

namespace MySql.EntityFrameworkCore.Basic.Tests
{
  public class DbFunctionsMySQLTest
  {
    public DbFunctionsMySQLTest()
    {
      using (var context = new SakilaLiteContext())
      {
        context.Database.EnsureDeleted();
        context.Database.EnsureCreated();
        context.PopulateData();
      }
    }

    [Fact]
    public void DateDiffYear()
    {
      using (var context = new SakilaLiteContext())
      {
        var count = context.Actor
            .Count(a => EF.Functions.DateDiffYear(a.LastUpdate, DateTime.Now) == 14);

        Assert.Equal(200, count);
      }
    }

    [Fact]
    public void DateDiffMonth()
    {
      using (var context = new SakilaLiteContext())
      {
        var count = context.Actor
            .Count(a => EF.Functions.DateDiffMonth(a.LastUpdate, DateTime.Now) == 0);

        Assert.Equal(0, count);
      }
    }

    [Fact]
    public void DateDiffDay()
    {
      using (var context = new SakilaLiteContext())
      {
        var count = context.Actor
            .Count(a => EF.Functions.DateDiffDay(a.LastUpdate, DateTime.Now) == 0);

        Assert.Equal(0, count);
      }
    }

    [Fact]
    public void DateDiffHour()
    {
      using (var context = new SakilaLiteContext())
      {
        var count = context.Actor
            .Count(a => EF.Functions.DateDiffHour(a.LastUpdate, DateTime.Now) == 0);

        Assert.Equal(0, count);
      }
    }

    [Fact]
    public void DateDiffMinute ()
    {
      using (var context = new SakilaLiteContext())
      {
        var count = context.Actor
            .Count(a => EF.Functions.DateDiffMinute(a.LastUpdate, DateTime.Now) == 0);

        Assert.Equal(0, count);
      }
    }

    [Fact]
    public void DateDiffSecond()
    {
      using (var context = new SakilaLiteContext())
      {
        var count = context.Actor
            .Count(a => EF.Functions.DateDiffSecond(a.LastUpdate, DateTime.Now) == 0);

        Assert.Equal(0, count);
      }
    }

    [Fact]
    public void DateDiffMicrosecond()
    {
      using (var context = new SakilaLiteContext())
      {
        var count = context.Actor
            .Count(a => EF.Functions.DateDiffMicrosecond(a.LastUpdate, DateTime.Now) == 0);

        Assert.Equal(0, count);
      }
    }

    [Fact]
    public void LikeIntLiteral()
    {
      using (var context = new SakilaLiteContext())
      {
        var count = context.Actor.Count(o => EF.Functions.Like(o.ActorId, "%A%"));

        Assert.Equal(0, count);
      }
    }

    [Fact]
    public void LikeDateTimeLiteral()
    {
      using (var context = new SakilaLiteContext())
      {
        var count = context.Actor.Count(o => EF.Functions.Like(o.LastUpdate, "%A%"));

        Assert.Equal(0, count);
      }
    }

    [Fact]
    public void LikeIntLiteralWithEscape()
    {
      using (var context = new SakilaLiteContext())
      {
        var count = context.Actor.Count(o => EF.Functions.Like(o.ActorId, "!%", "!"));

        Assert.Equal(0, count);
      }
    }
  }
}
