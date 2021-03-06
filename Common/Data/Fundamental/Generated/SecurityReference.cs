/*
 * QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
 * Lean Algorithmic Trading Engine v2.0. Copyright 2014 QuantConnect Corporation.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License"); 
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
*/

//------------------------------------------------------------------------------
// This code was generated by a tool.
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

// To get up to date fundamental definition files for your hedgefund contact sales@quantconnect.com

using System;
using Newtonsoft.Json;

namespace QuantConnect.Data.Fundamental
{
	/// <summary>
	/// Definition of the SecurityReference class
	/// </summary>
	public class SecurityReference : BaseData
	{
		/// <summary>
		/// An arrangement of characters (often letters) representing a particular security listed on an exchange or otherwise traded publicly.
		/// Note: Morningstar's multi-share class symbols will often contain a "period" within the symbol; e.g. BRK.B for Berkshire Hathaway
		/// Class B.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 1001
		/// </remarks>
		[JsonProperty("1001")]
		public string SecuritySymbol { get; set; }

		/// <summary>
		/// The Id representing the stock exchange that the particular share class is trading.  See separate reference document for Exchange
		/// Mappings.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 1002
		/// </remarks>
		[JsonProperty("1002")]
		public string ExchangeId { get; set; }

		/// <summary>
		/// 3 Character ISO code of the currency that the exchange price is denominated in; i.e. the trading currency of the security.  See
		/// separate reference document for Currency Mappings.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 1004
		/// </remarks>
		[JsonProperty("1004")]
		public string CurrencyId { get; set; }

		/// <summary>
		/// An identification number assigned to financial instruments in Switzerland. These numbers are similar to the CUSIP numbers that are
		/// used in Canada and the U.S. A typical valoren number is between six to nine digits in length.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 1005
		/// </remarks>
		[JsonProperty("1005")]
		public string Valoren { get; set; }

		/// <summary>
		/// The acronym for the Committee for Uniform Security Identification Procedures. The Committee is appointed by the National
		/// Association of Securities Dealers (NASD) to assign identification numbers to nearly all publicly traded stock and bond certificates.
		/// CUSIPs are 9-digit numbers designed to be unique numerical identifiers for traded securities.
		/// NOTE: CUSIPS are proprietary to Standard &amp; Poor's CUSIP Service Bureau through an exclusive agreement with American Bankers
		/// Association.  CUSIP number is provided for matching purposes only; no redistribution rights apply.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 1006
		/// </remarks>
		[JsonProperty("1006")]
		public string CUSIP { get; set; }

		/// <summary>
		/// The acronym for International Securities Identification Number.  A code that uniquely identifies a specific securities issue. The
		/// organization that allocates ISINs in any particular country is the country's respective National Numbering Agency (NNA). All
		/// internationally traded securities issuers are urged to use this numbering scheme, which is now the accepted standard by virtually
		/// all countries. The United States and Canada primarily use a similar scheme known as a CUSIP number.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 1007
		/// </remarks>
		[JsonProperty("1007")]
		public string ISIN { get; set; }

		/// <summary>
		/// The acronym for Stock Exchange Daily Official List. An identification code, consisting of at least seven alphanumeric characters,
		/// that is assigned to all securities trading on the London Stock Exchange and on other smaller exchanges in the U.K....U.K. stocks
		/// that do not trade in the U.S. can be identified by their SEDOL code.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 1008
		/// </remarks>
		[JsonProperty("1008")]
		public string SEDOL { get; set; }

		/// <summary>
		/// The initial day that the share begins trading on a public exchange.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 1009
		/// </remarks>
		[JsonProperty("1009")]
		public DateTime IPODate { get; set; }

		/// <summary>
		/// Indicator to denote if the share class is a depository receipt. 1 denotes it is an ADR or GDR; otherwise 0.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 1010
		/// </remarks>
		[JsonProperty("1010")]
		public bool IsDepositaryReceipt { get; set; }

		/// <summary>
		/// The number of underlying common shares backing each American Depository Receipt traded.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 1011
		/// </remarks>
		[JsonProperty("1011")]
		public decimal DepositaryReceiptRatio { get; set; }

		/// <summary>
		/// Each security will be assigned to one of the below security type classifications;
		/// - Common Stock (ST00000001)
		/// - Preferred Stock (ST00000002)
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 1012
		/// </remarks>
		[JsonProperty("1012")]
		public string SecurityType { get; set; }

