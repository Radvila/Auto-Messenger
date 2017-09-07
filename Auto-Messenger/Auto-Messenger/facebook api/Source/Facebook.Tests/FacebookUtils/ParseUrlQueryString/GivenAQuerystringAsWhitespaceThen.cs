//-----------------------------------------------------------------------
// <copyright file="<file>.cs" company="The Outercurve Foundation">
//    Copyright (c) 2011, The Outercurve Foundation. 
//
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//      http://www.apache.org/licenses/LICENSE-2.0
//
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
// </copyright>
// <author>Nathan Totten (ntotten.com), Jim Zimmerman (jimzimmerman.com) and Prabir Shrestha (prabir.me)</author>
// <website>https://github.com/facebook-csharp-sdk/facbook-csharp-sdk</website>
//-----------------------------------------------------------------------

namespace Facebook.Tests.FacebookUtils.ParseUrlQueryString
{
    using Facebook;
    using Xunit;

    public class GivenAQuerystringAsWhitespaceThen
    {
        [Fact]
        public void ResultShouldNotBeNull()
        {
            string whiteSpaceQueryString = "    ";
            var result = FacebookUtils.ParseUrlQueryString(whiteSpaceQueryString);

            Assert.NotNull(result);
        }

        [Fact]
        public void TheCountOfResultShouldBe0()
        {
            string whiteSpaceQueryString = "    ";
            var result = FacebookUtils.ParseUrlQueryString(whiteSpaceQueryString);

            Assert.Equal(0, result.Count);
        }
    }
}