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
   public class SdtMenuData_MenuDataItem : GxUserType
   {
      public SdtMenuData_MenuDataItem( )
      {
         constructorCallingAssembly = Assembly.GetCallingAssembly() ;
         initialize();
      }

      public SdtMenuData_MenuDataItem( IGxContext context )
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
                  gxTv_SdtMenuData_MenuDataItem_Menuid = (short)(NumberUtil.Val( oReader.Value, ".")) ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp(oReader.LocalName, "MenuTitle") == 0 )
               {
                  gxTv_SdtMenuData_MenuDataItem_Menutitle = oReader.Value ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp(oReader.LocalName, "MenuDescription") == 0 )
               {
                  gxTv_SdtMenuData_MenuDataItem_Menudescription = oReader.Value ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp(oReader.LocalName, "MenuURL") == 0 )
               {
                  gxTv_SdtMenuData_MenuDataItem_Menuurl = oReader.Value ;
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
            sName = "MenuData.MenuDataItem" ;
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
         oWriter.WriteElement("MenuId", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_SdtMenuData_MenuDataItem_Menuid), 4, 0)));
         oWriter.WriteElement("MenuTitle", StringUtil.RTrim( gxTv_SdtMenuData_MenuDataItem_Menutitle));
         oWriter.WriteElement("MenuDescription", StringUtil.RTrim( gxTv_SdtMenuData_MenuDataItem_Menudescription));
         oWriter.WriteElement("MenuURL", StringUtil.RTrim( gxTv_SdtMenuData_MenuDataItem_Menuurl));
         oWriter.WriteEndElement();
         return  ;
      }

      public override void ToJSON( )
      {
         AddObjectProperty("MenuId", (Object)(gxTv_SdtMenuData_MenuDataItem_Menuid));
         AddObjectProperty("MenuTitle", (Object)(gxTv_SdtMenuData_MenuDataItem_Menutitle));
         AddObjectProperty("MenuDescription", (Object)(gxTv_SdtMenuData_MenuDataItem_Menudescription));
         AddObjectProperty("MenuURL", (Object)(gxTv_SdtMenuData_MenuDataItem_Menuurl));
         return  ;
      }

      public short gxTpr_Menuid
      {
         get {
            return gxTv_SdtMenuData_MenuDataItem_Menuid ;
         }

         set {
            gxTv_SdtMenuData_MenuDataItem_Menuid = (short)(value) ;
         }

      }

      public void gxTv_SdtMenuData_MenuDataItem_Menuid_SetNull( )
      {
         gxTv_SdtMenuData_MenuDataItem_Menuid = 0 ;
         return  ;
      }

      public bool gxTv_SdtMenuData_MenuDataItem_Menuid_IsNull( )
      {
         return false ;
      }

      public String gxTpr_Menutitle
      {
         get {
            return gxTv_SdtMenuData_MenuDataItem_Menutitle ;
         }

         set {
            gxTv_SdtMenuData_MenuDataItem_Menutitle = (String)(value) ;
         }

      }

      public void gxTv_SdtMenuData_MenuDataItem_Menutitle_SetNull( )
      {
         gxTv_SdtMenuData_MenuDataItem_Menutitle = "" ;
         return  ;
      }

      public bool gxTv_SdtMenuData_MenuDataItem_Menutitle_IsNull( )
      {
         return false ;
      }

      public String gxTpr_Menudescription
      {
         get {
            return gxTv_SdtMenuData_MenuDataItem_Menudescription ;
         }

         set {
            gxTv_SdtMenuData_MenuDataItem_Menudescription = (String)(value) ;
         }

      }

      public void gxTv_SdtMenuData_MenuDataItem_Menudescription_SetNull( )
      {
         gxTv_SdtMenuData_MenuDataItem_Menudescription = "" ;
         return  ;
      }

      public bool gxTv_SdtMenuData_MenuDataItem_Menudescription_IsNull( )
      {
         return false ;
      }

      public String gxTpr_Menuurl
      {
         get {
            return gxTv_SdtMenuData_MenuDataItem_Menuurl ;
         }

         set {
            gxTv_SdtMenuData_MenuDataItem_Menuurl = (String)(value) ;
         }

      }

      public void gxTv_SdtMenuData_MenuDataItem_Menuurl_SetNull( )
      {
         gxTv_SdtMenuData_MenuDataItem_Menuurl = "" ;
         return  ;
      }

      public bool gxTv_SdtMenuData_MenuDataItem_Menuurl_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtMenuData_MenuDataItem_Menutitle = "" ;
         gxTv_SdtMenuData_MenuDataItem_Menudescription = "" ;
         gxTv_SdtMenuData_MenuDataItem_Menuurl = "" ;
         sTagName = "" ;
         return  ;
      }

      protected short gxTv_SdtMenuData_MenuDataItem_Menuid ;
      protected short readOk ;
      protected short nOutParmCount ;
      protected String gxTv_SdtMenuData_MenuDataItem_Menutitle ;
      protected String gxTv_SdtMenuData_MenuDataItem_Menudescription ;
      protected String sTagName ;
      protected String gxTv_SdtMenuData_MenuDataItem_Menuurl ;
      protected Assembly constructorCallingAssembly ;
      protected IGxContext context ;
   }

}
