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
   public class SdtRecentLinksItems_RecentLinksItem : GxUserType
   {
      public SdtRecentLinksItems_RecentLinksItem( )
      {
         constructorCallingAssembly = Assembly.GetCallingAssembly() ;
         initialize();
      }

      public SdtRecentLinksItems_RecentLinksItem( IGxContext context )
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
               if ( StringUtil.StrCmp(oReader.LocalName, "Caption") == 0 )
               {
                  gxTv_SdtRecentLinksItems_RecentLinksItem_Caption = oReader.Value ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp(oReader.LocalName, "URL") == 0 )
               {
                  gxTv_SdtRecentLinksItems_RecentLinksItem_Url = oReader.Value ;
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
            sName = "RecentLinksItems.RecentLinksItem" ;
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
         oWriter.WriteElement("Caption", StringUtil.RTrim( gxTv_SdtRecentLinksItems_RecentLinksItem_Caption));
         oWriter.WriteElement("URL", StringUtil.RTrim( gxTv_SdtRecentLinksItems_RecentLinksItem_Url));
         oWriter.WriteEndElement();
         return  ;
      }

      public override void ToJSON( )
      {
         AddObjectProperty("Caption", (Object)(gxTv_SdtRecentLinksItems_RecentLinksItem_Caption));
         AddObjectProperty("URL", (Object)(gxTv_SdtRecentLinksItems_RecentLinksItem_Url));
         return  ;
      }

      public String gxTpr_Caption
      {
         get {
            return gxTv_SdtRecentLinksItems_RecentLinksItem_Caption ;
         }

         set {
            gxTv_SdtRecentLinksItems_RecentLinksItem_Caption = (String)(value) ;
         }

      }

      public void gxTv_SdtRecentLinksItems_RecentLinksItem_Caption_SetNull( )
      {
         gxTv_SdtRecentLinksItems_RecentLinksItem_Caption = "" ;
         return  ;
      }

      public bool gxTv_SdtRecentLinksItems_RecentLinksItem_Caption_IsNull( )
      {
         return false ;
      }

      public String gxTpr_Url
      {
         get {
            return gxTv_SdtRecentLinksItems_RecentLinksItem_Url ;
         }

         set {
            gxTv_SdtRecentLinksItems_RecentLinksItem_Url = (String)(value) ;
         }

      }

      public void gxTv_SdtRecentLinksItems_RecentLinksItem_Url_SetNull( )
      {
         gxTv_SdtRecentLinksItems_RecentLinksItem_Url = "" ;
         return  ;
      }

      public bool gxTv_SdtRecentLinksItems_RecentLinksItem_Url_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtRecentLinksItems_RecentLinksItem_Caption = "" ;
         gxTv_SdtRecentLinksItems_RecentLinksItem_Url = "" ;
         sTagName = "" ;
         return  ;
      }

      protected short readOk ;
      protected short nOutParmCount ;
      protected String sTagName ;
      protected String gxTv_SdtRecentLinksItems_RecentLinksItem_Caption ;
      protected String gxTv_SdtRecentLinksItems_RecentLinksItem_Url ;
      protected Assembly constructorCallingAssembly ;
      protected IGxContext context ;
   }

}
