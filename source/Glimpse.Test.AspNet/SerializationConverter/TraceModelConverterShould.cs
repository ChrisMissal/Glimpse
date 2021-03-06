﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Glimpse.AspNet.Model;
using Glimpse.AspNet.SerializationConverter;
using Glimpse.Core.Tab.Assist;
using Xunit;

namespace Glimpse.Test.AspNet.SerializationConverter
{
    public class TraceModelConverterShould
    {
        [Fact]
        public void ConvertToList()
        {
            var model = new List<TraceModel> { new TraceModel { Category = FormattingKeywords.Ms, FromFirst = 1.2, FromLast = 2.3, IndentLevel = 0, Message = "test" } };

            var converter = new TraceModelConverter();
            var result = converter.Convert(model) as IEnumerable<object>;

            Assert.NotNull(result);
            Assert.True(result.Count() > 0);
        }
    }
}
