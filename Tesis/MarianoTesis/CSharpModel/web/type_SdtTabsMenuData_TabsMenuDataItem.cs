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
   public class SdtTabsMenuData_TabsMenuDataItem : GxUserType
   {
      public SdtTabsMenuData_TabsMenuDataItem( )
      {
         constructorCallingAssembly = Assembly.GetCallingAssembly() ;
         initialize();
      }

      public SdtTabsMenuData_TabsMenuDataItem( IGxContext context )
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
               if ( StringUtil.StrCmp(oReader.LocalName, "MenuId") == 0 )
               {
                  gxTv_SdtTabsMenuData_TabsMenuDataItem_Menuid = (short)(NumberUtil.Val( oReader.Value, ".")) ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp(oReader.LocalName, "MenuTitle") == 0 )
               {
                  gxTv_SdtTabsMenuData_TabsMenuDataItem_Menutitle = oReader.Value ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp(oReader.LocalName, "MenuDescription") == 0 )
               {
                  gxTv_SdtTabsMenuData_TabsMenuDataItem_Menudescription = oReader.Value ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp(oReader.LocalName, "MenuURL") == 0 )
               {
                  gxTv_SdtTabsMenuData_TabsMenuDataItem_Menuurl = oReader.Value ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp(oReader.LocalName, "Sections") == 0 )
               {
                  if ( gxTv_SdtTabsMenuData_TabsMenuDataItem_Sections == null )
                  {
                     gxTv_SdtTabsMenuData_TabsMenuDataItem_Sections = new GxObjectCollection( context, "TabsMenuData.TabsMenuDataItem.SectionsItem", "", "SdtTabsMenuData_TabsMenuDataItem_SectionsItem", "GeneXus.Programs");
                  }
                  if ( oReader.IsSimple == 0 )
                  {
                     GXSoapError = gxTv_SdtTabsMenuData_TabsMenuDataItem_Sections.readxmlcollection(oReader, "Sections", "SectionsItem") ;
                  }
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
            sName = "TabsMenuData.TabsMenuDataItem" ;
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
         oWriter.WriteElement("MenuId", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_SdtTabsMenuData_TabsMenuDataItem_Menuid), 4, 0)));
         oWriter.WriteElement("MenuTitle", StringUtil.RTrim( gxTv_SdtTabsMenuData_TabsMenuDataItem_Menutitle));
         oWriter.WriteElement("MenuDescription", StringUtil.RTrim( gxTv_SdtTabsMenuData_TabsMenuDataItem_Menudescription));
         oWriter.WriteElement("MenuURL", StringUtil.RTrim( gxTv_SdtTabsMenuData_TabsMenuDataItem_Menuurl));
         if ( gxTv_SdtTabsMenuData_TabsMenuDataItem_Sections != null )
         {
            String sNameSpace1 ;
            if ( StringUtil.StrCmp(sNameSpace, "MarianoTesis") == 0 )
            {
               sNameSpace1 = "[*:nosend]" + "MarianoTesis" ;
            }
            else
            {
               sNameSpace1 = "MarianoTesis" ;
            }
            gxTv_SdtTabsMenuData_TabsMenuDataItem_Sections.writexmlcollection(oWriter, "Sections", sNameSpace1, "SectionsItem", sNameSpace1);
         }
         oWriter.WriteEndElement();
         return  ;
      }

      public override void ToJSON( )
      {
         AddObjectProperty("MenuId", (Object)(gxTv_SdtTabsMenuData_TabsMenuDataItem_Menuid));
         AddObjectProperty("MenuTitle", (Object)(gxTv_SdtTabsMenuData_TabsMenuDataItem_Menutitle));
         AddObjectProperty("MenuDescription", (Object)(gxTv_SdtTabsMenuData_TabsMenuDataItem_Menudescription));
         AddObjectProperty("MenuURL", (Object)(gxTv_SdtTabsMenuData_TabsMenuDataItem_Menuurl));
         if ( gxTv_SdtTabsMenuData_TabsMenuDataItem_Sections != null )
         {
            AddObjectProperty("Sections", (Object)(gxTv_SdtTabsMenuData_TabsMenuDataItem_Sections));
         }
         return  ;
      }

      public short gxTpr_Menuid
      {
         get {
            return gxTv_SdtTabsMenuData_TabsMenuDataItem_Menuid ;
         }

         set {
            gxTv_SdtTabsMenuData_TabsMenuDataItem_Menuid = (short)(value) ;
         }

      }

      public void gxTv_SdtTabsMenuData_TabsMenuDataItem_Menuid_SetNull( )
      {
         gxTv_SdtTabsMenuData_TabsMenuDataItem_Menuid = 0 ;
         return  ;
      }

      public bool gxTv_SdtTabsMenuData_TabsMenuDataItem_Menuid_IsNull( )
      {
         return false ;
      }

      public String gxTpr_Menutitle
      {
         get {
            return gxTv_SdtTabsMenuData_TabsMenuDataItem_Menutitle ;
         }

         set {
            gxTv_SdtTabsMenuData_TabsMenuDataItem_Menutitle = (String)(value) ;
         }

      }

      public void gxTv_SdtTabsMenuData_TabsMenuDataItem_Menutitle_SetNull( )
      {
         gxTv_SdtTabsMenuData_TabsMenuDataItem_Menutitle = "" ;
         return  ;
      }

      public bool gxTv_SdtTabsMenuData_TabsMenuDataItem_Menutitle_IsNull( )
      {
         return false ;
      }

      public String gxTpr_Menudescription
      {
         get {
            return gxTv_SdtTabsMenuData_TabsMenuDataItem_Menudescription ;
         }

         set {
            gxTv_SdtTabsMenuData_TabsMenuDataItem_Menudescription = (String)(value) ;
         }

      }

      public void gxTv_SdtTabsMenuData_TabsMenuDataItem_Menudescription_SetNull( )
      {
         gxTv_SdtTabsMenuData_TabsMenuDataItem_Menudescription = "" ;
         return  ;
      }

      public bool gxTv_SdtTabsMenuData_TabsMenuDataItem_Menudescription_IsNull( )
      {
         return false ;
      }

      public String gxTpr_Menuurl
      {
         get {
            return gxTv_SdtTabsMenuData_TabsMenuDataItem_Menuurl ;
         }

         set {
            gxTv_SdtTabsMenuData_TabsMenuDataItem_Menuurl = (String)(value) ;
         }

      }

      public void gxTv_SdtTabsMenuData_TabsMenuDataItem_Menuurl_SetNull( )
      {
         gxTv_SdtTabsMenuData_TabsMenuDataItem_Menuurl = "" ;
         return  ;
      }

      public bool gxTv_SdtTabsMenuData_TabsMenuDataItem_Menuurl_IsNull( )
      {
         return false ;
      }

      public IGxCollection gxTpr_Sections
      {
         get {
            if ( gxTv_SdtTabsMenuData_TabsMenuDataItem_Sections == null )
            {
               gxTv_SdtTabsMenuData_TabsMenuDataItem_Sections = new GxObjectCollection( context, "TabsMenuData.TabsMenuDataItem.SectionsItem", "", "SdtTabsMenuData_TabsMenuDataItem_SectionsItem", "GeneXus.Programs");
            }
            return gxTv_SdtTabsMenuData_TabsMenuDataItem_Sections ;
         }

         set {
            gxTv_SdtTabsMenuData_TabsMenuDataItem_Sections = value ;
         }

      }

      public void gxTv_SdtTabsMenuData_TabsMenuDataItem_Sections_SetNull( )
      {
         gxTv_SdtTabsMenuData_TabsMenuDataItem_Sections = null ;
         return  ;
      }

      public bool gxTv_SdtTabsMenuData_TabsMenuDataItem_Sections_IsNull( )
      {
         if ( gxTv_SdtTabsMenuData_TabsMenuDataItem_Sections == null )
         {
            return true ;
         }
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtTabsMenuData_TabsMenuDataItem_Menutitle = "" ;
         gxTv_SdtTabsMenuData_TabsMenuDataItem_Menudescription = "" ;
         gxTv_SdtTabsMenuData_TabsMenuDataItem_Menuurl = "" ;
         sTagName = "" ;
         return  ;
      }

      protected short gxTv_SdtTabsMenuData_TabsMenuDataItem_Menuid ;
      protected short readOk ;
      protected short nOutParmCount ;
      protected String gxTv_SdtTabsMenuData_TabsMenuDataItem_Menutitle ;
      protected String gxTv_SdtTabsMenuData_TabsMenuDataItem_Menudescription ;
      protected String sTagName ;
      protected String gxTv_SdtTabsMenuData_TabsMenuDataItem_Menuurl ;
      protected Assembly constructorCallingAssembly ;
      protected IGxContext context ;
      [ObjectCollection(ItemType=typeof( SdtTabsMenuData_TabsMenuDataItem_SectionsItem ))]
      protected IGxCollection gxTv_SdtTabsMenuData_TabsMenuDataItem_Sections=null ;
   }

}
