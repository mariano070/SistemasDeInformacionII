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
   public class SdtSDT_Posiciones : GxUserType
   {
      public SdtSDT_Posiciones( )
      {
         constructorCallingAssembly = Assembly.GetCallingAssembly() ;
         initialize();
      }

      public SdtSDT_Posiciones( IGxContext context )
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
               if ( StringUtil.StrCmp(oReader.LocalName, "W53POS") == 0 )
               {
                  gxTv_SdtSDT_Posiciones_W53pos = (short)(NumberUtil.Val( oReader.Value, ".")) ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp(oReader.LocalName, "W53DES") == 0 )
               {
                  gxTv_SdtSDT_Posiciones_W53des = oReader.Value ;
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
            sName = "SDT_Posiciones" ;
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
         oWriter.WriteElement("W53POS", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_SdtSDT_Posiciones_W53pos), 3, 0)));
         oWriter.WriteElement("W53DES", StringUtil.RTrim( gxTv_SdtSDT_Posiciones_W53des));
         oWriter.WriteEndElement();
         return  ;
      }

      public override void ToJSON( )
      {
         AddObjectProperty("W53POS", (Object)(gxTv_SdtSDT_Posiciones_W53pos));
         AddObjectProperty("W53DES", (Object)(gxTv_SdtSDT_Posiciones_W53des));
         return  ;
      }

      public short gxTpr_W53pos
      {
         get {
            return gxTv_SdtSDT_Posiciones_W53pos ;
         }

         set {
            gxTv_SdtSDT_Posiciones_W53pos = (short)(value) ;
         }

      }

      public void gxTv_SdtSDT_Posiciones_W53pos_SetNull( )
      {
         gxTv_SdtSDT_Posiciones_W53pos = 0 ;
         return  ;
      }

      public bool gxTv_SdtSDT_Posiciones_W53pos_IsNull( )
      {
         return false ;
      }

      public String gxTpr_W53des
      {
         get {
            return gxTv_SdtSDT_Posiciones_W53des ;
         }

         set {
            gxTv_SdtSDT_Posiciones_W53des = (String)(value) ;
         }

      }

      public void gxTv_SdtSDT_Posiciones_W53des_SetNull( )
      {
         gxTv_SdtSDT_Posiciones_W53des = "" ;
         return  ;
      }

      public bool gxTv_SdtSDT_Posiciones_W53des_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtSDT_Posiciones_W53des = "" ;
         sTagName = "" ;
         return  ;
      }

      protected short gxTv_SdtSDT_Posiciones_W53pos ;
      protected short readOk ;
      protected short nOutParmCount ;
      protected String gxTv_SdtSDT_Posiciones_W53des ;
      protected String sTagName ;
      protected Assembly constructorCallingAssembly ;
      protected IGxContext context ;
   }

}
