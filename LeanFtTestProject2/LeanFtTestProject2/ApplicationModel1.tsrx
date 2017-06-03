<?xml version="1.0" encoding="utf-8"?>
<applicationModel>
  <name>Application Model</name>
  <className>ApplicationModel1</className>
  <description>Test Repo</description>
  <objects>
    <object technology="Web" type="Button">
      <name>Google Search</name>
      <codeName>GoogleSearchButton</codeName>
      <identification>
        <properties>
          <property name="ButtonType" type="string">submit</property>
          <property name="AccessibilityName" type="string">Google Search</property>
          <property name="XPath" type="string">//FORM[@id="tsf"]/DIV[2]/DIV[3]/CENTER[1]/INPUT[1]</property>
        </properties>
      </identification>
    </object>
    <object technology="Web" type="EditField">
      <name>Search</name>
      <codeName>SearchEditField</codeName>
      <identification>
        <properties>
          <property name="Type" type="string">text</property>
          <property name="AccessibilityName" type="string">Search</property>
          <property name="TagName" type="string">INPUT</property>
          <property name="Title" type="string">Search</property>
        </properties>
      </identification>
    </object>
  </objects>
</applicationModel>