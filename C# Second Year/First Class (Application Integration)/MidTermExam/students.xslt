<?xml version="1.0" encoding="UTF-8"?>

<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

<xsl:template match="/">
  <html>
  <body>
  <h2>Students</h2>
  <table border="1">
    <tr bgcolor="#9acd32">
      <th>Name</th>
      <th>School</th>
      <th>Hw1</th>
      <th>Hw2</th>
      <th>Hw3</th>
      <th>Exam</th>
      <th>Project Name</th>
      <th>Project Score</th>
    </tr>
    <xsl:for-each select="Students/Student">
    <tr>
      <td><xsl:value-of select="Name"/></td>
      <td><xsl:value-of select="School"/></td>
      <td><xsl:value-of select="Course/Hw1"/></td>
      <td><xsl:value-of select="Course/Hw2"/></td>
      <td><xsl:value-of select="Course/Hw3"/></td>
      <td><xsl:value-of select="Course/Exam"/></td>
      <td><xsl:value-of select="Course/Project/ProjectName"/></td>
      <td><xsl:value-of select="Course/Project/ProjectScore"/></td>
    </tr>
    </xsl:for-each>
  </table>
  </body>
  </html>
</xsl:template>

</xsl:stylesheet>