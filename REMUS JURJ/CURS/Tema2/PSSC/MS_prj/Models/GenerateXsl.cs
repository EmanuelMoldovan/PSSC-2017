using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSSC
{
    public class GenerateXsl
    {
        public static string _my_xsl_code = @"<xsl:stylesheet xmlns:xsl='http://www.w3.org/1999/XSL/Transform' version='1.0'>
                <xsl:template match = 'Orders'>
                  <HTML>
                    <head>
                         <title>Restaurant</title>
                    </head>
                    <BODY bgcolor='#126d69' align='center'>
                      <b><font size='7'> Restaurant </font></b>
                        <p></p>
                      <TABLE BORDER = '2' align='center'>
                        <TR bgcolor = '#0f7f7a'>
                          <TD><b><font size='6'>Waiter</font></b></TD>
                          <TD><b><font size='6'>Table</font></b></TD>
                          <TD><b><font size='6'>Order</font></b></TD>
		                  <TD><b><font size='6'>Amount</font></b></TD>
                        </TR>
                        <xsl:for-each select = 'Order'>
                               <xsl:call-template name = 'fill'>
                                  </xsl:call-template>
		                </xsl:for-each>
                      </TABLE>
                    </BODY>
                  </HTML>
                </xsl:template>
                <xsl:template name = 'fill'>
                    <xsl:for-each select = 'FooD/Food'>
                     <font size='6'>
		                <TR bgcolor = '#269993'>
                                <TD>
                                    <font size='5'> 
						                <xsl:value-of select = '../../Waiter/@Name'/>
                                    </font>
                                </TD>
                                <TD>
                                    <font size='5'> 
						                <xsl:value-of select = '../../Table/@Table_No'/>
                                    </font>
                                </TD>
                                <TD>
                                    <font size='5'> 
						                <xsl:value-of select = '@Food_Type'/>
                                    </font>
                                </TD>
                                <TD>
                                    <font size='5'> 
						                <xsl:value-of select = '@Food_Amount'/>
                                    </font>
                                </TD>
                        </TR>
                        </font>
                        </xsl:for-each>
		                <xsl:for-each select = 'Drinks/Drink'>
                        <font size='6'>
		                <TR bgcolor = '#269993'>
                                <TD>
                                    <font size='5'> 
						                <xsl:value-of select = '../../Waiter/@Name'/>
                                    </font>
                                </TD>
                                <TD>
                                    <font size='5'> 
						                <xsl:value-of select = '../../Table/@Table_No'/>
                                    </font>
                                </TD>
                                <TD>
                                    <font size='5'> 
						                <xsl:value-of select = '@Drink_Type'/>

                                    </font>
                                </TD>
                                <TD>
                                   <font size='5'> 
						                <xsl:value-of select = '@Drink_Amount'/>
                                    </font>
                                </TD>
                        </TR>
                        </font>
                        </xsl:for-each>
                  </xsl:template>
                </xsl:stylesheet>";
        public static void Xsl_Generate(string path)
        {
            File.WriteAllText(path+"\\restaurant.xsl", _my_xsl_code);
        }
    }
}
