/*
               File: HTBUS003c
        Description: Bienes de Uso Enviados
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 3/17/2014 13:22:21.50
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
   public class htbus003c : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public htbus003c( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public htbus003c( IGxContext context )
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
         this.AV10USUARIO = aP0_USUARIO;
         this.AV11SISTEMA = aP1_SISTEMA;
         executePrivate();
         aP0_USUARIO=this.AV10USUARIO;
         aP1_SISTEMA=this.AV11SISTEMA;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbavTtbus2_estadoenvio = new GXCombobox();
         chkavSeleccion = new GXCheckbox();
         cmbavGttbus2_estadoenvio = new GXCombobox();
      }

      protected void INITWEB( )
      {
         initialize_properties( ) ;
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxSuggest"+"_"+"vGTTBUS2_MOTIVOENVIO") == 0 )
            {
               A47TTBUS2_MotivoEnvio = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A47TTBUS2_MotivoEnvio", A47TTBUS2_MotivoEnvio);
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               GXSGVvGTTBUS2_MOTIVOENVIO1Q0( A47TTBUS2_MotivoEnvio) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxSuggest"+"_"+"vGTTBUS2_OBSERVACIONES") == 0 )
            {
               A87TTBUS2_Observaciones = GetNextPar( ) ;
               n87TTBUS2_Observaciones = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A87TTBUS2_Observaciones", A87TTBUS2_Observaciones);
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               GXSGVvGTTBUS2_OBSERVACIONES1Q0( A87TTBUS2_Observaciones) ;
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
               nGXsfl_24_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               sGXsfl_24_idx = GetNextPar( ) ;
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxnrGrid1_newrow( nRC_Grid1, nGXsfl_24_idx, sGXsfl_24_idx) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid1") == 0 )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0 ;
               edtavGttbus2_idmovimiento_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGttbus2_idmovimiento_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGttbus2_idmovimiento_Enabled), 5, 0)));
               edtavGnumeroidentificador_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGnumeroidentificador_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGnumeroidentificador_Enabled), 5, 0)));
               edtavGttbus2_idbien_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGttbus2_idbien_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGttbus2_idbien_Enabled), 5, 0)));
               edtavGttbus2_codposhacia_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGttbus2_codposhacia_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGttbus2_codposhacia_Enabled), 5, 0)));
               edtavHttbus3_des_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavHttbus3_des_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavHttbus3_des_Enabled), 5, 0)));
               edtavGttbus2_respdesde_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGttbus2_respdesde_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGttbus2_respdesde_Enabled), 5, 0)));
               edtavGttbus2_resphacia_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGttbus2_resphacia_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGttbus2_resphacia_Enabled), 5, 0)));
               edtavHusu_des_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavHusu_des_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavHusu_des_Enabled), 5, 0)));
               edtavGttbus2_fechaenvio_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGttbus2_fechaenvio_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGttbus2_fechaenvio_Enabled), 5, 0)));
               edtavGttbus2_motivoenvio_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGttbus2_motivoenvio_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGttbus2_motivoenvio_Enabled), 5, 0)));
               edtavGttbus2_observaciones_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGttbus2_observaciones_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGttbus2_observaciones_Enabled), 5, 0)));
               cmbavGttbus2_estadoenvio.Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavGttbus2_estadoenvio_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavGttbus2_estadoenvio.Enabled), 5, 0)));
               cmbavTtbus2_estadoenvio.Name = "vTTBUS2_ESTADOENVIO" ;
               cmbavTtbus2_estadoenvio.WebTags = "" ;
               cmbavTtbus2_estadoenvio.addItem(StringUtil.Str( (decimal)(0), 1, 0), "Todos", 0);
               cmbavTtbus2_estadoenvio.addItem("1", "No Finalizado", 0);
               cmbavTtbus2_estadoenvio.addItem("2", "Finalizado", 0);
               cmbavTtbus2_estadoenvio.addItem("3", "Cancelado", 0);
               if ( ( cmbavTtbus2_estadoenvio.ItemCount > 0 ) && (0==AV15TTBUS2_EstadoEnvio) )
               {
                  AV15TTBUS2_EstadoEnvio = (short)(NumberUtil.Val( cmbavTtbus2_estadoenvio.getItemValue(1), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15TTBUS2_EstadoEnvio", StringUtil.Str( (decimal)(AV15TTBUS2_EstadoEnvio), 1, 0));
               }
               GXCCtl = "vSELECCION_" + sGXsfl_24_idx ;
               chkavSeleccion.Name = GXCCtl ;
               chkavSeleccion.WebTags = "" ;
               chkavSeleccion.Caption = "" ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavSeleccion_Internalname, "Caption", chkavSeleccion.Caption);
               chkavSeleccion.CheckedValue = "0" ;
               GXCCtl = "vGTTBUS2_ESTADOENVIO_" + sGXsfl_24_idx ;
               cmbavGttbus2_estadoenvio.Name = GXCCtl ;
               cmbavGttbus2_estadoenvio.WebTags = "" ;
               cmbavGttbus2_estadoenvio.addItem("1", "No Finalizado", 0);
               cmbavGttbus2_estadoenvio.addItem("2", "Finalizado", 0);
               cmbavGttbus2_estadoenvio.addItem("3", "Cancelado", 0);
               if ( ( cmbavGttbus2_estadoenvio.ItemCount > 0 ) && (0==AV24gTTBUS2_EstadoEnvio) )
               {
                  AV24gTTBUS2_EstadoEnvio = (short)(NumberUtil.Val( cmbavGttbus2_estadoenvio.getItemValue(1), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24gTTBUS2_EstadoEnvio", StringUtil.Str( (decimal)(AV24gTTBUS2_EstadoEnvio), 1, 0));
               }
               Grid1_PageSize24 = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               A102TTBUS2_TipoResp = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A102TTBUS2_TipoResp", A102TTBUS2_TipoResp);
               A53TTBUS2_IdUsuario = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A53TTBUS2_IdUsuario", A53TTBUS2_IdUsuario);
               A26TTBUS2_EstadoEnvio = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26TTBUS2_EstadoEnvio", StringUtil.Str( (decimal)(A26TTBUS2_EstadoEnvio), 1, 0));
               A87TTBUS2_Observaciones = GetNextPar( ) ;
               n87TTBUS2_Observaciones = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A87TTBUS2_Observaciones", A87TTBUS2_Observaciones);
               A47TTBUS2_MotivoEnvio = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A47TTBUS2_MotivoEnvio", A47TTBUS2_MotivoEnvio);
               A45TTBUS2_FechaEnvio = context.localUtil.ParseDTimeParm( GetNextPar( )) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A45TTBUS2_FechaEnvio", context.localUtil.TToC( A45TTBUS2_FechaEnvio, 10, 5, 0, 3, "/", ":", " "));
               A24TTBUS2_RespDesde = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24TTBUS2_RespDesde", A24TTBUS2_RespDesde);
               A7USU_DES = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7USU_DES", A7USU_DES);
               A6USU_COD = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
               A25TTBUS2_RespHacia = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25TTBUS2_RespHacia", A25TTBUS2_RespHacia);
               A34TTBUS7_Des = GetNextPar( ) ;
               n34TTBUS7_Des = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34TTBUS7_Des", A34TTBUS7_Des);
               A33TTBUS7_Pos = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
               A49TTBUS2_CodPosHacia = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A49TTBUS2_CodPosHacia", StringUtil.LTrim( StringUtil.Str( (decimal)(A49TTBUS2_CodPosHacia), 3, 0)));
               A12TTBUS_Descripcion = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
               A11TTBUS_Id = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
               A22TTBUS2_IdBien = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22TTBUS2_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A22TTBUS2_IdBien), 8, 0)));
               A52TTBUS2_IdMovimiento = (long)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52TTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(A52TTBUS2_IdMovimiento), 12, 0)));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxgrGrid1_refresh( Grid1_PageSize24, A102TTBUS2_TipoResp, A53TTBUS2_IdUsuario, A26TTBUS2_EstadoEnvio, A87TTBUS2_Observaciones, A47TTBUS2_MotivoEnvio, A45TTBUS2_FechaEnvio, A24TTBUS2_RespDesde, A7USU_DES, A6USU_COD, A25TTBUS2_RespHacia, A34TTBUS7_Des, A33TTBUS7_Pos, A49TTBUS2_CodPosHacia, A12TTBUS_Descripcion, A11TTBUS_Id, A22TTBUS2_IdBien, A52TTBUS2_IdMovimiento) ;
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
            if ( ! entryPointCalled )
            {
               AV10USUARIO = gxfirstwebparm ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10USUARIO", AV10USUARIO);
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV11SISTEMA = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11SISTEMA", AV11SISTEMA);
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
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("mptrazabilidad", "GeneXus.Programs.mptrazabilidad", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
            MasterPageObj.setDataArea(this,false);
            MasterPageObj.webExecute();
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

      public override short ExecuteStartEvent( )
      {
         PA1Q2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START1Q2( ) ;
         }
         return gxajaxcallmode ;
      }

      public override void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, "IE=EmulateIE7");
      }

      public override void RenderHtmlOpenForm( )
      {
         context.WriteHtmlText( "<title>") ;
         context.WriteHtmlText( Form.Caption) ;
         context.WriteHtmlTextNl( "</title>") ;
         if ( StringUtil.Len( sDynURL) > 0 )
         {
            context.WriteHtmlText( "<BASE href=\""+sDynURL+"\" />") ;
         }
         define_styles( ) ;
         if ( nGXWrapped != 1 )
         {
            MasterPageObj.master_styles();
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
            context.AddJavascriptSource("gxcfg.js", "?42940");
         }
         context.AddJavascriptSource("calendar.js", "?42940");
         context.AddJavascriptSource("calendar-setup.js", "?42940");
         context.AddJavascriptSource("calendar-es.js", "?42940");
         context.WriteHtmlText( Form.Headerrawhtml) ;
         context.CloseHtmlHeader();
         FormProcess = ((nGXWrapped==0) ? " onkeyup=\"gx.evt.onkeyup(event)\" onkeypress=\"gx.evt.onkeypress(event,false,false)\" onkeydown=\"gx.evt.onkeypress(null,false,false)\"" : "") ;
         context.WriteHtmlText( "<body") ;
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            context.WriteHtmlText( " background=\""+context.convertURL( Form.Background)+"\"") ;
         }
         context.WriteHtmlText( " "+"class=\"Form\""+" "+" style=\"-moz-opacity:0;opacity:0;"+"background-color:"+context.BuildHTMLColor( Form.Backcolor)+"\""+FormProcess+">") ;
         context.skipLines(1);
         if ( nGXWrapped != 1 )
         {
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("htbus003c.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV10USUARIO)) + "," + UrlEncode(StringUtil.RTrim(AV11SISTEMA))+"\" class=\""+"Form"+"\">") ;
            GxWebStd.gx_hidden_field( context, "_EventName", "");
            GxWebStd.gx_hidden_field( context, "_EventGridId", "");
            GxWebStd.gx_hidden_field( context, "_EventRowId", "");
         }
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vUSUARIO", StringUtil.RTrim( AV10USUARIO));
         GxWebStd.gx_hidden_field( context, "vSISTEMA", StringUtil.RTrim( AV11SISTEMA));
         GxWebStd.gx_hidden_field( context, "TTBUS2_TIPORESP", StringUtil.RTrim( A102TTBUS2_TipoResp));
         GxWebStd.gx_hidden_field( context, "TTBUS2_IDUSUARIO", StringUtil.RTrim( A53TTBUS2_IdUsuario));
         GxWebStd.gx_hidden_field( context, "TTBUS2_ESTADOENVIO", StringUtil.LTrim( StringUtil.NToC( (decimal)(A26TTBUS2_EstadoEnvio), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "TTBUS2_OBSERVACIONES", StringUtil.RTrim( A87TTBUS2_Observaciones));
         GxWebStd.gx_hidden_field( context, "TTBUS2_MOTIVOENVIO", StringUtil.RTrim( A47TTBUS2_MotivoEnvio));
         GxWebStd.gx_hidden_field( context, "TTBUS2_FECHAENVIO", context.localUtil.TToC( A45TTBUS2_FechaEnvio, 10, 8, 0, 3, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "TTBUS2_RESPDESDE", StringUtil.RTrim( A24TTBUS2_RespDesde));
         GxWebStd.gx_hidden_field( context, "USU_DES", StringUtil.RTrim( A7USU_DES));
         GxWebStd.gx_hidden_field( context, "USU_COD", StringUtil.RTrim( A6USU_COD));
         GxWebStd.gx_hidden_field( context, "TTBUS2_RESPHACIA", StringUtil.RTrim( A25TTBUS2_RespHacia));
         GxWebStd.gx_hidden_field( context, "TTBUS7_DES", StringUtil.RTrim( A34TTBUS7_Des));
         GxWebStd.gx_hidden_field( context, "TTBUS7_POS", StringUtil.LTrim( StringUtil.NToC( (decimal)(A33TTBUS7_Pos), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "TTBUS2_CODPOSHACIA", StringUtil.LTrim( StringUtil.NToC( (decimal)(A49TTBUS2_CodPosHacia), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "TTBUS_DESCRIPCION", StringUtil.RTrim( A12TTBUS_Descripcion));
         GxWebStd.gx_hidden_field( context, "TTBUS_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A11TTBUS_Id), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "TTBUS2_IDBIEN", StringUtil.LTrim( StringUtil.NToC( (decimal)(A22TTBUS2_IdBien), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "TTBUS2_IDMOVIMIENTO", StringUtil.LTrim( StringUtil.NToC( (decimal)(A52TTBUS2_IdMovimiento), 12, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 6, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendComponentObjects();
         SendServerCommands();
         SendState();
         if ( nGXWrapped != 1 )
         {
            context.WriteHtmlTextNl( "</form>") ;
         }
         include_jscripts( ) ;
      }

      public override void RenderHtmlContent( )
      {
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            WE1Q2( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT1Q2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return false ;
      }

      public override String GetPgmname( )
      {
         return "HTBUS003c" ;
      }

      public override String GetPgmdesc( )
      {
         return "Bienes de Uso Enviados" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("htbus003c.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV10USUARIO)) + "," + UrlEncode(StringUtil.RTrim(AV11SISTEMA)) ;
      }

      protected void WB1Q0( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            if ( nGXWrapped == 1 )
            {
               RenderHtmlHeaders( ) ;
               RenderHtmlOpenForm( ) ;
            }
            wb_table1_2_1Q2( true) ;
         }
         else
         {
            wb_table1_2_1Q2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_1Q2e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START1Q2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "Bienes de Uso Enviados", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP1Q0( ) ;
      }

      protected void WS1Q2( )
      {
         START1Q2( ) ;
         EVT1Q2( ) ;
      }

      protected void EVT1Q2( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) && ! wbErr )
            {
               /* Read Web Panel buttons. */
               sEvt = cgiGet( "_EventName") ;
               EvtGridId = cgiGet( "_EventGridId") ;
               EvtRowId = cgiGet( "_EventRowId") ;
               if ( StringUtil.Len( sEvt) > 0 )
               {
                  sEvtType = StringUtil.Left( sEvt, 1) ;
                  sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                  /* Check if conditions changed and reset current page numbers */
                  if ( StringUtil.StrCmp(sEvtType, "M") != 0 )
                  {
                     if ( StringUtil.StrCmp(sEvtType, "E") == 0 )
                     {
                        sEvtType = StringUtil.Right( sEvt, 1) ;
                        if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                        {
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                           if ( StringUtil.StrCmp(sEvt, "RFR") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'CANCELAR ENVíO'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E111Q2 */
                              E111Q2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRID1PAGING") == 0 )
                           {
                              context.wbHandled = 1 ;
                              sEvt = cgiGet( "GRID1PAGING") ;
                              if ( StringUtil.StrCmp(sEvt, "FIRST") == 0 )
                              {
                                 subgrid1_firstpage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "PREV") == 0 )
                              {
                                 subgrid1_previouspage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                              {
                                 subgrid1_nextpage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "LAST") == 0 )
                              {
                                 subgrid1_lastpage( ) ;
                              }
                           }
                        }
                        else
                        {
                           sEvtType = StringUtil.Right( sEvt, 4) ;
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4)) ;
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 10), "GRID1.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 16), "'CANCELAR ENVíO'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) )
                           {
                              nGXsfl_24_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                              sGXsfl_24_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_24_idx), 4, 0)), 4, "0") ;
                              chkavSeleccion_Internalname = "vSELECCION_"+sGXsfl_24_idx ;
                              edtavDetalle_Internalname = "vDETALLE_"+sGXsfl_24_idx ;
                              edtavGttbus2_idmovimiento_Internalname = "vGTTBUS2_IDMOVIMIENTO_"+sGXsfl_24_idx ;
                              edtavGnumeroidentificador_Internalname = "vGNUMEROIDENTIFICADOR_"+sGXsfl_24_idx ;
                              edtavGttbus2_idbien_Internalname = "vGTTBUS2_IDBIEN_"+sGXsfl_24_idx ;
                              edtavGttbus2_codposhacia_Internalname = "vGTTBUS2_CODPOSHACIA_"+sGXsfl_24_idx ;
                              edtavHttbus3_des_Internalname = "vHTTBUS3_DES_"+sGXsfl_24_idx ;
                              edtavGttbus2_respdesde_Internalname = "vGTTBUS2_RESPDESDE_"+sGXsfl_24_idx ;
                              edtavGttbus2_resphacia_Internalname = "vGTTBUS2_RESPHACIA_"+sGXsfl_24_idx ;
                              edtavHusu_des_Internalname = "vHUSU_DES_"+sGXsfl_24_idx ;
                              edtavGttbus2_fechaenvio_Internalname = "vGTTBUS2_FECHAENVIO_"+sGXsfl_24_idx ;
                              edtavGttbus2_motivoenvio_Internalname = "vGTTBUS2_MOTIVOENVIO_"+sGXsfl_24_idx ;
                              edtavGttbus2_observaciones_Internalname = "vGTTBUS2_OBSERVACIONES_"+sGXsfl_24_idx ;
                              cmbavGttbus2_estadoenvio_Internalname = "vGTTBUS2_ESTADOENVIO_"+sGXsfl_24_idx ;
                              if ( ! context.localUtil.VCNumber( cgiGet( chkavSeleccion_Internalname), "9") || ( ((StringUtil.StrCmp(cgiGet( chkavSeleccion_Internalname), "1")==0) ? 1 : 0) < 0 ) || ( ( ((StringUtil.StrCmp(cgiGet( chkavSeleccion_Internalname), "1")==0) ? 1 : 0) > 9 ) ) )
                              {
                                 GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vSELECCION");
                                 GX_FocusControl = chkavSeleccion_Internalname ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                                 wbErr = true ;
                                 AV27seleccion = 0 ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27seleccion", StringUtil.Str( (decimal)(AV27seleccion), 1, 0));
                              }
                              else
                              {
                                 AV27seleccion = (short)(((StringUtil.StrCmp(cgiGet( chkavSeleccion_Internalname), "1")==0) ? 1 : 0)) ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27seleccion", StringUtil.Str( (decimal)(AV27seleccion), 1, 0));
                              }
                              AV28detalle = cgiGet( "GXimg"+edtavDetalle_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDetalle_Internalname, "Bitmap", context.convertURL( AV28detalle));
                              if ( ! context.localUtil.VCNumber( cgiGet( edtavGttbus2_idmovimiento_Internalname), "ZZZZZZZZZZZ9") || ( context.localUtil.CToN( cgiGet( edtavGttbus2_idmovimiento_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavGttbus2_idmovimiento_Internalname), ",", ".") > Convert.ToDecimal( 999999999999L )) ) )
                              {
                                 GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vGTTBUS2_IDMOVIMIENTO");
                                 GX_FocusControl = edtavGttbus2_idmovimiento_Internalname ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                                 wbErr = true ;
                                 AV19gTTBUS2_IdMovimiento = 0 ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19gTTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(AV19gTTBUS2_IdMovimiento), 12, 0)));
                              }
                              else
                              {
                                 AV19gTTBUS2_IdMovimiento = (long)(context.localUtil.CToN( cgiGet( edtavGttbus2_idmovimiento_Internalname), ",", ".")) ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19gTTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(AV19gTTBUS2_IdMovimiento), 12, 0)));
                              }
                              AV29gNumeroIdentificador = cgiGet( edtavGnumeroidentificador_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29gNumeroIdentificador", AV29gNumeroIdentificador);
                              if ( ! context.localUtil.VCNumber( cgiGet( edtavGttbus2_idbien_Internalname), "ZZZZZZZ9") || ( context.localUtil.CToN( cgiGet( edtavGttbus2_idbien_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavGttbus2_idbien_Internalname), ",", ".") > Convert.ToDecimal( 99999999 )) ) )
                              {
                                 GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vGTTBUS2_IDBIEN");
                                 GX_FocusControl = edtavGttbus2_idbien_Internalname ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                                 wbErr = true ;
                                 AV18gTTBUS2_IdBien = 0 ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18gTTBUS2_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18gTTBUS2_IdBien), 8, 0)));
                              }
                              else
                              {
                                 AV18gTTBUS2_IdBien = (int)(context.localUtil.CToN( cgiGet( edtavGttbus2_idbien_Internalname), ",", ".")) ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18gTTBUS2_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18gTTBUS2_IdBien), 8, 0)));
                              }
                              if ( ! context.localUtil.VCNumber( cgiGet( edtavGttbus2_codposhacia_Internalname), "ZZ9") || ( context.localUtil.CToN( cgiGet( edtavGttbus2_codposhacia_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavGttbus2_codposhacia_Internalname), ",", ".") > Convert.ToDecimal( 999 )) ) )
                              {
                                 GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vGTTBUS2_CODPOSHACIA");
                                 GX_FocusControl = edtavGttbus2_codposhacia_Internalname ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                                 wbErr = true ;
                                 AV17gTTBUS2_CodPosHacia = 0 ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17gTTBUS2_CodPosHacia", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17gTTBUS2_CodPosHacia), 3, 0)));
                              }
                              else
                              {
                                 AV17gTTBUS2_CodPosHacia = (short)(context.localUtil.CToN( cgiGet( edtavGttbus2_codposhacia_Internalname), ",", ".")) ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17gTTBUS2_CodPosHacia", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17gTTBUS2_CodPosHacia), 3, 0)));
                              }
                              AV16hTTBUS3_Des = cgiGet( edtavHttbus3_des_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16hTTBUS3_Des", AV16hTTBUS3_Des);
                              AV26gTTBUS2_RespDesde = cgiGet( edtavGttbus2_respdesde_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26gTTBUS2_RespDesde", AV26gTTBUS2_RespDesde);
                              AV20gTTBUS2_RespHacia = cgiGet( edtavGttbus2_resphacia_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20gTTBUS2_RespHacia", AV20gTTBUS2_RespHacia);
                              AV12hUSU_DES = StringUtil.Upper( cgiGet( edtavHusu_des_Internalname)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12hUSU_DES", AV12hUSU_DES);
                              if ( context.localUtil.VCDateTime( cgiGet( edtavGttbus2_fechaenvio_Internalname), 4, 0) == 0 )
                              {
                                 GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"g TTBUS2_ Fecha Envio"}), 1, "vGTTBUS2_FECHAENVIO");
                                 GX_FocusControl = edtavGttbus2_fechaenvio_Internalname ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                                 wbErr = true ;
                                 AV21gTTBUS2_FechaEnvio = (DateTime)(DateTime.MinValue) ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21gTTBUS2_FechaEnvio", context.localUtil.TToC( AV21gTTBUS2_FechaEnvio, 10, 5, 0, 3, "/", ":", " "));
                              }
                              else
                              {
                                 AV21gTTBUS2_FechaEnvio = context.localUtil.CToT( cgiGet( edtavGttbus2_fechaenvio_Internalname)) ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21gTTBUS2_FechaEnvio", context.localUtil.TToC( AV21gTTBUS2_FechaEnvio, 10, 5, 0, 3, "/", ":", " "));
                              }
                              AV22gTTBUS2_MotivoEnvio = StringUtil.Upper( cgiGet( edtavGttbus2_motivoenvio_Internalname)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22gTTBUS2_MotivoEnvio", AV22gTTBUS2_MotivoEnvio);
                              AV23gTTBUS2_Observaciones = StringUtil.Upper( cgiGet( edtavGttbus2_observaciones_Internalname)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23gTTBUS2_Observaciones", AV23gTTBUS2_Observaciones);
                              cmbavGttbus2_estadoenvio.Name = cmbavGttbus2_estadoenvio_Internalname ;
                              cmbavGttbus2_estadoenvio.CurrentValue = cgiGet( cmbavGttbus2_estadoenvio_Internalname) ;
                              AV24gTTBUS2_EstadoEnvio = (short)(NumberUtil.Val( cgiGet( cmbavGttbus2_estadoenvio_Internalname), ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24gTTBUS2_EstadoEnvio", StringUtil.Str( (decimal)(AV24gTTBUS2_EstadoEnvio), 1, 0));
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "GRID1.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E121Q2 */
                                    E121Q2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'CANCELAR ENVíO'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E111Q2 */
                                    E111Q2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false ;
                                       if ( ! Rfr0gs )
                                       {
                                       }
                                       dynload_actions( ) ;
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "CANCEL") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
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

      protected void WE1Q2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true ;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               if ( nGXWrapped == 1 )
               {
                  RenderHtmlCloseForm( ) ;
               }
            }
         }
      }

      protected void PA1Q2( )
      {
         if ( nDonePA == 0 )
         {
            cmbavTtbus2_estadoenvio.Name = "vTTBUS2_ESTADOENVIO" ;
            cmbavTtbus2_estadoenvio.WebTags = "" ;
            cmbavTtbus2_estadoenvio.addItem(StringUtil.Str( (decimal)(0), 1, 0), "Todos", 0);
            cmbavTtbus2_estadoenvio.addItem("1", "No Finalizado", 0);
            cmbavTtbus2_estadoenvio.addItem("2", "Finalizado", 0);
            cmbavTtbus2_estadoenvio.addItem("3", "Cancelado", 0);
            if ( ( cmbavTtbus2_estadoenvio.ItemCount > 0 ) && (0==AV15TTBUS2_EstadoEnvio) )
            {
               AV15TTBUS2_EstadoEnvio = (short)(NumberUtil.Val( cmbavTtbus2_estadoenvio.getItemValue(1), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15TTBUS2_EstadoEnvio", StringUtil.Str( (decimal)(AV15TTBUS2_EstadoEnvio), 1, 0));
            }
            GXCCtl = "vSELECCION_" + sGXsfl_24_idx ;
            chkavSeleccion.Name = GXCCtl ;
            chkavSeleccion.WebTags = "" ;
            chkavSeleccion.Caption = "" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavSeleccion_Internalname, "Caption", chkavSeleccion.Caption);
            chkavSeleccion.CheckedValue = "0" ;
            GXCCtl = "vGTTBUS2_ESTADOENVIO_" + sGXsfl_24_idx ;
            cmbavGttbus2_estadoenvio.Name = GXCCtl ;
            cmbavGttbus2_estadoenvio.WebTags = "" ;
            cmbavGttbus2_estadoenvio.addItem("1", "No Finalizado", 0);
            cmbavGttbus2_estadoenvio.addItem("2", "Finalizado", 0);
            cmbavGttbus2_estadoenvio.addItem("3", "Cancelado", 0);
            if ( ( cmbavGttbus2_estadoenvio.ItemCount > 0 ) && (0==AV24gTTBUS2_EstadoEnvio) )
            {
               AV24gTTBUS2_EstadoEnvio = (short)(NumberUtil.Val( cmbavGttbus2_estadoenvio.getItemValue(1), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24gTTBUS2_EstadoEnvio", StringUtil.Str( (decimal)(AV24gTTBUS2_EstadoEnvio), 1, 0));
            }
            GX_FocusControl = cmbavTtbus2_estadoenvio_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void GXSGVvGTTBUS2_MOTIVOENVIO1Q0( String A47TTBUS2_MotivoEnvio )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
         }
         context.GX_webresponse.AddString("(new Array( new Array(");
         GXSGVvGTTBUS2_MOTIVOENVIO_data1Q0( A47TTBUS2_MotivoEnvio) ;
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

      protected void GXSGVvGTTBUS2_MOTIVOENVIO_data1Q0( String A47TTBUS2_MotivoEnvio )
      {
         l47TTBUS2_MotivoEnvio = StringUtil.PadR( StringUtil.RTrim( A47TTBUS2_MotivoEnvio), 100, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A47TTBUS2_MotivoEnvio", A47TTBUS2_MotivoEnvio);
         /* Using cursor H001Q2 */
         pr_default.execute(0, new Object[] {l47TTBUS2_MotivoEnvio});
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         while ( (pr_default.getStatus(0) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.RTrim( H001Q2_A47TTBUS2_MotivoEnvio[0]));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( H001Q2_A47TTBUS2_MotivoEnvio[0]));
            pr_default.readNext(0);
         }
         pr_default.close(0);
      }

      protected void GXSGVvGTTBUS2_OBSERVACIONES1Q0( String A87TTBUS2_Observaciones )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
         }
         context.GX_webresponse.AddString("(new Array( new Array(");
         GXSGVvGTTBUS2_OBSERVACIONES_data1Q0( A87TTBUS2_Observaciones) ;
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

      protected void GXSGVvGTTBUS2_OBSERVACIONES_data1Q0( String A87TTBUS2_Observaciones )
      {
         l87TTBUS2_Observaciones = StringUtil.PadR( StringUtil.RTrim( A87TTBUS2_Observaciones), 400, "%") ;
         n87TTBUS2_Observaciones = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A87TTBUS2_Observaciones", A87TTBUS2_Observaciones);
         /* Using cursor H001Q3 */
         pr_default.execute(1, new Object[] {n87TTBUS2_Observaciones, l87TTBUS2_Observaciones});
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         while ( (pr_default.getStatus(1) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.RTrim( H001Q3_A87TTBUS2_Observaciones[0]));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( H001Q3_A87TTBUS2_Observaciones[0]));
            pr_default.readNext(1);
         }
         pr_default.close(1);
      }

      protected void gxnrGrid1_newrow( short nRC_Grid1 ,
                                       short nGXsfl_24_idx ,
                                       String sGXsfl_24_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         chkavSeleccion_Internalname = "vSELECCION_"+sGXsfl_24_idx ;
         edtavDetalle_Internalname = "vDETALLE_"+sGXsfl_24_idx ;
         edtavGttbus2_idmovimiento_Internalname = "vGTTBUS2_IDMOVIMIENTO_"+sGXsfl_24_idx ;
         edtavGnumeroidentificador_Internalname = "vGNUMEROIDENTIFICADOR_"+sGXsfl_24_idx ;
         edtavGttbus2_idbien_Internalname = "vGTTBUS2_IDBIEN_"+sGXsfl_24_idx ;
         edtavGttbus2_codposhacia_Internalname = "vGTTBUS2_CODPOSHACIA_"+sGXsfl_24_idx ;
         edtavHttbus3_des_Internalname = "vHTTBUS3_DES_"+sGXsfl_24_idx ;
         edtavGttbus2_respdesde_Internalname = "vGTTBUS2_RESPDESDE_"+sGXsfl_24_idx ;
         edtavGttbus2_resphacia_Internalname = "vGTTBUS2_RESPHACIA_"+sGXsfl_24_idx ;
         edtavHusu_des_Internalname = "vHUSU_DES_"+sGXsfl_24_idx ;
         edtavGttbus2_fechaenvio_Internalname = "vGTTBUS2_FECHAENVIO_"+sGXsfl_24_idx ;
         edtavGttbus2_motivoenvio_Internalname = "vGTTBUS2_MOTIVOENVIO_"+sGXsfl_24_idx ;
         edtavGttbus2_observaciones_Internalname = "vGTTBUS2_OBSERVACIONES_"+sGXsfl_24_idx ;
         cmbavGttbus2_estadoenvio_Internalname = "vGTTBUS2_ESTADOENVIO_"+sGXsfl_24_idx ;
         while ( nGXsfl_24_idx <= nRC_Grid1 )
         {
            sendrow_242( ) ;
            nGXsfl_24_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_24_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_24_idx+1)) ;
            sGXsfl_24_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_24_idx), 4, 0)), 4, "0") ;
            chkavSeleccion_Internalname = "vSELECCION_"+sGXsfl_24_idx ;
            edtavDetalle_Internalname = "vDETALLE_"+sGXsfl_24_idx ;
            edtavGttbus2_idmovimiento_Internalname = "vGTTBUS2_IDMOVIMIENTO_"+sGXsfl_24_idx ;
            edtavGnumeroidentificador_Internalname = "vGNUMEROIDENTIFICADOR_"+sGXsfl_24_idx ;
            edtavGttbus2_idbien_Internalname = "vGTTBUS2_IDBIEN_"+sGXsfl_24_idx ;
            edtavGttbus2_codposhacia_Internalname = "vGTTBUS2_CODPOSHACIA_"+sGXsfl_24_idx ;
            edtavHttbus3_des_Internalname = "vHTTBUS3_DES_"+sGXsfl_24_idx ;
            edtavGttbus2_respdesde_Internalname = "vGTTBUS2_RESPDESDE_"+sGXsfl_24_idx ;
            edtavGttbus2_resphacia_Internalname = "vGTTBUS2_RESPHACIA_"+sGXsfl_24_idx ;
            edtavHusu_des_Internalname = "vHUSU_DES_"+sGXsfl_24_idx ;
            edtavGttbus2_fechaenvio_Internalname = "vGTTBUS2_FECHAENVIO_"+sGXsfl_24_idx ;
            edtavGttbus2_motivoenvio_Internalname = "vGTTBUS2_MOTIVOENVIO_"+sGXsfl_24_idx ;
            edtavGttbus2_observaciones_Internalname = "vGTTBUS2_OBSERVACIONES_"+sGXsfl_24_idx ;
            cmbavGttbus2_estadoenvio_Internalname = "vGTTBUS2_ESTADOENVIO_"+sGXsfl_24_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int Grid1_PageSize24 ,
                                        String A102TTBUS2_TipoResp ,
                                        String A53TTBUS2_IdUsuario ,
                                        short A26TTBUS2_EstadoEnvio ,
                                        String A87TTBUS2_Observaciones ,
                                        String A47TTBUS2_MotivoEnvio ,
                                        DateTime A45TTBUS2_FechaEnvio ,
                                        String A24TTBUS2_RespDesde ,
                                        String A7USU_DES ,
                                        String A6USU_COD ,
                                        String A25TTBUS2_RespHacia ,
                                        String A34TTBUS7_Des ,
                                        short A33TTBUS7_Pos ,
                                        short A49TTBUS2_CodPosHacia ,
                                        String A12TTBUS_Descripcion ,
                                        int A11TTBUS_Id ,
                                        int A22TTBUS2_IdBien ,
                                        long A52TTBUS2_IdMovimiento )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         subGrid1_Rows = (short)(Grid1_PageSize24) ;
         RF1Q2( ) ;
         enableOutput();
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxgrGrid1_refresh */
      }

      protected void Refresh( )
      {
         RF1Q2( ) ;
         /* End function Refresh */
      }

      protected void RF1Q2( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 24 ;
         nGXsfl_24_idx = 1 ;
         sGXsfl_24_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_24_idx), 4, 0)), 4, "0") ;
         chkavSeleccion_Internalname = "vSELECCION_"+sGXsfl_24_idx ;
         edtavDetalle_Internalname = "vDETALLE_"+sGXsfl_24_idx ;
         edtavGttbus2_idmovimiento_Internalname = "vGTTBUS2_IDMOVIMIENTO_"+sGXsfl_24_idx ;
         edtavGnumeroidentificador_Internalname = "vGNUMEROIDENTIFICADOR_"+sGXsfl_24_idx ;
         edtavGttbus2_idbien_Internalname = "vGTTBUS2_IDBIEN_"+sGXsfl_24_idx ;
         edtavGttbus2_codposhacia_Internalname = "vGTTBUS2_CODPOSHACIA_"+sGXsfl_24_idx ;
         edtavHttbus3_des_Internalname = "vHTTBUS3_DES_"+sGXsfl_24_idx ;
         edtavGttbus2_respdesde_Internalname = "vGTTBUS2_RESPDESDE_"+sGXsfl_24_idx ;
         edtavGttbus2_resphacia_Internalname = "vGTTBUS2_RESPHACIA_"+sGXsfl_24_idx ;
         edtavHusu_des_Internalname = "vHUSU_DES_"+sGXsfl_24_idx ;
         edtavGttbus2_fechaenvio_Internalname = "vGTTBUS2_FECHAENVIO_"+sGXsfl_24_idx ;
         edtavGttbus2_motivoenvio_Internalname = "vGTTBUS2_MOTIVOENVIO_"+sGXsfl_24_idx ;
         edtavGttbus2_observaciones_Internalname = "vGTTBUS2_OBSERVACIONES_"+sGXsfl_24_idx ;
         cmbavGttbus2_estadoenvio_Internalname = "vGTTBUS2_ESTADOENVIO_"+sGXsfl_24_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            chkavSeleccion_Internalname = "vSELECCION_"+sGXsfl_24_idx ;
            edtavDetalle_Internalname = "vDETALLE_"+sGXsfl_24_idx ;
            edtavGttbus2_idmovimiento_Internalname = "vGTTBUS2_IDMOVIMIENTO_"+sGXsfl_24_idx ;
            edtavGnumeroidentificador_Internalname = "vGNUMEROIDENTIFICADOR_"+sGXsfl_24_idx ;
            edtavGttbus2_idbien_Internalname = "vGTTBUS2_IDBIEN_"+sGXsfl_24_idx ;
            edtavGttbus2_codposhacia_Internalname = "vGTTBUS2_CODPOSHACIA_"+sGXsfl_24_idx ;
            edtavHttbus3_des_Internalname = "vHTTBUS3_DES_"+sGXsfl_24_idx ;
            edtavGttbus2_respdesde_Internalname = "vGTTBUS2_RESPDESDE_"+sGXsfl_24_idx ;
            edtavGttbus2_resphacia_Internalname = "vGTTBUS2_RESPHACIA_"+sGXsfl_24_idx ;
            edtavHusu_des_Internalname = "vHUSU_DES_"+sGXsfl_24_idx ;
            edtavGttbus2_fechaenvio_Internalname = "vGTTBUS2_FECHAENVIO_"+sGXsfl_24_idx ;
            edtavGttbus2_motivoenvio_Internalname = "vGTTBUS2_MOTIVOENVIO_"+sGXsfl_24_idx ;
            edtavGttbus2_observaciones_Internalname = "vGTTBUS2_OBSERVACIONES_"+sGXsfl_24_idx ;
            cmbavGttbus2_estadoenvio_Internalname = "vGTTBUS2_ESTADOENVIO_"+sGXsfl_24_idx ;
            /* Execute user event: E121Q2 */
            E121Q2 ();
            wbEnd = 24 ;
            WB1Q0( ) ;
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
         if ( 10 > 0 )
         {
            if ( 1 > 0 )
            {
               return (int)(10*1) ;
            }
            else
            {
               return (int)(10) ;
            }
         }
         return (int)(-1) ;
      }

      protected int subGrid1_Currentpage( )
      {
         return (int)(-1) ;
      }

      protected short subgrid1_firstpage( )
      {
         GRID1_nFirstRecordOnPage = 0 ;
         return 0 ;
      }

      protected short subgrid1_nextpage( )
      {
         if ( GRID1_nEOF == 0 )
         {
            GRID1_nFirstRecordOnPage = (int)(GRID1_nFirstRecordOnPage+subGrid1_Recordsperpage( )) ;
         }
         return 0 ;
      }

      protected short subgrid1_previouspage( )
      {
         if ( GRID1_nFirstRecordOnPage >= subGrid1_Recordsperpage( ) )
         {
            GRID1_nFirstRecordOnPage = (int)(GRID1_nFirstRecordOnPage-subGrid1_Recordsperpage( )) ;
         }
         else
         {
            return 2 ;
         }
         return 0 ;
      }

      protected short subgrid1_lastpage( )
      {
         subGrid1_Islastpage = 1 ;
         return 3 ;
      }

      protected int subgrid1_gotopage( int nPageNo )
      {
         if ( nPageNo > 0 )
         {
            int gx_pageCount = subGrid1_Pagecount( ) ;
            if ( ( nPageNo <= gx_pageCount ) || ( gx_pageCount == -1 ) )
            {
               GRID1_nFirstRecordOnPage = (int)(subGrid1_Recordsperpage( )*(nPageNo-1)) ;
            }
            else
            {
               GRID1_nFirstRecordOnPage = (int)(subGrid1_Recordsperpage( )*(gx_pageCount-1)) ;
            }
         }
         else
         {
            GRID1_nFirstRecordOnPage = 0 ;
         }
         return (int)(0) ;
      }

      protected void STRUP1Q0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         edtavGttbus2_idmovimiento_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGttbus2_idmovimiento_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGttbus2_idmovimiento_Enabled), 5, 0)));
         edtavGnumeroidentificador_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGnumeroidentificador_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGnumeroidentificador_Enabled), 5, 0)));
         edtavGttbus2_idbien_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGttbus2_idbien_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGttbus2_idbien_Enabled), 5, 0)));
         edtavGttbus2_codposhacia_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGttbus2_codposhacia_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGttbus2_codposhacia_Enabled), 5, 0)));
         edtavHttbus3_des_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavHttbus3_des_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavHttbus3_des_Enabled), 5, 0)));
         edtavGttbus2_respdesde_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGttbus2_respdesde_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGttbus2_respdesde_Enabled), 5, 0)));
         edtavGttbus2_resphacia_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGttbus2_resphacia_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGttbus2_resphacia_Enabled), 5, 0)));
         edtavHusu_des_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavHusu_des_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavHusu_des_Enabled), 5, 0)));
         edtavGttbus2_fechaenvio_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGttbus2_fechaenvio_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGttbus2_fechaenvio_Enabled), 5, 0)));
         edtavGttbus2_motivoenvio_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGttbus2_motivoenvio_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGttbus2_motivoenvio_Enabled), 5, 0)));
         edtavGttbus2_observaciones_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGttbus2_observaciones_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGttbus2_observaciones_Enabled), 5, 0)));
         cmbavGttbus2_estadoenvio.Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavGttbus2_estadoenvio_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavGttbus2_estadoenvio.Enabled), 5, 0)));
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            cmbavTtbus2_estadoenvio.Name = cmbavTtbus2_estadoenvio_Internalname ;
            cmbavTtbus2_estadoenvio.CurrentValue = cgiGet( cmbavTtbus2_estadoenvio_Internalname) ;
            AV15TTBUS2_EstadoEnvio = (short)(NumberUtil.Val( cgiGet( cmbavTtbus2_estadoenvio_Internalname), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15TTBUS2_EstadoEnvio", StringUtil.Str( (decimal)(AV15TTBUS2_EstadoEnvio), 1, 0));
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ",", ".")) ;
            AV10USUARIO = cgiGet( "vUSUARIO") ;
            AV11SISTEMA = cgiGet( "vSISTEMA") ;
            GRID1_nFirstRecordOnPage = (int)(context.localUtil.CToN( cgiGet( "GRID1_nFirstRecordOnPage"), ",", ".")) ;
            GRID1_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID1_nEOF"), ",", ".")) ;
            /* Read subfile selected row values. */
            /* Read hidden variables. */
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      private void E121Q2( )
      {
         /* Grid1_Load Routine */
         AV28detalle = context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", "Modern") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDetalle_Internalname, "Bitmap", context.convertURL( AV28detalle));
         pr_default.dynParam(2, new Object[]{ new Object[]{
                                              AV15TTBUS2_EstadoEnvio ,
                                              A26TTBUS2_EstadoEnvio ,
                                              A24TTBUS2_RespDesde ,
                                              AV10USUARIO },
                                              new int[] {
                                              TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.STRING
                                              }
         });
         /* Using cursor H001Q4 */
         pr_default.execute(2, new Object[] {AV10USUARIO, AV15TTBUS2_EstadoEnvio});
         while ( (pr_default.getStatus(2) != 101) )
         {
            A25TTBUS2_RespHacia = H001Q4_A25TTBUS2_RespHacia[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25TTBUS2_RespHacia", A25TTBUS2_RespHacia);
            A49TTBUS2_CodPosHacia = H001Q4_A49TTBUS2_CodPosHacia[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A49TTBUS2_CodPosHacia", StringUtil.LTrim( StringUtil.Str( (decimal)(A49TTBUS2_CodPosHacia), 3, 0)));
            A22TTBUS2_IdBien = H001Q4_A22TTBUS2_IdBien[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22TTBUS2_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A22TTBUS2_IdBien), 8, 0)));
            A26TTBUS2_EstadoEnvio = H001Q4_A26TTBUS2_EstadoEnvio[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26TTBUS2_EstadoEnvio", StringUtil.Str( (decimal)(A26TTBUS2_EstadoEnvio), 1, 0));
            A24TTBUS2_RespDesde = H001Q4_A24TTBUS2_RespDesde[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24TTBUS2_RespDesde", A24TTBUS2_RespDesde);
            A45TTBUS2_FechaEnvio = H001Q4_A45TTBUS2_FechaEnvio[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A45TTBUS2_FechaEnvio", context.localUtil.TToC( A45TTBUS2_FechaEnvio, 10, 5, 0, 3, "/", ":", " "));
            A47TTBUS2_MotivoEnvio = H001Q4_A47TTBUS2_MotivoEnvio[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A47TTBUS2_MotivoEnvio", A47TTBUS2_MotivoEnvio);
            A87TTBUS2_Observaciones = H001Q4_A87TTBUS2_Observaciones[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A87TTBUS2_Observaciones", A87TTBUS2_Observaciones);
            n87TTBUS2_Observaciones = H001Q4_n87TTBUS2_Observaciones[0] ;
            A52TTBUS2_IdMovimiento = H001Q4_A52TTBUS2_IdMovimiento[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52TTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(A52TTBUS2_IdMovimiento), 12, 0)));
            AV19gTTBUS2_IdMovimiento = A52TTBUS2_IdMovimiento ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19gTTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(AV19gTTBUS2_IdMovimiento), 12, 0)));
            new ptbus009(context ).execute(  A22TTBUS2_IdBien,  1, out  AV29gNumeroIdentificador) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22TTBUS2_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A22TTBUS2_IdBien), 8, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29gNumeroIdentificador", AV29gNumeroIdentificador);
            AV18gTTBUS2_IdBien = A22TTBUS2_IdBien ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18gTTBUS2_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18gTTBUS2_IdBien), 8, 0)));
            /* Using cursor H001Q5 */
            pr_default.execute(3, new Object[] {A22TTBUS2_IdBien});
            while ( (pr_default.getStatus(3) != 101) )
            {
               A11TTBUS_Id = H001Q5_A11TTBUS_Id[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
               A12TTBUS_Descripcion = H001Q5_A12TTBUS_Descripcion[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
               AV5TTBUS_Descripcion = A12TTBUS_Descripcion ;
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(3);
            AV17gTTBUS2_CodPosHacia = A49TTBUS2_CodPosHacia ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17gTTBUS2_CodPosHacia", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17gTTBUS2_CodPosHacia), 3, 0)));
            /* Using cursor H001Q6 */
            pr_default.execute(4, new Object[] {A49TTBUS2_CodPosHacia});
            while ( (pr_default.getStatus(4) != 101) )
            {
               A33TTBUS7_Pos = H001Q6_A33TTBUS7_Pos[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
               A34TTBUS7_Des = H001Q6_A34TTBUS7_Des[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34TTBUS7_Des", A34TTBUS7_Des);
               n34TTBUS7_Des = H001Q6_n34TTBUS7_Des[0] ;
               A34TTBUS7_Des = H001Q6_A34TTBUS7_Des[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34TTBUS7_Des", A34TTBUS7_Des);
               n34TTBUS7_Des = H001Q6_n34TTBUS7_Des[0] ;
               AV16hTTBUS3_Des = A34TTBUS7_Des ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16hTTBUS3_Des", AV16hTTBUS3_Des);
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(4);
            AV20gTTBUS2_RespHacia = A25TTBUS2_RespHacia ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20gTTBUS2_RespHacia", AV20gTTBUS2_RespHacia);
            /* Using cursor H001Q7 */
            pr_default.execute(5, new Object[] {A25TTBUS2_RespHacia});
            while ( (pr_default.getStatus(5) != 101) )
            {
               A6USU_COD = H001Q7_A6USU_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
               A7USU_DES = H001Q7_A7USU_DES[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7USU_DES", A7USU_DES);
               AV12hUSU_DES = A7USU_DES ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12hUSU_DES", AV12hUSU_DES);
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(5);
            AV26gTTBUS2_RespDesde = A24TTBUS2_RespDesde ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26gTTBUS2_RespDesde", AV26gTTBUS2_RespDesde);
            AV21gTTBUS2_FechaEnvio = A45TTBUS2_FechaEnvio ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21gTTBUS2_FechaEnvio", context.localUtil.TToC( AV21gTTBUS2_FechaEnvio, 10, 5, 0, 3, "/", ":", " "));
            AV20gTTBUS2_RespHacia = A25TTBUS2_RespHacia ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20gTTBUS2_RespHacia", AV20gTTBUS2_RespHacia);
            AV22gTTBUS2_MotivoEnvio = A47TTBUS2_MotivoEnvio ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22gTTBUS2_MotivoEnvio", AV22gTTBUS2_MotivoEnvio);
            AV23gTTBUS2_Observaciones = A87TTBUS2_Observaciones ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23gTTBUS2_Observaciones", AV23gTTBUS2_Observaciones);
            AV24gTTBUS2_EstadoEnvio = A26TTBUS2_EstadoEnvio ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24gTTBUS2_EstadoEnvio", StringUtil.Str( (decimal)(AV24gTTBUS2_EstadoEnvio), 1, 0));
            /* Load Method */
            if ( wbStart != -1 )
            {
               wbStart = 24 ;
            }
            if ( ( subGrid1_Islastpage == 1 ) || ( 10 == 0 ) || ( ( GRID1_nCurrentRecord >= GRID1_nFirstRecordOnPage ) && ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) )
            {
               sendrow_242( ) ;
               GRID1_nEOF = 1 ;
               if ( ( subGrid1_Islastpage == 1 ) && ( ((int)(GRID1_nCurrentRecord) % (subGrid1_Recordsperpage( ))) == 0 ) )
               {
                  GRID1_nFirstRecordOnPage = GRID1_nCurrentRecord ;
               }
            }
            if ( GRID1_nCurrentRecord >= GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) )
            {
               GRID1_nEOF = 0 ;
            }
            GRID1_nCurrentRecord = (int)(GRID1_nCurrentRecord+1) ;
            pr_default.readNext(2);
         }
         pr_default.close(2);
         /* Using cursor H001Q8 */
         pr_default.execute(6, new Object[] {AV10USUARIO});
         while ( (pr_default.getStatus(6) != 101) )
         {
            BRK1Q7 = false ;
            A53TTBUS2_IdUsuario = H001Q8_A53TTBUS2_IdUsuario[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A53TTBUS2_IdUsuario", A53TTBUS2_IdUsuario);
            A26TTBUS2_EstadoEnvio = H001Q8_A26TTBUS2_EstadoEnvio[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26TTBUS2_EstadoEnvio", StringUtil.Str( (decimal)(A26TTBUS2_EstadoEnvio), 1, 0));
            A52TTBUS2_IdMovimiento = H001Q8_A52TTBUS2_IdMovimiento[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52TTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(A52TTBUS2_IdMovimiento), 12, 0)));
            A22TTBUS2_IdBien = H001Q8_A22TTBUS2_IdBien[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22TTBUS2_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A22TTBUS2_IdBien), 8, 0)));
            A49TTBUS2_CodPosHacia = H001Q8_A49TTBUS2_CodPosHacia[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A49TTBUS2_CodPosHacia", StringUtil.LTrim( StringUtil.Str( (decimal)(A49TTBUS2_CodPosHacia), 3, 0)));
            A25TTBUS2_RespHacia = H001Q8_A25TTBUS2_RespHacia[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25TTBUS2_RespHacia", A25TTBUS2_RespHacia);
            A24TTBUS2_RespDesde = H001Q8_A24TTBUS2_RespDesde[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24TTBUS2_RespDesde", A24TTBUS2_RespDesde);
            A45TTBUS2_FechaEnvio = H001Q8_A45TTBUS2_FechaEnvio[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A45TTBUS2_FechaEnvio", context.localUtil.TToC( A45TTBUS2_FechaEnvio, 10, 5, 0, 3, "/", ":", " "));
            A47TTBUS2_MotivoEnvio = H001Q8_A47TTBUS2_MotivoEnvio[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A47TTBUS2_MotivoEnvio", A47TTBUS2_MotivoEnvio);
            A87TTBUS2_Observaciones = H001Q8_A87TTBUS2_Observaciones[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A87TTBUS2_Observaciones", A87TTBUS2_Observaciones);
            n87TTBUS2_Observaciones = H001Q8_n87TTBUS2_Observaciones[0] ;
            A102TTBUS2_TipoResp = H001Q8_A102TTBUS2_TipoResp[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A102TTBUS2_TipoResp", A102TTBUS2_TipoResp);
            A26TTBUS2_EstadoEnvio = H001Q8_A26TTBUS2_EstadoEnvio[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26TTBUS2_EstadoEnvio", StringUtil.Str( (decimal)(A26TTBUS2_EstadoEnvio), 1, 0));
            A22TTBUS2_IdBien = H001Q8_A22TTBUS2_IdBien[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22TTBUS2_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A22TTBUS2_IdBien), 8, 0)));
            A49TTBUS2_CodPosHacia = H001Q8_A49TTBUS2_CodPosHacia[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A49TTBUS2_CodPosHacia", StringUtil.LTrim( StringUtil.Str( (decimal)(A49TTBUS2_CodPosHacia), 3, 0)));
            A25TTBUS2_RespHacia = H001Q8_A25TTBUS2_RespHacia[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25TTBUS2_RespHacia", A25TTBUS2_RespHacia);
            A24TTBUS2_RespDesde = H001Q8_A24TTBUS2_RespDesde[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24TTBUS2_RespDesde", A24TTBUS2_RespDesde);
            A45TTBUS2_FechaEnvio = H001Q8_A45TTBUS2_FechaEnvio[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A45TTBUS2_FechaEnvio", context.localUtil.TToC( A45TTBUS2_FechaEnvio, 10, 5, 0, 3, "/", ":", " "));
            A47TTBUS2_MotivoEnvio = H001Q8_A47TTBUS2_MotivoEnvio[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A47TTBUS2_MotivoEnvio", A47TTBUS2_MotivoEnvio);
            A87TTBUS2_Observaciones = H001Q8_A87TTBUS2_Observaciones[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A87TTBUS2_Observaciones", A87TTBUS2_Observaciones);
            n87TTBUS2_Observaciones = H001Q8_n87TTBUS2_Observaciones[0] ;
            AV25TTBUS2_IdMovimiento = A52TTBUS2_IdMovimiento ;
            if ( StringUtil.StrCmp(A102TTBUS2_TipoResp, "E") == 0 )
            {
               while ( (pr_default.getStatus(6) != 101) && ( StringUtil.StrCmp(H001Q8_A53TTBUS2_IdUsuario[0], A53TTBUS2_IdUsuario) == 0 ) && ( H001Q8_A52TTBUS2_IdMovimiento[0] == A52TTBUS2_IdMovimiento ) )
               {
                  BRK1Q7 = false ;
                  A26TTBUS2_EstadoEnvio = H001Q8_A26TTBUS2_EstadoEnvio[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26TTBUS2_EstadoEnvio", StringUtil.Str( (decimal)(A26TTBUS2_EstadoEnvio), 1, 0));
                  A22TTBUS2_IdBien = H001Q8_A22TTBUS2_IdBien[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22TTBUS2_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A22TTBUS2_IdBien), 8, 0)));
                  A49TTBUS2_CodPosHacia = H001Q8_A49TTBUS2_CodPosHacia[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A49TTBUS2_CodPosHacia", StringUtil.LTrim( StringUtil.Str( (decimal)(A49TTBUS2_CodPosHacia), 3, 0)));
                  A25TTBUS2_RespHacia = H001Q8_A25TTBUS2_RespHacia[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25TTBUS2_RespHacia", A25TTBUS2_RespHacia);
                  A24TTBUS2_RespDesde = H001Q8_A24TTBUS2_RespDesde[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24TTBUS2_RespDesde", A24TTBUS2_RespDesde);
                  A45TTBUS2_FechaEnvio = H001Q8_A45TTBUS2_FechaEnvio[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A45TTBUS2_FechaEnvio", context.localUtil.TToC( A45TTBUS2_FechaEnvio, 10, 5, 0, 3, "/", ":", " "));
                  A47TTBUS2_MotivoEnvio = H001Q8_A47TTBUS2_MotivoEnvio[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A47TTBUS2_MotivoEnvio", A47TTBUS2_MotivoEnvio);
                  A87TTBUS2_Observaciones = H001Q8_A87TTBUS2_Observaciones[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A87TTBUS2_Observaciones", A87TTBUS2_Observaciones);
                  n87TTBUS2_Observaciones = H001Q8_n87TTBUS2_Observaciones[0] ;
                  A102TTBUS2_TipoResp = H001Q8_A102TTBUS2_TipoResp[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A102TTBUS2_TipoResp", A102TTBUS2_TipoResp);
                  A26TTBUS2_EstadoEnvio = H001Q8_A26TTBUS2_EstadoEnvio[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26TTBUS2_EstadoEnvio", StringUtil.Str( (decimal)(A26TTBUS2_EstadoEnvio), 1, 0));
                  A22TTBUS2_IdBien = H001Q8_A22TTBUS2_IdBien[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22TTBUS2_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A22TTBUS2_IdBien), 8, 0)));
                  A49TTBUS2_CodPosHacia = H001Q8_A49TTBUS2_CodPosHacia[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A49TTBUS2_CodPosHacia", StringUtil.LTrim( StringUtil.Str( (decimal)(A49TTBUS2_CodPosHacia), 3, 0)));
                  A25TTBUS2_RespHacia = H001Q8_A25TTBUS2_RespHacia[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25TTBUS2_RespHacia", A25TTBUS2_RespHacia);
                  A24TTBUS2_RespDesde = H001Q8_A24TTBUS2_RespDesde[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24TTBUS2_RespDesde", A24TTBUS2_RespDesde);
                  A45TTBUS2_FechaEnvio = H001Q8_A45TTBUS2_FechaEnvio[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A45TTBUS2_FechaEnvio", context.localUtil.TToC( A45TTBUS2_FechaEnvio, 10, 5, 0, 3, "/", ":", " "));
                  A47TTBUS2_MotivoEnvio = H001Q8_A47TTBUS2_MotivoEnvio[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A47TTBUS2_MotivoEnvio", A47TTBUS2_MotivoEnvio);
                  A87TTBUS2_Observaciones = H001Q8_A87TTBUS2_Observaciones[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A87TTBUS2_Observaciones", A87TTBUS2_Observaciones);
                  n87TTBUS2_Observaciones = H001Q8_n87TTBUS2_Observaciones[0] ;
                  if ( A52TTBUS2_IdMovimiento == AV25TTBUS2_IdMovimiento )
                  {
                     if ( (0==AV15TTBUS2_EstadoEnvio) || ( ( A26TTBUS2_EstadoEnvio == AV15TTBUS2_EstadoEnvio ) ) )
                     {
                        AV19gTTBUS2_IdMovimiento = A52TTBUS2_IdMovimiento ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19gTTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(AV19gTTBUS2_IdMovimiento), 12, 0)));
                        AV18gTTBUS2_IdBien = A22TTBUS2_IdBien ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18gTTBUS2_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18gTTBUS2_IdBien), 8, 0)));
                        /* Using cursor H001Q9 */
                        pr_default.execute(7, new Object[] {A22TTBUS2_IdBien});
                        while ( (pr_default.getStatus(7) != 101) )
                        {
                           A11TTBUS_Id = H001Q9_A11TTBUS_Id[0] ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
                           A12TTBUS_Descripcion = H001Q9_A12TTBUS_Descripcion[0] ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
                           AV5TTBUS_Descripcion = A12TTBUS_Descripcion ;
                           /* Exiting from a For First loop. */
                           if (true) break;
                        }
                        pr_default.close(7);
                        AV17gTTBUS2_CodPosHacia = A49TTBUS2_CodPosHacia ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17gTTBUS2_CodPosHacia", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17gTTBUS2_CodPosHacia), 3, 0)));
                        /* Using cursor H001Q10 */
                        pr_default.execute(8, new Object[] {A49TTBUS2_CodPosHacia});
                        while ( (pr_default.getStatus(8) != 101) )
                        {
                           A33TTBUS7_Pos = H001Q10_A33TTBUS7_Pos[0] ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
                           A34TTBUS7_Des = H001Q10_A34TTBUS7_Des[0] ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34TTBUS7_Des", A34TTBUS7_Des);
                           n34TTBUS7_Des = H001Q10_n34TTBUS7_Des[0] ;
                           A34TTBUS7_Des = H001Q10_A34TTBUS7_Des[0] ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34TTBUS7_Des", A34TTBUS7_Des);
                           n34TTBUS7_Des = H001Q10_n34TTBUS7_Des[0] ;
                           AV16hTTBUS3_Des = A34TTBUS7_Des ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16hTTBUS3_Des", AV16hTTBUS3_Des);
                           /* Exiting from a For First loop. */
                           if (true) break;
                        }
                        pr_default.close(8);
                        AV20gTTBUS2_RespHacia = A25TTBUS2_RespHacia ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20gTTBUS2_RespHacia", AV20gTTBUS2_RespHacia);
                        /* Using cursor H001Q11 */
                        pr_default.execute(9, new Object[] {A25TTBUS2_RespHacia});
                        while ( (pr_default.getStatus(9) != 101) )
                        {
                           A6USU_COD = H001Q11_A6USU_COD[0] ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
                           A7USU_DES = H001Q11_A7USU_DES[0] ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7USU_DES", A7USU_DES);
                           AV12hUSU_DES = A7USU_DES ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12hUSU_DES", AV12hUSU_DES);
                           /* Exiting from a For First loop. */
                           if (true) break;
                        }
                        pr_default.close(9);
                        AV26gTTBUS2_RespDesde = A24TTBUS2_RespDesde ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26gTTBUS2_RespDesde", AV26gTTBUS2_RespDesde);
                        AV21gTTBUS2_FechaEnvio = A45TTBUS2_FechaEnvio ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21gTTBUS2_FechaEnvio", context.localUtil.TToC( AV21gTTBUS2_FechaEnvio, 10, 5, 0, 3, "/", ":", " "));
                        AV20gTTBUS2_RespHacia = A25TTBUS2_RespHacia ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20gTTBUS2_RespHacia", AV20gTTBUS2_RespHacia);
                        AV22gTTBUS2_MotivoEnvio = A47TTBUS2_MotivoEnvio ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22gTTBUS2_MotivoEnvio", AV22gTTBUS2_MotivoEnvio);
                        AV23gTTBUS2_Observaciones = A87TTBUS2_Observaciones ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23gTTBUS2_Observaciones", AV23gTTBUS2_Observaciones);
                        AV24gTTBUS2_EstadoEnvio = A26TTBUS2_EstadoEnvio ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24gTTBUS2_EstadoEnvio", StringUtil.Str( (decimal)(AV24gTTBUS2_EstadoEnvio), 1, 0));
                        /* Load Method */
                        if ( wbStart != -1 )
                        {
                           wbStart = 24 ;
                        }
                        if ( ( subGrid1_Islastpage == 1 ) || ( 10 == 0 ) || ( ( GRID1_nCurrentRecord >= GRID1_nFirstRecordOnPage ) && ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) )
                        {
                           sendrow_242( ) ;
                           GRID1_nEOF = 1 ;
                           if ( ( subGrid1_Islastpage == 1 ) && ( ((int)(GRID1_nCurrentRecord) % (subGrid1_Recordsperpage( ))) == 0 ) )
                           {
                              GRID1_nFirstRecordOnPage = GRID1_nCurrentRecord ;
                           }
                        }
                        if ( GRID1_nCurrentRecord >= GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) )
                        {
                           GRID1_nEOF = 0 ;
                        }
                        GRID1_nCurrentRecord = (int)(GRID1_nCurrentRecord+1) ;
                     }
                  }
                  BRK1Q7 = true ;
                  pr_default.readNext(6);
               }
            }
            if ( ! BRK1Q7 )
            {
               BRK1Q7 = true ;
               pr_default.readNext(6);
            }
         }
         pr_default.close(6);
      }

      protected void E111Q2( )
      {
         /* 'Cancelar Envío' Routine */
         /* Start For Each Line */
         nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ",", ".")) ;
         nGXsfl_24_fel_idx = 0 ;
         while ( nGXsfl_24_fel_idx < nRC_Grid1 )
         {
            nGXsfl_24_fel_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_24_fel_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_24_fel_idx+1)) ;
            sGXsfl_24_fel_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_24_fel_idx), 4, 0)), 4, "0") ;
            chkavSeleccion_Internalname = "vSELECCION_"+sGXsfl_24_fel_idx ;
            edtavDetalle_Internalname = "vDETALLE_"+sGXsfl_24_fel_idx ;
            edtavGttbus2_idmovimiento_Internalname = "vGTTBUS2_IDMOVIMIENTO_"+sGXsfl_24_fel_idx ;
            edtavGnumeroidentificador_Internalname = "vGNUMEROIDENTIFICADOR_"+sGXsfl_24_fel_idx ;
            edtavGttbus2_idbien_Internalname = "vGTTBUS2_IDBIEN_"+sGXsfl_24_fel_idx ;
            edtavGttbus2_codposhacia_Internalname = "vGTTBUS2_CODPOSHACIA_"+sGXsfl_24_fel_idx ;
            edtavHttbus3_des_Internalname = "vHTTBUS3_DES_"+sGXsfl_24_fel_idx ;
            edtavGttbus2_respdesde_Internalname = "vGTTBUS2_RESPDESDE_"+sGXsfl_24_fel_idx ;
            edtavGttbus2_resphacia_Internalname = "vGTTBUS2_RESPHACIA_"+sGXsfl_24_fel_idx ;
            edtavHusu_des_Internalname = "vHUSU_DES_"+sGXsfl_24_fel_idx ;
            edtavGttbus2_fechaenvio_Internalname = "vGTTBUS2_FECHAENVIO_"+sGXsfl_24_fel_idx ;
            edtavGttbus2_motivoenvio_Internalname = "vGTTBUS2_MOTIVOENVIO_"+sGXsfl_24_fel_idx ;
            edtavGttbus2_observaciones_Internalname = "vGTTBUS2_OBSERVACIONES_"+sGXsfl_24_fel_idx ;
            cmbavGttbus2_estadoenvio_Internalname = "vGTTBUS2_ESTADOENVIO_"+sGXsfl_24_fel_idx ;
            if ( ! context.localUtil.VCNumber( cgiGet( chkavSeleccion_Internalname), "9") || ( ((StringUtil.StrCmp(cgiGet( chkavSeleccion_Internalname), "1")==0) ? 1 : 0) < 0 ) || ( ( ((StringUtil.StrCmp(cgiGet( chkavSeleccion_Internalname), "1")==0) ? 1 : 0) > 9 ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vSELECCION");
               GX_FocusControl = chkavSeleccion_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV27seleccion = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27seleccion", StringUtil.Str( (decimal)(AV27seleccion), 1, 0));
            }
            else
            {
               AV27seleccion = (short)(((StringUtil.StrCmp(cgiGet( chkavSeleccion_Internalname), "1")==0) ? 1 : 0)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27seleccion", StringUtil.Str( (decimal)(AV27seleccion), 1, 0));
            }
            AV28detalle = cgiGet( "GXimg"+edtavDetalle_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDetalle_Internalname, "Bitmap", context.convertURL( AV28detalle));
            if ( ! context.localUtil.VCNumber( cgiGet( edtavGttbus2_idmovimiento_Internalname), "ZZZZZZZZZZZ9") || ( context.localUtil.CToN( cgiGet( edtavGttbus2_idmovimiento_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavGttbus2_idmovimiento_Internalname), ",", ".") > Convert.ToDecimal( 999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vGTTBUS2_IDMOVIMIENTO");
               GX_FocusControl = edtavGttbus2_idmovimiento_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV19gTTBUS2_IdMovimiento = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19gTTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(AV19gTTBUS2_IdMovimiento), 12, 0)));
            }
            else
            {
               AV19gTTBUS2_IdMovimiento = (long)(context.localUtil.CToN( cgiGet( edtavGttbus2_idmovimiento_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19gTTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(AV19gTTBUS2_IdMovimiento), 12, 0)));
            }
            AV29gNumeroIdentificador = cgiGet( edtavGnumeroidentificador_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29gNumeroIdentificador", AV29gNumeroIdentificador);
            if ( ! context.localUtil.VCNumber( cgiGet( edtavGttbus2_idbien_Internalname), "ZZZZZZZ9") || ( context.localUtil.CToN( cgiGet( edtavGttbus2_idbien_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavGttbus2_idbien_Internalname), ",", ".") > Convert.ToDecimal( 99999999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vGTTBUS2_IDBIEN");
               GX_FocusControl = edtavGttbus2_idbien_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV18gTTBUS2_IdBien = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18gTTBUS2_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18gTTBUS2_IdBien), 8, 0)));
            }
            else
            {
               AV18gTTBUS2_IdBien = (int)(context.localUtil.CToN( cgiGet( edtavGttbus2_idbien_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18gTTBUS2_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18gTTBUS2_IdBien), 8, 0)));
            }
            if ( ! context.localUtil.VCNumber( cgiGet( edtavGttbus2_codposhacia_Internalname), "ZZ9") || ( context.localUtil.CToN( cgiGet( edtavGttbus2_codposhacia_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavGttbus2_codposhacia_Internalname), ",", ".") > Convert.ToDecimal( 999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vGTTBUS2_CODPOSHACIA");
               GX_FocusControl = edtavGttbus2_codposhacia_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV17gTTBUS2_CodPosHacia = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17gTTBUS2_CodPosHacia", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17gTTBUS2_CodPosHacia), 3, 0)));
            }
            else
            {
               AV17gTTBUS2_CodPosHacia = (short)(context.localUtil.CToN( cgiGet( edtavGttbus2_codposhacia_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17gTTBUS2_CodPosHacia", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17gTTBUS2_CodPosHacia), 3, 0)));
            }
            AV16hTTBUS3_Des = cgiGet( edtavHttbus3_des_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16hTTBUS3_Des", AV16hTTBUS3_Des);
            AV26gTTBUS2_RespDesde = cgiGet( edtavGttbus2_respdesde_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26gTTBUS2_RespDesde", AV26gTTBUS2_RespDesde);
            AV20gTTBUS2_RespHacia = cgiGet( edtavGttbus2_resphacia_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20gTTBUS2_RespHacia", AV20gTTBUS2_RespHacia);
            AV12hUSU_DES = StringUtil.Upper( cgiGet( edtavHusu_des_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12hUSU_DES", AV12hUSU_DES);
            if ( context.localUtil.VCDateTime( cgiGet( edtavGttbus2_fechaenvio_Internalname), 4, 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"g TTBUS2_ Fecha Envio"}), 1, "vGTTBUS2_FECHAENVIO");
               GX_FocusControl = edtavGttbus2_fechaenvio_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV21gTTBUS2_FechaEnvio = (DateTime)(DateTime.MinValue) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21gTTBUS2_FechaEnvio", context.localUtil.TToC( AV21gTTBUS2_FechaEnvio, 10, 5, 0, 3, "/", ":", " "));
            }
            else
            {
               AV21gTTBUS2_FechaEnvio = context.localUtil.CToT( cgiGet( edtavGttbus2_fechaenvio_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21gTTBUS2_FechaEnvio", context.localUtil.TToC( AV21gTTBUS2_FechaEnvio, 10, 5, 0, 3, "/", ":", " "));
            }
            AV22gTTBUS2_MotivoEnvio = StringUtil.Upper( cgiGet( edtavGttbus2_motivoenvio_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22gTTBUS2_MotivoEnvio", AV22gTTBUS2_MotivoEnvio);
            AV23gTTBUS2_Observaciones = StringUtil.Upper( cgiGet( edtavGttbus2_observaciones_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23gTTBUS2_Observaciones", AV23gTTBUS2_Observaciones);
            cmbavGttbus2_estadoenvio.Name = cmbavGttbus2_estadoenvio_Internalname ;
            cmbavGttbus2_estadoenvio.CurrentValue = cgiGet( cmbavGttbus2_estadoenvio_Internalname) ;
            AV24gTTBUS2_EstadoEnvio = (short)(NumberUtil.Val( cgiGet( cmbavGttbus2_estadoenvio_Internalname), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24gTTBUS2_EstadoEnvio", StringUtil.Str( (decimal)(AV24gTTBUS2_EstadoEnvio), 1, 0));
            if ( AV27seleccion == 1 )
            {
               if ( AV24gTTBUS2_EstadoEnvio == 1 )
               {
                  /* Using cursor H001Q12 */
                  pr_default.execute(10, new Object[] {AV18gTTBUS2_IdBien});
                  while ( (pr_default.getStatus(10) != 101) )
                  {
                     A11TTBUS_Id = H001Q12_A11TTBUS_Id[0] ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
                     A12TTBUS_Descripcion = H001Q12_A12TTBUS_Descripcion[0] ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
                     AV5TTBUS_Descripcion = StringUtil.Trim( A12TTBUS_Descripcion) ;
                     /* Exiting from a For First loop. */
                     if (true) break;
                  }
                  pr_default.close(10);
                  context.PopUp(formatLink("ttbus002_c.aspx") + "?" + UrlEncode("" +AV19gTTBUS2_IdMovimiento) + "," + UrlEncode("" +AV18gTTBUS2_IdBien) + "," + UrlEncode(StringUtil.RTrim(AV5TTBUS_Descripcion)) + "," + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode(StringUtil.RTrim(AV11SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV10USUARIO)), new Object[] {"AV19gTTBUS2_IdMovimiento","AV18gTTBUS2_IdBien","AV5TTBUS_Descripcion","","AV11SISTEMA","AV10USUARIO"});
                  context.DoAjaxRefresh();
                  GX_msglist.addItem("EL ENVÍO FUE CANCELADO.");
               }
               else
               {
                  GX_msglist.addItem("NO PUEDE CANCELAR UN ENVÍO FINALIZADO");
               }
            }
            else
            {
               GX_msglist.addItem("DEBE SELECCIONAR UN ENVÍO.");
            }
            /* End For Each Line */
         }
         if ( nGXsfl_24_fel_idx == 0 )
         {
            nGXsfl_24_idx = 1 ;
            sGXsfl_24_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_24_idx), 4, 0)), 4, "0") ;
            chkavSeleccion_Internalname = "vSELECCION_"+sGXsfl_24_idx ;
            edtavDetalle_Internalname = "vDETALLE_"+sGXsfl_24_idx ;
            edtavGttbus2_idmovimiento_Internalname = "vGTTBUS2_IDMOVIMIENTO_"+sGXsfl_24_idx ;
            edtavGnumeroidentificador_Internalname = "vGNUMEROIDENTIFICADOR_"+sGXsfl_24_idx ;
            edtavGttbus2_idbien_Internalname = "vGTTBUS2_IDBIEN_"+sGXsfl_24_idx ;
            edtavGttbus2_codposhacia_Internalname = "vGTTBUS2_CODPOSHACIA_"+sGXsfl_24_idx ;
            edtavHttbus3_des_Internalname = "vHTTBUS3_DES_"+sGXsfl_24_idx ;
            edtavGttbus2_respdesde_Internalname = "vGTTBUS2_RESPDESDE_"+sGXsfl_24_idx ;
            edtavGttbus2_resphacia_Internalname = "vGTTBUS2_RESPHACIA_"+sGXsfl_24_idx ;
            edtavHusu_des_Internalname = "vHUSU_DES_"+sGXsfl_24_idx ;
            edtavGttbus2_fechaenvio_Internalname = "vGTTBUS2_FECHAENVIO_"+sGXsfl_24_idx ;
            edtavGttbus2_motivoenvio_Internalname = "vGTTBUS2_MOTIVOENVIO_"+sGXsfl_24_idx ;
            edtavGttbus2_observaciones_Internalname = "vGTTBUS2_OBSERVACIONES_"+sGXsfl_24_idx ;
            cmbavGttbus2_estadoenvio_Internalname = "vGTTBUS2_ESTADOENVIO_"+sGXsfl_24_idx ;
         }
         nGXsfl_24_fel_idx = 1 ;
      }

      protected void wb_table1_2_1Q2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            sStyleString = sStyleString + " height: " + StringUtil.LTrim( StringUtil.Str( (decimal)(104), 10, 0)) + "px" + ";" ;
            sStyleString = sStyleString + " width: " + StringUtil.LTrim( StringUtil.Str( (decimal)(918), 10, 0)) + "px" + ";" ;
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            ClassString = "ErrorViewer" ;
            StyleString = "" ;
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_10_1Q2( true) ;
         }
         else
         {
            wb_table2_10_1Q2( false) ;
         }
         return  ;
      }

      protected void wb_table2_10_1Q2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
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
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Nº Mov.") ;
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
               context.SendWebValue( "g TTBUS2_ Resp Desde") ;
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
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Observaciones") ;
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
               Grid1Container.AddObjectProperty("CmpContext", "");
               Grid1Container.AddObjectProperty("InMasterPage", "false");
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV27seleccion), 1, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", context.convertURL( AV28detalle));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV19gTTBUS2_IdMovimiento), 12, 0, ".", "")));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavGttbus2_idmovimiento_Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( AV29gNumeroIdentificador));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavGnumeroidentificador_Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18gTTBUS2_IdBien), 8, 0, ".", "")));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavGttbus2_idbien_Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV17gTTBUS2_CodPosHacia), 3, 0, ".", "")));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavGttbus2_codposhacia_Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( AV16hTTBUS3_Des));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavHttbus3_des_Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( AV26gTTBUS2_RespDesde));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavGttbus2_respdesde_Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( AV20gTTBUS2_RespHacia));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavGttbus2_resphacia_Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( AV12hUSU_DES));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavHusu_des_Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", context.localUtil.Format(AV21gTTBUS2_FechaEnvio, "99/99/9999 99:99"));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavGttbus2_fechaenvio_Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( AV22gTTBUS2_MotivoEnvio));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavGttbus2_motivoenvio_Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( AV23gTTBUS2_Observaciones));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavGttbus2_observaciones_Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV24gTTBUS2_EstadoEnvio), 1, 0, ".", "")));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbavGttbus2_estadoenvio.Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Allowselection", "false");
               Grid1Container.AddObjectProperty("Allowcollapsing", "false");
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 9, 0, ".", "")));
            }
         }
         if ( wbEnd == 24 )
         {
            wbEnd = 0 ;
            nRC_Grid1 = (short)(nGXsfl_24_idx-1) ;
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
            }
            else
            {
               Grid1Container.AddObjectProperty("GRID1_nEOF", GRID1_nEOF);
               Grid1Container.AddObjectProperty("GRID1_nFirstRecordOnPage", GRID1_nFirstRecordOnPage);
               sStyleString = " style=\"display:none;\"" ;
               sStyleString = "" ;
               context.WriteHtmlText( "<div id=\""+"Grid1Container"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Grid1", (Object)(Grid1Container));
               GxWebStd.gx_hidden_field( context, "Grid1ContainerData", Grid1Container.ToJavascriptSource());
               if ( context.isAjaxRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "Grid1ContainerData"+"V", Grid1Container.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Grid1ContainerData"+"V"+"\" value='"+Grid1Container.GridValuesHidden()+"'>") ;
               }
            }
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 41,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtnrecibir_Internalname, "Cancelar Envío", "Cancelar Envío", "", StyleString, ClassString, 1, 1, "rounded", 5, bttBtnrecibir_Jsonclick, "E\\'CANCELAR ENVíO\\'.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(24), 3, 0)+","+"null"+");", "", "HLP_HTBUS003c.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"height:15px\">") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"height:15px\">") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_1Q2e( true) ;
         }
         else
         {
            wb_table1_2_1Q2e( false) ;
         }
      }

      protected void wb_table2_10_1Q2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            sStyleString = sStyleString + " height: " + StringUtil.LTrim( StringUtil.Str( (decimal)(36), 10, 0)) + "px" + ";" ;
            sStyleString = sStyleString + " width: " + StringUtil.LTrim( StringUtil.Str( (decimal)(111), 10, 0)) + "px" + ";" ;
            GxWebStd.gx_table_start( context, tblTable2_Internalname, tblTable2_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock2_Internalname, 1, 1, 0, "Estado de Envío:", "", "", "", 0, lblTextblock2_Jsonclick, "", StyleString, ClassString, "HLP_HTBUS003c.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'" + sGXsfl_24_idx + "',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavTtbus2_estadoenvio, cmbavTtbus2_estadoenvio_Internalname, StringUtil.Str( (decimal)(AV15TTBUS2_EstadoEnvio), 1, 0), "", "int", 1, 1, 0, 1, 0, 1, "chr", 0, "", StyleString, ClassString, "", 0, cmbavTtbus2_estadoenvio_Jsonclick, "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(15);\"", true, "HLP_HTBUS003c.htm");
            cmbavTtbus2_estadoenvio.CurrentValue = StringUtil.Str( (decimal)(AV15TTBUS2_EstadoEnvio), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavTtbus2_estadoenvio_Internalname, "Values", (String)(cmbavTtbus2_estadoenvio.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttButton1_Internalname, "Buscar", "Buscar", "", StyleString, ClassString, 1, 1, "rounded", 5, bttButton1_Jsonclick, "EREFRESH.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(24), 3, 0)+","+"null"+");", "", "HLP_HTBUS003c.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_10_1Q2e( true) ;
         }
         else
         {
            wb_table2_10_1Q2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV10USUARIO = (String)getParm(obj,0) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10USUARIO", AV10USUARIO);
         AV11SISTEMA = (String)getParm(obj,1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11SISTEMA", AV11SISTEMA);
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
         PA1Q2( ) ;
         WS1Q2( ) ;
         WE1Q2( ) ;
         this.cleanup();
         context.SetWrapped(false);
         context.GX_msglist = BackMsgLst ;
         return "";
      }

      public void responsestatic( String sGXDynURL )
      {
      }

      protected void define_styles( )
      {
         AddStyleSheetFile("calendar-system.css", "?84120");
         AddThemeStyleSheetFile("", "Modern.css", "?2051812");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?13222239");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         if ( nGXWrapped != 1 )
         {
            context.AddJavascriptSource("messages.spa.js", "?42940");
            context.AddJavascriptSource("htbus003c.js", "?13222239");
         }
         /* End function include_jscripts */
      }

      protected void sendrow_242( )
      {
         WB1Q0( ) ;
         if ( ( 10 * 1 == 0 ) || ( nGXsfl_24_idx <= subGrid1_Recordsperpage( ) * 1 ) )
         {
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
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Grid1ContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid1_Backcolor), 9, 0)));
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
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Grid1ContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid1_Backcolor), 9, 0)));
            }
            else if ( subGrid1_Backcolorstyle == 3 )
            {
               /* Report style subfile background logic. */
               subGrid1_Backstyle = 1 ;
               if ( ((int)(nGXsfl_24_idx) % (2)) == 0 )
               {
                  subGrid1_Backcolor = (int)(0xE5E5E5) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Grid1ContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid1_Backcolor), 9, 0)));
                  if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Even" ;
                  }
               }
               else
               {
                  subGrid1_Backcolor = (int)(0xF0F0F0) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Grid1ContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid1_Backcolor), 9, 0)));
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
            TempTags = " " + ((chkavSeleccion.Enabled!=0)&&(chkavSeleccion.Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 25,'',false,'"+sGXsfl_24_idx+"',24)\"" : " ") ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            Grid1Row.AddColumnProperties("checkbox", 1, isAjaxCallMode( ), new Object[] {(String)chkavSeleccion_Internalname,StringUtil.Str( (decimal)(AV27seleccion), 1, 0),(String)"",(short)-1,(short)1,(String)"1",(String)"",(String)StyleString,(String)ClassString,TempTags+((chkavSeleccion.Enabled!=0)&&(chkavSeleccion.Visible!=0) ? " onclick=\"gx.fn.checkboxClick(25, this, 1, 0);gx.evt.onchange(this);\" " : " ")+((chkavSeleccion.Enabled!=0)&&(chkavSeleccion.Visible!=0) ? " onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(25);\"" : " ")});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Active Bitmap Variable */
            TempTags = " " + ((edtavDetalle_Enabled!=0)&&(edtavDetalle_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 26,'',false,'',24)\"" : " ") ;
            ClassString = "Image" ;
            StyleString = "" ;
            Grid1Row.AddColumnProperties("bitmap", 2, isAjaxCallMode( ), new Object[] {(String)edtavDetalle_Internalname,(String)"",(String)AV28detalle,(String)"Modern",(short)-1,(short)1,(String)"",(String)"Ver Identificadores",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"",(short)0,(short)0,(String)"",(String)"",(short)7,(String)edtavDetalle_Jsonclick,(String)"'"+""+"'"+",false,"+"'"+"e131q2_client"+"'",(String)StyleString,(String)ClassString,(String)"",(String)""+TempTags,(String)"''",(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            TempTags = " " + ((edtavGttbus2_idmovimiento_Enabled!=0)&&(edtavGttbus2_idmovimiento_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 27,'',false,'"+sGXsfl_24_idx+"',24)\"" : " ") ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavGttbus2_idmovimiento_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(AV19gTTBUS2_IdMovimiento), 12, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)12,(short)-1,(int)edtavGttbus2_idmovimiento_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(AV19gTTBUS2_IdMovimiento), "ZZZZZZZZZZZ9"),TempTags+((edtavGttbus2_idmovimiento_Enabled!=0)&&(edtavGttbus2_idmovimiento_Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((edtavGttbus2_idmovimiento_Enabled!=0)&&(edtavGttbus2_idmovimiento_Visible!=0) ? " onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(27);\"" : " "),(short)0,(String)edtavGttbus2_idmovimiento_Jsonclick,(String)"",(short)24,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            TempTags = " " + ((edtavGnumeroidentificador_Enabled!=0)&&(edtavGnumeroidentificador_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 28,'',false,'"+sGXsfl_24_idx+"',24)\"" : " ") ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavGnumeroidentificador_Internalname,StringUtil.RTrim( AV29gNumeroIdentificador),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)80,(short)-1,(int)edtavGnumeroidentificador_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( AV29gNumeroIdentificador, "")),TempTags+((edtavGnumeroidentificador_Enabled!=0)&&(edtavGnumeroidentificador_Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((edtavGnumeroidentificador_Enabled!=0)&&(edtavGnumeroidentificador_Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(28);\"" : " "),(short)0,(String)edtavGnumeroidentificador_Jsonclick,(String)"",(short)24,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            TempTags = " " + ((edtavGttbus2_idbien_Enabled!=0)&&(edtavGttbus2_idbien_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 29,'',false,'"+sGXsfl_24_idx+"',24)\"" : " ") ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavGttbus2_idbien_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18gTTBUS2_IdBien), 8, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)8,(short)-1,(int)edtavGttbus2_idbien_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(AV18gTTBUS2_IdBien), "ZZZZZZZ9"),TempTags+((edtavGttbus2_idbien_Enabled!=0)&&(edtavGttbus2_idbien_Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((edtavGttbus2_idbien_Enabled!=0)&&(edtavGttbus2_idbien_Visible!=0) ? " onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(29);\"" : " "),(short)0,(String)edtavGttbus2_idbien_Jsonclick,(String)"",(short)24,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            TempTags = " " + ((edtavGttbus2_codposhacia_Enabled!=0)&&(edtavGttbus2_codposhacia_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 30,'',false,'"+sGXsfl_24_idx+"',24)\"" : " ") ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavGttbus2_codposhacia_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(AV17gTTBUS2_CodPosHacia), 3, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)3,(short)0,(int)edtavGttbus2_codposhacia_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(AV17gTTBUS2_CodPosHacia), "ZZ9"),TempTags+((edtavGttbus2_codposhacia_Enabled!=0)&&(edtavGttbus2_codposhacia_Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((edtavGttbus2_codposhacia_Enabled!=0)&&(edtavGttbus2_codposhacia_Visible!=0) ? " onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(30);\"" : " "),(short)0,(String)edtavGttbus2_codposhacia_Jsonclick,(String)"",(short)24,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            TempTags = " " + ((edtavHttbus3_des_Enabled!=0)&&(edtavHttbus3_des_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 31,'',false,'"+sGXsfl_24_idx+"',24)\"" : " ") ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavHttbus3_des_Internalname,StringUtil.RTrim( AV16hTTBUS3_Des),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)50,(short)-1,(int)edtavHttbus3_des_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( AV16hTTBUS3_Des, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")),TempTags+((edtavHttbus3_des_Enabled!=0)&&(edtavHttbus3_des_Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((edtavHttbus3_des_Enabled!=0)&&(edtavHttbus3_des_Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(31);\"" : " "),(short)0,(String)edtavHttbus3_des_Jsonclick,(String)"",(short)24,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            TempTags = " " + ((edtavGttbus2_respdesde_Enabled!=0)&&(edtavGttbus2_respdesde_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 32,'',false,'"+sGXsfl_24_idx+"',24)\"" : " ") ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavGttbus2_respdesde_Internalname,StringUtil.RTrim( AV26gTTBUS2_RespDesde),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)15,(short)0,(int)edtavGttbus2_respdesde_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( AV26gTTBUS2_RespDesde, "XXXXXXXXXXXXXXX")),TempTags+((edtavGttbus2_respdesde_Enabled!=0)&&(edtavGttbus2_respdesde_Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((edtavGttbus2_respdesde_Enabled!=0)&&(edtavGttbus2_respdesde_Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(32);\"" : " "),(short)0,(String)edtavGttbus2_respdesde_Jsonclick,(String)"",(short)24,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            TempTags = " " + ((edtavGttbus2_resphacia_Enabled!=0)&&(edtavGttbus2_resphacia_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 33,'',false,'"+sGXsfl_24_idx+"',24)\"" : " ") ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavGttbus2_resphacia_Internalname,StringUtil.RTrim( AV20gTTBUS2_RespHacia),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)15,(short)0,(int)edtavGttbus2_resphacia_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( AV20gTTBUS2_RespHacia, "XXXXXXXXXXXXXXX")),TempTags+((edtavGttbus2_resphacia_Enabled!=0)&&(edtavGttbus2_resphacia_Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((edtavGttbus2_resphacia_Enabled!=0)&&(edtavGttbus2_resphacia_Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(33);\"" : " "),(short)0,(String)edtavGttbus2_resphacia_Jsonclick,(String)"",(short)24,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            TempTags = " " + ((edtavHusu_des_Enabled!=0)&&(edtavHusu_des_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 34,'',false,'"+sGXsfl_24_idx+"',24)\"" : " ") ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavHusu_des_Internalname,StringUtil.RTrim( AV12hUSU_DES),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)50,(short)-1,(int)edtavHusu_des_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( AV12hUSU_DES, "@!")),TempTags+((edtavHusu_des_Enabled!=0)&&(edtavHusu_des_Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((edtavHusu_des_Enabled!=0)&&(edtavHusu_des_Visible!=0) ? " onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(34);\"" : " "),(short)0,(String)edtavHusu_des_Jsonclick,(String)"",(short)24,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            TempTags = " " + ((edtavGttbus2_fechaenvio_Enabled!=0)&&(edtavGttbus2_fechaenvio_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 35,'',false,'"+sGXsfl_24_idx+"',24)\"" : " ") ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavGttbus2_fechaenvio_Internalname,context.localUtil.Format(AV21gTTBUS2_FechaEnvio, "99/99/9999 99:99"),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)16,(short)-1,(int)edtavGttbus2_fechaenvio_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( AV21gTTBUS2_FechaEnvio, "99/99/9999 99:99"),TempTags+((edtavGttbus2_fechaenvio_Enabled!=0)&&(edtavGttbus2_fechaenvio_Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((edtavGttbus2_fechaenvio_Enabled!=0)&&(edtavGttbus2_fechaenvio_Visible!=0) ? " onblur=\""+"gx.date.valid_date(this, 10,'DMY',5,24,'spa',false,0);"+";gx.evt.onblur(35);\"" : " "),(short)0,(String)edtavGttbus2_fechaenvio_Jsonclick,(String)"",(short)24,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            TempTags = " " + ((edtavGttbus2_motivoenvio_Enabled!=0)&&(edtavGttbus2_motivoenvio_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 36,'',false,'"+sGXsfl_24_idx+"',24)\"" : " ") ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavGttbus2_motivoenvio_Internalname,StringUtil.RTrim( AV22gTTBUS2_MotivoEnvio),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)100,(short)-1,(int)edtavGttbus2_motivoenvio_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( AV22gTTBUS2_MotivoEnvio, "@!")),TempTags+((edtavGttbus2_motivoenvio_Enabled!=0)&&(edtavGttbus2_motivoenvio_Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((edtavGttbus2_motivoenvio_Enabled!=0)&&(edtavGttbus2_motivoenvio_Visible!=0) ? " onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(36);\"" : " "),(short)0,(String)edtavGttbus2_motivoenvio_Jsonclick,(String)"",(short)24,(short)1,(short)0,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            TempTags = " " + ((edtavGttbus2_observaciones_Enabled!=0)&&(edtavGttbus2_observaciones_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 37,'',false,'"+sGXsfl_24_idx+"',24)\"" : " ") ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavGttbus2_observaciones_Internalname,StringUtil.RTrim( AV23gTTBUS2_Observaciones),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)400,(short)-1,(int)edtavGttbus2_observaciones_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( AV23gTTBUS2_Observaciones, "@!")),TempTags+((edtavGttbus2_observaciones_Enabled!=0)&&(edtavGttbus2_observaciones_Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((edtavGttbus2_observaciones_Enabled!=0)&&(edtavGttbus2_observaciones_Visible!=0) ? " onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(37);\"" : " "),(short)0,(String)edtavGttbus2_observaciones_Jsonclick,(String)"",(short)24,(short)1,(short)0,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = " " + ((cmbavGttbus2_estadoenvio.Enabled!=0)&&(cmbavGttbus2_estadoenvio.Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 38,'',false,'"+sGXsfl_24_idx+"',24)\"" : " ") ;
            if ( ( nGXsfl_24_idx == 1 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "vGTTBUS2_ESTADOENVIO_" + sGXsfl_24_idx ;
               cmbavGttbus2_estadoenvio.Name = GXCCtl ;
               cmbavGttbus2_estadoenvio.WebTags = "" ;
               cmbavGttbus2_estadoenvio.addItem("1", "No Finalizado", 0);
               cmbavGttbus2_estadoenvio.addItem("2", "Finalizado", 0);
               cmbavGttbus2_estadoenvio.addItem("3", "Cancelado", 0);
               if ( ( cmbavGttbus2_estadoenvio.ItemCount > 0 ) && (0==AV24gTTBUS2_EstadoEnvio) )
               {
                  AV24gTTBUS2_EstadoEnvio = (short)(NumberUtil.Val( cmbavGttbus2_estadoenvio.getItemValue(1), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24gTTBUS2_EstadoEnvio", StringUtil.Str( (decimal)(AV24gTTBUS2_EstadoEnvio), 1, 0));
               }
            }
            /* ComboBox */
            Grid1Row.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbavGttbus2_estadoenvio,(String)cmbavGttbus2_estadoenvio_Internalname,StringUtil.Str( (decimal)(AV24gTTBUS2_EstadoEnvio), 1, 0),(String)"",(String)"int",(short)-1,cmbavGttbus2_estadoenvio.Enabled,(short)0,(short)1,(short)0,(short)0,(String)"px",(short)0,(String)"",(String)StyleString,(String)ClassString,(String)"",(short)0,(String)cmbavGttbus2_estadoenvio_Jsonclick,(String)"",TempTags+((cmbavGttbus2_estadoenvio.Enabled!=0)&&(cmbavGttbus2_estadoenvio.Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((cmbavGttbus2_estadoenvio.Enabled!=0)&&(cmbavGttbus2_estadoenvio.Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(38);\"" : " "),(bool)true});
            cmbavGttbus2_estadoenvio.CurrentValue = StringUtil.Str( (decimal)(AV24gTTBUS2_EstadoEnvio), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavGttbus2_estadoenvio_Internalname, "Values", (String)(cmbavGttbus2_estadoenvio.ToJavascriptSource()));
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_24_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_24_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_24_idx+1)) ;
            sGXsfl_24_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_24_idx), 4, 0)), 4, "0") ;
            chkavSeleccion_Internalname = "vSELECCION_"+sGXsfl_24_idx ;
            edtavDetalle_Internalname = "vDETALLE_"+sGXsfl_24_idx ;
            edtavGttbus2_idmovimiento_Internalname = "vGTTBUS2_IDMOVIMIENTO_"+sGXsfl_24_idx ;
            edtavGnumeroidentificador_Internalname = "vGNUMEROIDENTIFICADOR_"+sGXsfl_24_idx ;
            edtavGttbus2_idbien_Internalname = "vGTTBUS2_IDBIEN_"+sGXsfl_24_idx ;
            edtavGttbus2_codposhacia_Internalname = "vGTTBUS2_CODPOSHACIA_"+sGXsfl_24_idx ;
            edtavHttbus3_des_Internalname = "vHTTBUS3_DES_"+sGXsfl_24_idx ;
            edtavGttbus2_respdesde_Internalname = "vGTTBUS2_RESPDESDE_"+sGXsfl_24_idx ;
            edtavGttbus2_resphacia_Internalname = "vGTTBUS2_RESPHACIA_"+sGXsfl_24_idx ;
            edtavHusu_des_Internalname = "vHUSU_DES_"+sGXsfl_24_idx ;
            edtavGttbus2_fechaenvio_Internalname = "vGTTBUS2_FECHAENVIO_"+sGXsfl_24_idx ;
            edtavGttbus2_motivoenvio_Internalname = "vGTTBUS2_MOTIVOENVIO_"+sGXsfl_24_idx ;
            edtavGttbus2_observaciones_Internalname = "vGTTBUS2_OBSERVACIONES_"+sGXsfl_24_idx ;
            cmbavGttbus2_estadoenvio_Internalname = "vGTTBUS2_ESTADOENVIO_"+sGXsfl_24_idx ;
         }
         /* End function sendrow_242 */
      }

      protected void init_default_properties( )
      {
         lblTextblock2_Internalname = "TEXTBLOCK2" ;
         cmbavTtbus2_estadoenvio_Internalname = "vTTBUS2_ESTADOENVIO" ;
         bttButton1_Internalname = "BUTTON1" ;
         tblTable2_Internalname = "TABLE2" ;
         bttBtnrecibir_Internalname = "BTNRECIBIR" ;
         tblTable1_Internalname = "TABLE1" ;
         Form.Internalname = "FORM" ;
         subGrid1_Internalname = "GRID1" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         cmbavGttbus2_estadoenvio_Jsonclick = "" ;
         cmbavGttbus2_estadoenvio.Visible = -1 ;
         edtavGttbus2_observaciones_Jsonclick = "" ;
         edtavGttbus2_observaciones_Visible = -1 ;
         edtavGttbus2_motivoenvio_Jsonclick = "" ;
         edtavGttbus2_motivoenvio_Visible = -1 ;
         edtavGttbus2_fechaenvio_Jsonclick = "" ;
         edtavGttbus2_fechaenvio_Visible = -1 ;
         edtavHusu_des_Jsonclick = "" ;
         edtavHusu_des_Visible = -1 ;
         edtavGttbus2_resphacia_Jsonclick = "" ;
         edtavGttbus2_resphacia_Visible = 0 ;
         edtavGttbus2_respdesde_Jsonclick = "" ;
         edtavGttbus2_respdesde_Visible = 0 ;
         edtavHttbus3_des_Jsonclick = "" ;
         edtavHttbus3_des_Visible = -1 ;
         edtavGttbus2_codposhacia_Jsonclick = "" ;
         edtavGttbus2_codposhacia_Visible = 0 ;
         edtavGttbus2_idbien_Jsonclick = "" ;
         edtavGttbus2_idbien_Visible = -1 ;
         edtavGnumeroidentificador_Jsonclick = "" ;
         edtavGnumeroidentificador_Visible = -1 ;
         edtavGttbus2_idmovimiento_Jsonclick = "" ;
         edtavGttbus2_idmovimiento_Visible = -1 ;
         edtavDetalle_Jsonclick = "" ;
         edtavDetalle_Visible = -1 ;
         edtavDetalle_Enabled = 1 ;
         chkavSeleccion.Visible = -1 ;
         chkavSeleccion.Enabled = 1 ;
         cmbavTtbus2_estadoenvio_Jsonclick = "" ;
         cmbavGttbus2_estadoenvio.Enabled = 1 ;
         edtavGttbus2_observaciones_Enabled = 1 ;
         edtavGttbus2_motivoenvio_Enabled = 1 ;
         edtavGttbus2_fechaenvio_Enabled = 1 ;
         edtavHusu_des_Enabled = 1 ;
         edtavGttbus2_resphacia_Enabled = 1 ;
         edtavGttbus2_respdesde_Enabled = 1 ;
         edtavHttbus3_des_Enabled = 1 ;
         edtavGttbus2_codposhacia_Enabled = 1 ;
         edtavGttbus2_idbien_Enabled = 1 ;
         edtavGnumeroidentificador_Enabled = 1 ;
         edtavGttbus2_idmovimiento_Enabled = 1 ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 3 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Bienes de Uso Enviados" ;
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
         wcpOAV10USUARIO = "" ;
         wcpOAV11SISTEMA = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         A47TTBUS2_MotivoEnvio = "" ;
         A87TTBUS2_Observaciones = "" ;
         edtavGttbus2_idmovimiento_Internalname = "" ;
         edtavGnumeroidentificador_Internalname = "" ;
         edtavGttbus2_idbien_Internalname = "" ;
         edtavGttbus2_codposhacia_Internalname = "" ;
         edtavHttbus3_des_Internalname = "" ;
         edtavGttbus2_respdesde_Internalname = "" ;
         edtavGttbus2_resphacia_Internalname = "" ;
         edtavHusu_des_Internalname = "" ;
         edtavGttbus2_fechaenvio_Internalname = "" ;
         edtavGttbus2_motivoenvio_Internalname = "" ;
         edtavGttbus2_observaciones_Internalname = "" ;
         cmbavGttbus2_estadoenvio_Internalname = "" ;
         GXCCtl = "" ;
         chkavSeleccion_Internalname = "" ;
         A102TTBUS2_TipoResp = "" ;
         A53TTBUS2_IdUsuario = "" ;
         A45TTBUS2_FechaEnvio = (DateTime)(DateTime.MinValue) ;
         A24TTBUS2_RespDesde = "" ;
         A7USU_DES = "" ;
         A6USU_COD = "" ;
         A25TTBUS2_RespHacia = "" ;
         A34TTBUS7_Des = "" ;
         A12TTBUS_Descripcion = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         GX_FocusControl = "" ;
         Form = new GXWebForm();
         sPrefix = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         edtavDetalle_Internalname = "" ;
         AV28detalle = "" ;
         AV29gNumeroIdentificador = "" ;
         AV16hTTBUS3_Des = "" ;
         AV26gTTBUS2_RespDesde = "" ;
         AV20gTTBUS2_RespHacia = "" ;
         AV12hUSU_DES = "" ;
         AV21gTTBUS2_FechaEnvio = (DateTime)(DateTime.MinValue) ;
         AV22gTTBUS2_MotivoEnvio = "" ;
         AV23gTTBUS2_Observaciones = "" ;
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxwrpcisep = "" ;
         scmdbuf = "" ;
         l47TTBUS2_MotivoEnvio = "" ;
         H001Q2_A47TTBUS2_MotivoEnvio = new String[] {""} ;
         l87TTBUS2_Observaciones = "" ;
         H001Q3_A87TTBUS2_Observaciones = new String[] {""} ;
         H001Q3_n87TTBUS2_Observaciones = new bool[] {false} ;
         Grid1Container = new GXWebGrid( context);
         H001Q4_A25TTBUS2_RespHacia = new String[] {""} ;
         H001Q4_A49TTBUS2_CodPosHacia = new short[1] ;
         H001Q4_A22TTBUS2_IdBien = new int[1] ;
         H001Q4_A26TTBUS2_EstadoEnvio = new short[1] ;
         H001Q4_A24TTBUS2_RespDesde = new String[] {""} ;
         H001Q4_A45TTBUS2_FechaEnvio = new DateTime[] {DateTime.MinValue} ;
         H001Q4_A47TTBUS2_MotivoEnvio = new String[] {""} ;
         H001Q4_A87TTBUS2_Observaciones = new String[] {""} ;
         H001Q4_n87TTBUS2_Observaciones = new bool[] {false} ;
         H001Q4_A52TTBUS2_IdMovimiento = new long[1] ;
         H001Q5_A11TTBUS_Id = new int[1] ;
         H001Q5_A12TTBUS_Descripcion = new String[] {""} ;
         AV5TTBUS_Descripcion = "" ;
         H001Q6_A33TTBUS7_Pos = new short[1] ;
         H001Q6_A34TTBUS7_Des = new String[] {""} ;
         H001Q6_n34TTBUS7_Des = new bool[] {false} ;
         H001Q7_A6USU_COD = new String[] {""} ;
         H001Q7_A7USU_DES = new String[] {""} ;
         H001Q8_A53TTBUS2_IdUsuario = new String[] {""} ;
         H001Q8_A26TTBUS2_EstadoEnvio = new short[1] ;
         H001Q8_A52TTBUS2_IdMovimiento = new long[1] ;
         H001Q8_A22TTBUS2_IdBien = new int[1] ;
         H001Q8_A49TTBUS2_CodPosHacia = new short[1] ;
         H001Q8_A25TTBUS2_RespHacia = new String[] {""} ;
         H001Q8_A24TTBUS2_RespDesde = new String[] {""} ;
         H001Q8_A45TTBUS2_FechaEnvio = new DateTime[] {DateTime.MinValue} ;
         H001Q8_A47TTBUS2_MotivoEnvio = new String[] {""} ;
         H001Q8_A87TTBUS2_Observaciones = new String[] {""} ;
         H001Q8_n87TTBUS2_Observaciones = new bool[] {false} ;
         H001Q8_A102TTBUS2_TipoResp = new String[] {""} ;
         H001Q9_A11TTBUS_Id = new int[1] ;
         H001Q9_A12TTBUS_Descripcion = new String[] {""} ;
         H001Q10_A33TTBUS7_Pos = new short[1] ;
         H001Q10_A34TTBUS7_Des = new String[] {""} ;
         H001Q10_n34TTBUS7_Des = new bool[] {false} ;
         H001Q11_A6USU_COD = new String[] {""} ;
         H001Q11_A7USU_DES = new String[] {""} ;
         H001Q12_A11TTBUS_Id = new int[1] ;
         H001Q12_A12TTBUS_Descripcion = new String[] {""} ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         subGrid1_Linesclass = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char3 = "" ;
         GXt_char4 = "" ;
         GXt_char5 = "" ;
         GXt_char6 = "" ;
         GXt_char7 = "" ;
         GXt_char8 = "" ;
         GXt_char9 = "" ;
         GXt_char10 = "" ;
         GXt_char11 = "" ;
         GXt_char12 = "" ;
         GXt_char13 = "" ;
         Grid1Column = new GXWebColumn();
         TempTags = "" ;
         bttBtnrecibir_Jsonclick = "" ;
         lblTextblock2_Jsonclick = "" ;
         bttButton1_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         ROClassString = "" ;
         GXt_char14 = "" ;
         GXt_char15 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.htbus003c__default(),
            new Object[][] {
                new Object[] {
               H001Q2_A47TTBUS2_MotivoEnvio
               }
               , new Object[] {
               H001Q3_A87TTBUS2_Observaciones, H001Q3_n87TTBUS2_Observaciones
               }
               , new Object[] {
               H001Q4_A25TTBUS2_RespHacia, H001Q4_A49TTBUS2_CodPosHacia, H001Q4_A22TTBUS2_IdBien, H001Q4_A26TTBUS2_EstadoEnvio, H001Q4_A24TTBUS2_RespDesde, H001Q4_A45TTBUS2_FechaEnvio, H001Q4_A47TTBUS2_MotivoEnvio, H001Q4_A87TTBUS2_Observaciones, H001Q4_n87TTBUS2_Observaciones, H001Q4_A52TTBUS2_IdMovimiento
               }
               , new Object[] {
               H001Q5_A11TTBUS_Id, H001Q5_A12TTBUS_Descripcion
               }
               , new Object[] {
               H001Q6_A33TTBUS7_Pos, H001Q6_A34TTBUS7_Des, H001Q6_n34TTBUS7_Des
               }
               , new Object[] {
               H001Q7_A6USU_COD, H001Q7_A7USU_DES
               }
               , new Object[] {
               H001Q8_A53TTBUS2_IdUsuario, H001Q8_A26TTBUS2_EstadoEnvio, H001Q8_A52TTBUS2_IdMovimiento, H001Q8_A22TTBUS2_IdBien, H001Q8_A49TTBUS2_CodPosHacia, H001Q8_A25TTBUS2_RespHacia, H001Q8_A24TTBUS2_RespDesde, H001Q8_A45TTBUS2_FechaEnvio, H001Q8_A47TTBUS2_MotivoEnvio, H001Q8_A87TTBUS2_Observaciones,
               H001Q8_n87TTBUS2_Observaciones, H001Q8_A102TTBUS2_TipoResp
               }
               , new Object[] {
               H001Q9_A11TTBUS_Id, H001Q9_A12TTBUS_Descripcion
               }
               , new Object[] {
               H001Q10_A33TTBUS7_Pos, H001Q10_A34TTBUS7_Des, H001Q10_n34TTBUS7_Des
               }
               , new Object[] {
               H001Q11_A6USU_COD, H001Q11_A7USU_DES
               }
               , new Object[] {
               H001Q12_A11TTBUS_Id, H001Q12_A12TTBUS_Descripcion
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
         edtavGttbus2_respdesde_Enabled = 0 ;
         edtavGttbus2_resphacia_Enabled = 0 ;
         edtavHusu_des_Enabled = 0 ;
         edtavGttbus2_fechaenvio_Enabled = 0 ;
         edtavGttbus2_motivoenvio_Enabled = 0 ;
         edtavGttbus2_observaciones_Enabled = 0 ;
         cmbavGttbus2_estadoenvio.Enabled = 0 ;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_Grid1 ;
      private short nGXsfl_24_idx=1 ;
      private short AV15TTBUS2_EstadoEnvio ;
      private short AV24gTTBUS2_EstadoEnvio ;
      private short A26TTBUS2_EstadoEnvio ;
      private short A33TTBUS7_Pos ;
      private short A49TTBUS2_CodPosHacia ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short nGXWrapped ;
      private short GRID1_nEOF ;
      private short wbEnd ;
      private short wbStart ;
      private short AV27seleccion ;
      private short AV17gTTBUS2_CodPosHacia ;
      private short nDonePA ;
      private short subGrid1_Rows ;
      private short nGXsfl_24_fel_idx=1 ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short subGrid1_Collapsed ;
      private short subGrid1_Backstyle ;
      private int Grid1_PageSize24 ;
      private int edtavGttbus2_idmovimiento_Enabled ;
      private int edtavGnumeroidentificador_Enabled ;
      private int edtavGttbus2_idbien_Enabled ;
      private int edtavGttbus2_codposhacia_Enabled ;
      private int edtavHttbus3_des_Enabled ;
      private int edtavGttbus2_respdesde_Enabled ;
      private int edtavGttbus2_resphacia_Enabled ;
      private int edtavHusu_des_Enabled ;
      private int edtavGttbus2_fechaenvio_Enabled ;
      private int edtavGttbus2_motivoenvio_Enabled ;
      private int edtavGttbus2_observaciones_Enabled ;
      private int A11TTBUS_Id ;
      private int A22TTBUS2_IdBien ;
      private int GRID1_nFirstRecordOnPage ;
      private int AV18gTTBUS2_IdBien ;
      private int gxdynajaxindex ;
      private int subGrid1_Islastpage ;
      private int GRID1_nCurrentRecord ;
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
      private int edtavGttbus2_respdesde_Visible ;
      private int edtavGttbus2_resphacia_Visible ;
      private int edtavHusu_des_Visible ;
      private int edtavGttbus2_fechaenvio_Visible ;
      private int edtavGttbus2_motivoenvio_Visible ;
      private int edtavGttbus2_observaciones_Visible ;
      private long A52TTBUS2_IdMovimiento ;
      private long AV19gTTBUS2_IdMovimiento ;
      private long AV25TTBUS2_IdMovimiento ;
      private String AV10USUARIO ;
      private String AV11SISTEMA ;
      private String wcpOAV10USUARIO ;
      private String wcpOAV11SISTEMA ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_24_idx="0001" ;
      private String edtavGttbus2_idmovimiento_Internalname ;
      private String edtavGnumeroidentificador_Internalname ;
      private String edtavGttbus2_idbien_Internalname ;
      private String edtavGttbus2_codposhacia_Internalname ;
      private String edtavHttbus3_des_Internalname ;
      private String edtavGttbus2_respdesde_Internalname ;
      private String edtavGttbus2_resphacia_Internalname ;
      private String edtavHusu_des_Internalname ;
      private String edtavGttbus2_fechaenvio_Internalname ;
      private String edtavGttbus2_motivoenvio_Internalname ;
      private String edtavGttbus2_observaciones_Internalname ;
      private String cmbavGttbus2_estadoenvio_Internalname ;
      private String GXCCtl ;
      private String chkavSeleccion_Internalname ;
      private String A102TTBUS2_TipoResp ;
      private String A53TTBUS2_IdUsuario ;
      private String A24TTBUS2_RespDesde ;
      private String A7USU_DES ;
      private String A6USU_COD ;
      private String A25TTBUS2_RespHacia ;
      private String A34TTBUS7_Des ;
      private String sDynURL ;
      private String FormProcess ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavDetalle_Internalname ;
      private String AV16hTTBUS3_Des ;
      private String AV26gTTBUS2_RespDesde ;
      private String AV20gTTBUS2_RespHacia ;
      private String AV12hUSU_DES ;
      private String cmbavTtbus2_estadoenvio_Internalname ;
      private String gxwrpcisep ;
      private String scmdbuf ;
      private String sGXsfl_24_fel_idx="0001" ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String subGrid1_Internalname ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GXt_char3 ;
      private String GXt_char4 ;
      private String GXt_char5 ;
      private String GXt_char6 ;
      private String GXt_char7 ;
      private String GXt_char8 ;
      private String GXt_char9 ;
      private String GXt_char10 ;
      private String GXt_char11 ;
      private String GXt_char12 ;
      private String GXt_char13 ;
      private String TempTags ;
      private String bttBtnrecibir_Internalname ;
      private String bttBtnrecibir_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblock2_Internalname ;
      private String lblTextblock2_Jsonclick ;
      private String cmbavTtbus2_estadoenvio_Jsonclick ;
      private String bttButton1_Internalname ;
      private String bttButton1_Jsonclick ;
      private String edtavDetalle_Jsonclick ;
      private String ROClassString ;
      private String edtavGttbus2_idmovimiento_Jsonclick ;
      private String edtavGnumeroidentificador_Jsonclick ;
      private String edtavGttbus2_idbien_Jsonclick ;
      private String edtavGttbus2_codposhacia_Jsonclick ;
      private String edtavHttbus3_des_Jsonclick ;
      private String edtavGttbus2_respdesde_Jsonclick ;
      private String edtavGttbus2_resphacia_Jsonclick ;
      private String edtavHusu_des_Jsonclick ;
      private String edtavGttbus2_fechaenvio_Jsonclick ;
      private String edtavGttbus2_motivoenvio_Jsonclick ;
      private String edtavGttbus2_observaciones_Jsonclick ;
      private String cmbavGttbus2_estadoenvio_Jsonclick ;
      private String GXt_char14 ;
      private String GXt_char15 ;
      private DateTime A45TTBUS2_FechaEnvio ;
      private DateTime AV21gTTBUS2_FechaEnvio ;
      private bool entryPointCalled ;
      private bool n87TTBUS2_Observaciones ;
      private bool n34TTBUS7_Des ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool BRK1Q7 ;
      private String A47TTBUS2_MotivoEnvio ;
      private String A87TTBUS2_Observaciones ;
      private String A12TTBUS_Descripcion ;
      private String AV29gNumeroIdentificador ;
      private String AV22gTTBUS2_MotivoEnvio ;
      private String AV23gTTBUS2_Observaciones ;
      private String l47TTBUS2_MotivoEnvio ;
      private String l87TTBUS2_Observaciones ;
      private String AV5TTBUS_Descripcion ;
      private String AV28detalle ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private String aP0_USUARIO ;
      private String aP1_SISTEMA ;
      private GXCombobox cmbavTtbus2_estadoenvio ;
      private GXCheckbox chkavSeleccion ;
      private GXCombobox cmbavGttbus2_estadoenvio ;
      private IDataStoreProvider pr_default ;
      private String[] H001Q2_A47TTBUS2_MotivoEnvio ;
      private String[] H001Q3_A87TTBUS2_Observaciones ;
      private bool[] H001Q3_n87TTBUS2_Observaciones ;
      private String[] H001Q4_A25TTBUS2_RespHacia ;
      private short[] H001Q4_A49TTBUS2_CodPosHacia ;
      private int[] H001Q4_A22TTBUS2_IdBien ;
      private short[] H001Q4_A26TTBUS2_EstadoEnvio ;
      private String[] H001Q4_A24TTBUS2_RespDesde ;
      private DateTime[] H001Q4_A45TTBUS2_FechaEnvio ;
      private String[] H001Q4_A47TTBUS2_MotivoEnvio ;
      private String[] H001Q4_A87TTBUS2_Observaciones ;
      private bool[] H001Q4_n87TTBUS2_Observaciones ;
      private long[] H001Q4_A52TTBUS2_IdMovimiento ;
      private int[] H001Q5_A11TTBUS_Id ;
      private String[] H001Q5_A12TTBUS_Descripcion ;
      private short[] H001Q6_A33TTBUS7_Pos ;
      private String[] H001Q6_A34TTBUS7_Des ;
      private bool[] H001Q6_n34TTBUS7_Des ;
      private String[] H001Q7_A6USU_COD ;
      private String[] H001Q7_A7USU_DES ;
      private String[] H001Q8_A53TTBUS2_IdUsuario ;
      private short[] H001Q8_A26TTBUS2_EstadoEnvio ;
      private long[] H001Q8_A52TTBUS2_IdMovimiento ;
      private int[] H001Q8_A22TTBUS2_IdBien ;
      private short[] H001Q8_A49TTBUS2_CodPosHacia ;
      private String[] H001Q8_A25TTBUS2_RespHacia ;
      private String[] H001Q8_A24TTBUS2_RespDesde ;
      private DateTime[] H001Q8_A45TTBUS2_FechaEnvio ;
      private String[] H001Q8_A47TTBUS2_MotivoEnvio ;
      private String[] H001Q8_A87TTBUS2_Observaciones ;
      private bool[] H001Q8_n87TTBUS2_Observaciones ;
      private String[] H001Q8_A102TTBUS2_TipoResp ;
      private int[] H001Q9_A11TTBUS_Id ;
      private String[] H001Q9_A12TTBUS_Descripcion ;
      private short[] H001Q10_A33TTBUS7_Pos ;
      private String[] H001Q10_A34TTBUS7_Des ;
      private bool[] H001Q10_n34TTBUS7_Des ;
      private String[] H001Q11_A6USU_COD ;
      private String[] H001Q11_A7USU_DES ;
      private int[] H001Q12_A11TTBUS_Id ;
      private String[] H001Q12_A12TTBUS_Descripcion ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXWebForm Form ;
   }

   public class htbus003c__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H001Q4( short AV15TTBUS2_EstadoEnvio ,
                                             short A26TTBUS2_EstadoEnvio ,
                                             String A24TTBUS2_RespDesde ,
                                             String AV10USUARIO )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int16 ;
         GXv_int16 = new short [2] ;
         Object[] GXv_Object17 ;
         GXv_Object17 = new Object [2] ;
         scmdbuf = "SELECT [TTBUS2_RespHacia], [TTBUS2_CodPosHacia], [TTBUS2_IdBien], [TTBUS2_EstadoEnvio], [TTBUS2_RespDesde], [TTBUS2_FechaEnvio], [TTBUS2_MotivoEnvio], [TTBUS2_Observaciones], [TTBUS2_IdMovimiento] FROM [TTBUS002] WITH (NOLOCK)" ;
         scmdbuf = scmdbuf + " WHERE ([TTBUS2_RespDesde] = @AV10USUARIO)" ;
         if ( ! (0==AV15TTBUS2_EstadoEnvio) )
         {
            sWhereString = sWhereString + " and ([TTBUS2_EstadoEnvio] = @AV15TTBUS2_EstadoEnvio)" ;
         }
         else
         {
            GXv_int16[1] = 1 ;
         }
         scmdbuf = scmdbuf + sWhereString ;
         scmdbuf = scmdbuf + " ORDER BY [TTBUS2_IdMovimiento]" ;
         GXv_Object17[0] = scmdbuf ;
         GXv_Object17[1] = (Object)(GXv_int16) ;
         return GXv_Object17 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 2 :
                     return conditional_H001Q4( (short)dynConstraints[0] , (short)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] );
         }
         return base.getDynamicStatement(cursor, dynConstraints);
      }

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
         ,new ForEachCursor(def[8])
         ,new ForEachCursor(def[9])
         ,new ForEachCursor(def[10])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH001Q2 ;
          prmH001Q2 = new Object[] {
          new Object[] {"@TTBUS2_MotivoEnvio",SqlDbType.VarChar,100,0}
          } ;
          Object[] prmH001Q3 ;
          prmH001Q3 = new Object[] {
          new Object[] {"@TTBUS2_Observaciones",SqlDbType.VarChar,400,0}
          } ;
          Object[] prmH001Q5 ;
          prmH001Q5 = new Object[] {
          new Object[] {"@TTBUS2_IdBien",SqlDbType.Int,8,0}
          } ;
          Object[] prmH001Q6 ;
          prmH001Q6 = new Object[] {
          new Object[] {"@TTBUS2_CodPosHacia",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmH001Q7 ;
          prmH001Q7 = new Object[] {
          new Object[] {"@TTBUS2_RespHacia",SqlDbType.Char,15,0}
          } ;
          Object[] prmH001Q8 ;
          prmH001Q8 = new Object[] {
          new Object[] {"@AV10USUARIO",SqlDbType.Char,16,0}
          } ;
          Object[] prmH001Q9 ;
          prmH001Q9 = new Object[] {
          new Object[] {"@TTBUS2_IdBien",SqlDbType.Int,8,0}
          } ;
          Object[] prmH001Q10 ;
          prmH001Q10 = new Object[] {
          new Object[] {"@TTBUS2_CodPosHacia",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmH001Q11 ;
          prmH001Q11 = new Object[] {
          new Object[] {"@TTBUS2_RespHacia",SqlDbType.Char,15,0}
          } ;
          Object[] prmH001Q12 ;
          prmH001Q12 = new Object[] {
          new Object[] {"@AV18gTTBUS2_IdBien",SqlDbType.Int,8,0}
          } ;
          Object[] prmH001Q4 ;
          prmH001Q4 = new Object[] {
          new Object[] {"@AV10USUARIO",SqlDbType.Char,16,0} ,
          new Object[] {"@AV15TTBUS2_EstadoEnvio",SqlDbType.SmallInt,1,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H001Q2", "SELECT DISTINCT TOP 5 [TTBUS2_MotivoEnvio] FROM [TTBUS002] WITH (NOLOCK) WHERE UPPER(CAST([TTBUS2_MotivoEnvio] AS char(100))) like UPPER(CAST(@TTBUS2_MotivoEnvio AS char(100))) ORDER BY [TTBUS2_MotivoEnvio] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001Q2,0,0,true,false )
             ,new CursorDef("H001Q3", "SELECT DISTINCT TOP 5 [TTBUS2_Observaciones] FROM [TTBUS002] WITH (NOLOCK) WHERE UPPER(CAST([TTBUS2_Observaciones] AS char(400))) like UPPER(CAST(@TTBUS2_Observaciones AS char(400))) ORDER BY [TTBUS2_Observaciones] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001Q3,0,0,true,false )
             ,new CursorDef("H001Q4", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001Q4,100,0,true,false )
             ,new CursorDef("H001Q5", "SELECT [TTBUS_Id], [TTBUS_Descripcion] FROM [TTBUS000] WITH (NOLOCK) WHERE [TTBUS_Id] = @TTBUS2_IdBien ORDER BY [TTBUS_Id] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001Q5,1,0,false,true )
             ,new CursorDef("H001Q6", "SELECT T1.[TTBUS7_Pos] AS TTBUS7_Pos, T2.[W53DES] AS TTBUS7_Des FROM ([TTBUS007] T1 WITH (NOLOCK) INNER JOIN [T53FPOS] T2 WITH (NOLOCK) ON T2.[W53POS] = T1.[TTBUS7_Pos]) WHERE T1.[TTBUS7_Pos] = @TTBUS2_CodPosHacia ORDER BY T1.[TTBUS7_Pos] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001Q6,1,0,false,true )
             ,new CursorDef("H001Q7", "SELECT [USU_COD], [USU_DES] FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @TTBUS2_RespHacia ORDER BY [USU_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001Q7,1,0,false,true )
             ,new CursorDef("H001Q8", "SELECT T1.[TTBUS2_IdUsuario], T2.[TTBUS2_EstadoEnvio], T1.[TTBUS2_IdMovimiento], T2.[TTBUS2_IdBien], T2.[TTBUS2_CodPosHacia], T2.[TTBUS2_RespHacia], T2.[TTBUS2_RespDesde], T2.[TTBUS2_FechaEnvio], T2.[TTBUS2_MotivoEnvio], T2.[TTBUS2_Observaciones], T1.[TTBUS2_TipoResp] FROM ([TTBUS002_Det] T1 WITH (NOLOCK) INNER JOIN [TTBUS002] T2 WITH (NOLOCK) ON T2.[TTBUS2_IdMovimiento] = T1.[TTBUS2_IdMovimiento]) WHERE T1.[TTBUS2_IdUsuario] = @AV10USUARIO ORDER BY T1.[TTBUS2_IdUsuario], T1.[TTBUS2_IdMovimiento] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001Q8,100,0,true,false )
             ,new CursorDef("H001Q9", "SELECT [TTBUS_Id], [TTBUS_Descripcion] FROM [TTBUS000] WITH (NOLOCK) WHERE [TTBUS_Id] = @TTBUS2_IdBien ORDER BY [TTBUS_Id] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001Q9,1,0,false,true )
             ,new CursorDef("H001Q10", "SELECT T1.[TTBUS7_Pos] AS TTBUS7_Pos, T2.[W53DES] AS TTBUS7_Des FROM ([TTBUS007] T1 WITH (NOLOCK) INNER JOIN [T53FPOS] T2 WITH (NOLOCK) ON T2.[W53POS] = T1.[TTBUS7_Pos]) WHERE T1.[TTBUS7_Pos] = @TTBUS2_CodPosHacia ORDER BY T1.[TTBUS7_Pos] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001Q10,1,0,false,true )
             ,new CursorDef("H001Q11", "SELECT [USU_COD], [USU_DES] FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @TTBUS2_RespHacia ORDER BY [USU_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001Q11,1,0,false,true )
             ,new CursorDef("H001Q12", "SELECT [TTBUS_Id], [TTBUS_Descripcion] FROM [TTBUS000] WITH (NOLOCK) WHERE [TTBUS_Id] = @AV18gTTBUS2_IdBien ORDER BY [TTBUS_Id] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001Q12,1,0,false,true )
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
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 15) ;
                ((DateTime[]) buf[5])[0] = rslt.getGXDateTime(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                ((String[]) buf[7])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(8);
                ((long[]) buf[9])[0] = rslt.getLong(9) ;
                break;
             case 3 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                break;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                break;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                break;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((long[]) buf[2])[0] = rslt.getLong(3) ;
                ((int[]) buf[3])[0] = rslt.getInt(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((String[]) buf[5])[0] = rslt.getString(6, 15) ;
                ((String[]) buf[6])[0] = rslt.getString(7, 15) ;
                ((DateTime[]) buf[7])[0] = rslt.getGXDateTime(8) ;
                ((String[]) buf[8])[0] = rslt.getVarchar(9) ;
                ((String[]) buf[9])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(10);
                ((String[]) buf[11])[0] = rslt.getString(11, 1) ;
                break;
             case 7 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                break;
             case 8 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                break;
             case 9 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                break;
             case 10 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       short sIdx ;
       switch ( cursor )
       {
             case 0 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 1 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(1, (String)parms[1]);
                }
                break;
             case 2 :
                sIdx = 0 ;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1) ;
                   stmt.SetParameter(sIdx, (String)parms[2]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1) ;
                   stmt.SetParameter(sIdx, (short)parms[3]);
                }
                break;
             case 3 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 4 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 5 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 6 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 7 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 8 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 9 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 10 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
       }
    }

 }

}
