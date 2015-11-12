/*
               File: HTBUS003_
        Description: Visualización de envíos realizados
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 4/2/2014 19:29:12.56
       Program type: Callable routine
          Main DBMS: sqlserver
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using System.Data;
using System.Data.SqlClient;
using GeneXus.Data;
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class htbus003_ : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public htbus003_( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public htbus003_( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_USUARIO ,
                           ref String aP1_SISTEMA )
      {
         this.AV25USUARIO = aP0_USUARIO;
         this.AV21SISTEMA = aP1_SISTEMA;
         executePrivate();
         aP0_USUARIO=this.AV25USUARIO;
         aP1_SISTEMA=this.AV21SISTEMA;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      public override void SetPrefix( String sPPrefix )
      {
         sPrefix = sPPrefix;
      }

      protected override void createObjects( )
      {
         chkavSeleccion = new GXCheckbox();
         cmbavGttbus2_estadoenvio = new GXCombobox();
      }

      protected void INITWEB( )
      {
         initialize_properties( ) ;
         if ( StringUtil.Len( (String)(sPrefix)) == 0 )
         {
            if ( nGotPars == 0 )
            {
               entryPointCalled = false ;
               gxfirstwebparm = GetNextPar( ) ;
               gxfirstwebparm_bkp = gxfirstwebparm ;
               gxfirstwebparm = DecryptAjaxCall( gxfirstwebparm, "High") ;
               if ( StringUtil.StrCmp(gxfirstwebparm, "dyncall") == 0 )
               {
                  setAjaxCallMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1 ;
                     return  ;
                  }
                  dyncall( GetNextPar( )) ;
                  return  ;
               }
               else if ( StringUtil.StrCmp(gxfirstwebparm, "dyncomponent") == 0 )
               {
                  setAjaxEventMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1 ;
                     return  ;
                  }
                  nDynComponent = 1 ;
                  sCompPrefix = GetNextPar( ) ;
                  sSFPrefix = GetNextPar( ) ;
                  AV25USUARIO = GetNextPar( ) ;
                  AV21SISTEMA = GetNextPar( ) ;
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(String)AV25USUARIO,(String)AV21SISTEMA});
                  componentstart();
                  context.httpAjaxContext.ajax_rspStartCmp(sPrefix);
                  componentdraw();
                  context.httpAjaxContext.ajax_rspEndCmp();
                  return  ;
               }
               else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxSuggest"+"_"+"vGTTBUS2_MOTIVOENVIO") == 0 )
               {
                  A47TTBUS2_MotivoEnvio = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A47TTBUS2_MotivoEnvio", A47TTBUS2_MotivoEnvio);
                  setAjaxCallMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1 ;
                     return  ;
                  }
                  GXSGVvGTTBUS2_MOTIVOENVIO1O0( A47TTBUS2_MotivoEnvio) ;
                  return  ;
               }
               else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxEvt") == 0 )
               {
                  setAjaxEventMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1 ;
                     return  ;
                  }
                  gxfirstwebparm = GetNextPar( ) ;
               }
               else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Grid1") == 0 )
               {
                  nRC_Grid1 = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  nGXsfl_8_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  sGXsfl_8_idx = GetNextPar( ) ;
                  sPrefix = GetNextPar( ) ;
                  setAjaxCallMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1 ;
                     return  ;
                  }
                  gxnrGrid1_newrow( nRC_Grid1, nGXsfl_8_idx, sGXsfl_8_idx, sPrefix) ;
                  return  ;
               }
               else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid1") == 0 )
               {
                  /* GeneXus formulas. */
                  context.Gx_err = 0 ;
                  edtavGttbus2_idmovimiento_Enabled = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavGttbus2_idmovimiento_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGttbus2_idmovimiento_Enabled), 5, 0)));
                  edtavGnumeroidentificador_Enabled = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavGnumeroidentificador_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGnumeroidentificador_Enabled), 5, 0)));
                  edtavGttbus2_idbien_Enabled = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavGttbus2_idbien_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGttbus2_idbien_Enabled), 5, 0)));
                  edtavGttbus2_codposhacia_Enabled = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavGttbus2_codposhacia_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGttbus2_codposhacia_Enabled), 5, 0)));
                  edtavHttbus3_des_Enabled = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavHttbus3_des_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavHttbus3_des_Enabled), 5, 0)));
                  edtavGttbus2_resphacia_Enabled = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavGttbus2_resphacia_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGttbus2_resphacia_Enabled), 5, 0)));
                  edtavHusu_des_Enabled = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavHusu_des_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavHusu_des_Enabled), 5, 0)));
                  edtavGttbus2_fechaenvio_Enabled = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavGttbus2_fechaenvio_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGttbus2_fechaenvio_Enabled), 5, 0)));
                  edtavGttbus2_motivoenvio_Enabled = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavGttbus2_motivoenvio_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGttbus2_motivoenvio_Enabled), 5, 0)));
                  cmbavGttbus2_estadoenvio.Enabled = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbavGttbus2_estadoenvio_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavGttbus2_estadoenvio.Enabled), 5, 0)));
                  GXCCtl = "vSELECCION_" + sGXsfl_8_idx ;
                  chkavSeleccion.Name = GXCCtl ;
                  chkavSeleccion.WebTags = "" ;
                  chkavSeleccion.Caption = "" ;
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, chkavSeleccion_Internalname, "Caption", chkavSeleccion.Caption);
                  chkavSeleccion.CheckedValue = "0" ;
                  GXCCtl = "vGTTBUS2_ESTADOENVIO_" + sGXsfl_8_idx ;
                  cmbavGttbus2_estadoenvio.Name = GXCCtl ;
                  cmbavGttbus2_estadoenvio.WebTags = "" ;
                  cmbavGttbus2_estadoenvio.addItem("1", "No Finalizado", 0);
                  cmbavGttbus2_estadoenvio.addItem("2", "Finalizado", 0);
                  cmbavGttbus2_estadoenvio.addItem("3", "Cancelado", 0);
                  if ( ( cmbavGttbus2_estadoenvio.ItemCount > 0 ) && (0==AV11gTTBUS2_EstadoEnvio) )
                  {
                     AV11gTTBUS2_EstadoEnvio = (short)(NumberUtil.Val( cmbavGttbus2_estadoenvio.getItemValue(1), ".")) ;
                     context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV11gTTBUS2_EstadoEnvio", StringUtil.Str( (decimal)(AV11gTTBUS2_EstadoEnvio), 1, 0));
                  }
                  A102TTBUS2_TipoResp = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A102TTBUS2_TipoResp", A102TTBUS2_TipoResp);
                  A53TTBUS2_IdUsuario = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A53TTBUS2_IdUsuario", A53TTBUS2_IdUsuario);
                  A26TTBUS2_EstadoEnvio = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A26TTBUS2_EstadoEnvio", StringUtil.Str( (decimal)(A26TTBUS2_EstadoEnvio), 1, 0));
                  A47TTBUS2_MotivoEnvio = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A47TTBUS2_MotivoEnvio", A47TTBUS2_MotivoEnvio);
                  A45TTBUS2_FechaEnvio = context.localUtil.ParseDTimeParm( GetNextPar( )) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A45TTBUS2_FechaEnvio", context.localUtil.TToC( A45TTBUS2_FechaEnvio, 10, 5, 0, 3, "/", ":", " "));
                  A7USU_DES = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A7USU_DES", A7USU_DES);
                  A6USU_COD = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A6USU_COD", A6USU_COD);
                  A25TTBUS2_RespHacia = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A25TTBUS2_RespHacia", A25TTBUS2_RespHacia);
                  A34TTBUS7_Des = GetNextPar( ) ;
                  n34TTBUS7_Des = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A34TTBUS7_Des", A34TTBUS7_Des);
                  A33TTBUS7_Pos = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
                  A49TTBUS2_CodPosHacia = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A49TTBUS2_CodPosHacia", StringUtil.LTrim( StringUtil.Str( (decimal)(A49TTBUS2_CodPosHacia), 3, 0)));
                  A22TTBUS2_IdBien = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A22TTBUS2_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A22TTBUS2_IdBien), 8, 0)));
                  A52TTBUS2_IdMovimiento = (long)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A52TTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(A52TTBUS2_IdMovimiento), 12, 0)));
                  sPrefix = GetNextPar( ) ;
                  setAjaxCallMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1 ;
                     return  ;
                  }
                  gxgrGrid1_refresh( A102TTBUS2_TipoResp, A53TTBUS2_IdUsuario, A26TTBUS2_EstadoEnvio, A47TTBUS2_MotivoEnvio, A45TTBUS2_FechaEnvio, A7USU_DES, A6USU_COD, A25TTBUS2_RespHacia, A34TTBUS7_Des, A33TTBUS7_Pos, A49TTBUS2_CodPosHacia, A22TTBUS2_IdBien, A52TTBUS2_IdMovimiento, sPrefix) ;
                  return  ;
               }
               else
               {
                  if ( ! IsValidAjaxCall( false) )
                  {
                     GxWebError = 1 ;
                     return  ;
                  }
                  gxfirstwebparm = gxfirstwebparm_bkp ;
               }
            }
         }
         context.SetTheme("Modern");
      }

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITWEB( ) ;
         if ( ! isAjaxCallMode( ) )
         {
            PA1O2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0 ;
               edtavGttbus2_idmovimiento_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavGttbus2_idmovimiento_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGttbus2_idmovimiento_Enabled), 5, 0)));
               edtavGnumeroidentificador_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavGnumeroidentificador_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGnumeroidentificador_Enabled), 5, 0)));
               edtavGttbus2_idbien_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavGttbus2_idbien_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGttbus2_idbien_Enabled), 5, 0)));
               edtavGttbus2_codposhacia_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavGttbus2_codposhacia_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGttbus2_codposhacia_Enabled), 5, 0)));
               edtavHttbus3_des_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavHttbus3_des_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavHttbus3_des_Enabled), 5, 0)));
               edtavGttbus2_resphacia_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavGttbus2_resphacia_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGttbus2_resphacia_Enabled), 5, 0)));
               edtavHusu_des_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavHusu_des_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavHusu_des_Enabled), 5, 0)));
               edtavGttbus2_fechaenvio_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavGttbus2_fechaenvio_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGttbus2_fechaenvio_Enabled), 5, 0)));
               edtavGttbus2_motivoenvio_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavGttbus2_motivoenvio_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGttbus2_motivoenvio_Enabled), 5, 0)));
               cmbavGttbus2_estadoenvio.Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbavGttbus2_estadoenvio_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavGttbus2_estadoenvio.Enabled), 5, 0)));
               WS1O2( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  if ( nDynComponent == 0 )
                  {
                     throw new System.Net.WebException("WebComponent is not allowed to run") ;
                  }
               }
            }
            if ( context.isAjaxRequest( ) )
            {
               enableOutput();
               if ( ! context.isAjaxRequest( ) )
               {
                  context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
               }
               if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) )
               {
                  context.GX_webresponse.AddString((String)(context.getJSONResponse( )));
               }
               else
               {
                  context.Redirect( context.wjLoc );
                  context.DispatchAjaxCommands();
               }
            }
         }
         this.cleanup();
      }

      protected void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, "IE=EmulateIE7");
      }

      protected void RenderHtmlOpenForm( )
      {
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            context.WriteHtmlText( "<title>") ;
            context.WriteHtmlText( "Visualización de envíos realizados") ;
            context.WriteHtmlTextNl( "</title>") ;
            if ( StringUtil.Len( sDynURL) > 0 )
            {
               context.WriteHtmlText( "<BASE href=\""+sDynURL+"\" />") ;
            }
            define_styles( ) ;
         }
         if ( ! context.isSmartDevice( ) )
         {
            context.AddJavascriptSource("gxgral.js", "?42940");
            context.AddJavascriptSource("gxcfg.js", "?42940");
         }
         else
         {
            context.AddJavascriptSource("gxapiSD.js", "?42940");
            context.AddJavascriptSource("gxfxSD.js", "?42940");
            context.AddJavascriptSource("gxtypesSD.js", "?42940");
            context.AddJavascriptSource("gxpopupSD.js", "?42940");
            context.AddJavascriptSource("gxfrmutlSD.js", "?42940");
            context.AddJavascriptSource("gxgridSD.js", "?42940");
            context.AddJavascriptSource("JavaScripTableSD.js", "?42940");
            context.AddJavascriptSource("rijndaelSD.js", "?42940");
            context.AddJavascriptSource("gxgralSD.js", "?42940");
         }
         context.AddJavascriptSource("calendar.js", "?42940");
         context.AddJavascriptSource("calendar-setup.js", "?42940");
         context.AddJavascriptSource("calendar-es.js", "?42940");
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            context.CloseHtmlHeader();
            FormProcess = ((nGXWrapped==0) ? " onkeyup=\"gx.evt.onkeyup(event)\" onkeypress=\"gx.evt.onkeypress(event,false,false)\" onkeydown=\"gx.evt.onkeypress(null,false,false)\"" : "") ;
            context.WriteHtmlText( "<body") ;
            context.WriteHtmlText( " "+"class=\"Form\""+" "+" style=\"-moz-opacity:0;opacity:0;"+"\""+FormProcess+">") ;
            context.skipLines(1);
            if ( nGXWrapped != 1 )
            {
               context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("htbus003_.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV25USUARIO)) + "," + UrlEncode(StringUtil.RTrim(AV21SISTEMA))+"\" class=\""+"Form"+"\">") ;
               GxWebStd.gx_hidden_field( context, "_EventName", "");
               GxWebStd.gx_hidden_field( context, "_EventGridId", "");
               GxWebStd.gx_hidden_field( context, "_EventRowId", "");
            }
         }
      }

      protected void RenderHtmlCloseForm1O2( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, sPrefix+"nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOAV25USUARIO", StringUtil.RTrim( wcpOAV25USUARIO));
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOAV21SISTEMA", StringUtil.RTrim( wcpOAV21SISTEMA));
         GxWebStd.gx_hidden_field( context, sPrefix+"vUSUARIO", StringUtil.RTrim( AV25USUARIO));
         GxWebStd.gx_hidden_field( context, sPrefix+"vSISTEMA", StringUtil.RTrim( AV21SISTEMA));
         GxWebStd.gx_hidden_field( context, sPrefix+"TTBUS2_TIPORESP", StringUtil.RTrim( A102TTBUS2_TipoResp));
         GxWebStd.gx_hidden_field( context, sPrefix+"TTBUS2_IDUSUARIO", StringUtil.RTrim( A53TTBUS2_IdUsuario));
         GxWebStd.gx_hidden_field( context, sPrefix+"TTBUS2_ESTADOENVIO", StringUtil.LTrim( StringUtil.NToC( (decimal)(A26TTBUS2_EstadoEnvio), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"TTBUS2_MOTIVOENVIO", StringUtil.RTrim( A47TTBUS2_MotivoEnvio));
         GxWebStd.gx_hidden_field( context, sPrefix+"TTBUS2_FECHAENVIO", context.localUtil.TToC( A45TTBUS2_FechaEnvio, 10, 8, 0, 3, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, sPrefix+"USU_DES", StringUtil.RTrim( A7USU_DES));
         GxWebStd.gx_hidden_field( context, sPrefix+"USU_COD", StringUtil.RTrim( A6USU_COD));
         GxWebStd.gx_hidden_field( context, sPrefix+"TTBUS2_RESPHACIA", StringUtil.RTrim( A25TTBUS2_RespHacia));
         GxWebStd.gx_hidden_field( context, sPrefix+"TTBUS7_DES", StringUtil.RTrim( A34TTBUS7_Des));
         GxWebStd.gx_hidden_field( context, sPrefix+"TTBUS7_POS", StringUtil.LTrim( StringUtil.NToC( (decimal)(A33TTBUS7_Pos), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"TTBUS2_CODPOSHACIA", StringUtil.LTrim( StringUtil.NToC( (decimal)(A49TTBUS2_CodPosHacia), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"TTBUS2_IDBIEN", StringUtil.LTrim( StringUtil.NToC( (decimal)(A22TTBUS2_IdBien), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"TTBUS2_IDMOVIMIENTO", StringUtil.LTrim( StringUtil.NToC( (decimal)(A52TTBUS2_IdMovimiento), 12, 0, ",", "")));
         if ( ( StringUtil.Len( sPrefix) != 0 ) && context.isAjaxRequest( ) )
         {
            context.AddJavascriptSource("htbus003_.js", "?19291265");
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"GX_FocusControl", GX_FocusControl);
         define_styles( ) ;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            SendAjaxEncryptionKey();
            SendComponentObjects();
            SendServerCommands();
            SendState();
            if ( nGXWrapped != 1 )
            {
               context.WriteHtmlTextNl( "</form>") ;
            }
            include_jscripts( ) ;
            context.WriteHtmlTextNl( "</body>") ;
            context.WriteHtmlTextNl( "</html>") ;
         }
      }

      protected void WB1O0( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               RenderHtmlHeaders( ) ;
            }
            RenderHtmlOpenForm( ) ;
            if ( StringUtil.Len( sPrefix) != 0 )
            {
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "htbus003_.aspx");
            }
            wb_table1_2_1O2( true) ;
         }
         else
         {
            wb_table1_2_1O2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_1O2e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START1O2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
            Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
            Form.Meta.addItem("Description", "Visualización de envíos realizados", 0) ;
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
            context.wbHandled = 0 ;
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               sXEvt = cgiGet( "_EventName") ;
               if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
               {
               }
            }
         }
         wbErr = false ;
         if ( ( StringUtil.Len( sPrefix) == 0 ) || ( nDraw == 1 ) )
         {
            if ( nDoneStart == 0 )
            {
               STRUP1O0( ) ;
            }
         }
      }

      protected void WS1O2( )
      {
         START1O2( ) ;
         EVT1O2( ) ;
      }

      protected void EVT1O2( )
      {
         sXEvt = cgiGet( "_EventName") ;
         if ( ( ( ( StringUtil.Len( sPrefix) == 0 ) ) || ( StringUtil.StringSearch( sXEvt, sPrefix, 1) > 0 ) ) && ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) && ! wbErr )
            {
               /* Read Web Panel buttons. */
               if ( context.wbHandled == 0 )
               {
                  if ( StringUtil.Len( sPrefix) == 0 )
                  {
                     sEvt = cgiGet( "_EventName") ;
                     EvtGridId = cgiGet( "_EventGridId") ;
                     EvtRowId = cgiGet( "_EventRowId") ;
                  }
                  if ( StringUtil.Len( sEvt) > 0 )
                  {
                     sEvtType = StringUtil.Left( sEvt, 1) ;
                     sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                     if ( StringUtil.StrCmp(sEvtType, "E") == 0 )
                     {
                        sEvtType = StringUtil.Right( sEvt, 1) ;
                        if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                        {
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                           if ( StringUtil.StrCmp(sEvt, "RFR") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP1O0( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'SELECCIONAR TODOS'") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP1O0( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: E111O2 */
                                    E111O2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'CANCELAR ENVíO'") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP1O0( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: E121O2 */
                                    E121O2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP1O0( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    GX_FocusControl = chkavSeleccion_Internalname ;
                                    context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                 }
                              }
                           }
                        }
                        else
                        {
                           sEvtType = StringUtil.Right( sEvt, 4) ;
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4)) ;
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 10), "GRID1.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 16), "'CANCELAR ENVíO'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 19), "'SELECCIONAR TODOS'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP1O0( ) ;
                              }
                              nGXsfl_8_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                              sGXsfl_8_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_8_idx), 4, 0)), 4, "0") ;
                              chkavSeleccion_Internalname = sPrefix+"vSELECCION_"+sGXsfl_8_idx ;
                              edtavDetalle_Internalname = sPrefix+"vDETALLE_"+sGXsfl_8_idx ;
                              edtavGttbus2_idmovimiento_Internalname = sPrefix+"vGTTBUS2_IDMOVIMIENTO_"+sGXsfl_8_idx ;
                              edtavGnumeroidentificador_Internalname = sPrefix+"vGNUMEROIDENTIFICADOR_"+sGXsfl_8_idx ;
                              edtavGttbus2_idbien_Internalname = sPrefix+"vGTTBUS2_IDBIEN_"+sGXsfl_8_idx ;
                              edtavGttbus2_codposhacia_Internalname = sPrefix+"vGTTBUS2_CODPOSHACIA_"+sGXsfl_8_idx ;
                              edtavHttbus3_des_Internalname = sPrefix+"vHTTBUS3_DES_"+sGXsfl_8_idx ;
                              edtavGttbus2_resphacia_Internalname = sPrefix+"vGTTBUS2_RESPHACIA_"+sGXsfl_8_idx ;
                              edtavHusu_des_Internalname = sPrefix+"vHUSU_DES_"+sGXsfl_8_idx ;
                              edtavGttbus2_fechaenvio_Internalname = sPrefix+"vGTTBUS2_FECHAENVIO_"+sGXsfl_8_idx ;
                              edtavGttbus2_motivoenvio_Internalname = sPrefix+"vGTTBUS2_MOTIVOENVIO_"+sGXsfl_8_idx ;
                              cmbavGttbus2_estadoenvio_Internalname = sPrefix+"vGTTBUS2_ESTADOENVIO_"+sGXsfl_8_idx ;
                              if ( ! context.localUtil.VCNumber( cgiGet( chkavSeleccion_Internalname), "9") || ( ((StringUtil.StrCmp(cgiGet( chkavSeleccion_Internalname), "1")==0) ? 1 : 0) < 0 ) || ( ( ((StringUtil.StrCmp(cgiGet( chkavSeleccion_Internalname), "1")==0) ? 1 : 0) > 9 ) ) )
                              {
                                 GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vSELECCION");
                                 GX_FocusControl = chkavSeleccion_Internalname ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                 wbErr = true ;
                                 AV20seleccion = 0 ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV20seleccion", StringUtil.Str( (decimal)(AV20seleccion), 1, 0));
                              }
                              else
                              {
                                 AV20seleccion = (short)(((StringUtil.StrCmp(cgiGet( chkavSeleccion_Internalname), "1")==0) ? 1 : 0)) ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV20seleccion", StringUtil.Str( (decimal)(AV20seleccion), 1, 0));
                              }
                              AV28detalle = cgiGet( "GXimg"+edtavDetalle_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDetalle_Internalname, "Bitmap", context.convertURL( AV28detalle));
                              if ( ! context.localUtil.VCNumber( cgiGet( edtavGttbus2_idmovimiento_Internalname), "ZZZZZZZZZZZ9") || ( context.localUtil.CToN( cgiGet( edtavGttbus2_idmovimiento_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavGttbus2_idmovimiento_Internalname), ",", ".") > Convert.ToDecimal( 999999999999L )) ) )
                              {
                                 GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vGTTBUS2_IDMOVIMIENTO");
                                 GX_FocusControl = edtavGttbus2_idmovimiento_Internalname ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                 wbErr = true ;
                                 AV14gTTBUS2_IdMovimiento = 0 ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14gTTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14gTTBUS2_IdMovimiento), 12, 0)));
                              }
                              else
                              {
                                 AV14gTTBUS2_IdMovimiento = (long)(context.localUtil.CToN( cgiGet( edtavGttbus2_idmovimiento_Internalname), ",", ".")) ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14gTTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14gTTBUS2_IdMovimiento), 12, 0)));
                              }
                              AV29gNumeroIdentificador = cgiGet( edtavGnumeroidentificador_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV29gNumeroIdentificador", AV29gNumeroIdentificador);
                              if ( ! context.localUtil.VCNumber( cgiGet( edtavGttbus2_idbien_Internalname), "ZZZZZZZ9") || ( context.localUtil.CToN( cgiGet( edtavGttbus2_idbien_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavGttbus2_idbien_Internalname), ",", ".") > Convert.ToDecimal( 99999999 )) ) )
                              {
                                 GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vGTTBUS2_IDBIEN");
                                 GX_FocusControl = edtavGttbus2_idbien_Internalname ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                 wbErr = true ;
                                 AV13gTTBUS2_IdBien = 0 ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV13gTTBUS2_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13gTTBUS2_IdBien), 8, 0)));
                              }
                              else
                              {
                                 AV13gTTBUS2_IdBien = (int)(context.localUtil.CToN( cgiGet( edtavGttbus2_idbien_Internalname), ",", ".")) ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV13gTTBUS2_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13gTTBUS2_IdBien), 8, 0)));
                              }
                              if ( ! context.localUtil.VCNumber( cgiGet( edtavGttbus2_codposhacia_Internalname), "ZZ9") || ( context.localUtil.CToN( cgiGet( edtavGttbus2_codposhacia_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavGttbus2_codposhacia_Internalname), ",", ".") > Convert.ToDecimal( 999 )) ) )
                              {
                                 GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vGTTBUS2_CODPOSHACIA");
                                 GX_FocusControl = edtavGttbus2_codposhacia_Internalname ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                 wbErr = true ;
                                 AV10gTTBUS2_CodPosHacia = 0 ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV10gTTBUS2_CodPosHacia", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10gTTBUS2_CodPosHacia), 3, 0)));
                              }
                              else
                              {
                                 AV10gTTBUS2_CodPosHacia = (short)(context.localUtil.CToN( cgiGet( edtavGttbus2_codposhacia_Internalname), ",", ".")) ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV10gTTBUS2_CodPosHacia", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10gTTBUS2_CodPosHacia), 3, 0)));
                              }
                              AV19hTTBUS3_Des = cgiGet( edtavHttbus3_des_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV19hTTBUS3_Des", AV19hTTBUS3_Des);
                              AV18gTTBUS2_RespHacia = cgiGet( edtavGttbus2_resphacia_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV18gTTBUS2_RespHacia", AV18gTTBUS2_RespHacia);
                              AV26hUSU_DES = StringUtil.Upper( cgiGet( edtavHusu_des_Internalname)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV26hUSU_DES", AV26hUSU_DES);
                              if ( context.localUtil.VCDateTime( cgiGet( edtavGttbus2_fechaenvio_Internalname), 4, 0) == 0 )
                              {
                                 GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"g TTBUS2_ Fecha Envio"}), 1, "vGTTBUS2_FECHAENVIO");
                                 GX_FocusControl = edtavGttbus2_fechaenvio_Internalname ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                 wbErr = true ;
                                 AV12gTTBUS2_FechaEnvio = (DateTime)(DateTime.MinValue) ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV12gTTBUS2_FechaEnvio", context.localUtil.TToC( AV12gTTBUS2_FechaEnvio, 10, 5, 0, 3, "/", ":", " "));
                              }
                              else
                              {
                                 AV12gTTBUS2_FechaEnvio = context.localUtil.CToT( cgiGet( edtavGttbus2_fechaenvio_Internalname)) ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV12gTTBUS2_FechaEnvio", context.localUtil.TToC( AV12gTTBUS2_FechaEnvio, 10, 5, 0, 3, "/", ":", " "));
                              }
                              AV15gTTBUS2_MotivoEnvio = StringUtil.Upper( cgiGet( edtavGttbus2_motivoenvio_Internalname)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15gTTBUS2_MotivoEnvio", AV15gTTBUS2_MotivoEnvio);
                              cmbavGttbus2_estadoenvio.Name = cmbavGttbus2_estadoenvio_Internalname ;
                              cmbavGttbus2_estadoenvio.CurrentValue = cgiGet( cmbavGttbus2_estadoenvio_Internalname) ;
                              AV11gTTBUS2_EstadoEnvio = (short)(NumberUtil.Val( cgiGet( cmbavGttbus2_estadoenvio_Internalname), ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV11gTTBUS2_EstadoEnvio", StringUtil.Str( (decimal)(AV11gTTBUS2_EstadoEnvio), 1, 0));
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1 ;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          GX_FocusControl = chkavSeleccion_Internalname ;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                          /* Execute user event: E131O2 */
                                          E131O2 ();
                                       }
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID1.LOAD") == 0 )
                                 {
                                    if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1 ;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          GX_FocusControl = chkavSeleccion_Internalname ;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                          /* Execute user event: E141O2 */
                                          E141O2 ();
                                       }
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'CANCELAR ENVíO'") == 0 )
                                 {
                                    if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1 ;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          GX_FocusControl = chkavSeleccion_Internalname ;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                          /* Execute user event: E121O2 */
                                          E121O2 ();
                                       }
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'SELECCIONAR TODOS'") == 0 )
                                 {
                                    if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1 ;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          GX_FocusControl = chkavSeleccion_Internalname ;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                          /* Execute user event: E111O2 */
                                          E111O2 ();
                                       }
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1 ;
                                       if ( ! wbErr )
                                       {
                                          if ( ! wbErr )
                                          {
                                             Rfr0gs = false ;
                                             if ( ! Rfr0gs )
                                             {
                                             }
                                             dynload_actions( ) ;
                                          }
                                       }
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "CANCEL") == 0 )
                                 {
                                    if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1 ;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          GX_FocusControl = chkavSeleccion_Internalname ;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                       }
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                                 {
                                    if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                                    {
                                       STRUP1O0( ) ;
                                    }
                                    if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1 ;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          GX_FocusControl = chkavSeleccion_Internalname ;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                       }
                                    }
                                 }
                              }
                              else
                              {
                              }
                           }
                        }
                     }
                     context.wbHandled = 1 ;
                  }
               }
            }
         }
      }

      protected void WE1O2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true ;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm1O2( ) ;
            }
         }
      }

      protected void PA1O2( )
      {
         if ( nDonePA == 0 )
         {
            if ( StringUtil.Len( sPrefix) != 0 )
            {
               initialize_properties( ) ;
            }
            GXCCtl = "vSELECCION_" + sGXsfl_8_idx ;
            chkavSeleccion.Name = GXCCtl ;
            chkavSeleccion.WebTags = "" ;
            chkavSeleccion.Caption = "" ;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, chkavSeleccion_Internalname, "Caption", chkavSeleccion.Caption);
            chkavSeleccion.CheckedValue = "0" ;
            GXCCtl = "vGTTBUS2_ESTADOENVIO_" + sGXsfl_8_idx ;
            cmbavGttbus2_estadoenvio.Name = GXCCtl ;
            cmbavGttbus2_estadoenvio.WebTags = "" ;
            cmbavGttbus2_estadoenvio.addItem("1", "No Finalizado", 0);
            cmbavGttbus2_estadoenvio.addItem("2", "Finalizado", 0);
            cmbavGttbus2_estadoenvio.addItem("3", "Cancelado", 0);
            if ( ( cmbavGttbus2_estadoenvio.ItemCount > 0 ) && (0==AV11gTTBUS2_EstadoEnvio) )
            {
               AV11gTTBUS2_EstadoEnvio = (short)(NumberUtil.Val( cmbavGttbus2_estadoenvio.getItemValue(1), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV11gTTBUS2_EstadoEnvio", StringUtil.Str( (decimal)(AV11gTTBUS2_EstadoEnvio), 1, 0));
            }
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void GXSGVvGTTBUS2_MOTIVOENVIO1O0( String A47TTBUS2_MotivoEnvio )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
         }
         context.GX_webresponse.AddString("(new Array( new Array(");
         GXSGVvGTTBUS2_MOTIVOENVIO_data1O0( A47TTBUS2_MotivoEnvio) ;
         gxdynajaxindex = 1 ;
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            context.GX_webresponse.AddString(gxwrpcisep+"{c:\""+GXUtil.EncodeJSConstant( gxdynajaxctrlcodr.Item(gxdynajaxindex))+"\",d:\""+GXUtil.EncodeJSConstant( gxdynajaxctrldescr.Item(gxdynajaxindex))+"\"}");
            gxdynajaxindex = (int)(gxdynajaxindex+1) ;
            gxwrpcisep = "," ;
         }
         context.GX_webresponse.AddString(")");
         if ( gxdynajaxctrlcodr.Count == 0 )
         {
            context.GX_webresponse.AddString(",101");
         }
         context.GX_webresponse.AddString("))");
      }

      protected void GXSGVvGTTBUS2_MOTIVOENVIO_data1O0( String A47TTBUS2_MotivoEnvio )
      {
         l47TTBUS2_MotivoEnvio = StringUtil.PadR( StringUtil.RTrim( A47TTBUS2_MotivoEnvio), 100, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A47TTBUS2_MotivoEnvio", A47TTBUS2_MotivoEnvio);
         /* Using cursor H001O2 */
         pr_default.execute(0, new Object[] {l47TTBUS2_MotivoEnvio});
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         while ( (pr_default.getStatus(0) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.RTrim( H001O2_A47TTBUS2_MotivoEnvio[0]));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( H001O2_A47TTBUS2_MotivoEnvio[0]));
            pr_default.readNext(0);
         }
         pr_default.close(0);
      }

      protected void gxnrGrid1_newrow( short nRC_Grid1 ,
                                       short nGXsfl_8_idx ,
                                       String sGXsfl_8_idx ,
                                       String sPrefix )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         chkavSeleccion_Internalname = sPrefix+"vSELECCION_"+sGXsfl_8_idx ;
         edtavDetalle_Internalname = sPrefix+"vDETALLE_"+sGXsfl_8_idx ;
         edtavGttbus2_idmovimiento_Internalname = sPrefix+"vGTTBUS2_IDMOVIMIENTO_"+sGXsfl_8_idx ;
         edtavGnumeroidentificador_Internalname = sPrefix+"vGNUMEROIDENTIFICADOR_"+sGXsfl_8_idx ;
         edtavGttbus2_idbien_Internalname = sPrefix+"vGTTBUS2_IDBIEN_"+sGXsfl_8_idx ;
         edtavGttbus2_codposhacia_Internalname = sPrefix+"vGTTBUS2_CODPOSHACIA_"+sGXsfl_8_idx ;
         edtavHttbus3_des_Internalname = sPrefix+"vHTTBUS3_DES_"+sGXsfl_8_idx ;
         edtavGttbus2_resphacia_Internalname = sPrefix+"vGTTBUS2_RESPHACIA_"+sGXsfl_8_idx ;
         edtavHusu_des_Internalname = sPrefix+"vHUSU_DES_"+sGXsfl_8_idx ;
         edtavGttbus2_fechaenvio_Internalname = sPrefix+"vGTTBUS2_FECHAENVIO_"+sGXsfl_8_idx ;
         edtavGttbus2_motivoenvio_Internalname = sPrefix+"vGTTBUS2_MOTIVOENVIO_"+sGXsfl_8_idx ;
         cmbavGttbus2_estadoenvio_Internalname = sPrefix+"vGTTBUS2_ESTADOENVIO_"+sGXsfl_8_idx ;
         while ( nGXsfl_8_idx <= nRC_Grid1 )
         {
            sendrow_82( ) ;
            nGXsfl_8_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_8_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_8_idx+1)) ;
            sGXsfl_8_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_8_idx), 4, 0)), 4, "0") ;
            chkavSeleccion_Internalname = sPrefix+"vSELECCION_"+sGXsfl_8_idx ;
            edtavDetalle_Internalname = sPrefix+"vDETALLE_"+sGXsfl_8_idx ;
            edtavGttbus2_idmovimiento_Internalname = sPrefix+"vGTTBUS2_IDMOVIMIENTO_"+sGXsfl_8_idx ;
            edtavGnumeroidentificador_Internalname = sPrefix+"vGNUMEROIDENTIFICADOR_"+sGXsfl_8_idx ;
            edtavGttbus2_idbien_Internalname = sPrefix+"vGTTBUS2_IDBIEN_"+sGXsfl_8_idx ;
            edtavGttbus2_codposhacia_Internalname = sPrefix+"vGTTBUS2_CODPOSHACIA_"+sGXsfl_8_idx ;
            edtavHttbus3_des_Internalname = sPrefix+"vHTTBUS3_DES_"+sGXsfl_8_idx ;
            edtavGttbus2_resphacia_Internalname = sPrefix+"vGTTBUS2_RESPHACIA_"+sGXsfl_8_idx ;
            edtavHusu_des_Internalname = sPrefix+"vHUSU_DES_"+sGXsfl_8_idx ;
            edtavGttbus2_fechaenvio_Internalname = sPrefix+"vGTTBUS2_FECHAENVIO_"+sGXsfl_8_idx ;
            edtavGttbus2_motivoenvio_Internalname = sPrefix+"vGTTBUS2_MOTIVOENVIO_"+sGXsfl_8_idx ;
            cmbavGttbus2_estadoenvio_Internalname = sPrefix+"vGTTBUS2_ESTADOENVIO_"+sGXsfl_8_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( String A102TTBUS2_TipoResp ,
                                        String A53TTBUS2_IdUsuario ,
                                        short A26TTBUS2_EstadoEnvio ,
                                        String A47TTBUS2_MotivoEnvio ,
                                        DateTime A45TTBUS2_FechaEnvio ,
                                        String A7USU_DES ,
                                        String A6USU_COD ,
                                        String A25TTBUS2_RespHacia ,
                                        String A34TTBUS7_Des ,
                                        short A33TTBUS7_Pos ,
                                        short A49TTBUS2_CodPosHacia ,
                                        int A22TTBUS2_IdBien ,
                                        long A52TTBUS2_IdMovimiento ,
                                        String sPrefix )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         RF1O2( ) ;
         enableOutput();
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxgrGrid1_refresh */
      }

      protected void Refresh( )
      {
         RF1O2( ) ;
         /* End function Refresh */
      }

      protected void RF1O2( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 8 ;
         nGXsfl_8_idx = 1 ;
         sGXsfl_8_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_8_idx), 4, 0)), 4, "0") ;
         chkavSeleccion_Internalname = sPrefix+"vSELECCION_"+sGXsfl_8_idx ;
         edtavDetalle_Internalname = sPrefix+"vDETALLE_"+sGXsfl_8_idx ;
         edtavGttbus2_idmovimiento_Internalname = sPrefix+"vGTTBUS2_IDMOVIMIENTO_"+sGXsfl_8_idx ;
         edtavGnumeroidentificador_Internalname = sPrefix+"vGNUMEROIDENTIFICADOR_"+sGXsfl_8_idx ;
         edtavGttbus2_idbien_Internalname = sPrefix+"vGTTBUS2_IDBIEN_"+sGXsfl_8_idx ;
         edtavGttbus2_codposhacia_Internalname = sPrefix+"vGTTBUS2_CODPOSHACIA_"+sGXsfl_8_idx ;
         edtavHttbus3_des_Internalname = sPrefix+"vHTTBUS3_DES_"+sGXsfl_8_idx ;
         edtavGttbus2_resphacia_Internalname = sPrefix+"vGTTBUS2_RESPHACIA_"+sGXsfl_8_idx ;
         edtavHusu_des_Internalname = sPrefix+"vHUSU_DES_"+sGXsfl_8_idx ;
         edtavGttbus2_fechaenvio_Internalname = sPrefix+"vGTTBUS2_FECHAENVIO_"+sGXsfl_8_idx ;
         edtavGttbus2_motivoenvio_Internalname = sPrefix+"vGTTBUS2_MOTIVOENVIO_"+sGXsfl_8_idx ;
         cmbavGttbus2_estadoenvio_Internalname = sPrefix+"vGTTBUS2_ESTADOENVIO_"+sGXsfl_8_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            chkavSeleccion_Internalname = sPrefix+"vSELECCION_"+sGXsfl_8_idx ;
            edtavDetalle_Internalname = sPrefix+"vDETALLE_"+sGXsfl_8_idx ;
            edtavGttbus2_idmovimiento_Internalname = sPrefix+"vGTTBUS2_IDMOVIMIENTO_"+sGXsfl_8_idx ;
            edtavGnumeroidentificador_Internalname = sPrefix+"vGNUMEROIDENTIFICADOR_"+sGXsfl_8_idx ;
            edtavGttbus2_idbien_Internalname = sPrefix+"vGTTBUS2_IDBIEN_"+sGXsfl_8_idx ;
            edtavGttbus2_codposhacia_Internalname = sPrefix+"vGTTBUS2_CODPOSHACIA_"+sGXsfl_8_idx ;
            edtavHttbus3_des_Internalname = sPrefix+"vHTTBUS3_DES_"+sGXsfl_8_idx ;
            edtavGttbus2_resphacia_Internalname = sPrefix+"vGTTBUS2_RESPHACIA_"+sGXsfl_8_idx ;
            edtavHusu_des_Internalname = sPrefix+"vHUSU_DES_"+sGXsfl_8_idx ;
            edtavGttbus2_fechaenvio_Internalname = sPrefix+"vGTTBUS2_FECHAENVIO_"+sGXsfl_8_idx ;
            edtavGttbus2_motivoenvio_Internalname = sPrefix+"vGTTBUS2_MOTIVOENVIO_"+sGXsfl_8_idx ;
            cmbavGttbus2_estadoenvio_Internalname = sPrefix+"vGTTBUS2_ESTADOENVIO_"+sGXsfl_8_idx ;
            /* Execute user event: E141O2 */
            E141O2 ();
            wbEnd = 8 ;
            WB1O0( ) ;
         }
      }

      protected int subGrid1_Pagecount( )
      {
         return (int)(-1) ;
      }

      protected int subGrid1_Recordcount( )
      {
         return (int)(-1) ;
      }

      protected int subGrid1_Recordsperpage( )
      {
         return (int)(-1) ;
      }

      protected int subGrid1_Currentpage( )
      {
         return (int)(-1) ;
      }

      protected void STRUP1O0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         edtavGttbus2_idmovimiento_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavGttbus2_idmovimiento_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGttbus2_idmovimiento_Enabled), 5, 0)));
         edtavGnumeroidentificador_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavGnumeroidentificador_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGnumeroidentificador_Enabled), 5, 0)));
         edtavGttbus2_idbien_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavGttbus2_idbien_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGttbus2_idbien_Enabled), 5, 0)));
         edtavGttbus2_codposhacia_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavGttbus2_codposhacia_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGttbus2_codposhacia_Enabled), 5, 0)));
         edtavHttbus3_des_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavHttbus3_des_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavHttbus3_des_Enabled), 5, 0)));
         edtavGttbus2_resphacia_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavGttbus2_resphacia_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGttbus2_resphacia_Enabled), 5, 0)));
         edtavHusu_des_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavHusu_des_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavHusu_des_Enabled), 5, 0)));
         edtavGttbus2_fechaenvio_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavGttbus2_fechaenvio_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGttbus2_fechaenvio_Enabled), 5, 0)));
         edtavGttbus2_motivoenvio_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavGttbus2_motivoenvio_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGttbus2_motivoenvio_Enabled), 5, 0)));
         cmbavGttbus2_estadoenvio.Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbavGttbus2_estadoenvio_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavGttbus2_estadoenvio.Enabled), 5, 0)));
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E131O2 */
         E131O2 ();
         context.wbGlbDoneStart = 1 ;
         nDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName") ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( sPrefix+"nRC_Grid1"), ",", ".")) ;
            wcpOAV25USUARIO = cgiGet( sPrefix+"wcpOAV25USUARIO") ;
            wcpOAV21SISTEMA = cgiGet( sPrefix+"wcpOAV21SISTEMA") ;
            AV25USUARIO = cgiGet( sPrefix+"vUSUARIO") ;
            AV21SISTEMA = cgiGet( sPrefix+"vSISTEMA") ;
            /* Read subfile selected row values. */
            /* Read hidden variables. */
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: E131O2 */
         E131O2 ();
         if (returnInSub) return;
      }

      protected void E131O2( )
      {
         /* Start Routine */
      }

      private void E141O2( )
      {
         /* Grid1_Load Routine */
         AV28detalle = context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", "Modern") ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDetalle_Internalname, "Bitmap", context.convertURL( AV28detalle));
         /* Using cursor H001O3 */
         pr_default.execute(1, new Object[] {AV25USUARIO});
         while ( (pr_default.getStatus(1) != 101) )
         {
            A25TTBUS2_RespHacia = H001O3_A25TTBUS2_RespHacia[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A25TTBUS2_RespHacia", A25TTBUS2_RespHacia);
            A49TTBUS2_CodPosHacia = H001O3_A49TTBUS2_CodPosHacia[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A49TTBUS2_CodPosHacia", StringUtil.LTrim( StringUtil.Str( (decimal)(A49TTBUS2_CodPosHacia), 3, 0)));
            A26TTBUS2_EstadoEnvio = H001O3_A26TTBUS2_EstadoEnvio[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A26TTBUS2_EstadoEnvio", StringUtil.Str( (decimal)(A26TTBUS2_EstadoEnvio), 1, 0));
            A24TTBUS2_RespDesde = H001O3_A24TTBUS2_RespDesde[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A24TTBUS2_RespDesde", A24TTBUS2_RespDesde);
            A22TTBUS2_IdBien = H001O3_A22TTBUS2_IdBien[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A22TTBUS2_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A22TTBUS2_IdBien), 8, 0)));
            A45TTBUS2_FechaEnvio = H001O3_A45TTBUS2_FechaEnvio[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A45TTBUS2_FechaEnvio", context.localUtil.TToC( A45TTBUS2_FechaEnvio, 10, 5, 0, 3, "/", ":", " "));
            A47TTBUS2_MotivoEnvio = H001O3_A47TTBUS2_MotivoEnvio[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A47TTBUS2_MotivoEnvio", A47TTBUS2_MotivoEnvio);
            A52TTBUS2_IdMovimiento = H001O3_A52TTBUS2_IdMovimiento[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A52TTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(A52TTBUS2_IdMovimiento), 12, 0)));
            AV14gTTBUS2_IdMovimiento = A52TTBUS2_IdMovimiento ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14gTTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14gTTBUS2_IdMovimiento), 12, 0)));
            new ptbus009(context ).execute(  A22TTBUS2_IdBien,  1, out  AV29gNumeroIdentificador) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A22TTBUS2_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A22TTBUS2_IdBien), 8, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV29gNumeroIdentificador", AV29gNumeroIdentificador);
            AV13gTTBUS2_IdBien = A22TTBUS2_IdBien ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV13gTTBUS2_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13gTTBUS2_IdBien), 8, 0)));
            AV10gTTBUS2_CodPosHacia = A49TTBUS2_CodPosHacia ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV10gTTBUS2_CodPosHacia", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10gTTBUS2_CodPosHacia), 3, 0)));
            /* Using cursor H001O4 */
            pr_default.execute(2, new Object[] {A49TTBUS2_CodPosHacia});
            while ( (pr_default.getStatus(2) != 101) )
            {
               A33TTBUS7_Pos = H001O4_A33TTBUS7_Pos[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
               A34TTBUS7_Des = H001O4_A34TTBUS7_Des[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A34TTBUS7_Des", A34TTBUS7_Des);
               n34TTBUS7_Des = H001O4_n34TTBUS7_Des[0] ;
               A34TTBUS7_Des = H001O4_A34TTBUS7_Des[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A34TTBUS7_Des", A34TTBUS7_Des);
               n34TTBUS7_Des = H001O4_n34TTBUS7_Des[0] ;
               AV19hTTBUS3_Des = A34TTBUS7_Des ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV19hTTBUS3_Des", AV19hTTBUS3_Des);
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(2);
            AV18gTTBUS2_RespHacia = A25TTBUS2_RespHacia ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV18gTTBUS2_RespHacia", AV18gTTBUS2_RespHacia);
            /* Using cursor H001O5 */
            pr_default.execute(3, new Object[] {A25TTBUS2_RespHacia});
            while ( (pr_default.getStatus(3) != 101) )
            {
               A6USU_COD = H001O5_A6USU_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A6USU_COD", A6USU_COD);
               A7USU_DES = H001O5_A7USU_DES[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A7USU_DES", A7USU_DES);
               AV26hUSU_DES = A7USU_DES ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV26hUSU_DES", AV26hUSU_DES);
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(3);
            AV12gTTBUS2_FechaEnvio = A45TTBUS2_FechaEnvio ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV12gTTBUS2_FechaEnvio", context.localUtil.TToC( AV12gTTBUS2_FechaEnvio, 10, 5, 0, 3, "/", ":", " "));
            AV18gTTBUS2_RespHacia = A25TTBUS2_RespHacia ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV18gTTBUS2_RespHacia", AV18gTTBUS2_RespHacia);
            AV15gTTBUS2_MotivoEnvio = A47TTBUS2_MotivoEnvio ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15gTTBUS2_MotivoEnvio", AV15gTTBUS2_MotivoEnvio);
            AV11gTTBUS2_EstadoEnvio = A26TTBUS2_EstadoEnvio ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV11gTTBUS2_EstadoEnvio", StringUtil.Str( (decimal)(AV11gTTBUS2_EstadoEnvio), 1, 0));
            /* Load Method */
            if ( wbStart != -1 )
            {
               wbStart = 8 ;
            }
            sendrow_82( ) ;
            pr_default.readNext(1);
         }
         pr_default.close(1);
         /* Using cursor H001O6 */
         pr_default.execute(4, new Object[] {AV25USUARIO});
         while ( (pr_default.getStatus(4) != 101) )
         {
            BRK1O6 = false ;
            A53TTBUS2_IdUsuario = H001O6_A53TTBUS2_IdUsuario[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A53TTBUS2_IdUsuario", A53TTBUS2_IdUsuario);
            A26TTBUS2_EstadoEnvio = H001O6_A26TTBUS2_EstadoEnvio[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A26TTBUS2_EstadoEnvio", StringUtil.Str( (decimal)(A26TTBUS2_EstadoEnvio), 1, 0));
            A52TTBUS2_IdMovimiento = H001O6_A52TTBUS2_IdMovimiento[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A52TTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(A52TTBUS2_IdMovimiento), 12, 0)));
            A22TTBUS2_IdBien = H001O6_A22TTBUS2_IdBien[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A22TTBUS2_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A22TTBUS2_IdBien), 8, 0)));
            A49TTBUS2_CodPosHacia = H001O6_A49TTBUS2_CodPosHacia[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A49TTBUS2_CodPosHacia", StringUtil.LTrim( StringUtil.Str( (decimal)(A49TTBUS2_CodPosHacia), 3, 0)));
            A25TTBUS2_RespHacia = H001O6_A25TTBUS2_RespHacia[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A25TTBUS2_RespHacia", A25TTBUS2_RespHacia);
            A45TTBUS2_FechaEnvio = H001O6_A45TTBUS2_FechaEnvio[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A45TTBUS2_FechaEnvio", context.localUtil.TToC( A45TTBUS2_FechaEnvio, 10, 5, 0, 3, "/", ":", " "));
            A47TTBUS2_MotivoEnvio = H001O6_A47TTBUS2_MotivoEnvio[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A47TTBUS2_MotivoEnvio", A47TTBUS2_MotivoEnvio);
            A102TTBUS2_TipoResp = H001O6_A102TTBUS2_TipoResp[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A102TTBUS2_TipoResp", A102TTBUS2_TipoResp);
            A26TTBUS2_EstadoEnvio = H001O6_A26TTBUS2_EstadoEnvio[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A26TTBUS2_EstadoEnvio", StringUtil.Str( (decimal)(A26TTBUS2_EstadoEnvio), 1, 0));
            A22TTBUS2_IdBien = H001O6_A22TTBUS2_IdBien[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A22TTBUS2_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A22TTBUS2_IdBien), 8, 0)));
            A49TTBUS2_CodPosHacia = H001O6_A49TTBUS2_CodPosHacia[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A49TTBUS2_CodPosHacia", StringUtil.LTrim( StringUtil.Str( (decimal)(A49TTBUS2_CodPosHacia), 3, 0)));
            A25TTBUS2_RespHacia = H001O6_A25TTBUS2_RespHacia[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A25TTBUS2_RespHacia", A25TTBUS2_RespHacia);
            A45TTBUS2_FechaEnvio = H001O6_A45TTBUS2_FechaEnvio[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A45TTBUS2_FechaEnvio", context.localUtil.TToC( A45TTBUS2_FechaEnvio, 10, 5, 0, 3, "/", ":", " "));
            A47TTBUS2_MotivoEnvio = H001O6_A47TTBUS2_MotivoEnvio[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A47TTBUS2_MotivoEnvio", A47TTBUS2_MotivoEnvio);
            AV23TTBUS2_IdMovimiento = A52TTBUS2_IdMovimiento ;
            if ( StringUtil.StrCmp(A102TTBUS2_TipoResp, "E") == 0 )
            {
               while ( (pr_default.getStatus(4) != 101) && ( StringUtil.StrCmp(H001O6_A53TTBUS2_IdUsuario[0], A53TTBUS2_IdUsuario) == 0 ) && ( H001O6_A52TTBUS2_IdMovimiento[0] == A52TTBUS2_IdMovimiento ) )
               {
                  BRK1O6 = false ;
                  A26TTBUS2_EstadoEnvio = H001O6_A26TTBUS2_EstadoEnvio[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A26TTBUS2_EstadoEnvio", StringUtil.Str( (decimal)(A26TTBUS2_EstadoEnvio), 1, 0));
                  A22TTBUS2_IdBien = H001O6_A22TTBUS2_IdBien[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A22TTBUS2_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A22TTBUS2_IdBien), 8, 0)));
                  A49TTBUS2_CodPosHacia = H001O6_A49TTBUS2_CodPosHacia[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A49TTBUS2_CodPosHacia", StringUtil.LTrim( StringUtil.Str( (decimal)(A49TTBUS2_CodPosHacia), 3, 0)));
                  A25TTBUS2_RespHacia = H001O6_A25TTBUS2_RespHacia[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A25TTBUS2_RespHacia", A25TTBUS2_RespHacia);
                  A45TTBUS2_FechaEnvio = H001O6_A45TTBUS2_FechaEnvio[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A45TTBUS2_FechaEnvio", context.localUtil.TToC( A45TTBUS2_FechaEnvio, 10, 5, 0, 3, "/", ":", " "));
                  A47TTBUS2_MotivoEnvio = H001O6_A47TTBUS2_MotivoEnvio[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A47TTBUS2_MotivoEnvio", A47TTBUS2_MotivoEnvio);
                  A102TTBUS2_TipoResp = H001O6_A102TTBUS2_TipoResp[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A102TTBUS2_TipoResp", A102TTBUS2_TipoResp);
                  A26TTBUS2_EstadoEnvio = H001O6_A26TTBUS2_EstadoEnvio[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A26TTBUS2_EstadoEnvio", StringUtil.Str( (decimal)(A26TTBUS2_EstadoEnvio), 1, 0));
                  A22TTBUS2_IdBien = H001O6_A22TTBUS2_IdBien[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A22TTBUS2_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A22TTBUS2_IdBien), 8, 0)));
                  A49TTBUS2_CodPosHacia = H001O6_A49TTBUS2_CodPosHacia[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A49TTBUS2_CodPosHacia", StringUtil.LTrim( StringUtil.Str( (decimal)(A49TTBUS2_CodPosHacia), 3, 0)));
                  A25TTBUS2_RespHacia = H001O6_A25TTBUS2_RespHacia[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A25TTBUS2_RespHacia", A25TTBUS2_RespHacia);
                  A45TTBUS2_FechaEnvio = H001O6_A45TTBUS2_FechaEnvio[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A45TTBUS2_FechaEnvio", context.localUtil.TToC( A45TTBUS2_FechaEnvio, 10, 5, 0, 3, "/", ":", " "));
                  A47TTBUS2_MotivoEnvio = H001O6_A47TTBUS2_MotivoEnvio[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A47TTBUS2_MotivoEnvio", A47TTBUS2_MotivoEnvio);
                  if ( A52TTBUS2_IdMovimiento == AV23TTBUS2_IdMovimiento )
                  {
                     if ( A26TTBUS2_EstadoEnvio == 1 )
                     {
                        AV14gTTBUS2_IdMovimiento = A52TTBUS2_IdMovimiento ;
                        context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14gTTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14gTTBUS2_IdMovimiento), 12, 0)));
                        AV13gTTBUS2_IdBien = A22TTBUS2_IdBien ;
                        context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV13gTTBUS2_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13gTTBUS2_IdBien), 8, 0)));
                        AV10gTTBUS2_CodPosHacia = A49TTBUS2_CodPosHacia ;
                        context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV10gTTBUS2_CodPosHacia", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10gTTBUS2_CodPosHacia), 3, 0)));
                        /* Using cursor H001O7 */
                        pr_default.execute(5, new Object[] {A49TTBUS2_CodPosHacia});
                        while ( (pr_default.getStatus(5) != 101) )
                        {
                           A33TTBUS7_Pos = H001O7_A33TTBUS7_Pos[0] ;
                           context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
                           A34TTBUS7_Des = H001O7_A34TTBUS7_Des[0] ;
                           context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A34TTBUS7_Des", A34TTBUS7_Des);
                           n34TTBUS7_Des = H001O7_n34TTBUS7_Des[0] ;
                           A34TTBUS7_Des = H001O7_A34TTBUS7_Des[0] ;
                           context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A34TTBUS7_Des", A34TTBUS7_Des);
                           n34TTBUS7_Des = H001O7_n34TTBUS7_Des[0] ;
                           AV19hTTBUS3_Des = A34TTBUS7_Des ;
                           context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV19hTTBUS3_Des", AV19hTTBUS3_Des);
                           /* Exiting from a For First loop. */
                           if (true) break;
                        }
                        pr_default.close(5);
                        AV18gTTBUS2_RespHacia = A25TTBUS2_RespHacia ;
                        context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV18gTTBUS2_RespHacia", AV18gTTBUS2_RespHacia);
                        /* Using cursor H001O8 */
                        pr_default.execute(6, new Object[] {A25TTBUS2_RespHacia});
                        while ( (pr_default.getStatus(6) != 101) )
                        {
                           A6USU_COD = H001O8_A6USU_COD[0] ;
                           context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A6USU_COD", A6USU_COD);
                           A7USU_DES = H001O8_A7USU_DES[0] ;
                           context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A7USU_DES", A7USU_DES);
                           AV26hUSU_DES = A7USU_DES ;
                           context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV26hUSU_DES", AV26hUSU_DES);
                           /* Exiting from a For First loop. */
                           if (true) break;
                        }
                        pr_default.close(6);
                        AV12gTTBUS2_FechaEnvio = A45TTBUS2_FechaEnvio ;
                        context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV12gTTBUS2_FechaEnvio", context.localUtil.TToC( AV12gTTBUS2_FechaEnvio, 10, 5, 0, 3, "/", ":", " "));
                        AV18gTTBUS2_RespHacia = A25TTBUS2_RespHacia ;
                        context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV18gTTBUS2_RespHacia", AV18gTTBUS2_RespHacia);
                        AV15gTTBUS2_MotivoEnvio = A47TTBUS2_MotivoEnvio ;
                        context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15gTTBUS2_MotivoEnvio", AV15gTTBUS2_MotivoEnvio);
                        AV11gTTBUS2_EstadoEnvio = A26TTBUS2_EstadoEnvio ;
                        context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV11gTTBUS2_EstadoEnvio", StringUtil.Str( (decimal)(AV11gTTBUS2_EstadoEnvio), 1, 0));
                        /* Load Method */
                        if ( wbStart != -1 )
                        {
                           wbStart = 8 ;
                        }
                        sendrow_82( ) ;
                     }
                  }
                  BRK1O6 = true ;
                  pr_default.readNext(4);
               }
            }
            if ( ! BRK1O6 )
            {
               BRK1O6 = true ;
               pr_default.readNext(4);
            }
         }
         pr_default.close(4);
      }

      protected void E121O2( )
      {
         /* 'Cancelar Envío' Routine */
         /* Start For Each Line */
         nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( sPrefix+"nRC_Grid1"), ",", ".")) ;
         nGXsfl_8_fel_idx = 0 ;
         while ( nGXsfl_8_fel_idx < nRC_Grid1 )
         {
            nGXsfl_8_fel_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_8_fel_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_8_fel_idx+1)) ;
            sGXsfl_8_fel_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_8_fel_idx), 4, 0)), 4, "0") ;
            chkavSeleccion_Internalname = sPrefix+"vSELECCION_"+sGXsfl_8_fel_idx ;
            edtavDetalle_Internalname = sPrefix+"vDETALLE_"+sGXsfl_8_fel_idx ;
            edtavGttbus2_idmovimiento_Internalname = sPrefix+"vGTTBUS2_IDMOVIMIENTO_"+sGXsfl_8_fel_idx ;
            edtavGnumeroidentificador_Internalname = sPrefix+"vGNUMEROIDENTIFICADOR_"+sGXsfl_8_fel_idx ;
            edtavGttbus2_idbien_Internalname = sPrefix+"vGTTBUS2_IDBIEN_"+sGXsfl_8_fel_idx ;
            edtavGttbus2_codposhacia_Internalname = sPrefix+"vGTTBUS2_CODPOSHACIA_"+sGXsfl_8_fel_idx ;
            edtavHttbus3_des_Internalname = sPrefix+"vHTTBUS3_DES_"+sGXsfl_8_fel_idx ;
            edtavGttbus2_resphacia_Internalname = sPrefix+"vGTTBUS2_RESPHACIA_"+sGXsfl_8_fel_idx ;
            edtavHusu_des_Internalname = sPrefix+"vHUSU_DES_"+sGXsfl_8_fel_idx ;
            edtavGttbus2_fechaenvio_Internalname = sPrefix+"vGTTBUS2_FECHAENVIO_"+sGXsfl_8_fel_idx ;
            edtavGttbus2_motivoenvio_Internalname = sPrefix+"vGTTBUS2_MOTIVOENVIO_"+sGXsfl_8_fel_idx ;
            cmbavGttbus2_estadoenvio_Internalname = sPrefix+"vGTTBUS2_ESTADOENVIO_"+sGXsfl_8_fel_idx ;
            if ( ! context.localUtil.VCNumber( cgiGet( chkavSeleccion_Internalname), "9") || ( ((StringUtil.StrCmp(cgiGet( chkavSeleccion_Internalname), "1")==0) ? 1 : 0) < 0 ) || ( ( ((StringUtil.StrCmp(cgiGet( chkavSeleccion_Internalname), "1")==0) ? 1 : 0) > 9 ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vSELECCION");
               GX_FocusControl = chkavSeleccion_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV20seleccion = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV20seleccion", StringUtil.Str( (decimal)(AV20seleccion), 1, 0));
            }
            else
            {
               AV20seleccion = (short)(((StringUtil.StrCmp(cgiGet( chkavSeleccion_Internalname), "1")==0) ? 1 : 0)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV20seleccion", StringUtil.Str( (decimal)(AV20seleccion), 1, 0));
            }
            AV28detalle = cgiGet( "GXimg"+edtavDetalle_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDetalle_Internalname, "Bitmap", context.convertURL( AV28detalle));
            if ( ! context.localUtil.VCNumber( cgiGet( edtavGttbus2_idmovimiento_Internalname), "ZZZZZZZZZZZ9") || ( context.localUtil.CToN( cgiGet( edtavGttbus2_idmovimiento_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavGttbus2_idmovimiento_Internalname), ",", ".") > Convert.ToDecimal( 999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vGTTBUS2_IDMOVIMIENTO");
               GX_FocusControl = edtavGttbus2_idmovimiento_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV14gTTBUS2_IdMovimiento = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14gTTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14gTTBUS2_IdMovimiento), 12, 0)));
            }
            else
            {
               AV14gTTBUS2_IdMovimiento = (long)(context.localUtil.CToN( cgiGet( edtavGttbus2_idmovimiento_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14gTTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14gTTBUS2_IdMovimiento), 12, 0)));
            }
            AV29gNumeroIdentificador = cgiGet( edtavGnumeroidentificador_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV29gNumeroIdentificador", AV29gNumeroIdentificador);
            if ( ! context.localUtil.VCNumber( cgiGet( edtavGttbus2_idbien_Internalname), "ZZZZZZZ9") || ( context.localUtil.CToN( cgiGet( edtavGttbus2_idbien_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavGttbus2_idbien_Internalname), ",", ".") > Convert.ToDecimal( 99999999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vGTTBUS2_IDBIEN");
               GX_FocusControl = edtavGttbus2_idbien_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV13gTTBUS2_IdBien = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV13gTTBUS2_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13gTTBUS2_IdBien), 8, 0)));
            }
            else
            {
               AV13gTTBUS2_IdBien = (int)(context.localUtil.CToN( cgiGet( edtavGttbus2_idbien_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV13gTTBUS2_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13gTTBUS2_IdBien), 8, 0)));
            }
            if ( ! context.localUtil.VCNumber( cgiGet( edtavGttbus2_codposhacia_Internalname), "ZZ9") || ( context.localUtil.CToN( cgiGet( edtavGttbus2_codposhacia_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavGttbus2_codposhacia_Internalname), ",", ".") > Convert.ToDecimal( 999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vGTTBUS2_CODPOSHACIA");
               GX_FocusControl = edtavGttbus2_codposhacia_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV10gTTBUS2_CodPosHacia = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV10gTTBUS2_CodPosHacia", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10gTTBUS2_CodPosHacia), 3, 0)));
            }
            else
            {
               AV10gTTBUS2_CodPosHacia = (short)(context.localUtil.CToN( cgiGet( edtavGttbus2_codposhacia_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV10gTTBUS2_CodPosHacia", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10gTTBUS2_CodPosHacia), 3, 0)));
            }
            AV19hTTBUS3_Des = cgiGet( edtavHttbus3_des_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV19hTTBUS3_Des", AV19hTTBUS3_Des);
            AV18gTTBUS2_RespHacia = cgiGet( edtavGttbus2_resphacia_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV18gTTBUS2_RespHacia", AV18gTTBUS2_RespHacia);
            AV26hUSU_DES = StringUtil.Upper( cgiGet( edtavHusu_des_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV26hUSU_DES", AV26hUSU_DES);
            if ( context.localUtil.VCDateTime( cgiGet( edtavGttbus2_fechaenvio_Internalname), 4, 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"g TTBUS2_ Fecha Envio"}), 1, "vGTTBUS2_FECHAENVIO");
               GX_FocusControl = edtavGttbus2_fechaenvio_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV12gTTBUS2_FechaEnvio = (DateTime)(DateTime.MinValue) ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV12gTTBUS2_FechaEnvio", context.localUtil.TToC( AV12gTTBUS2_FechaEnvio, 10, 5, 0, 3, "/", ":", " "));
            }
            else
            {
               AV12gTTBUS2_FechaEnvio = context.localUtil.CToT( cgiGet( edtavGttbus2_fechaenvio_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV12gTTBUS2_FechaEnvio", context.localUtil.TToC( AV12gTTBUS2_FechaEnvio, 10, 5, 0, 3, "/", ":", " "));
            }
            AV15gTTBUS2_MotivoEnvio = StringUtil.Upper( cgiGet( edtavGttbus2_motivoenvio_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15gTTBUS2_MotivoEnvio", AV15gTTBUS2_MotivoEnvio);
            cmbavGttbus2_estadoenvio.Name = cmbavGttbus2_estadoenvio_Internalname ;
            cmbavGttbus2_estadoenvio.CurrentValue = cgiGet( cmbavGttbus2_estadoenvio_Internalname) ;
            AV11gTTBUS2_EstadoEnvio = (short)(NumberUtil.Val( cgiGet( cmbavGttbus2_estadoenvio_Internalname), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV11gTTBUS2_EstadoEnvio", StringUtil.Str( (decimal)(AV11gTTBUS2_EstadoEnvio), 1, 0));
            if ( AV20seleccion == 1 )
            {
               /* Using cursor H001O9 */
               pr_default.execute(7, new Object[] {AV13gTTBUS2_IdBien});
               while ( (pr_default.getStatus(7) != 101) )
               {
                  A11TTBUS_Id = H001O9_A11TTBUS_Id[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
                  A12TTBUS_Descripcion = H001O9_A12TTBUS_Descripcion[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
                  AV22TTBUS_Descripcion = A12TTBUS_Descripcion ;
                  /* Exiting from a For First loop. */
                  if (true) break;
               }
               pr_default.close(7);
               context.PopUp(formatLink("ttbus002_c.aspx") + "?" + UrlEncode("" +AV14gTTBUS2_IdMovimiento) + "," + UrlEncode("" +AV13gTTBUS2_IdBien) + "," + UrlEncode(StringUtil.RTrim(AV22TTBUS_Descripcion)) + "," + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode(StringUtil.RTrim(AV21SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV25USUARIO)), new Object[] {"AV14gTTBUS2_IdMovimiento","AV13gTTBUS2_IdBien","AV22TTBUS_Descripcion","","AV21SISTEMA","AV25USUARIO"});
            }
            /* End For Each Line */
         }
         if ( nGXsfl_8_fel_idx == 0 )
         {
            nGXsfl_8_idx = 1 ;
            sGXsfl_8_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_8_idx), 4, 0)), 4, "0") ;
            chkavSeleccion_Internalname = sPrefix+"vSELECCION_"+sGXsfl_8_idx ;
            edtavDetalle_Internalname = sPrefix+"vDETALLE_"+sGXsfl_8_idx ;
            edtavGttbus2_idmovimiento_Internalname = sPrefix+"vGTTBUS2_IDMOVIMIENTO_"+sGXsfl_8_idx ;
            edtavGnumeroidentificador_Internalname = sPrefix+"vGNUMEROIDENTIFICADOR_"+sGXsfl_8_idx ;
            edtavGttbus2_idbien_Internalname = sPrefix+"vGTTBUS2_IDBIEN_"+sGXsfl_8_idx ;
            edtavGttbus2_codposhacia_Internalname = sPrefix+"vGTTBUS2_CODPOSHACIA_"+sGXsfl_8_idx ;
            edtavHttbus3_des_Internalname = sPrefix+"vHTTBUS3_DES_"+sGXsfl_8_idx ;
            edtavGttbus2_resphacia_Internalname = sPrefix+"vGTTBUS2_RESPHACIA_"+sGXsfl_8_idx ;
            edtavHusu_des_Internalname = sPrefix+"vHUSU_DES_"+sGXsfl_8_idx ;
            edtavGttbus2_fechaenvio_Internalname = sPrefix+"vGTTBUS2_FECHAENVIO_"+sGXsfl_8_idx ;
            edtavGttbus2_motivoenvio_Internalname = sPrefix+"vGTTBUS2_MOTIVOENVIO_"+sGXsfl_8_idx ;
            cmbavGttbus2_estadoenvio_Internalname = sPrefix+"vGTTBUS2_ESTADOENVIO_"+sGXsfl_8_idx ;
         }
         nGXsfl_8_fel_idx = 1 ;
         context.DoAjaxRefresh();
      }

      protected void E111O2( )
      {
         /* 'Seleccionar Todos' Routine */
         /* Start For Each Line */
         nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( sPrefix+"nRC_Grid1"), ",", ".")) ;
         nGXsfl_8_fel_idx = 0 ;
         while ( nGXsfl_8_fel_idx < nRC_Grid1 )
         {
            nGXsfl_8_fel_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_8_fel_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_8_fel_idx+1)) ;
            sGXsfl_8_fel_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_8_fel_idx), 4, 0)), 4, "0") ;
            chkavSeleccion_Internalname = sPrefix+"vSELECCION_"+sGXsfl_8_fel_idx ;
            edtavDetalle_Internalname = sPrefix+"vDETALLE_"+sGXsfl_8_fel_idx ;
            edtavGttbus2_idmovimiento_Internalname = sPrefix+"vGTTBUS2_IDMOVIMIENTO_"+sGXsfl_8_fel_idx ;
            edtavGnumeroidentificador_Internalname = sPrefix+"vGNUMEROIDENTIFICADOR_"+sGXsfl_8_fel_idx ;
            edtavGttbus2_idbien_Internalname = sPrefix+"vGTTBUS2_IDBIEN_"+sGXsfl_8_fel_idx ;
            edtavGttbus2_codposhacia_Internalname = sPrefix+"vGTTBUS2_CODPOSHACIA_"+sGXsfl_8_fel_idx ;
            edtavHttbus3_des_Internalname = sPrefix+"vHTTBUS3_DES_"+sGXsfl_8_fel_idx ;
            edtavGttbus2_resphacia_Internalname = sPrefix+"vGTTBUS2_RESPHACIA_"+sGXsfl_8_fel_idx ;
            edtavHusu_des_Internalname = sPrefix+"vHUSU_DES_"+sGXsfl_8_fel_idx ;
            edtavGttbus2_fechaenvio_Internalname = sPrefix+"vGTTBUS2_FECHAENVIO_"+sGXsfl_8_fel_idx ;
            edtavGttbus2_motivoenvio_Internalname = sPrefix+"vGTTBUS2_MOTIVOENVIO_"+sGXsfl_8_fel_idx ;
            cmbavGttbus2_estadoenvio_Internalname = sPrefix+"vGTTBUS2_ESTADOENVIO_"+sGXsfl_8_fel_idx ;
            if ( ! context.localUtil.VCNumber( cgiGet( chkavSeleccion_Internalname), "9") || ( ((StringUtil.StrCmp(cgiGet( chkavSeleccion_Internalname), "1")==0) ? 1 : 0) < 0 ) || ( ( ((StringUtil.StrCmp(cgiGet( chkavSeleccion_Internalname), "1")==0) ? 1 : 0) > 9 ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vSELECCION");
               GX_FocusControl = chkavSeleccion_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV20seleccion = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV20seleccion", StringUtil.Str( (decimal)(AV20seleccion), 1, 0));
            }
            else
            {
               AV20seleccion = (short)(((StringUtil.StrCmp(cgiGet( chkavSeleccion_Internalname), "1")==0) ? 1 : 0)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV20seleccion", StringUtil.Str( (decimal)(AV20seleccion), 1, 0));
            }
            AV28detalle = cgiGet( "GXimg"+edtavDetalle_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDetalle_Internalname, "Bitmap", context.convertURL( AV28detalle));
            if ( ! context.localUtil.VCNumber( cgiGet( edtavGttbus2_idmovimiento_Internalname), "ZZZZZZZZZZZ9") || ( context.localUtil.CToN( cgiGet( edtavGttbus2_idmovimiento_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavGttbus2_idmovimiento_Internalname), ",", ".") > Convert.ToDecimal( 999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vGTTBUS2_IDMOVIMIENTO");
               GX_FocusControl = edtavGttbus2_idmovimiento_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV14gTTBUS2_IdMovimiento = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14gTTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14gTTBUS2_IdMovimiento), 12, 0)));
            }
            else
            {
               AV14gTTBUS2_IdMovimiento = (long)(context.localUtil.CToN( cgiGet( edtavGttbus2_idmovimiento_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14gTTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14gTTBUS2_IdMovimiento), 12, 0)));
            }
            AV29gNumeroIdentificador = cgiGet( edtavGnumeroidentificador_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV29gNumeroIdentificador", AV29gNumeroIdentificador);
            if ( ! context.localUtil.VCNumber( cgiGet( edtavGttbus2_idbien_Internalname), "ZZZZZZZ9") || ( context.localUtil.CToN( cgiGet( edtavGttbus2_idbien_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavGttbus2_idbien_Internalname), ",", ".") > Convert.ToDecimal( 99999999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vGTTBUS2_IDBIEN");
               GX_FocusControl = edtavGttbus2_idbien_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV13gTTBUS2_IdBien = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV13gTTBUS2_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13gTTBUS2_IdBien), 8, 0)));
            }
            else
            {
               AV13gTTBUS2_IdBien = (int)(context.localUtil.CToN( cgiGet( edtavGttbus2_idbien_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV13gTTBUS2_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13gTTBUS2_IdBien), 8, 0)));
            }
            if ( ! context.localUtil.VCNumber( cgiGet( edtavGttbus2_codposhacia_Internalname), "ZZ9") || ( context.localUtil.CToN( cgiGet( edtavGttbus2_codposhacia_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavGttbus2_codposhacia_Internalname), ",", ".") > Convert.ToDecimal( 999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vGTTBUS2_CODPOSHACIA");
               GX_FocusControl = edtavGttbus2_codposhacia_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV10gTTBUS2_CodPosHacia = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV10gTTBUS2_CodPosHacia", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10gTTBUS2_CodPosHacia), 3, 0)));
            }
            else
            {
               AV10gTTBUS2_CodPosHacia = (short)(context.localUtil.CToN( cgiGet( edtavGttbus2_codposhacia_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV10gTTBUS2_CodPosHacia", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10gTTBUS2_CodPosHacia), 3, 0)));
            }
            AV19hTTBUS3_Des = cgiGet( edtavHttbus3_des_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV19hTTBUS3_Des", AV19hTTBUS3_Des);
            AV18gTTBUS2_RespHacia = cgiGet( edtavGttbus2_resphacia_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV18gTTBUS2_RespHacia", AV18gTTBUS2_RespHacia);
            AV26hUSU_DES = StringUtil.Upper( cgiGet( edtavHusu_des_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV26hUSU_DES", AV26hUSU_DES);
            if ( context.localUtil.VCDateTime( cgiGet( edtavGttbus2_fechaenvio_Internalname), 4, 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"g TTBUS2_ Fecha Envio"}), 1, "vGTTBUS2_FECHAENVIO");
               GX_FocusControl = edtavGttbus2_fechaenvio_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV12gTTBUS2_FechaEnvio = (DateTime)(DateTime.MinValue) ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV12gTTBUS2_FechaEnvio", context.localUtil.TToC( AV12gTTBUS2_FechaEnvio, 10, 5, 0, 3, "/", ":", " "));
            }
            else
            {
               AV12gTTBUS2_FechaEnvio = context.localUtil.CToT( cgiGet( edtavGttbus2_fechaenvio_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV12gTTBUS2_FechaEnvio", context.localUtil.TToC( AV12gTTBUS2_FechaEnvio, 10, 5, 0, 3, "/", ":", " "));
            }
            AV15gTTBUS2_MotivoEnvio = StringUtil.Upper( cgiGet( edtavGttbus2_motivoenvio_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15gTTBUS2_MotivoEnvio", AV15gTTBUS2_MotivoEnvio);
            cmbavGttbus2_estadoenvio.Name = cmbavGttbus2_estadoenvio_Internalname ;
            cmbavGttbus2_estadoenvio.CurrentValue = cgiGet( cmbavGttbus2_estadoenvio_Internalname) ;
            AV11gTTBUS2_EstadoEnvio = (short)(NumberUtil.Val( cgiGet( cmbavGttbus2_estadoenvio_Internalname), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV11gTTBUS2_EstadoEnvio", StringUtil.Str( (decimal)(AV11gTTBUS2_EstadoEnvio), 1, 0));
            AV20seleccion = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV20seleccion", StringUtil.Str( (decimal)(AV20seleccion), 1, 0));
            /* End For Each Line */
         }
         if ( nGXsfl_8_fel_idx == 0 )
         {
            nGXsfl_8_idx = 1 ;
            sGXsfl_8_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_8_idx), 4, 0)), 4, "0") ;
            chkavSeleccion_Internalname = sPrefix+"vSELECCION_"+sGXsfl_8_idx ;
            edtavDetalle_Internalname = sPrefix+"vDETALLE_"+sGXsfl_8_idx ;
            edtavGttbus2_idmovimiento_Internalname = sPrefix+"vGTTBUS2_IDMOVIMIENTO_"+sGXsfl_8_idx ;
            edtavGnumeroidentificador_Internalname = sPrefix+"vGNUMEROIDENTIFICADOR_"+sGXsfl_8_idx ;
            edtavGttbus2_idbien_Internalname = sPrefix+"vGTTBUS2_IDBIEN_"+sGXsfl_8_idx ;
            edtavGttbus2_codposhacia_Internalname = sPrefix+"vGTTBUS2_CODPOSHACIA_"+sGXsfl_8_idx ;
            edtavHttbus3_des_Internalname = sPrefix+"vHTTBUS3_DES_"+sGXsfl_8_idx ;
            edtavGttbus2_resphacia_Internalname = sPrefix+"vGTTBUS2_RESPHACIA_"+sGXsfl_8_idx ;
            edtavHusu_des_Internalname = sPrefix+"vHUSU_DES_"+sGXsfl_8_idx ;
            edtavGttbus2_fechaenvio_Internalname = sPrefix+"vGTTBUS2_FECHAENVIO_"+sGXsfl_8_idx ;
            edtavGttbus2_motivoenvio_Internalname = sPrefix+"vGTTBUS2_MOTIVOENVIO_"+sGXsfl_8_idx ;
            cmbavGttbus2_estadoenvio_Internalname = sPrefix+"vGTTBUS2_ESTADOENVIO_"+sGXsfl_8_idx ;
         }
         nGXsfl_8_fel_idx = 1 ;
      }

      protected void wb_table1_2_1O2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            sStyleString = sStyleString + " height: " + StringUtil.LTrim( StringUtil.Str( (decimal)(104), 10, 0)) + "px" + ";" ;
            sStyleString = sStyleString + " width: " + StringUtil.LTrim( StringUtil.Str( (decimal)(600), 10, 0)) + "px" + ";" ;
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "left")+"\">") ;
            ClassString = "ErrorViewer" ;
            StyleString = "" ;
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, sPrefix, "false");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\"  style=\"height:182px\">") ;
            /*  Grid Control  */
            Grid1Container.SetWrapped(nGXWrapped);
            if ( Grid1Container.GetWrapped() == 1 )
            {
               sStyleString = "" ;
               GxWebStd.gx_table_start( context, subGrid1_Internalname, subGrid1_Internalname, "", "Grid", 0, "", "", 1, 2, sStyleString, "", 0);
               /* Subfile titles */
               context.WriteHtmlText( "<tr") ;
               context.WriteHtmlTextNl( ">") ;
               if ( subGrid1_Backcolorstyle == 0 )
               {
                  subGrid1_Titlebackstyle = 0 ;
                  if ( StringUtil.Len( subGrid1_Class) > 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Title" ;
                  }
               }
               else
               {
                  subGrid1_Titlebackstyle = 1 ;
                  if ( subGrid1_Backcolorstyle == 1 )
                  {
                     subGrid1_Titlebackcolor = subGrid1_Allbackcolor ;
                     if ( StringUtil.Len( subGrid1_Class) > 0 )
                     {
                        subGrid1_Linesclass = subGrid1_Class+"UniformTitle" ;
                     }
                  }
                  else
                  {
                     if ( StringUtil.Len( subGrid1_Class) > 0 )
                     {
                        subGrid1_Linesclass = subGrid1_Class+"Title" ;
                     }
                  }
               }
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "g TTBUS2_ Id Movimiento") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Nº Etiqueta") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Nº Bien") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "g TTBUS2_ Cod Pos Hacia") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Posición Recepción") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "g TTBUS2_ Resp Hacia") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Responsable Recepción") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Fecha Envío") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Motivo Envío") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Estado de Envío") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlTextNl( "</tr>") ;
            }
            else
            {
               Grid1Container.AddObjectProperty("GridName", "Grid1");
               Grid1Container.AddObjectProperty("Class", "Grid");
               Grid1Container.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Backcolorstyle), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("CmpContext", sPrefix);
               Grid1Container.AddObjectProperty("InMasterPage", "false");
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV20seleccion), 1, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", context.convertURL( AV28detalle));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14gTTBUS2_IdMovimiento), 12, 0, ".", "")));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavGttbus2_idmovimiento_Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( AV29gNumeroIdentificador));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavGnumeroidentificador_Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13gTTBUS2_IdBien), 8, 0, ".", "")));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavGttbus2_idbien_Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10gTTBUS2_CodPosHacia), 3, 0, ".", "")));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavGttbus2_codposhacia_Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( AV19hTTBUS3_Des));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavHttbus3_des_Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( AV18gTTBUS2_RespHacia));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavGttbus2_resphacia_Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( AV26hUSU_DES));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavHusu_des_Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", context.localUtil.Format(AV12gTTBUS2_FechaEnvio, "99/99/9999 99:99"));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavGttbus2_fechaenvio_Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( AV15gTTBUS2_MotivoEnvio));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavGttbus2_motivoenvio_Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11gTTBUS2_EstadoEnvio), 1, 0, ".", "")));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbavGttbus2_estadoenvio.Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Allowselection", "false");
               Grid1Container.AddObjectProperty("Allowcollapsing", "false");
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 9, 0, ".", "")));
            }
         }
         if ( wbEnd == 8 )
         {
            wbEnd = 0 ;
            nRC_Grid1 = (short)(nGXsfl_8_idx-1) ;
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
            }
            else
            {
               sStyleString = " style=\"display:none;\"" ;
               sStyleString = "" ;
               context.WriteHtmlText( "<div id=\""+sPrefix+"Grid1Container"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid(sPrefix+"_"+"Grid1", (Object)(Grid1Container));
               GxWebStd.gx_hidden_field( context, sPrefix+"Grid1ContainerData", Grid1Container.ToJavascriptSource());
               if ( context.isAjaxRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, sPrefix+"Grid1ContainerData"+"V", Grid1Container.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+sPrefix+"Grid1ContainerData"+"V"+"\" value='"+Grid1Container.GridValuesHidden()+"'>") ;
               }
            }
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"height:41px\">") ;
            wb_table2_23_1O2( true) ;
         }
         else
         {
            wb_table2_23_1O2( false) ;
         }
         return  ;
      }

      protected void wb_table2_23_1O2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"height:15px\">") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_1O2e( true) ;
         }
         else
         {
            wb_table1_2_1O2e( false) ;
         }
      }

      protected void wb_table2_23_1O2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable2_Internalname, tblTable2_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'" + sPrefix + "',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttButton1_Internalname, "Seleccionar Todos", "Seleccionar Todos", "", StyleString, ClassString, 1, 1, "rounded", 5, bttButton1_Jsonclick, sPrefix+"E\\'SELECCIONAR TODOS\\'.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(8), 3, 0)+","+"null"+");", "", "HLP_HTBUS003_.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'" + sPrefix + "',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtnrecibir_Internalname, "Cancelar Envío", "Cancelar Envío", "", StyleString, ClassString, 1, 1, "rounded", 5, bttBtnrecibir_Jsonclick, sPrefix+"E\\'CANCELAR ENVíO\\'.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(8), 3, 0)+","+"null"+");", "", "HLP_HTBUS003_.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_23_1O2e( true) ;
         }
         else
         {
            wb_table2_23_1O2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV25USUARIO = (String)getParm(obj,0) ;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV25USUARIO", AV25USUARIO);
         AV21SISTEMA = (String)getParm(obj,1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV21SISTEMA", AV21SISTEMA);
      }

      public override String getresponse( String sGXDynURL )
      {
         initialize_properties( ) ;
         BackMsgLst = context.GX_msglist ;
         context.GX_msglist = LclMsgLst ;
         sDynURL = sGXDynURL ;
         nGotPars = (short)(1) ;
         nGXWrapped = (short)(1) ;
         context.SetWrapped(true);
         PA1O2( ) ;
         WS1O2( ) ;
         WE1O2( ) ;
         this.cleanup();
         context.SetWrapped(false);
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst ;
         return "";
      }

      public void responsestatic( String sGXDynURL )
      {
      }

      public override void componentbind( Object[] obj )
      {
         if ( IsUrlCreated( ) )
         {
            return  ;
         }
         sCtrlAV25USUARIO = (String)((String)getParm(obj,0)) ;
         sCtrlAV21SISTEMA = (String)((String)getParm(obj,1)) ;
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix ;
         PA1O2( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false ;
         sCompPrefix = (String)getParm(obj,0) ;
         sSFPrefix = (String)getParm(obj,1) ;
         sPrefix = sCompPrefix + sSFPrefix ;
         AddComponentObject(sPrefix, "htbus003_");
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
         }
         PA1O2( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            AV25USUARIO = (String)getParm(obj,2) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV25USUARIO", AV25USUARIO);
            AV21SISTEMA = (String)getParm(obj,3) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV21SISTEMA", AV21SISTEMA);
         }
         wcpOAV25USUARIO = cgiGet( sPrefix+"wcpOAV25USUARIO") ;
         wcpOAV21SISTEMA = cgiGet( sPrefix+"wcpOAV21SISTEMA") ;
         if ( ! GetJustCreated( ) && ( ( StringUtil.StrCmp(AV25USUARIO, wcpOAV25USUARIO) != 0 ) || ( StringUtil.StrCmp(AV21SISTEMA, wcpOAV21SISTEMA) != 0 ) ) )
         {
            setjustcreated();
         }
         wcpOAV25USUARIO = AV25USUARIO ;
         wcpOAV21SISTEMA = AV21SISTEMA ;
      }

      protected void WCParametersGet( )
      {
         /* Read Component Parameters. */
         sCtrlAV25USUARIO = cgiGet( sPrefix+"AV25USUARIO_CTRL") ;
         if ( StringUtil.Len( sCtrlAV25USUARIO) > 0 )
         {
            AV25USUARIO = cgiGet( sCtrlAV25USUARIO) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV25USUARIO", AV25USUARIO);
         }
         else
         {
            AV25USUARIO = cgiGet( sPrefix+"AV25USUARIO_PARM") ;
         }
         sCtrlAV21SISTEMA = cgiGet( sPrefix+"AV21SISTEMA_CTRL") ;
         if ( StringUtil.Len( sCtrlAV21SISTEMA) > 0 )
         {
            AV21SISTEMA = cgiGet( sCtrlAV21SISTEMA) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV21SISTEMA", AV21SISTEMA);
         }
         else
         {
            AV21SISTEMA = cgiGet( sPrefix+"AV21SISTEMA_PARM") ;
         }
      }

      public override void componentprocess( String sPPrefix ,
                                             String sPSFPrefix ,
                                             String sCompEvt )
      {
         sCompPrefix = sPPrefix ;
         sSFPrefix = sPSFPrefix ;
         sPrefix = sCompPrefix + sSFPrefix ;
         BackMsgLst = context.GX_msglist ;
         context.GX_msglist = LclMsgLst ;
         INITWEB( ) ;
         nDraw = 0 ;
         PA1O2( ) ;
         sEvt = sCompEvt ;
         WCParametersGet( ) ;
         WS1O2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst ;
      }

      public override void componentstart( )
      {
         if ( nDoneStart == 0 )
         {
            WCStart( ) ;
         }
      }

      protected void WCStart( )
      {
         nDraw = 1 ;
         BackMsgLst = context.GX_msglist ;
         context.GX_msglist = LclMsgLst ;
         WS1O2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst ;
      }

      protected void WCParametersSet( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"AV25USUARIO_PARM", StringUtil.RTrim( AV25USUARIO));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlAV25USUARIO)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"AV25USUARIO_CTRL", StringUtil.RTrim( sCtrlAV25USUARIO));
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"AV21SISTEMA_PARM", StringUtil.RTrim( AV21SISTEMA));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlAV21SISTEMA)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"AV21SISTEMA_CTRL", StringUtil.RTrim( sCtrlAV21SISTEMA));
         }
      }

      public override void componentdraw( )
      {
         if ( nDoneStart == 0 )
         {
            WCStart( ) ;
         }
         BackMsgLst = context.GX_msglist ;
         context.GX_msglist = LclMsgLst ;
         WCParametersSet( ) ;
         WE1O2( ) ;
         this.cleanup();
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst ;
      }

      public override String getstring( String sGXControl )
      {
         String sCtrlName ;
         if ( StringUtil.StrCmp(StringUtil.Substring( sGXControl, 1, 1), "&") == 0 )
         {
            sCtrlName = StringUtil.Substring( sGXControl, 2, StringUtil.Len( sGXControl)-1) ;
         }
         else
         {
            sCtrlName = sGXControl ;
         }
         return cgiGet( sPrefix+"v"+StringUtil.Upper( sCtrlName)) ;
      }

      public override void componentjscripts( )
      {
         include_jscripts( ) ;
      }

      public override void componentthemes( )
      {
         define_styles( ) ;
      }

      protected void define_styles( )
      {
         AddStyleSheetFile("calendar-system.css", "?84120");
         AddThemeStyleSheetFile("", "Modern.css", "?2051812");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?19291340");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         if ( nGXWrapped != 1 )
         {
            context.AddJavascriptSource("htbus003_.js", "?19291340");
         }
         /* End function include_jscripts */
      }

      protected void sendrow_82( )
      {
         WB1O0( ) ;
         Grid1Row = GXWebRow.GetNew(context,Grid1Container) ;
         if ( subGrid1_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGrid1_Backstyle = 0 ;
            if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
            {
               subGrid1_Linesclass = subGrid1_Class+"Odd" ;
            }
         }
         else if ( subGrid1_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGrid1_Backstyle = 0 ;
            subGrid1_Backcolor = subGrid1_Allbackcolor ;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, sPrefix+"Grid1ContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid1_Backcolor), 9, 0)));
            if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
            {
               subGrid1_Linesclass = subGrid1_Class+"Uniform" ;
            }
         }
         else if ( subGrid1_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGrid1_Backstyle = 1 ;
            if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
            {
               subGrid1_Linesclass = subGrid1_Class+"Odd" ;
            }
            subGrid1_Backcolor = (int)(0xF0F0F0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, sPrefix+"Grid1ContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid1_Backcolor), 9, 0)));
         }
         else if ( subGrid1_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGrid1_Backstyle = 1 ;
            if ( ((int)(nGXsfl_8_idx) % (2)) == 0 )
            {
               subGrid1_Backcolor = (int)(0xE5E5E5) ;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, sPrefix+"Grid1ContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid1_Backcolor), 9, 0)));
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Even" ;
               }
            }
            else
            {
               subGrid1_Backcolor = (int)(0xF0F0F0) ;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, sPrefix+"Grid1ContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid1_Backcolor), 9, 0)));
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Odd" ;
               }
            }
         }
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<tr ") ;
            context.WriteHtmlText( " class=\""+subGrid1_Linesclass+"\" style=\""+""+"\"") ;
            context.WriteHtmlText( ">") ;
         }
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Check box */
         TempTags = " " + ((chkavSeleccion.Enabled!=0)&&(chkavSeleccion.Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 9,'"+sPrefix+"',false,'"+sGXsfl_8_idx+"',8)\"" : " ") ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         Grid1Row.AddColumnProperties("checkbox", 1, isAjaxCallMode( ), new Object[] {(String)chkavSeleccion_Internalname,StringUtil.Str( (decimal)(AV20seleccion), 1, 0),(String)"",(short)-1,(short)1,(String)"1",(String)"",(String)StyleString,(String)ClassString,TempTags+((chkavSeleccion.Enabled!=0)&&(chkavSeleccion.Visible!=0) ? " onclick=\"gx.fn.checkboxClick(9, this, 1, 0);gx.evt.onchange(this);\" " : " ")+((chkavSeleccion.Enabled!=0)&&(chkavSeleccion.Visible!=0) ? " onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(9);\"" : " ")});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Active Bitmap Variable */
         TempTags = " " + ((edtavDetalle_Enabled!=0)&&(edtavDetalle_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 10,'"+sPrefix+"',false,'',8)\"" : " ") ;
         ClassString = "Image" ;
         StyleString = "" ;
         Grid1Row.AddColumnProperties("bitmap", 2, isAjaxCallMode( ), new Object[] {(String)edtavDetalle_Internalname,(String)"",(String)AV28detalle,(String)"Modern",(short)-1,(short)1,(String)"",(String)"Ver Identificadores",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"",(short)0,(short)0,(String)"",(String)"",(short)7,(String)edtavDetalle_Jsonclick,(String)"'"+sPrefix+"'"+",false,"+"'"+"e151o2_client"+"'",(String)StyleString,(String)ClassString,(String)"",(String)""+TempTags,(String)"''",(String)""});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
         }
         /* Single line edit */
         TempTags = " " + ((edtavGttbus2_idmovimiento_Enabled!=0)&&(edtavGttbus2_idmovimiento_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 11,'"+sPrefix+"',false,'"+sGXsfl_8_idx+"',8)\"" : " ") ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavGttbus2_idmovimiento_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14gTTBUS2_IdMovimiento), 12, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)12,(short)0,(int)edtavGttbus2_idmovimiento_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(AV14gTTBUS2_IdMovimiento), "ZZZZZZZZZZZ9"),TempTags+((edtavGttbus2_idmovimiento_Enabled!=0)&&(edtavGttbus2_idmovimiento_Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((edtavGttbus2_idmovimiento_Enabled!=0)&&(edtavGttbus2_idmovimiento_Visible!=0) ? " onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(11);\"" : " "),(short)0,(String)edtavGttbus2_idmovimiento_Jsonclick,(String)"",(short)8,(short)1,(short)1,(bool)true,(String)"right"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         TempTags = " " + ((edtavGnumeroidentificador_Enabled!=0)&&(edtavGnumeroidentificador_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 12,'"+sPrefix+"',false,'"+sGXsfl_8_idx+"',8)\"" : " ") ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavGnumeroidentificador_Internalname,StringUtil.RTrim( AV29gNumeroIdentificador),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)80,(short)-1,(int)edtavGnumeroidentificador_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( AV29gNumeroIdentificador, "")),TempTags+((edtavGnumeroidentificador_Enabled!=0)&&(edtavGnumeroidentificador_Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((edtavGnumeroidentificador_Enabled!=0)&&(edtavGnumeroidentificador_Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(12);\"" : " "),(short)0,(String)edtavGnumeroidentificador_Jsonclick,(String)"",(short)8,(short)1,(short)1,(bool)true,(String)"left"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         TempTags = " " + ((edtavGttbus2_idbien_Enabled!=0)&&(edtavGttbus2_idbien_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 13,'"+sPrefix+"',false,'"+sGXsfl_8_idx+"',8)\"" : " ") ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavGttbus2_idbien_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13gTTBUS2_IdBien), 8, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)8,(short)-1,(int)edtavGttbus2_idbien_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(AV13gTTBUS2_IdBien), "ZZZZZZZ9"),TempTags+((edtavGttbus2_idbien_Enabled!=0)&&(edtavGttbus2_idbien_Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((edtavGttbus2_idbien_Enabled!=0)&&(edtavGttbus2_idbien_Visible!=0) ? " onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(13);\"" : " "),(short)0,(String)edtavGttbus2_idbien_Jsonclick,(String)"",(short)8,(short)1,(short)1,(bool)true,(String)"right"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
         }
         /* Single line edit */
         TempTags = " " + ((edtavGttbus2_codposhacia_Enabled!=0)&&(edtavGttbus2_codposhacia_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 14,'"+sPrefix+"',false,'"+sGXsfl_8_idx+"',8)\"" : " ") ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavGttbus2_codposhacia_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10gTTBUS2_CodPosHacia), 3, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)3,(short)0,(int)edtavGttbus2_codposhacia_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(AV10gTTBUS2_CodPosHacia), "ZZ9"),TempTags+((edtavGttbus2_codposhacia_Enabled!=0)&&(edtavGttbus2_codposhacia_Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((edtavGttbus2_codposhacia_Enabled!=0)&&(edtavGttbus2_codposhacia_Visible!=0) ? " onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(14);\"" : " "),(short)0,(String)edtavGttbus2_codposhacia_Jsonclick,(String)"",(short)8,(short)1,(short)1,(bool)true,(String)"right"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         TempTags = " " + ((edtavHttbus3_des_Enabled!=0)&&(edtavHttbus3_des_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 15,'"+sPrefix+"',false,'"+sGXsfl_8_idx+"',8)\"" : " ") ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavHttbus3_des_Internalname,StringUtil.RTrim( AV19hTTBUS3_Des),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)50,(short)-1,(int)edtavHttbus3_des_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( AV19hTTBUS3_Des, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")),TempTags+((edtavHttbus3_des_Enabled!=0)&&(edtavHttbus3_des_Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((edtavHttbus3_des_Enabled!=0)&&(edtavHttbus3_des_Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(15);\"" : " "),(short)0,(String)edtavHttbus3_des_Jsonclick,(String)"",(short)8,(short)1,(short)1,(bool)true,(String)"left"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
         }
         /* Single line edit */
         TempTags = " " + ((edtavGttbus2_resphacia_Enabled!=0)&&(edtavGttbus2_resphacia_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 16,'"+sPrefix+"',false,'"+sGXsfl_8_idx+"',8)\"" : " ") ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavGttbus2_resphacia_Internalname,StringUtil.RTrim( AV18gTTBUS2_RespHacia),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)15,(short)0,(int)edtavGttbus2_resphacia_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( AV18gTTBUS2_RespHacia, "XXXXXXXXXXXXXXX")),TempTags+((edtavGttbus2_resphacia_Enabled!=0)&&(edtavGttbus2_resphacia_Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((edtavGttbus2_resphacia_Enabled!=0)&&(edtavGttbus2_resphacia_Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(16);\"" : " "),(short)0,(String)edtavGttbus2_resphacia_Jsonclick,(String)"",(short)8,(short)1,(short)1,(bool)true,(String)"left"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         TempTags = " " + ((edtavHusu_des_Enabled!=0)&&(edtavHusu_des_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 17,'"+sPrefix+"',false,'"+sGXsfl_8_idx+"',8)\"" : " ") ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavHusu_des_Internalname,StringUtil.RTrim( AV26hUSU_DES),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)50,(short)-1,(int)edtavHusu_des_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( AV26hUSU_DES, "@!")),TempTags+((edtavHusu_des_Enabled!=0)&&(edtavHusu_des_Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((edtavHusu_des_Enabled!=0)&&(edtavHusu_des_Visible!=0) ? " onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(17);\"" : " "),(short)0,(String)edtavHusu_des_Jsonclick,(String)"",(short)8,(short)1,(short)1,(bool)true,(String)"left"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         TempTags = " " + ((edtavGttbus2_fechaenvio_Enabled!=0)&&(edtavGttbus2_fechaenvio_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 18,'"+sPrefix+"',false,'"+sGXsfl_8_idx+"',8)\"" : " ") ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavGttbus2_fechaenvio_Internalname,context.localUtil.Format(AV12gTTBUS2_FechaEnvio, "99/99/9999 99:99"),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)16,(short)-1,(int)edtavGttbus2_fechaenvio_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( AV12gTTBUS2_FechaEnvio, "99/99/9999 99:99"),TempTags+((edtavGttbus2_fechaenvio_Enabled!=0)&&(edtavGttbus2_fechaenvio_Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((edtavGttbus2_fechaenvio_Enabled!=0)&&(edtavGttbus2_fechaenvio_Visible!=0) ? " onblur=\""+"gx.date.valid_date(this, 10,'DMY',5,24,'spa',false,0);"+";gx.evt.onblur(18);\"" : " "),(short)0,(String)edtavGttbus2_fechaenvio_Jsonclick,(String)"",(short)8,(short)1,(short)1,(bool)true,(String)"right"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         TempTags = " " + ((edtavGttbus2_motivoenvio_Enabled!=0)&&(edtavGttbus2_motivoenvio_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 19,'"+sPrefix+"',false,'"+sGXsfl_8_idx+"',8)\"" : " ") ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavGttbus2_motivoenvio_Internalname,StringUtil.RTrim( AV15gTTBUS2_MotivoEnvio),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)100,(short)-1,(int)edtavGttbus2_motivoenvio_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( AV15gTTBUS2_MotivoEnvio, "@!")),TempTags+((edtavGttbus2_motivoenvio_Enabled!=0)&&(edtavGttbus2_motivoenvio_Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((edtavGttbus2_motivoenvio_Enabled!=0)&&(edtavGttbus2_motivoenvio_Visible!=0) ? " onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(19);\"" : " "),(short)0,(String)edtavGttbus2_motivoenvio_Jsonclick,(String)"",(short)8,(short)1,(short)0,(bool)true,(String)"left"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         ClassString = "Attribute" ;
         StyleString = "" ;
         TempTags = " " + ((cmbavGttbus2_estadoenvio.Enabled!=0)&&(cmbavGttbus2_estadoenvio.Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 20,'"+sPrefix+"',false,'"+sGXsfl_8_idx+"',8)\"" : " ") ;
         if ( ( nGXsfl_8_idx == 1 ) && isAjaxCallMode( ) )
         {
            GXCCtl = "vGTTBUS2_ESTADOENVIO_" + sGXsfl_8_idx ;
            cmbavGttbus2_estadoenvio.Name = GXCCtl ;
            cmbavGttbus2_estadoenvio.WebTags = "" ;
            cmbavGttbus2_estadoenvio.addItem("1", "No Finalizado", 0);
            cmbavGttbus2_estadoenvio.addItem("2", "Finalizado", 0);
            cmbavGttbus2_estadoenvio.addItem("3", "Cancelado", 0);
            if ( ( cmbavGttbus2_estadoenvio.ItemCount > 0 ) && (0==AV11gTTBUS2_EstadoEnvio) )
            {
               AV11gTTBUS2_EstadoEnvio = (short)(NumberUtil.Val( cmbavGttbus2_estadoenvio.getItemValue(1), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV11gTTBUS2_EstadoEnvio", StringUtil.Str( (decimal)(AV11gTTBUS2_EstadoEnvio), 1, 0));
            }
         }
         /* ComboBox */
         Grid1Row.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbavGttbus2_estadoenvio,(String)cmbavGttbus2_estadoenvio_Internalname,StringUtil.Str( (decimal)(AV11gTTBUS2_EstadoEnvio), 1, 0),(String)"",(String)"int",(short)-1,cmbavGttbus2_estadoenvio.Enabled,(short)0,(short)1,(short)0,(short)0,(String)"px",(short)0,(String)"",(String)StyleString,(String)ClassString,(String)"",(short)0,(String)cmbavGttbus2_estadoenvio_Jsonclick,(String)"",TempTags+((cmbavGttbus2_estadoenvio.Enabled!=0)&&(cmbavGttbus2_estadoenvio.Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((cmbavGttbus2_estadoenvio.Enabled!=0)&&(cmbavGttbus2_estadoenvio.Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(20);\"" : " "),(bool)true});
         cmbavGttbus2_estadoenvio.CurrentValue = StringUtil.Str( (decimal)(AV11gTTBUS2_EstadoEnvio), 1, 0) ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbavGttbus2_estadoenvio_Internalname, "Values", (String)(cmbavGttbus2_estadoenvio.ToJavascriptSource()));
         Grid1Container.AddRow(Grid1Row);
         nGXsfl_8_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_8_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_8_idx+1)) ;
         sGXsfl_8_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_8_idx), 4, 0)), 4, "0") ;
         chkavSeleccion_Internalname = sPrefix+"vSELECCION_"+sGXsfl_8_idx ;
         edtavDetalle_Internalname = sPrefix+"vDETALLE_"+sGXsfl_8_idx ;
         edtavGttbus2_idmovimiento_Internalname = sPrefix+"vGTTBUS2_IDMOVIMIENTO_"+sGXsfl_8_idx ;
         edtavGnumeroidentificador_Internalname = sPrefix+"vGNUMEROIDENTIFICADOR_"+sGXsfl_8_idx ;
         edtavGttbus2_idbien_Internalname = sPrefix+"vGTTBUS2_IDBIEN_"+sGXsfl_8_idx ;
         edtavGttbus2_codposhacia_Internalname = sPrefix+"vGTTBUS2_CODPOSHACIA_"+sGXsfl_8_idx ;
         edtavHttbus3_des_Internalname = sPrefix+"vHTTBUS3_DES_"+sGXsfl_8_idx ;
         edtavGttbus2_resphacia_Internalname = sPrefix+"vGTTBUS2_RESPHACIA_"+sGXsfl_8_idx ;
         edtavHusu_des_Internalname = sPrefix+"vHUSU_DES_"+sGXsfl_8_idx ;
         edtavGttbus2_fechaenvio_Internalname = sPrefix+"vGTTBUS2_FECHAENVIO_"+sGXsfl_8_idx ;
         edtavGttbus2_motivoenvio_Internalname = sPrefix+"vGTTBUS2_MOTIVOENVIO_"+sGXsfl_8_idx ;
         cmbavGttbus2_estadoenvio_Internalname = sPrefix+"vGTTBUS2_ESTADOENVIO_"+sGXsfl_8_idx ;
         /* End function sendrow_82 */
      }

      protected void init_default_properties( )
      {
         bttButton1_Internalname = sPrefix+"BUTTON1" ;
         bttBtnrecibir_Internalname = sPrefix+"BTNRECIBIR" ;
         tblTable2_Internalname = sPrefix+"TABLE2" ;
         tblTable1_Internalname = sPrefix+"TABLE1" ;
         Form.Internalname = sPrefix+"FORM" ;
         subGrid1_Internalname = sPrefix+"GRID1" ;
      }

      protected void initialize_properties( )
      {
         init_default_properties( ) ;
         cmbavGttbus2_estadoenvio_Jsonclick = "" ;
         cmbavGttbus2_estadoenvio.Visible = -1 ;
         edtavGttbus2_motivoenvio_Jsonclick = "" ;
         edtavGttbus2_motivoenvio_Visible = -1 ;
         edtavGttbus2_fechaenvio_Jsonclick = "" ;
         edtavGttbus2_fechaenvio_Visible = -1 ;
         edtavHusu_des_Jsonclick = "" ;
         edtavHusu_des_Visible = -1 ;
         edtavGttbus2_resphacia_Jsonclick = "" ;
         edtavGttbus2_resphacia_Visible = 0 ;
         edtavHttbus3_des_Jsonclick = "" ;
         edtavHttbus3_des_Visible = -1 ;
         edtavGttbus2_codposhacia_Jsonclick = "" ;
         edtavGttbus2_codposhacia_Visible = 0 ;
         edtavGttbus2_idbien_Jsonclick = "" ;
         edtavGttbus2_idbien_Visible = -1 ;
         edtavGnumeroidentificador_Jsonclick = "" ;
         edtavGnumeroidentificador_Visible = -1 ;
         edtavGttbus2_idmovimiento_Jsonclick = "" ;
         edtavGttbus2_idmovimiento_Visible = 0 ;
         edtavDetalle_Jsonclick = "" ;
         edtavDetalle_Visible = -1 ;
         edtavDetalle_Enabled = 1 ;
         chkavSeleccion.Visible = -1 ;
         chkavSeleccion.Enabled = 1 ;
         cmbavGttbus2_estadoenvio.Enabled = 1 ;
         edtavGttbus2_motivoenvio_Enabled = 1 ;
         edtavGttbus2_fechaenvio_Enabled = 1 ;
         edtavHusu_des_Enabled = 1 ;
         edtavGttbus2_resphacia_Enabled = 1 ;
         edtavHttbus3_des_Enabled = 1 ;
         edtavGttbus2_codposhacia_Enabled = 1 ;
         edtavGttbus2_idbien_Enabled = 1 ;
         edtavGnumeroidentificador_Enabled = 1 ;
         edtavGttbus2_idmovimiento_Enabled = 1 ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 3 ;
         chkavSeleccion.Caption = "" ;
         context.GX_msglist.DisplayMode = 1 ;
      }

      protected void cleanup( )
      {
         flushBuffer();
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         wcpOAV25USUARIO = "" ;
         wcpOAV21SISTEMA = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         sPrefix = "" ;
         A47TTBUS2_MotivoEnvio = "" ;
         edtavGttbus2_idmovimiento_Internalname = "" ;
         edtavGnumeroidentificador_Internalname = "" ;
         edtavGttbus2_idbien_Internalname = "" ;
         edtavGttbus2_codposhacia_Internalname = "" ;
         edtavHttbus3_des_Internalname = "" ;
         edtavGttbus2_resphacia_Internalname = "" ;
         edtavHusu_des_Internalname = "" ;
         edtavGttbus2_fechaenvio_Internalname = "" ;
         edtavGttbus2_motivoenvio_Internalname = "" ;
         cmbavGttbus2_estadoenvio_Internalname = "" ;
         GXCCtl = "" ;
         chkavSeleccion_Internalname = "" ;
         A102TTBUS2_TipoResp = "" ;
         A53TTBUS2_IdUsuario = "" ;
         A45TTBUS2_FechaEnvio = (DateTime)(DateTime.MinValue) ;
         A7USU_DES = "" ;
         A6USU_COD = "" ;
         A25TTBUS2_RespHacia = "" ;
         A34TTBUS7_Des = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char1 = "" ;
         GXt_char2 = "" ;
         GXt_char3 = "" ;
         GXt_char4 = "" ;
         GXt_char5 = "" ;
         GXt_char6 = "" ;
         GX_FocusControl = "" ;
         Form = new GXWebForm();
         sXEvt = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         edtavDetalle_Internalname = "" ;
         AV28detalle = "" ;
         AV29gNumeroIdentificador = "" ;
         AV19hTTBUS3_Des = "" ;
         AV18gTTBUS2_RespHacia = "" ;
         AV26hUSU_DES = "" ;
         AV12gTTBUS2_FechaEnvio = (DateTime)(DateTime.MinValue) ;
         AV15gTTBUS2_MotivoEnvio = "" ;
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxwrpcisep = "" ;
         scmdbuf = "" ;
         l47TTBUS2_MotivoEnvio = "" ;
         H001O2_A47TTBUS2_MotivoEnvio = new String[] {""} ;
         Grid1Container = new GXWebGrid( context);
         H001O3_A25TTBUS2_RespHacia = new String[] {""} ;
         H001O3_A49TTBUS2_CodPosHacia = new short[1] ;
         H001O3_A26TTBUS2_EstadoEnvio = new short[1] ;
         H001O3_A24TTBUS2_RespDesde = new String[] {""} ;
         H001O3_A22TTBUS2_IdBien = new int[1] ;
         H001O3_A45TTBUS2_FechaEnvio = new DateTime[] {DateTime.MinValue} ;
         H001O3_A47TTBUS2_MotivoEnvio = new String[] {""} ;
         H001O3_A52TTBUS2_IdMovimiento = new long[1] ;
         A24TTBUS2_RespDesde = "" ;
         H001O4_A33TTBUS7_Pos = new short[1] ;
         H001O4_A34TTBUS7_Des = new String[] {""} ;
         H001O4_n34TTBUS7_Des = new bool[] {false} ;
         H001O5_A6USU_COD = new String[] {""} ;
         H001O5_A7USU_DES = new String[] {""} ;
         H001O6_A53TTBUS2_IdUsuario = new String[] {""} ;
         H001O6_A26TTBUS2_EstadoEnvio = new short[1] ;
         H001O6_A52TTBUS2_IdMovimiento = new long[1] ;
         H001O6_A22TTBUS2_IdBien = new int[1] ;
         H001O6_A49TTBUS2_CodPosHacia = new short[1] ;
         H001O6_A25TTBUS2_RespHacia = new String[] {""} ;
         H001O6_A45TTBUS2_FechaEnvio = new DateTime[] {DateTime.MinValue} ;
         H001O6_A47TTBUS2_MotivoEnvio = new String[] {""} ;
         H001O6_A102TTBUS2_TipoResp = new String[] {""} ;
         H001O7_A33TTBUS7_Pos = new short[1] ;
         H001O7_A34TTBUS7_Des = new String[] {""} ;
         H001O7_n34TTBUS7_Des = new bool[] {false} ;
         H001O8_A6USU_COD = new String[] {""} ;
         H001O8_A7USU_DES = new String[] {""} ;
         H001O9_A11TTBUS_Id = new int[1] ;
         H001O9_A12TTBUS_Descripcion = new String[] {""} ;
         A12TTBUS_Descripcion = "" ;
         AV22TTBUS_Descripcion = "" ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         subGrid1_Linesclass = "" ;
         GXt_char16 = "" ;
         GXt_char15 = "" ;
         GXt_char14 = "" ;
         GXt_char13 = "" ;
         GXt_char12 = "" ;
         GXt_char11 = "" ;
         GXt_char10 = "" ;
         GXt_char9 = "" ;
         GXt_char8 = "" ;
         GXt_char7 = "" ;
         Grid1Column = new GXWebColumn();
         GXt_char17 = "" ;
         TempTags = "" ;
         bttButton1_Jsonclick = "" ;
         bttBtnrecibir_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlAV25USUARIO = "" ;
         sCtrlAV21SISTEMA = "" ;
         Grid1Row = new GXWebRow();
         ROClassString = "" ;
         GXt_char18 = "" ;
         GXt_char19 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.htbus003___default(),
            new Object[][] {
                new Object[] {
               H001O2_A47TTBUS2_MotivoEnvio
               }
               , new Object[] {
               H001O3_A25TTBUS2_RespHacia, H001O3_A49TTBUS2_CodPosHacia, H001O3_A26TTBUS2_EstadoEnvio, H001O3_A24TTBUS2_RespDesde, H001O3_A22TTBUS2_IdBien, H001O3_A45TTBUS2_FechaEnvio, H001O3_A47TTBUS2_MotivoEnvio, H001O3_A52TTBUS2_IdMovimiento
               }
               , new Object[] {
               H001O4_A33TTBUS7_Pos, H001O4_A34TTBUS7_Des, H001O4_n34TTBUS7_Des
               }
               , new Object[] {
               H001O5_A6USU_COD, H001O5_A7USU_DES
               }
               , new Object[] {
               H001O6_A53TTBUS2_IdUsuario, H001O6_A26TTBUS2_EstadoEnvio, H001O6_A52TTBUS2_IdMovimiento, H001O6_A22TTBUS2_IdBien, H001O6_A49TTBUS2_CodPosHacia, H001O6_A25TTBUS2_RespHacia, H001O6_A45TTBUS2_FechaEnvio, H001O6_A47TTBUS2_MotivoEnvio, H001O6_A102TTBUS2_TipoResp
               }
               , new Object[] {
               H001O7_A33TTBUS7_Pos, H001O7_A34TTBUS7_Des, H001O7_n34TTBUS7_Des
               }
               , new Object[] {
               H001O8_A6USU_COD, H001O8_A7USU_DES
               }
               , new Object[] {
               H001O9_A11TTBUS_Id, H001O9_A12TTBUS_Descripcion
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
         edtavGttbus2_idmovimiento_Enabled = 0 ;
         edtavGnumeroidentificador_Enabled = 0 ;
         edtavGttbus2_idbien_Enabled = 0 ;
         edtavGttbus2_codposhacia_Enabled = 0 ;
         edtavHttbus3_des_Enabled = 0 ;
         edtavGttbus2_resphacia_Enabled = 0 ;
         edtavHusu_des_Enabled = 0 ;
         edtavGttbus2_fechaenvio_Enabled = 0 ;
         edtavGttbus2_motivoenvio_Enabled = 0 ;
         cmbavGttbus2_estadoenvio.Enabled = 0 ;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nDynComponent ;
      private short nRC_Grid1 ;
      private short nGXsfl_8_idx=1 ;
      private short AV11gTTBUS2_EstadoEnvio ;
      private short A26TTBUS2_EstadoEnvio ;
      private short A33TTBUS7_Pos ;
      private short A49TTBUS2_CodPosHacia ;
      private short initialized ;
      private short nGXWrapped ;
      private short wbEnd ;
      private short wbStart ;
      private short nDraw ;
      private short nDoneStart ;
      private short AV20seleccion ;
      private short AV10gTTBUS2_CodPosHacia ;
      private short nDonePA ;
      private short nGXsfl_8_fel_idx=1 ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short subGrid1_Collapsed ;
      private short subGrid1_Backstyle ;
      private int edtavGttbus2_idmovimiento_Enabled ;
      private int edtavGnumeroidentificador_Enabled ;
      private int edtavGttbus2_idbien_Enabled ;
      private int edtavGttbus2_codposhacia_Enabled ;
      private int edtavHttbus3_des_Enabled ;
      private int edtavGttbus2_resphacia_Enabled ;
      private int edtavHusu_des_Enabled ;
      private int edtavGttbus2_fechaenvio_Enabled ;
      private int edtavGttbus2_motivoenvio_Enabled ;
      private int A22TTBUS2_IdBien ;
      private int AV13gTTBUS2_IdBien ;
      private int gxdynajaxindex ;
      private int subGrid1_Islastpage ;
      private int A11TTBUS_Id ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private int edtavDetalle_Enabled ;
      private int edtavDetalle_Visible ;
      private int edtavGttbus2_idmovimiento_Visible ;
      private int edtavGnumeroidentificador_Visible ;
      private int edtavGttbus2_idbien_Visible ;
      private int edtavGttbus2_codposhacia_Visible ;
      private int edtavHttbus3_des_Visible ;
      private int edtavGttbus2_resphacia_Visible ;
      private int edtavHusu_des_Visible ;
      private int edtavGttbus2_fechaenvio_Visible ;
      private int edtavGttbus2_motivoenvio_Visible ;
      private long A52TTBUS2_IdMovimiento ;
      private long AV14gTTBUS2_IdMovimiento ;
      private long AV23TTBUS2_IdMovimiento ;
      private String AV25USUARIO ;
      private String AV21SISTEMA ;
      private String wcpOAV25USUARIO ;
      private String wcpOAV21SISTEMA ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sPrefix ;
      private String sCompPrefix ;
      private String sSFPrefix ;
      private String sGXsfl_8_idx="0001" ;
      private String edtavGttbus2_idmovimiento_Internalname ;
      private String edtavGnumeroidentificador_Internalname ;
      private String edtavGttbus2_idbien_Internalname ;
      private String edtavGttbus2_codposhacia_Internalname ;
      private String edtavHttbus3_des_Internalname ;
      private String edtavGttbus2_resphacia_Internalname ;
      private String edtavHusu_des_Internalname ;
      private String edtavGttbus2_fechaenvio_Internalname ;
      private String edtavGttbus2_motivoenvio_Internalname ;
      private String cmbavGttbus2_estadoenvio_Internalname ;
      private String GXCCtl ;
      private String chkavSeleccion_Internalname ;
      private String A102TTBUS2_TipoResp ;
      private String A53TTBUS2_IdUsuario ;
      private String A7USU_DES ;
      private String A6USU_COD ;
      private String A25TTBUS2_RespHacia ;
      private String A34TTBUS7_Des ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char1 ;
      private String GXt_char2 ;
      private String GXt_char3 ;
      private String GXt_char4 ;
      private String GXt_char5 ;
      private String GXt_char6 ;
      private String GX_FocusControl ;
      private String sXEvt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavDetalle_Internalname ;
      private String AV19hTTBUS3_Des ;
      private String AV18gTTBUS2_RespHacia ;
      private String AV26hUSU_DES ;
      private String gxwrpcisep ;
      private String scmdbuf ;
      private String A24TTBUS2_RespDesde ;
      private String sGXsfl_8_fel_idx="0001" ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String subGrid1_Internalname ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String GXt_char16 ;
      private String GXt_char15 ;
      private String GXt_char14 ;
      private String GXt_char13 ;
      private String GXt_char12 ;
      private String GXt_char11 ;
      private String GXt_char10 ;
      private String GXt_char9 ;
      private String GXt_char8 ;
      private String GXt_char7 ;
      private String GXt_char17 ;
      private String tblTable2_Internalname ;
      private String TempTags ;
      private String bttButton1_Internalname ;
      private String bttButton1_Jsonclick ;
      private String bttBtnrecibir_Internalname ;
      private String bttBtnrecibir_Jsonclick ;
      private String sCtrlAV25USUARIO ;
      private String sCtrlAV21SISTEMA ;
      private String edtavDetalle_Jsonclick ;
      private String ROClassString ;
      private String edtavGttbus2_idmovimiento_Jsonclick ;
      private String edtavGnumeroidentificador_Jsonclick ;
      private String edtavGttbus2_idbien_Jsonclick ;
      private String edtavGttbus2_codposhacia_Jsonclick ;
      private String edtavHttbus3_des_Jsonclick ;
      private String edtavGttbus2_resphacia_Jsonclick ;
      private String edtavHusu_des_Jsonclick ;
      private String edtavGttbus2_fechaenvio_Jsonclick ;
      private String edtavGttbus2_motivoenvio_Jsonclick ;
      private String cmbavGttbus2_estadoenvio_Jsonclick ;
      private String GXt_char18 ;
      private String GXt_char19 ;
      private DateTime A45TTBUS2_FechaEnvio ;
      private DateTime AV12gTTBUS2_FechaEnvio ;
      private bool entryPointCalled ;
      private bool n34TTBUS7_Des ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private bool BRK1O6 ;
      private String A47TTBUS2_MotivoEnvio ;
      private String AV29gNumeroIdentificador ;
      private String AV15gTTBUS2_MotivoEnvio ;
      private String l47TTBUS2_MotivoEnvio ;
      private String A12TTBUS_Descripcion ;
      private String AV22TTBUS_Descripcion ;
      private String AV28detalle ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private String aP0_USUARIO ;
      private String aP1_SISTEMA ;
      private GXCheckbox chkavSeleccion ;
      private GXCombobox cmbavGttbus2_estadoenvio ;
      private IDataStoreProvider pr_default ;
      private String[] H001O2_A47TTBUS2_MotivoEnvio ;
      private String[] H001O3_A25TTBUS2_RespHacia ;
      private short[] H001O3_A49TTBUS2_CodPosHacia ;
      private short[] H001O3_A26TTBUS2_EstadoEnvio ;
      private String[] H001O3_A24TTBUS2_RespDesde ;
      private int[] H001O3_A22TTBUS2_IdBien ;
      private DateTime[] H001O3_A45TTBUS2_FechaEnvio ;
      private String[] H001O3_A47TTBUS2_MotivoEnvio ;
      private long[] H001O3_A52TTBUS2_IdMovimiento ;
      private short[] H001O4_A33TTBUS7_Pos ;
      private String[] H001O4_A34TTBUS7_Des ;
      private bool[] H001O4_n34TTBUS7_Des ;
      private String[] H001O5_A6USU_COD ;
      private String[] H001O5_A7USU_DES ;
      private String[] H001O6_A53TTBUS2_IdUsuario ;
      private short[] H001O6_A26TTBUS2_EstadoEnvio ;
      private long[] H001O6_A52TTBUS2_IdMovimiento ;
      private int[] H001O6_A22TTBUS2_IdBien ;
      private short[] H001O6_A49TTBUS2_CodPosHacia ;
      private String[] H001O6_A25TTBUS2_RespHacia ;
      private DateTime[] H001O6_A45TTBUS2_FechaEnvio ;
      private String[] H001O6_A47TTBUS2_MotivoEnvio ;
      private String[] H001O6_A102TTBUS2_TipoResp ;
      private short[] H001O7_A33TTBUS7_Pos ;
      private String[] H001O7_A34TTBUS7_Des ;
      private bool[] H001O7_n34TTBUS7_Des ;
      private String[] H001O8_A6USU_COD ;
      private String[] H001O8_A7USU_DES ;
      private int[] H001O9_A11TTBUS_Id ;
      private String[] H001O9_A12TTBUS_Descripcion ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
   }

   public class htbus003___default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new ForEachCursor(def[3])
         ,new ForEachCursor(def[4])
         ,new ForEachCursor(def[5])
         ,new ForEachCursor(def[6])
         ,new ForEachCursor(def[7])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH001O2 ;
          prmH001O2 = new Object[] {
          new Object[] {"@TTBUS2_MotivoEnvio",SqlDbType.VarChar,100,0}
          } ;
          Object[] prmH001O3 ;
          prmH001O3 = new Object[] {
          new Object[] {"@AV25USUARIO",SqlDbType.Char,16,0}
          } ;
          Object[] prmH001O4 ;
          prmH001O4 = new Object[] {
          new Object[] {"@TTBUS2_CodPosHacia",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmH001O5 ;
          prmH001O5 = new Object[] {
          new Object[] {"@TTBUS2_RespHacia",SqlDbType.Char,15,0}
          } ;
          Object[] prmH001O6 ;
          prmH001O6 = new Object[] {
          new Object[] {"@AV25USUARIO",SqlDbType.Char,16,0}
          } ;
          Object[] prmH001O7 ;
          prmH001O7 = new Object[] {
          new Object[] {"@TTBUS2_CodPosHacia",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmH001O8 ;
          prmH001O8 = new Object[] {
          new Object[] {"@TTBUS2_RespHacia",SqlDbType.Char,15,0}
          } ;
          Object[] prmH001O9 ;
          prmH001O9 = new Object[] {
          new Object[] {"@AV13gTTBUS2_IdBien",SqlDbType.Int,8,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H001O2", "SELECT DISTINCT TOP 5 [TTBUS2_MotivoEnvio] FROM [TTBUS002] WITH (NOLOCK) WHERE UPPER(CAST([TTBUS2_MotivoEnvio] AS char(100))) like UPPER(CAST(@TTBUS2_MotivoEnvio AS char(100))) ORDER BY [TTBUS2_MotivoEnvio] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001O2,0,0,true,false )
             ,new CursorDef("H001O3", "SELECT [TTBUS2_RespHacia], [TTBUS2_CodPosHacia], [TTBUS2_EstadoEnvio], [TTBUS2_RespDesde], [TTBUS2_IdBien], [TTBUS2_FechaEnvio], [TTBUS2_MotivoEnvio], [TTBUS2_IdMovimiento] FROM [TTBUS002] WITH (NOLOCK) WHERE ([TTBUS2_RespDesde] = @AV25USUARIO) AND ([TTBUS2_EstadoEnvio] = 1) ORDER BY [TTBUS2_IdMovimiento] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001O3,100,0,true,false )
             ,new CursorDef("H001O4", "SELECT T1.[TTBUS7_Pos] AS TTBUS7_Pos, T2.[W53DES] AS TTBUS7_Des FROM ([TTBUS007] T1 WITH (NOLOCK) INNER JOIN [T53FPOS] T2 WITH (NOLOCK) ON T2.[W53POS] = T1.[TTBUS7_Pos]) WHERE T1.[TTBUS7_Pos] = @TTBUS2_CodPosHacia ORDER BY T1.[TTBUS7_Pos] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001O4,1,0,false,true )
             ,new CursorDef("H001O5", "SELECT [USU_COD], [USU_DES] FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @TTBUS2_RespHacia ORDER BY [USU_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001O5,1,0,false,true )
             ,new CursorDef("H001O6", "SELECT T1.[TTBUS2_IdUsuario], T2.[TTBUS2_EstadoEnvio], T1.[TTBUS2_IdMovimiento], T2.[TTBUS2_IdBien], T2.[TTBUS2_CodPosHacia], T2.[TTBUS2_RespHacia], T2.[TTBUS2_FechaEnvio], T2.[TTBUS2_MotivoEnvio], T1.[TTBUS2_TipoResp] FROM ([TTBUS002_Det] T1 WITH (NOLOCK) INNER JOIN [TTBUS002] T2 WITH (NOLOCK) ON T2.[TTBUS2_IdMovimiento] = T1.[TTBUS2_IdMovimiento]) WHERE T1.[TTBUS2_IdUsuario] = @AV25USUARIO ORDER BY T1.[TTBUS2_IdUsuario], T1.[TTBUS2_IdMovimiento] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001O6,100,0,true,false )
             ,new CursorDef("H001O7", "SELECT T1.[TTBUS7_Pos] AS TTBUS7_Pos, T2.[W53DES] AS TTBUS7_Des FROM ([TTBUS007] T1 WITH (NOLOCK) INNER JOIN [T53FPOS] T2 WITH (NOLOCK) ON T2.[W53POS] = T1.[TTBUS7_Pos]) WHERE T1.[TTBUS7_Pos] = @TTBUS2_CodPosHacia ORDER BY T1.[TTBUS7_Pos] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001O7,1,0,false,true )
             ,new CursorDef("H001O8", "SELECT [USU_COD], [USU_DES] FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @TTBUS2_RespHacia ORDER BY [USU_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001O8,1,0,false,true )
             ,new CursorDef("H001O9", "SELECT [TTBUS_Id], [TTBUS_Descripcion] FROM [TTBUS000] WITH (NOLOCK) WHERE [TTBUS_Id] = @AV13gTTBUS2_IdBien ORDER BY [TTBUS_Id] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001O9,1,0,false,true )
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 0 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 15) ;
                ((int[]) buf[4])[0] = rslt.getInt(5) ;
                ((DateTime[]) buf[5])[0] = rslt.getGXDateTime(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                ((long[]) buf[7])[0] = rslt.getLong(8) ;
                break;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                break;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                break;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((long[]) buf[2])[0] = rslt.getLong(3) ;
                ((int[]) buf[3])[0] = rslt.getInt(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((String[]) buf[5])[0] = rslt.getString(6, 15) ;
                ((DateTime[]) buf[6])[0] = rslt.getGXDateTime(7) ;
                ((String[]) buf[7])[0] = rslt.getVarchar(8) ;
                ((String[]) buf[8])[0] = rslt.getString(9, 1) ;
                break;
             case 5 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                break;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                break;
             case 7 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 0 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 3 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 4 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 5 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 6 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 7 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
       }
    }

 }

}
