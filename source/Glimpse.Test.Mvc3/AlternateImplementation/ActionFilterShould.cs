﻿using System.Linq;
using System.Web.Mvc;
using Glimpse.Core.Extensibility;
using Glimpse.Mvc.AlternateImplementation;
using Glimpse.Test.Common;
using Xunit;
using Xunit.Extensions;

namespace Glimpse.Test.Mvc3.AlternateImplementation
{
    public class ActionFilterShould
    {
        [Theory, AutoMock]
        public void ReturnTwoMethods(IProxyFactory proxyFactory)
        {
            AlternateType<IActionFilter> alternationImplementation = new ActionFilter(proxyFactory);

            Assert.Equal(2, alternationImplementation.AllMethods.Count());
        }

        [Theory, AutoMock]
        public void SetProxyFactory(IProxyFactory proxyFactory)
        {
            AlternateType<IActionFilter> alternationImplementation = new ActionFilter(proxyFactory);

            Assert.Equal(proxyFactory, alternationImplementation.ProxyFactory);
        }
    }
}
