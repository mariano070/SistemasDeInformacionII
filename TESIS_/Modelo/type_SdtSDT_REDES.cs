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
   public class SdtSDT_REDES : GxUserType
   {
      public SdtSDT_REDES( )
      {
         constructorCallingAssembly = Assembly.GetCallingAssembly() ;
         initialize();
      }

      public SdtSDT_REDES( IGxContext context )
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
               if ( StringUtil.StrCmp(oReader.LocalName, "Red_DireccionDesdeB1") == 0 )
               {
                  gxTv_SdtSDT_REDES_Red_direcciondesdeb1 = (short)(NumberUtil.Val( oReader.Value, ".")) ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp(oReader.LocalName, "Red_DireccionDesdeB2") == 0 )
               {
                  gxTv_SdtSDT_REDES_Red_direcciondesdeb2 = (short)(NumberUtil.Val( oReader.Value, ".")) ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp(oReader.LocalName, "Red_DireccionDesdeB3") == 0 )
               {
                  gxTv_SdtSDT_REDES_Red_direcciondesdeb3 = (short)(NumberUtil.Val( oReader.Value, ".")) ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp(oReader.LocalName, "Red_DireccionDesdeB4") == 0 )
               {
                  gxTv_SdtSDT_REDES_Red_direcciondesdeb4 = (short)(NumberUtil.Val( oReader.Value, ".")) ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp(oReader.LocalName, "Red_DireccionHastaB1") == 0 )
               {
                  gxTv_SdtSDT_REDES_Red_direccionhastab1 = (short)(NumberUtil.Val( oReader.Value, ".")) ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp(oReader.LocalName, "Red_DireccionHastaB2") == 0 )
               {
                  gxTv_SdtSDT_REDES_Red_direccionhastab2 = (short)(NumberUtil.Val( oReader.Value, ".")) ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp(oReader.LocalName, "Red_DireccionHastaB3") == 0 )
               {
                  gxTv_SdtSDT_REDES_Red_direccionhastab3 = (short)(NumberUtil.Val( oReader.Value, ".")) ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp(oReader.LocalName, "Red_DireccionHastaB4") == 0 )
               {
                  gxTv_SdtSDT_REDES_Red_direccionhastab4 = (short)(NumberUtil.Val( oReader.Value, ".")) ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp(oReader.LocalName, "Red_MascaraB1") == 0 )
               {
                  gxTv_SdtSDT_REDES_Red_mascarab1 = (short)(NumberUtil.Val( oReader.Value, ".")) ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp(oReader.LocalName, "Red_MascaraB2") == 0 )
               {
                  gxTv_SdtSDT_REDES_Red_mascarab2 = (short)(NumberUtil.Val( oReader.Value, ".")) ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp(oReader.LocalName, "Red_MascaraB3") == 0 )
               {
                  gxTv_SdtSDT_REDES_Red_mascarab3 = (short)(NumberUtil.Val( oReader.Value, ".")) ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp(oReader.LocalName, "Red_MascaraB4") == 0 )
               {
                  gxTv_SdtSDT_REDES_Red_mascarab4 = (short)(NumberUtil.Val( oReader.Value, ".")) ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp(oReader.LocalName, "Red_PuertaEnlaceB1") == 0 )
               {
                  gxTv_SdtSDT_REDES_Red_puertaenlaceb1 = (short)(NumberUtil.Val( oReader.Value, ".")) ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp(oReader.LocalName, "Red_PuertaEnlaceB2") == 0 )
               {
                  gxTv_SdtSDT_REDES_Red_puertaenlaceb2 = (short)(NumberUtil.Val( oReader.Value, ".")) ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp(oReader.LocalName, "Red_PuertaEnlaceB3") == 0 )
               {
                  gxTv_SdtSDT_REDES_Red_puertaenlaceb3 = (short)(NumberUtil.Val( oReader.Value, ".")) ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp(oReader.LocalName, "Red_PuertaEnlaceB4") == 0 )
               {
                  gxTv_SdtSDT_REDES_Red_puertaenlaceb4 = (short)(NumberUtil.Val( oReader.Value, ".")) ;
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
            sName = "SDT_REDES" ;
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
         oWriter.WriteElement("Red_DireccionDesdeB1", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_SdtSDT_REDES_Red_direcciondesdeb1), 3, 0)));
         oWriter.WriteElement("Red_DireccionDesdeB2", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_SdtSDT_REDES_Red_direcciondesdeb2), 3, 0)));
         oWriter.WriteElement("Red_DireccionDesdeB3", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_SdtSDT_REDES_Red_direcciondesdeb3), 3, 0)));
         oWriter.WriteElement("Red_DireccionDesdeB4", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_SdtSDT_REDES_Red_direcciondesdeb4), 3, 0)));
         oWriter.WriteElement("Red_DireccionHastaB1", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_SdtSDT_REDES_Red_direccionhastab1), 3, 0)));
         oWriter.WriteElement("Red_DireccionHastaB2", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_SdtSDT_REDES_Red_direccionhastab2), 3, 0)));
         oWriter.WriteElement("Red_DireccionHastaB3", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_SdtSDT_REDES_Red_direccionhastab3), 3, 0)));
         oWriter.WriteElement("Red_DireccionHastaB4", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_SdtSDT_REDES_Red_direccionhastab4), 3, 0)));
         oWriter.WriteElement("Red_MascaraB1", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_SdtSDT_REDES_Red_mascarab1), 3, 0)));
         oWriter.WriteElement("Red_MascaraB2", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_SdtSDT_REDES_Red_mascarab2), 3, 0)));
         oWriter.WriteElement("Red_MascaraB3", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_SdtSDT_REDES_Red_mascarab3), 3, 0)));
         oWriter.WriteElement("Red_MascaraB4", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_SdtSDT_REDES_Red_mascarab4), 3, 0)));
         oWriter.WriteElement("Red_PuertaEnlaceB1", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_SdtSDT_REDES_Red_puertaenlaceb1), 3, 0)));
         oWriter.WriteElement("Red_PuertaEnlaceB2", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_SdtSDT_REDES_Red_puertaenlaceb2), 3, 0)));
         oWriter.WriteElement("Red_PuertaEnlaceB3", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_SdtSDT_REDES_Red_puertaenlaceb3), 3, 0)));
         oWriter.WriteElement("Red_PuertaEnlaceB4", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_SdtSDT_REDES_Red_puertaenlaceb4), 3, 0)));
         oWriter.WriteEndElement();
         return  ;
      }

      public override void ToJSON( )
      {
         AddObjectProperty("Red_DireccionDesdeB1", (Object)(gxTv_SdtSDT_REDES_Red_direcciondesdeb1));
         AddObjectProperty("Red_DireccionDesdeB2", (Object)(gxTv_SdtSDT_REDES_Red_direcciondesdeb2));
         AddObjectProperty("Red_DireccionDesdeB3", (Object)(gxTv_SdtSDT_REDES_Red_direcciondesdeb3));
         AddObjectProperty("Red_DireccionDesdeB4", (Object)(gxTv_SdtSDT_REDES_Red_direcciondesdeb4));
         AddObjectProperty("Red_DireccionHastaB1", (Object)(gxTv_SdtSDT_REDES_Red_direccionhastab1));
         AddObjectProperty("Red_DireccionHastaB2", (Object)(gxTv_SdtSDT_REDES_Red_direccionhastab2));
         AddObjectProperty("Red_DireccionHastaB3", (Object)(gxTv_SdtSDT_REDES_Red_direccionhastab3));
         AddObjectProperty("Red_DireccionHastaB4", (Object)(gxTv_SdtSDT_REDES_Red_direccionhastab4));
         AddObjectProperty("Red_MascaraB1", (Object)(gxTv_SdtSDT_REDES_Red_mascarab1));
         AddObjectProperty("Red_MascaraB2", (Object)(gxTv_SdtSDT_REDES_Red_mascarab2));
         AddObjectProperty("Red_MascaraB3", (Object)(gxTv_SdtSDT_REDES_Red_mascarab3));
         AddObjectProperty("Red_MascaraB4", (Object)(gxTv_SdtSDT_REDES_Red_mascarab4));
         AddObjectProperty("Red_PuertaEnlaceB1", (Object)(gxTv_SdtSDT_REDES_Red_puertaenlaceb1));
         AddObjectProperty("Red_PuertaEnlaceB2", (Object)(gxTv_SdtSDT_REDES_Red_puertaenlaceb2));
         AddObjectProperty("Red_PuertaEnlaceB3", (Object)(gxTv_SdtSDT_REDES_Red_puertaenlaceb3));
         AddObjectProperty("Red_PuertaEnlaceB4", (Object)(gxTv_SdtSDT_REDES_Red_puertaenlaceb4));
         return  ;
      }

      public short gxTpr_Red_direcciondesdeb1
      {
         get {
            return gxTv_SdtSDT_REDES_Red_direcciondesdeb1 ;
         }

         set {
            gxTv_SdtSDT_REDES_Red_direcciondesdeb1 = (short)(value) ;
         }

      }

      public void gxTv_SdtSDT_REDES_Red_direcciondesdeb1_SetNull( )
      {
         gxTv_SdtSDT_REDES_Red_direcciondesdeb1 = 0 ;
         return  ;
      }

      public bool gxTv_SdtSDT_REDES_Red_direcciondesdeb1_IsNull( )
      {
         return false ;
      }

      public short gxTpr_Red_direcciondesdeb2
      {
         get {
            return gxTv_SdtSDT_REDES_Red_direcciondesdeb2 ;
         }

         set {
            gxTv_SdtSDT_REDES_Red_direcciondesdeb2 = (short)(value) ;
         }

      }

      public void gxTv_SdtSDT_REDES_Red_direcciondesdeb2_SetNull( )
      {
         gxTv_SdtSDT_REDES_Red_direcciondesdeb2 = 0 ;
         return  ;
      }

      public bool gxTv_SdtSDT_REDES_Red_direcciondesdeb2_IsNull( )
      {
         return false ;
      }

      public short gxTpr_Red_direcciondesdeb3
      {
         get {
            return gxTv_SdtSDT_REDES_Red_direcciondesdeb3 ;
         }

         set {
            gxTv_SdtSDT_REDES_Red_direcciondesdeb3 = (short)(value) ;
         }

      }

      public void gxTv_SdtSDT_REDES_Red_direcciondesdeb3_SetNull( )
      {
         gxTv_SdtSDT_REDES_Red_direcciondesdeb3 = 0 ;
         return  ;
      }

      public bool gxTv_SdtSDT_REDES_Red_direcciondesdeb3_IsNull( )
      {
         return false ;
      }

      public short gxTpr_Red_direcciondesdeb4
      {
         get {
            return gxTv_SdtSDT_REDES_Red_direcciondesdeb4 ;
         }

         set {
            gxTv_SdtSDT_REDES_Red_direcciondesdeb4 = (short)(value) ;
         }

      }

      public void gxTv_SdtSDT_REDES_Red_direcciondesdeb4_SetNull( )
      {
         gxTv_SdtSDT_REDES_Red_direcciondesdeb4 = 0 ;
         return  ;
      }

      public bool gxTv_SdtSDT_REDES_Red_direcciondesdeb4_IsNull( )
      {
         return false ;
      }

      public short gxTpr_Red_direccionhastab1
      {
         get {
            return gxTv_SdtSDT_REDES_Red_direccionhastab1 ;
         }

         set {
            gxTv_SdtSDT_REDES_Red_direccionhastab1 = (short)(value) ;
         }

      }

      public void gxTv_SdtSDT_REDES_Red_direccionhastab1_SetNull( )
      {
         gxTv_SdtSDT_REDES_Red_direccionhastab1 = 0 ;
         return  ;
      }

      public bool gxTv_SdtSDT_REDES_Red_direccionhastab1_IsNull( )
      {
         return false ;
      }

      public short gxTpr_Red_direccionhastab2
      {
         get {
            return gxTv_SdtSDT_REDES_Red_direccionhastab2 ;
         }

         set {
            gxTv_SdtSDT_REDES_Red_direccionhastab2 = (short)(value) ;
         }

      }

      public void gxTv_SdtSDT_REDES_Red_direccionhastab2_SetNull( )
      {
         gxTv_SdtSDT_REDES_Red_direccionhastab2 = 0 ;
         return  ;
      }

      public bool gxTv_SdtSDT_REDES_Red_direccionhastab2_IsNull( )
      {
         return false ;
      }

      public short gxTpr_Red_direccionhastab3
      {
         get {
            return gxTv_SdtSDT_REDES_Red_direccionhastab3 ;
         }

         set {
            gxTv_SdtSDT_REDES_Red_direccionhastab3 = (short)(value) ;
         }

      }

      public void gxTv_SdtSDT_REDES_Red_direccionhastab3_SetNull( )
      {
         gxTv_SdtSDT_REDES_Red_direccionhastab3 = 0 ;
         return  ;
      }

      public bool gxTv_SdtSDT_REDES_Red_direccionhastab3_IsNull( )
      {
         return false ;
      }

      public short gxTpr_Red_direccionhastab4
      {
         get {
            return gxTv_SdtSDT_REDES_Red_direccionhastab4 ;
         }

         set {
            gxTv_SdtSDT_REDES_Red_direccionhastab4 = (short)(value) ;
         }

      }

      public void gxTv_SdtSDT_REDES_Red_direccionhastab4_SetNull( )
      {
         gxTv_SdtSDT_REDES_Red_direccionhastab4 = 0 ;
         return  ;
      }

      public bool gxTv_SdtSDT_REDES_Red_direccionhastab4_IsNull( )
      {
         return false ;
      }

      public short gxTpr_Red_mascarab1
      {
         get {
            return gxTv_SdtSDT_REDES_Red_mascarab1 ;
         }

         set {
            gxTv_SdtSDT_REDES_Red_mascarab1 = (short)(value) ;
         }

      }

      public void gxTv_SdtSDT_REDES_Red_mascarab1_SetNull( )
      {
         gxTv_SdtSDT_REDES_Red_mascarab1 = 0 ;
         return  ;
      }

      public bool gxTv_SdtSDT_REDES_Red_mascarab1_IsNull( )
      {
         return false ;
      }

      public short gxTpr_Red_mascarab2
      {
         get {
            return gxTv_SdtSDT_REDES_Red_mascarab2 ;
         }

         set {
            gxTv_SdtSDT_REDES_Red_mascarab2 = (short)(value) ;
         }

      }

      public void gxTv_SdtSDT_REDES_Red_mascarab2_SetNull( )
      {
         gxTv_SdtSDT_REDES_Red_mascarab2 = 0 ;
         return  ;
      }

      public bool gxTv_SdtSDT_REDES_Red_mascarab2_IsNull( )
      {
         return false ;
      }

      public short gxTpr_Red_mascarab3
      {
         get {
            return gxTv_SdtSDT_REDES_Red_mascarab3 ;
         }

         set {
            gxTv_SdtSDT_REDES_Red_mascarab3 = (short)(value) ;
         }

      }

      public void gxTv_SdtSDT_REDES_Red_mascarab3_SetNull( )
      {
         gxTv_SdtSDT_REDES_Red_mascarab3 = 0 ;
         return  ;
      }

      public bool gxTv_SdtSDT_REDES_Red_mascarab3_IsNull( )
      {
         return false ;
      }

      public short gxTpr_Red_mascarab4
      {
         get {
            return gxTv_SdtSDT_REDES_Red_mascarab4 ;
         }

         set {
            gxTv_SdtSDT_REDES_Red_mascarab4 = (short)(value) ;
         }

      }

      public void gxTv_SdtSDT_REDES_Red_mascarab4_SetNull( )
      {
         gxTv_SdtSDT_REDES_Red_mascarab4 = 0 ;
         return  ;
      }

      public bool gxTv_SdtSDT_REDES_Red_mascarab4_IsNull( )
      {
         return false ;
      }

      public short gxTpr_Red_puertaenlaceb1
      {
         get {
            return gxTv_SdtSDT_REDES_Red_puertaenlaceb1 ;
         }

         set {
            gxTv_SdtSDT_REDES_Red_puertaenlaceb1 = (short)(value) ;
         }

      }

      public void gxTv_SdtSDT_REDES_Red_puertaenlaceb1_SetNull( )
      {
         gxTv_SdtSDT_REDES_Red_puertaenlaceb1 = 0 ;
         return  ;
      }

      public bool gxTv_SdtSDT_REDES_Red_puertaenlaceb1_IsNull( )
      {
         return false ;
      }

      public short gxTpr_Red_puertaenlaceb2
      {
         get {
            return gxTv_SdtSDT_REDES_Red_puertaenlaceb2 ;
         }

         set {
            gxTv_SdtSDT_REDES_Red_puertaenlaceb2 = (short)(value) ;
         }

      }

      public void gxTv_SdtSDT_REDES_Red_puertaenlaceb2_SetNull( )
      {
         gxTv_SdtSDT_REDES_Red_puertaenlaceb2 = 0 ;
         return  ;
      }

      public bool gxTv_SdtSDT_REDES_Red_puertaenlaceb2_IsNull( )
      {
         return false ;
      }

      public short gxTpr_Red_puertaenlaceb3
      {
         get {
            return gxTv_SdtSDT_REDES_Red_puertaenlaceb3 ;
         }

         set {
            gxTv_SdtSDT_REDES_Red_puertaenlaceb3 = (short)(value) ;
         }

      }

      public void gxTv_SdtSDT_REDES_Red_puertaenlaceb3_SetNull( )
      {
         gxTv_SdtSDT_REDES_Red_puertaenlaceb3 = 0 ;
         return  ;
      }

      public bool gxTv_SdtSDT_REDES_Red_puertaenlaceb3_IsNull( )
      {
         return false ;
      }

      public short gxTpr_Red_puertaenlaceb4
      {
         get {
            return gxTv_SdtSDT_REDES_Red_puertaenlaceb4 ;
         }

         set {
            gxTv_SdtSDT_REDES_Red_puertaenlaceb4 = (short)(value) ;
         }

      }

      public void gxTv_SdtSDT_REDES_Red_puertaenlaceb4_SetNull( )
      {
         gxTv_SdtSDT_REDES_Red_puertaenlaceb4 = 0 ;
         return  ;
      }

      public bool gxTv_SdtSDT_REDES_Red_puertaenlaceb4_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         sTagName = "" ;
         return  ;
      }

      protected short gxTv_SdtSDT_REDES_Red_direcciondesdeb1 ;
      protected short gxTv_SdtSDT_REDES_Red_direcciondesdeb2 ;
      protected short gxTv_SdtSDT_REDES_Red_direcciondesdeb3 ;
      protected short gxTv_SdtSDT_REDES_Red_direcciondesdeb4 ;
      protected short gxTv_SdtSDT_REDES_Red_direccionhastab1 ;
      protected short gxTv_SdtSDT_REDES_Red_direccionhastab2 ;
      protected short gxTv_SdtSDT_REDES_Red_direccionhastab3 ;
      protected short gxTv_SdtSDT_REDES_Red_direccionhastab4 ;
      protected short gxTv_SdtSDT_REDES_Red_mascarab1 ;
      protected short gxTv_SdtSDT_REDES_Red_mascarab2 ;
      protected short gxTv_SdtSDT_REDES_Red_mascarab3 ;
      protected short gxTv_SdtSDT_REDES_Red_mascarab4 ;
      protected short gxTv_SdtSDT_REDES_Red_puertaenlaceb1 ;
      protected short gxTv_SdtSDT_REDES_Red_puertaenlaceb2 ;
      protected short gxTv_SdtSDT_REDES_Red_puertaenlaceb3 ;
      protected short gxTv_SdtSDT_REDES_Red_puertaenlaceb4 ;
      protected short readOk ;
      protected short nOutParmCount ;
      protected String sTagName ;
      protected Assembly constructorCallingAssembly ;
      protected IGxContext context ;
   }

}
