<?xml version="1.0" encoding="UTF-8"?>

<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

<xsl:template match="/">
  <html>
  <body>
  <h2>Drones</h2>
  <table border="1">
    <tr bgcolor="#9acd32">
      <th>Manufacturer</th>
      <th>Model</th>
      <th>Price</th>
      <th>Time</th>
      <th>Size</th>
    </tr>
    <xsl:for-each select="table/trow">
    <tr>
      <td><xsl:value-of select="Manufacturer"/></td>
      <td><xsl:value-of select="Model"/></td>
      <td><xsl:value-of select="Price"/></td>
      <td><xsl:value-of select="Time"/></td>
      <td><xsl:value-of select="Size"/></td>
    </tr>
    </xsl:for-each>
  </table>
  </body>
  </html>
</xsl:template>

</xsl:stylesheet>