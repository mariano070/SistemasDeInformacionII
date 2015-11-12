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
   public class SdtJSCookMenuItem : GxUserType
   {
      public SdtJSCookMenuItem( )
      {
         constructorCallingAssembly = Assembly.GetCallingAssembly() ;
         initialize();
      }

      public SdtJSCookMenuItem( IGxContext context )
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
               if ( StringUtil.StrCmp(oReader.LocalName, "Icon") == 0 )
               {
                  gxTv_SdtJSCookMenuItem_Icon = oReader.Value ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp(oReader.LocalName, "Title") == 0 )
               {
                  gxTv_SdtJSCookMenuItem_Title = oReader.Value ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp(oReader.LocalName, "Url") == 0 )
               {
                  gxTv_SdtJSCookMenuItem_Url = oReader.Value ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp(oReader.LocalName, "Target") == 0 )
               {
                  gxTv_SdtJSCookMenuItem_Target = oReader.Value ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp(oReader.LocalName, "Description") == 0 )
               {
                  gxTv_SdtJSCookMenuItem_Description = oReader.Value ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp(oReader.LocalName, "Childs") == 0 )
               {
                  if ( gxTv_SdtJSCookMenuItem_Childs == null )
                  {
                     gxTv_SdtJSCookMenuItem_Childs = new GxObjectCollection( context, "JSCookMenuItem", "MarianoTesis", "SdtJSCookMenuItem", "GeneXus.Programs");
                  }
                  if ( oReader.IsSimple == 0 )
                  {
                     GXSoapError = gxTv_SdtJSCookMenuItem_Childs.readxmlcollection(oReader, "Childs", "Item") ;
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
            sName = "JSCookMenuItem" ;
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
         oWriter.WriteElement("Icon", StringUtil.RTrim( gxTv_SdtJSCookMenuItem_Icon));
         oWriter.WriteElement("Title", StringUtil.RTrim( gxTv_SdtJSCookMenuItem_Title));
         oWriter.WriteElement("Url", StringUtil.RTrim( gxTv_SdtJSCookMenuItem_Url));
         oWriter.WriteElement("Target", StringUtil.RTrim( gxTv_SdtJSCookMenuItem_Target));
         oWriter.WriteElement("Description", StringUtil.RTrim( gxTv_SdtJSCookMenuItem_Description));
         if ( gxTv_SdtJSCookMenuItem_Childs != null )
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
            gxTv_SdtJSCookMenuItem_Childs.writexmlcollection(oWriter, "Childs", sNameSpace1, "Item", sNameSpace1);
         }
         oWriter.WriteEndElement();
         return  ;
      }

      public override void ToJSON( )
      {
         AddObjectProperty("Icon", (Object)(gxTv_SdtJSCookMenuItem_Icon));
         AddObjectProperty("Title", (Object)(gxTv_SdtJSCookMenuItem_Title));
         AddObjectProperty("Url", (Object)(gxTv_SdtJSCookMenuItem_Url));
         AddObjectProperty("Target", (Object)(gxTv_SdtJSCookMenuItem_Target));
         AddObjectProperty("Description", (Object)(gxTv_SdtJSCookMenuItem_Description));
         if ( gxTv_SdtJSCookMenuItem_Childs != null )
         {
            AddObjectProperty("Childs", (Object)(gxTv_SdtJSCookMenuItem_Childs));
         }
         return  ;
      }

      public String gxTpr_Icon
      {
         get {
            return gxTv_SdtJSCookMenuItem_Icon ;
         }

         set {
            gxTv_SdtJSCookMenuItem_Icon = (String)(value) ;
         }

      }

      public void gxTv_SdtJSCookMenuItem_Icon_SetNull( )
      {
         gxTv_SdtJSCookMenuItem_Icon = "" ;
         return  ;
      }

      public bool gxTv_SdtJSCookMenuItem_Icon_IsNull( )
      {
         return false ;
      }

      public String gxTpr_Title
      {
         get {
            return gxTv_SdtJSCookMenuItem_Title ;
         }

         set {
            gxTv_SdtJSCookMenuItem_Title = (String)(value) ;
         }

      }

      public void gxTv_SdtJSCookMenuItem_Title_SetNull( )
      {
         gxTv_SdtJSCookMenuItem_Title = "" ;
         return  ;
      }

      public bool gxTv_SdtJSCookMenuItem_Title_IsNull( )
      {
         return false ;
      }

      public String gxTpr_Url
      {
         get {
            return gxTv_SdtJSCookMenuItem_Url ;
         }

         set {
            gxTv_SdtJSCookMenuItem_Url = (String)(value) ;
         }

      }

      public void gxTv_SdtJSCookMenuItem_Url_SetNull( )
      {
         gxTv_SdtJSCookMenuItem_Url = "" ;
         return  ;
      }

      public bool gxTv_SdtJSCookMenuItem_Url_IsNull( )
      {
         return false ;
      }

      public String gxTpr_Target
      {
         get {
            return gxTv_SdtJSCookMenuItem_Target ;
         }

         set {
            gxTv_SdtJSCookMenuItem_Target = (String)(value) ;
         }

      }

      public void gxTv_SdtJSCookMenuItem_Target_SetNull( )
      {
         gxTv_SdtJSCookMenuItem_Target = "" ;
         return  ;
      }

      public bool gxTv_SdtJSCookMenuItem_Target_IsNull( )
      {
         return false ;
      }

      public String gxTpr_Description
      {
         get {
            return gxTv_SdtJSCookMenuItem_Description ;
         }

         set {
            gxTv_SdtJSCookMenuItem_Description = (String)(value) ;
         }

      }

      public void gxTv_SdtJSCookMenuItem_Description_SetNull( )
      {
         gxTv_SdtJSCookMenuItem_Description = "" ;
         return  ;
      }

      public bool gxTv_SdtJSCookMenuItem_Description_IsNull( )
      {
         return false ;
      }

      public IGxCollection gxTpr_Childs
      {
         get {
            if ( gxTv_SdtJSCookMenuItem_Childs == null )
            {
               gxTv_SdtJSCookMenuItem_Childs = new GxObjectCollection( context, "JSCookMenuItem", "MarianoTesis", "SdtJSCookMenuItem", "GeneXus.Programs");
            }
            return gxTv_SdtJSCookMenuItem_Childs ;
         }

         set {
            gxTv_SdtJSCookMenuItem_Childs = value ;
         }

      }

      public void gxTv_SdtJSCookMenuItem_Childs_SetNull( )
      {
         gxTv_SdtJSCookMenuItem_Childs = null ;
         return  ;
      }

      public bool gxTv_SdtJSCookMenuItem_Childs_IsNull( )
      {
         if ( gxTv_SdtJSCookMenuItem_Childs == null )
         {
            return true ;
         }
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtJSCookMenuItem_Icon = "" ;
         gxTv_SdtJSCookMenuItem_Title = "" ;
         gxTv_SdtJSCookMenuItem_Url = "" ;
         gxTv_SdtJSCookMenuItem_Target = "" ;
         gxTv_SdtJSCookMenuItem_Description = "" ;
         sTagName = "" ;
         return  ;
      }

      protected short readOk ;
      protected short nOutParmCount ;
      protected String gxTv_SdtJSCookMenuItem_Icon ;
      protected String gxTv_SdtJSCookMenuItem_Title ;
      protected String gxTv_SdtJSCookMenuItem_Url ;
      protected String gxTv_SdtJSCookMenuItem_Target ;
      protected String gxTv_SdtJSCookMenuItem_Description ;
      protected String sTagName ;
      protected Assembly constructorCallingAssembly ;
      protected IGxContext context ;
      [ObjectCollection(ItemType=typeof( SdtJSCookMenuItem ))]
      protected IGxCollection gxTv_SdtJSCookMenuItem_Childs=null ;
   }

}
