using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Data;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Reflection;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   [Serializable]
   public class SdtTabsMenuData_TabsMenuDataItem_SectionsItem : GxUserType
   {
      public SdtTabsMenuData_TabsMenuDataItem_SectionsItem( )
      {
         constructorCallingAssembly = Assembly.GetCallingAssembly() ;
         initialize();
      }

      public SdtTabsMenuData_TabsMenuDataItem_SectionsItem( IGxContext context )
      {
         this.context = context;
         constructorCallingAssembly = Assembly.GetCallingAssembly() ;
         initialize();
      }

      public override short readxml( GXXMLReader oReader ,
                                     String sName )
      {
         short GXSoapError = 1 ;
         sTagName = oReader.Name ;
         if ( oReader.IsSimple == 0 )
         {
            GXSoapError = oReader.Read() ;
            nOutParmCount = 0 ;
            while ( ( ( StringUtil.StrCmp(oReader.Name, sTagName) != 0 ) || ( oReader.NodeType == 1 ) ) && ( GXSoapError > 0 ) )
            {
               readOk = 0 ;
               if ( StringUtil.StrCmp(oReader.LocalName, "SectionId") == 0 )
               {
                  gxTv_SdtTabsMenuData_TabsMenuDataItem_SectionsItem_Sectionid = (short)(NumberUtil.Val( oReader.Value, ".")) ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp(oReader.LocalName, "SectionTitle") == 0 )
               {
                  gxTv_SdtTabsMenuData_TabsMenuDataItem_SectionsItem_Sectiontitle = oReader.Value ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp(oReader.LocalName, "SectionDescription") == 0 )
               {
                  gxTv_SdtTabsMenuData_TabsMenuDataItem_SectionsItem_Sectiondescription = oReader.Value ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp(oReader.LocalName, "SectionURL") == 0 )
               {
                  gxTv_SdtTabsMenuData_TabsMenuDataItem_SectionsItem_Sectionurl = oReader.Value ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               nOutParmCount = (short)(nOutParmCount+1) ;
               if ( readOk == 0 )
               {
                  context.sSOAPErrMsg = context.sSOAPErrMsg + "Error reading " + sTagName + StringUtil.NewLine( ) ;
                  GXSoapError = (short)(nOutParmCount*-1) ;
               }
            }
         }
         return GXSoapError ;
      }

      public override void writexml( GXXMLWriter oWriter ,
                                     String sName ,
                                     String sNameSpace )
      {
         if ( String.IsNullOrEmpty(StringUtil.RTrim( sName)) )
         {
            sName = "TabsMenuData.TabsMenuDataItem.SectionsItem" ;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( sNameSpace)) )
         {
            sNameSpace = "MarianoTesis" ;
         }
         oWriter.WriteStartElement(sName);
         if ( StringUtil.StrCmp(StringUtil.Left( sNameSpace, 10), "[*:nosend]") != 0 )
         {
            oWriter.WriteAttribute("xmlns", sNameSpace);
         }
         else
         {
            sNameSpace = StringUtil.Right( sNameSpace, (short)(StringUtil.Len( sNameSpace)-10)) ;
         }
         oWriter.WriteElement("SectionId", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_SdtTabsMenuData_TabsMenuDataItem_SectionsItem_Sectionid), 4, 0)));
         oWriter.WriteElement("SectionTitle", StringUtil.RTrim( gxTv_SdtTabsMenuData_TabsMenuDataItem_SectionsItem_Sectiontitle));
         oWriter.WriteElement("SectionDescription", StringUtil.RTrim( gxTv_SdtTabsMenuData_TabsMenuDataItem_SectionsItem_Sectiondescription));
         oWriter.WriteElement("SectionURL", StringUtil.RTrim( gxTv_SdtTabsMenuData_TabsMenuDataItem_SectionsItem_Sectionurl));
         oWriter.WriteEndElement();
         return  ;
      }

      public override void ToJSON( )
      {
         AddObjectProperty("SectionId", (Object)(gxTv_SdtTabsMenuData_TabsMenuDataItem_SectionsItem_Sectionid));
         AddObjectProperty("SectionTitle", (Object)(gxTv_SdtTabsMenuData_TabsMenuDataItem_SectionsItem_Sectiontitle));
         AddObjectProperty("SectionDescription", (Object)(gxTv_SdtTabsMenuData_TabsMenuDataItem_SectionsItem_Sectiondescription));
         AddObjectProperty("SectionURL", (Object)(gxTv_SdtTabsMenuData_TabsMenuDataItem_SectionsItem_Sectionurl));
         return  ;
      }

      public short gxTpr_Sectionid
      {
         get {
            return gxTv_SdtTabsMenuData_TabsMenuDataItem_SectionsItem_Sectionid ;
         }

         set {
            gxTv_SdtTabsMenuData_TabsMenuDataItem_SectionsItem_Sectionid = (short)(value) ;
         }

      }

      public void gxTv_SdtTabsMenuData_TabsMenuDataItem_SectionsItem_Sectionid_SetNull( )
      {
         gxTv_SdtTabsMenuData_TabsMenuDataItem_SectionsItem_Sectionid = 0 ;
         return  ;
      }

      public bool gxTv_SdtTabsMenuData_TabsMenuDataItem_SectionsItem_Sectionid_IsNull( )
      {
         return false ;
      }

      public String gxTpr_Sectiontitle
      {
         get {
            return gxTv_SdtTabsMenuData_TabsMenuDataItem_SectionsItem_Sectiontitle ;
         }

         set {
            gxTv_SdtTabsMenuData_TabsMenuDataItem_SectionsItem_Sectiontitle = (String)(value) ;
         }

      }

      public void gxTv_SdtTabsMenuData_TabsMenuDataItem_SectionsItem_Sectiontitle_SetNull( )
      {
         gxTv_SdtTabsMenuData_TabsMenuDataItem_SectionsItem_Sectiontitle = "" ;
         return  ;
      }

      public bool gxTv_SdtTabsMenuData_TabsMenuDataItem_SectionsItem_Sectiontitle_IsNull( )
      {
         return false ;
      }

      public String gxTpr_Sectiondescription
      {
         get {
            return gxTv_SdtTabsMenuData_TabsMenuDataItem_SectionsItem_Sectiondescription ;
         }

         set {
            gxTv_SdtTabsMenuData_TabsMenuDataItem_SectionsItem_Sectiondescription = (String)(value) ;
         }

      }

      public void gxTv_SdtTabsMenuData_TabsMenuDataItem_SectionsItem_Sectiondescription_SetNull( )
      {
         gxTv_SdtTabsMenuData_TabsMenuDataItem_SectionsItem_Sectiondescription = "" ;
         return  ;
      }

      public bool gxTv_SdtTabsMenuData_TabsMenuDataItem_SectionsItem_Sectiondescription_IsNull( )
      {
         return false ;
      }

      public String gxTpr_Sectionurl
      {
         get {
            return gxTv_SdtTabsMenuData_TabsMenuDataItem_SectionsItem_Sectionurl ;
         }

         set {
            gxTv_SdtTabsMenuData_TabsMenuDataItem_SectionsItem_Sectionurl = (String)(value) ;
         }

      }

      public void gxTv_SdtTabsMenuData_TabsMenuDataItem_SectionsItem_Sectionurl_SetNull( )
      {
         gxTv_SdtTabsMenuData_TabsMenuDataItem_SectionsItem_Sectionurl = "" ;
         return  ;
      }

      public bool gxTv_SdtTabsMenuData_TabsMenuDataItem_SectionsItem_Sectionurl_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtTabsMenuData_TabsMenuDataItem_SectionsItem_Sectiontitle = "" ;
         gxTv_SdtTabsMenuData_TabsMenuDataItem_SectionsItem_Sectiondescription = "" ;
         gxTv_SdtTabsMenuData_TabsMenuDataItem_SectionsItem_Sectionurl = "" ;
         sTagName = "" ;
         return  ;
      }

      protected short gxTv_SdtTabsMenuData_TabsMenuDataItem_SectionsItem_Sectionid ;
      protected short readOk ;
      protected short nOutParmCount ;
      protected String gxTv_SdtTabsMenuData_TabsMenuDataItem_SectionsItem_Sectiontitle ;
      protected String gxTv_SdtTabsMenuData_TabsMenuDataItem_SectionsItem_Sectiondescription ;
      protected String sTagName ;
      protected String gxTv_SdtTabsMenuData_TabsMenuDataItem_SectionsItem_Sectionurl ;
      protected Assembly constructorCallingAssembly ;
      protected IGxContext context ;
   }

}
