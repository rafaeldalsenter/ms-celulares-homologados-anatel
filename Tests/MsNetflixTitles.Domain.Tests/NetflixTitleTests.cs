using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MsNetflixTitles.Domain.Tests
{
    public class NetflixTitleTests
    {
        [Fact]
        public void WithoutId_IsInvalid()
        {
        }

        [Fact]
        public void WithoutTitle_IsInvalid()
        {
        }

        [Fact]
        public void WithoutDirector_IsValid()
        {
        }

        [Fact]
        public void WithoutCast_IsValid()
        {
        }

        [Fact]
        public void WithoutCountry_IsValid()
        {
        }

        [Fact]
        public void WithoutDurationMin_IsValid()
        {
        }

        [Fact]
        public void WithoutDescription_IsValid()
        {
        }
    }
}