		/// <summary>
		/// Provides information when applicable such as whether the share class is Class A or Class B, an ADR, GDR, or a business
		/// development company (BDC).  For preferred stocks, this field provides more detail about the preferred share class.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 1013
		/// </remarks>
		[JsonProperty("1013")]
		public string ShareClassDescription { get; set; }

		/// <summary>
		/// At the ShareClass level; each share is assigned to 1 of 4 possible status classifications; (A) Active, (D) Deactive, (I) Inactive, or (O)
		/// Obsolete:
		/// - Active-Share class is currently trading in a public market, and we have fundamental data available.
		/// - Deactive-Share class was once Active, but is no longer trading due to share being delisted from the exchange.
		/// - Inactive-Share class is currently trading in a public market, but no fundamental data is available.
		/// - Obsolete-Share class was once Inactive, but is no longer trading due to share being delisted from the exchange.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 1014
		/// </remarks>
		[JsonProperty("1014")]
		public string ShareClassStatus { get; set; }

		/// <summary>
		/// This indicator will denote if the indicated share is the primary share for the company. A "1" denotes the primary share, a "0"
		/// denotes a share that is not the primary share. The primary share is defined as the first share that a company IPO'd with and is still
		/// actively trading. If this share is no longer trading, we will denote the primary share as the share with the highest volume.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 1015
		/// </remarks>
		[JsonProperty("1015")]
		public bool IsPrimaryShare { get; set; }

		/// <summary>
		/// Shareholder election plan to re-invest cash dividend into additional shares.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 1016
		/// </remarks>
		[JsonProperty("1016")]
		public bool IsDividendReinvest { get; set; }

		/// <summary>
		/// A plan to make it possible for individual investors to invest in public companies without going through a stock broker.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 1017
		/// </remarks>
		[JsonProperty("1017")]
		public bool IsDirectInvest { get; set; }

		/// <summary>
		/// Identifier assigned to each security Morningstar covers.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 1018
		/// </remarks>
		[JsonProperty("1018")]
		public string InvestmentId { get; set; }

		/// <summary>
		/// IPO offer price indicates the price at which an issuer sells its shares under an initial public offering (IPO). The offer price is set by
		/// issuer and its underwriters.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 1019
		/// </remarks>
		[JsonProperty("1019")]
		public decimal IPOOfferPrice { get; set; }

		/// <summary>
		/// The date on which an inactive security was delisted from an exchange.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 1020
		/// </remarks>
		[JsonProperty("1020")]
		public DateTime DelistingDate { get; set; }

		/// <summary>
		/// The reason for an inactive security's delisting from an exchange. The full list of Delisting Reason codes can be found within the Data
		/// Definitions- Appendix A DelistingReason Codes tab.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 1021
		/// </remarks>
		[JsonProperty("1021")]
		public string DelistingReason { get; set; }

		/// <summary>
		/// The MIC (market identifier code) of the related shareclass of the company. See Data Appendix A for the relevant MIC to exchange
		/// name mapping.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 1022
		/// </remarks>
		[JsonProperty("1022")]
		public string MIC { get; set; }

		/// <summary>
		/// Refers to the type of securities that can be found within the equity database. For the vast majority, this value will populate as null
		/// for regular common shares. For a minority of shareclasses, this will populate as either "Participating Preferred" or "Closed-End
		/// Fund", which reflects our limited coverage of these types of securities within our equity database.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 1023
		/// </remarks>
		[JsonProperty("1023")]
		public string CommonShareSubType { get; set; }

		/// <summary>
		/// The estimated offer price range (low-high) for a new IPO. The field should be used until the final IPO price becomes available, as
		/// populated in the data field "IPOPrice".
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 1024
		/// </remarks>
		[JsonProperty("1024")]
		public string IPOOfferPriceRange { get; set; }

		/// <summary>
		/// Classification to denote different Marketplace or Market tiers within a stock exchange.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 1025
		/// </remarks>
		[JsonProperty("1025")]
		public string ExchangeSubMarketGlobalId { get; set; }

		/// <summary>
		/// Creates an instance of the SecurityReference class
		/// </summary>
		public SecurityReference()
		{
		}

		/// <summary>
		/// Sets values for non existing periods from a previous instance
		/// </summary>
		/// <remarks>Used to fill-forward values from previous dates</remarks>
		/// <param name="previous">The previous instance</param>
		public void UpdateValues(SecurityReference previous)
		{
			if (previous == null) return;

		}
	}
}
