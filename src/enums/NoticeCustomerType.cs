using System;

/*
 * AvaTax API Client Library
 *
 * (c) 2004-2019 Avalara, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author Genevieve Conty
 * @author Greg Hester
 */

namespace Avalara.AvaTax.RestClient
{
    /// <summary>
    /// Filing Frequency types
    /// </summary>
    public enum NoticeCustomerType
    {
        /// <summary>
        /// AvaTax Returns
        /// </summary>
        AvaTaxReturns = 1,

        /// <summary>
        /// Stand Alone
        /// </summary>
        StandAlone = 2,

        /// <summary>
        /// Strategic
        /// </summary>
        Strategic = 3,

        /// <summary>
        /// SST
        /// </summary>
        SST = 4,

        /// <summary>
        /// TrustFile
        /// </summary>
        TrustFile = 5,

    }
}
