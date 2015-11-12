/*
               File: HTBUS004c
        Description: Bienes de Uso a Recibir
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 3/17/2014 13:22:19.79
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
   public class htbus004c : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public htbus004c( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public htbus004c( IGxContext context )
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
         this.AV11USUARIO = aP0_USUARIO;
         this.AV8SISTEMA = aP1_SISTEMA;
         executePrivate();
         aP0_USUARIO=this.AV11USUARIO;
         aP1_SISTEMA=this.AV8SISTEMA;
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxSuggest"+"_"+"vTTBUS_DESCRIPCION") == 0 )
            {
               A12TTBUS_Descripcion = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               GXSGVvTTBUS_DESCRIPCION1P0( A12TTBUS_Descripcion) ;
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
               GXSGVvGTTBUS2_MOTIVOENVIO1P0( A47TTBUS2_MotivoEnvio) ;
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
               GXSGVvGTTBUS2_OBSERVACIONES1P0( A87TTBUS2_Observaciones) ;
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
               edtavTtbus_descripcion_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTtbus_descripcion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTtbus_descripcion_Enabled), 5, 0)));
               edtavGttbus2_codposdesde_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGttbus2_codposdesde_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGttbus2_codposdesde_Enabled), 5, 0)));
               edtavDttbus3_des_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDttbus3_des_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDttbus3_des_Enabled), 5, 0)));
               edtavGttbus2_respdesde_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGttbus2_respdesde_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGttbus2_respdesde_Enabled), 5, 0)));
               edtavDusu_des_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDusu_des_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDusu_des_Enabled), 5, 0)));
               edtavGttbus2_fechaenvio_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGttbus2_fechaenvio_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGttbus2_fechaenvio_Enabled), 5, 0)));
               edtavGttbus2_fecharecepcion_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGttbus2_fecharecepcion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGttbus2_fecharecepcion_Enabled), 5, 0)));
               edtavGttbus2_motivoenvio_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGttbus2_motivoenvio_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGttbus2_motivoenvio_Enabled), 5, 0)));
               edtavGttbus2_observaciones_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGttbus2_observaciones_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGttbus2_observaciones_Enabled), 5, 0)));
               cmbavTtbus2_estadoenvio.Name = "vTTBUS2_ESTADOENVIO" ;
               cmbavTtbus2_estadoenvio.WebTags = "" ;
               cmbavTtbus2_estadoenvio.addItem(StringUtil.Str( (decimal)(0), 1, 0), "Todos", 0);
               cmbavTtbus2_estadoenvio.addItem("1", "No Finalizado", 0);
               cmbavTtbus2_estadoenvio.addItem("2", "Finalizado", 0);
               cmbavTtbus2_estadoenvio.addItem("3", "Cancelado", 0);
               if ( ( cmbavTtbus2_estadoenvio.ItemCount > 0 ) && (0==AV12TTBUS2_EstadoEnvio) )
               {
                  AV12TTBUS2_EstadoEnvio = 1 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12TTBUS2_EstadoEnvio", StringUtil.Str( (decimal)(AV12TTBUS2_EstadoEnvio), 1, 0));
               }
               GXCCtl = "vSELECCION_" + sGXsfl_24_idx ;
               chkavSeleccion.Name = GXCCtl ;
               chkavSeleccion.WebTags = "" ;
               chkavSeleccion.Caption = "" ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavSeleccion_Internalname, "Caption", chkavSeleccion.Caption);
               chkavSeleccion.CheckedValue = "0" ;
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
               A25TTBUS2_RespHacia = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25TTBUS2_RespHacia", A25TTBUS2_RespHacia);
               A46TTBUS2_FechaRecepcion = context.localUtil.ParseDTimeParm( GetNextPar( )) ;
               n46TTBUS2_FechaRecepcion = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46TTBUS2_FechaRecepcion", context.localUtil.TToC( A46TTBUS2_FechaRecepcion, 8, 5, 0, 3, "/", ":", " "));
               A45TTBUS2_FechaEnvio = context.localUtil.ParseDTimeParm( GetNextPar( )) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A45TTBUS2_FechaEnvio", context.localUtil.TToC( A45TTBUS2_FechaEnvio, 10, 5, 0, 3, "/", ":", " "));
               A7USU_DES = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7USU_DES", A7USU_DES);
               A6USU_COD = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
               A24TTBUS2_RespDesde = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24TTBUS2_RespDesde", A24TTBUS2_RespDesde);
               A34TTBUS7_Des = GetNextPar( ) ;
               n34TTBUS7_Des = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34TTBUS7_Des", A34TTBUS7_Des);
               A33TTBUS7_Pos = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
               A48TTBUS2_CodPosDesde = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A48TTBUS2_CodPosDesde", StringUtil.LTrim( StringUtil.Str( (decimal)(A48TTBUS2_CodPosDesde), 3, 0)));
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
               gxgrGrid1_refresh( Grid1_PageSize24, A102TTBUS2_TipoResp, A53TTBUS2_IdUsuario, A26TTBUS2_EstadoEnvio, A87TTBUS2_Observaciones, A47TTBUS2_MotivoEnvio, A25TTBUS2_RespHacia, A46TTBUS2_FechaRecepcion, A45TTBUS2_FechaEnvio, A7USU_DES, A6USU_COD, A24TTBUS2_RespDesde, A34TTBUS7_Des, A33TTBUS7_Pos, A48TTBUS2_CodPosDesde, A12TTBUS_Descripcion, A11TTBUS_Id, A22TTBUS2_IdBien, A52TTBUS2_IdMovimiento) ;
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
               AV11USUARIO = gxfirstwebparm ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11USUARIO", AV11USUARIO);
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV8SISTEMA = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8SISTEMA", AV8SISTEMA);
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
         PA1P2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START1P2( ) ;
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
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("htbus004c.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV11USUARIO)) + "," + UrlEncode(StringUtil.RTrim(AV8SISTEMA))+"\" class=\""+"Form"+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "vUSUARIO", StringUtil.RTrim( AV11USUARIO));
         GxWebStd.gx_hidden_field( context, "vSISTEMA", StringUtil.RTrim( AV8SISTEMA));
         GxWebStd.gx_hidden_field( context, "TTBUS2_TIPORESP", StringUtil.RTrim( A102TTBUS2_TipoResp));
         GxWebStd.gx_hidden_field( context, "TTBUS2_IDUSUARIO", StringUtil.RTrim( A53TTBUS2_IdUsuario));
         GxWebStd.gx_hidden_field( context, "TTBUS2_ESTADOENVIO", StringUtil.LTrim( StringUtil.NToC( (decimal)(A26TTBUS2_EstadoEnvio), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "TTBUS2_OBSERVACIONES", StringUtil.RTrim( A87TTBUS2_Observaciones));
         GxWebStd.gx_hidden_field( context, "TTBUS2_MOTIVOENVIO", StringUtil.RTrim( A47TTBUS2_MotivoEnvio));
         GxWebStd.gx_hidden_field( context, "TTBUS2_RESPHACIA", StringUtil.RTrim( A25TTBUS2_RespHacia));
         GxWebStd.gx_hidden_field( context, "TTBUS2_FECHARECEPCION", context.localUtil.TToC( A46TTBUS2_FechaRecepcion, 10, 8, 0, 3, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "TTBUS2_FECHAENVIO", context.localUtil.TToC( A45TTBUS2_FechaEnvio, 10, 8, 0, 3, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "USU_DES", StringUtil.RTrim( A7USU_DES));
         GxWebStd.gx_hidden_field( context, "USU_COD", StringUtil.RTrim( A6USU_COD));
         GxWebStd.gx_hidden_field( context, "TTBUS2_RESPDESDE", StringUtil.RTrim( A24TTBUS2_RespDesde));
         GxWebStd.gx_hidden_field( context, "TTBUS7_DES", StringUtil.RTrim( A34TTBUS7_Des));
         GxWebStd.gx_hidden_field( context, "TTBUS7_POS", StringUtil.LTrim( StringUtil.NToC( (decimal)(A33TTBUS7_Pos), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "TTBUS2_CODPOSDESDE", StringUtil.LTrim( StringUtil.NToC( (decimal)(A48TTBUS2_CodPosDesde), 3, 0, ",", "")));
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
            WE1P2( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT1P2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return false ;
      }

      public override String GetPgmname( )
      {
         return "HTBUS004c" ;
      }

      public override String GetPgmdesc( )
      {
         return "Bienes de Uso a Recibir" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("htbus004c.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV11USUARIO)) + "," + UrlEncode(StringUtil.RTrim(AV8SISTEMA)) ;
      }

      protected void WB1P0( )
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
            wb_table1_2_1P2( true) ;
         }
         else
         {
            wb_table1_2_1P2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_1P2e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START1P2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "Bienes de Uso a Recibir", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP1P0( ) ;
      }

      protected void WS1P2( )
      {
         START1P2( ) ;
         EVT1P2( ) ;
      }

      protected void EVT1P2( )
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
                           else if ( StringUtil.StrCmp(sEvt, "'RECIBIR BIEN'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E111P2 */
                              E111P2 ();
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
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 10), "GRID1.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 14), "'RECIBIR BIEN'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) )
                           {
                              nGXsfl_24_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                              sGXsfl_24_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_24_idx), 4, 0)), 4, "0") ;
                              chkavSeleccion_Internalname = "vSELECCION_"+sGXsfl_24_idx ;
                              edtavDetalle_Internalname = "vDETALLE_"+sGXsfl_24_idx ;
                              edtavGttbus2_idmovimiento_Internalname = "vGTTBUS2_IDMOVIMIENTO_"+sGXsfl_24_idx ;
                              edtavGnumeroidentificador_Internalname = "vGNUMEROIDENTIFICADOR_"+sGXsfl_24_idx ;
                              edtavGttbus2_idbien_Internalname = "vGTTBUS2_IDBIEN_"+sGXsfl_24_idx ;
                              edtavTtbus_descripcion_Internalname = "vTTBUS_DESCRIPCION_"+sGXsfl_24_idx ;
                              edtavGttbus2_codposdesde_Internalname = "vGTTBUS2_CODPOSDESDE_"+sGXsfl_24_idx ;
                              edtavDttbus3_des_Internalname = "vDTTBUS3_DES_"+sGXsfl_24_idx ;
                              edtavGttbus2_respdesde_Internalname = "vGTTBUS2_RESPDESDE_"+sGXsfl_24_idx ;
                              edtavDusu_des_Internalname = "vDUSU_DES_"+sGXsfl_24_idx ;
                              edtavGttbus2_fechaenvio_Internalname = "vGTTBUS2_FECHAENVIO_"+sGXsfl_24_idx ;
                              edtavGttbus2_fecharecepcion_Internalname = "vGTTBUS2_FECHARECEPCION_"+sGXsfl_24_idx ;
                              edtavGttbus2_fechaenvio_Internalname = "vGTTBUS2_FECHAENVIO_"+sGXsfl_24_idx ;
                              edtavGttbus2_motivoenvio_Internalname = "vGTTBUS2_MOTIVOENVIO_"+sGXsfl_24_idx ;
                              edtavGttbus2_observaciones_Internalname = "vGTTBUS2_OBSERVACIONES_"+sGXsfl_24_idx ;
                              if ( ! context.localUtil.VCNumber( cgiGet( chkavSeleccion_Internalname), "9") || ( ((StringUtil.StrCmp(cgiGet( chkavSeleccion_Internalname), "1")==0) ? 1 : 0) < 0 ) || ( ( ((StringUtil.StrCmp(cgiGet( chkavSeleccion_Internalname), "1")==0) ? 1 : 0) > 9 ) ) )
                              {
                                 GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vSELECCION");
                                 GX_FocusControl = chkavSeleccion_Internalname ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                                 wbErr = true ;
                                 AV26seleccion = 0 ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26seleccion", StringUtil.Str( (decimal)(AV26seleccion), 1, 0));
                              }
                              else
                              {
                                 AV26seleccion = (short)(((StringUtil.StrCmp(cgiGet( chkavSeleccion_Internalname), "1")==0) ? 1 : 0)) ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26seleccion", StringUtil.Str( (decimal)(AV26seleccion), 1, 0));
                              }
                              AV27detalle = cgiGet( "GXimg"+edtavDetalle_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDetalle_Internalname, "Bitmap", context.convertURL( AV27detalle));
                              if ( ! context.localUtil.VCNumber( cgiGet( edtavGttbus2_idmovimiento_Internalname), "ZZZZZZZZZZZ9") || ( context.localUtil.CToN( cgiGet( edtavGttbus2_idmovimiento_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavGttbus2_idmovimiento_Internalname), ",", ".") > Convert.ToDecimal( 999999999999L )) ) )
                              {
                                 GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vGTTBUS2_IDMOVIMIENTO");
                                 GX_FocusControl = edtavGttbus2_idmovimiento_Internalname ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                                 wbErr = true ;
                                 AV18gTTBUS2_IdMovimiento = 0 ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18gTTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18gTTBUS2_IdMovimiento), 12, 0)));
                              }
                              else
                              {
                                 AV18gTTBUS2_IdMovimiento = (long)(context.localUtil.CToN( cgiGet( edtavGttbus2_idmovimiento_Internalname), ",", ".")) ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18gTTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18gTTBUS2_IdMovimiento), 12, 0)));
                              }
                              AV28gNumeroIdentificador = cgiGet( edtavGnumeroidentificador_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28gNumeroIdentificador", AV28gNumeroIdentificador);
                              if ( ! context.localUtil.VCNumber( cgiGet( edtavGttbus2_idbien_Internalname), "ZZZZZZZ9") || ( context.localUtil.CToN( cgiGet( edtavGttbus2_idbien_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavGttbus2_idbien_Internalname), ",", ".") > Convert.ToDecimal( 99999999 )) ) )
                              {
                                 GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vGTTBUS2_IDBIEN");
                                 GX_FocusControl = edtavGttbus2_idbien_Internalname ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                                 wbErr = true ;
                                 AV15gTTBUS2_IdBien = 0 ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15gTTBUS2_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15gTTBUS2_IdBien), 8, 0)));
                              }
                              else
                              {
                                 AV15gTTBUS2_IdBien = (int)(context.localUtil.CToN( cgiGet( edtavGttbus2_idbien_Internalname), ",", ".")) ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15gTTBUS2_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15gTTBUS2_IdBien), 8, 0)));
                              }
                              AV9TTBUS_Descripcion = StringUtil.Upper( cgiGet( edtavTtbus_descripcion_Internalname)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9TTBUS_Descripcion", AV9TTBUS_Descripcion);
                              if ( ! context.localUtil.VCNumber( cgiGet( edtavGttbus2_codposdesde_Internalname), "ZZ9") || ( context.localUtil.CToN( cgiGet( edtavGttbus2_codposdesde_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavGttbus2_codposdesde_Internalname), ",", ".") > Convert.ToDecimal( 999 )) ) )
                              {
                                 GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vGTTBUS2_CODPOSDESDE");
                                 GX_FocusControl = edtavGttbus2_codposdesde_Internalname ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                                 wbErr = true ;
                                 AV14gTTBUS2_CodPosDesde = 0 ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14gTTBUS2_CodPosDesde", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14gTTBUS2_CodPosDesde), 3, 0)));
                              }
                              else
                              {
                                 AV14gTTBUS2_CodPosDesde = (short)(context.localUtil.CToN( cgiGet( edtavGttbus2_codposdesde_Internalname), ",", ".")) ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14gTTBUS2_CodPosDesde", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14gTTBUS2_CodPosDesde), 3, 0)));
                              }
                              AV13dTTBUS3_Des = cgiGet( edtavDttbus3_des_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13dTTBUS3_Des", AV13dTTBUS3_Des);
                              AV24gTTBUS2_RespDesde = cgiGet( edtavGttbus2_respdesde_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24gTTBUS2_RespDesde", AV24gTTBUS2_RespDesde);
                              AV7dUSU_DES = StringUtil.Upper( cgiGet( edtavDusu_des_Internalname)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7dUSU_DES", AV7dUSU_DES);
                              if ( context.localUtil.VCDateTime( cgiGet( edtavGttbus2_fechaenvio_Internalname), 4, 0) == 0 )
                              {
                                 GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"g TTBUS2_ Fecha Envio"}), 1, "vGTTBUS2_FECHAENVIO");
                                 GX_FocusControl = edtavGttbus2_fechaenvio_Internalname ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                                 wbErr = true ;
                                 AV20gTTBUS2_FechaEnvio = (DateTime)(DateTime.MinValue) ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20gTTBUS2_FechaEnvio", context.localUtil.TToC( AV20gTTBUS2_FechaEnvio, 10, 5, 0, 3, "/", ":", " "));
                              }
                              else
                              {
                                 AV20gTTBUS2_FechaEnvio = context.localUtil.CToT( cgiGet( edtavGttbus2_fechaenvio_Internalname)) ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20gTTBUS2_FechaEnvio", context.localUtil.TToC( AV20gTTBUS2_FechaEnvio, 10, 5, 0, 3, "/", ":", " "));
                              }
                              if ( context.localUtil.VCDateTime( cgiGet( edtavGttbus2_fecharecepcion_Internalname), 4, 0) == 0 )
                              {
                                 GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"g TTBUS2_ Fecha Recepcion"}), 1, "vGTTBUS2_FECHARECEPCION");
                                 GX_FocusControl = edtavGttbus2_fecharecepcion_Internalname ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                                 wbErr = true ;
                                 AV25gTTBUS2_FechaRecepcion = (DateTime)(DateTime.MinValue) ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25gTTBUS2_FechaRecepcion", context.localUtil.TToC( AV25gTTBUS2_FechaRecepcion, 8, 5, 0, 3, "/", ":", " "));
                              }
                              else
                              {
                                 AV25gTTBUS2_FechaRecepcion = context.localUtil.CToT( cgiGet( edtavGttbus2_fecharecepcion_Internalname)) ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25gTTBUS2_FechaRecepcion", context.localUtil.TToC( AV25gTTBUS2_FechaRecepcion, 8, 5, 0, 3, "/", ":", " "));
                              }
                              if ( context.localUtil.VCDateTime( cgiGet( edtavGttbus2_fechaenvio_Internalname), 4, 0) == 0 )
                              {
                                 GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"g TTBUS2_ Fecha Envio"}), 1, "vGTTBUS2_FECHAENVIO");
                                 GX_FocusControl = edtavGttbus2_fechaenvio_Internalname ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                                 wbErr = true ;
                                 AV20gTTBUS2_FechaEnvio = (DateTime)(DateTime.MinValue) ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20gTTBUS2_FechaEnvio", context.localUtil.TToC( AV20gTTBUS2_FechaEnvio, 10, 5, 0, 3, "/", ":", " "));
                              }
                              else
                              {
                                 AV20gTTBUS2_FechaEnvio = context.localUtil.CToT( cgiGet( edtavGttbus2_fechaenvio_Internalname)) ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20gTTBUS2_FechaEnvio", context.localUtil.TToC( AV20gTTBUS2_FechaEnvio, 10, 5, 0, 3, "/", ":", " "));
                              }
                              AV22gTTBUS2_MotivoEnvio = StringUtil.Upper( cgiGet( edtavGttbus2_motivoenvio_Internalname)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22gTTBUS2_MotivoEnvio", AV22gTTBUS2_MotivoEnvio);
                              AV23gTTBUS2_Observaciones = StringUtil.Upper( cgiGet( edtavGttbus2_observaciones_Internalname)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23gTTBUS2_Observaciones", AV23gTTBUS2_Observaciones);
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "GRID1.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E121P2 */
                                    E121P2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'RECIBIR BIEN'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E111P2 */
                                    E111P2 ();
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

      protected void WE1P2( )
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

      protected void PA1P2( )
      {
         if ( nDonePA == 0 )
         {
            cmbavTtbus2_estadoenvio.Name = "vTTBUS2_ESTADOENVIO" ;
            cmbavTtbus2_estadoenvio.WebTags = "" ;
            cmbavTtbus2_estadoenvio.addItem(StringUtil.Str( (decimal)(0), 1, 0), "Todos", 0);
            cmbavTtbus2_estadoenvio.addItem("1", "No Finalizado", 0);
            cmbavTtbus2_estadoenvio.addItem("2", "Finalizado", 0);
            cmbavTtbus2_estadoenvio.addItem("3", "Cancelado", 0);
            if ( ( cmbavTtbus2_estadoenvio.ItemCount > 0 ) && (0==AV12TTBUS2_EstadoEnvio) )
            {
               AV12TTBUS2_EstadoEnvio = 1 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12TTBUS2_EstadoEnvio", StringUtil.Str( (decimal)(AV12TTBUS2_EstadoEnvio), 1, 0));
            }
            GXCCtl = "vSELECCION_" + sGXsfl_24_idx ;
            chkavSeleccion.Name = GXCCtl ;
            chkavSeleccion.WebTags = "" ;
            chkavSeleccion.Caption = "" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavSeleccion_Internalname, "Caption", chkavSeleccion.Caption);
            chkavSeleccion.CheckedValue = "0" ;
            GX_FocusControl = cmbavTtbus2_estadoenvio_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void GXSGVvTTBUS_DESCRIPCION1P0( String A12TTBUS_Descripcion )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
         }
         context.GX_webresponse.AddString("(new Array( new Array(");
         GXSGVvTTBUS_DESCRIPCION_data1P0( A12TTBUS_Descripcion) ;
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

      protected void GXSGVvTTBUS_DESCRIPCION_data1P0( String A12TTBUS_Descripcion )
      {
         l12TTBUS_Descripcion = StringUtil.PadR( StringUtil.RTrim( A12TTBUS_Descripcion), 50, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
         /* Using cursor H001P2 */
         pr_default.execute(0, new Object[] {l12TTBUS_Descripcion});
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         while ( (pr_default.getStatus(0) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.RTrim( H001P2_A12TTBUS_Descripcion[0]));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( H001P2_A12TTBUS_Descripcion[0]));
            pr_default.readNext(0);
         }
         pr_default.close(0);
      }

      protected void GXSGVvGTTBUS2_MOTIVOENVIO1P0( String A47TTBUS2_MotivoEnvio )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
         }
         context.GX_webresponse.AddString("(new Array( new Array(");
         GXSGVvGTTBUS2_MOTIVOENVIO_data1P0( A47TTBUS2_MotivoEnvio) ;
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

      protected void GXSGVvGTTBUS2_MOTIVOENVIO_data1P0( String A47TTBUS2_MotivoEnvio )
      {
         l47TTBUS2_MotivoEnvio = StringUtil.PadR( StringUtil.RTrim( A47TTBUS2_MotivoEnvio), 100, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A47TTBUS2_MotivoEnvio", A47TTBUS2_MotivoEnvio);
         /* Using cursor H001P3 */
         pr_default.execute(1, new Object[] {l47TTBUS2_MotivoEnvio});
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         while ( (pr_default.getStatus(1) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.RTrim( H001P3_A47TTBUS2_MotivoEnvio[0]));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( H001P3_A47TTBUS2_MotivoEnvio[0]));
            pr_default.readNext(1);
         }
         pr_default.close(1);
      }

      protected void GXSGVvGTTBUS2_OBSERVACIONES1P0( String A87TTBUS2_Observaciones )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
         }
         context.GX_webresponse.AddString("(new Array( new Array(");
         GXSGVvGTTBUS2_OBSERVACIONES_data1P0( A87TTBUS2_Observaciones) ;
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

      protected void GXSGVvGTTBUS2_OBSERVACIONES_data1P0( String A87TTBUS2_Observaciones )
      {
         l87TTBUS2_Observaciones = StringUtil.PadR( StringUtil.RTrim( A87TTBUS2_Observaciones), 400, "%") ;
         n87TTBUS2_Observaciones = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A87TTBUS2_Observaciones", A87TTBUS2_Observaciones);
         /* Using cursor H001P4 */
         pr_default.execute(2, new Object[] {n87TTBUS2_Observaciones, l87TTBUS2_Observaciones});
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         while ( (pr_default.getStatus(2) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.RTrim( H001P4_A87TTBUS2_Observaciones[0]));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( H001P4_A87TTBUS2_Observaciones[0]));
            pr_default.readNext(2);
         }
         pr_default.close(2);
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
         edtavTtbus_descripcion_Internalname = "vTTBUS_DESCRIPCION_"+sGXsfl_24_idx ;
         edtavGttbus2_codposdesde_Internalname = "vGTTBUS2_CODPOSDESDE_"+sGXsfl_24_idx ;
         edtavDttbus3_des_Internalname = "vDTTBUS3_DES_"+sGXsfl_24_idx ;
         edtavGttbus2_respdesde_Internalname = "vGTTBUS2_RESPDESDE_"+sGXsfl_24_idx ;
         edtavDusu_des_Internalname = "vDUSU_DES_"+sGXsfl_24_idx ;
         edtavGttbus2_fechaenvio_Internalname = "vGTTBUS2_FECHAENVIO_"+sGXsfl_24_idx ;
         edtavGttbus2_fecharecepcion_Internalname = "vGTTBUS2_FECHARECEPCION_"+sGXsfl_24_idx ;
         edtavGttbus2_fechaenvio_Internalname = "vGTTBUS2_FECHAENVIO_"+sGXsfl_24_idx ;
         edtavGttbus2_motivoenvio_Internalname = "vGTTBUS2_MOTIVOENVIO_"+sGXsfl_24_idx ;
         edtavGttbus2_observaciones_Internalname = "vGTTBUS2_OBSERVACIONES_"+sGXsfl_24_idx ;
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
            edtavTtbus_descripcion_Internalname = "vTTBUS_DESCRIPCION_"+sGXsfl_24_idx ;
            edtavGttbus2_codposdesde_Internalname = "vGTTBUS2_CODPOSDESDE_"+sGXsfl_24_idx ;
            edtavDttbus3_des_Internalname = "vDTTBUS3_DES_"+sGXsfl_24_idx ;
            edtavGttbus2_respdesde_Internalname = "vGTTBUS2_RESPDESDE_"+sGXsfl_24_idx ;
            edtavDusu_des_Internalname = "vDUSU_DES_"+sGXsfl_24_idx ;
            edtavGttbus2_fechaenvio_Internalname = "vGTTBUS2_FECHAENVIO_"+sGXsfl_24_idx ;
            edtavGttbus2_fecharecepcion_Internalname = "vGTTBUS2_FECHARECEPCION_"+sGXsfl_24_idx ;
            edtavGttbus2_fechaenvio_Internalname = "vGTTBUS2_FECHAENVIO_"+sGXsfl_24_idx ;
            edtavGttbus2_motivoenvio_Internalname = "vGTTBUS2_MOTIVOENVIO_"+sGXsfl_24_idx ;
            edtavGttbus2_observaciones_Internalname = "vGTTBUS2_OBSERVACIONES_"+sGXsfl_24_idx ;
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
                                        String A25TTBUS2_RespHacia ,
                                        DateTime A46TTBUS2_FechaRecepcion ,
                                        DateTime A45TTBUS2_FechaEnvio ,
                                        String A7USU_DES ,
                                        String A6USU_COD ,
                                        String A24TTBUS2_RespDesde ,
                                        String A34TTBUS7_Des ,
                                        short A33TTBUS7_Pos ,
                                        short A48TTBUS2_CodPosDesde ,
                                        String A12TTBUS_Descripcion ,
                                        int A11TTBUS_Id ,
                                        int A22TTBUS2_IdBien ,
                                        long A52TTBUS2_IdMovimiento )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         subGrid1_Rows = (short)(Grid1_PageSize24) ;
         RF1P2( ) ;
         enableOutput();
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxgrGrid1_refresh */
      }

      protected void Refresh( )
      {
         RF1P2( ) ;
         /* End function Refresh */
      }

      protected void RF1P2( )
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
         edtavTtbus_descripcion_Internalname = "vTTBUS_DESCRIPCION_"+sGXsfl_24_idx ;
         edtavGttbus2_codposdesde_Internalname = "vGTTBUS2_CODPOSDESDE_"+sGXsfl_24_idx ;
         edtavDttbus3_des_Internalname = "vDTTBUS3_DES_"+sGXsfl_24_idx ;
         edtavGttbus2_respdesde_Internalname = "vGTTBUS2_RESPDESDE_"+sGXsfl_24_idx ;
         edtavDusu_des_Internalname = "vDUSU_DES_"+sGXsfl_24_idx ;
         edtavGttbus2_fechaenvio_Internalname = "vGTTBUS2_FECHAENVIO_"+sGXsfl_24_idx ;
         edtavGttbus2_fecharecepcion_Internalname = "vGTTBUS2_FECHARECEPCION_"+sGXsfl_24_idx ;
         edtavGttbus2_fechaenvio_Internalname = "vGTTBUS2_FECHAENVIO_"+sGXsfl_24_idx ;
         edtavGttbus2_motivoenvio_Internalname = "vGTTBUS2_MOTIVOENVIO_"+sGXsfl_24_idx ;
         edtavGttbus2_observaciones_Internalname = "vGTTBUS2_OBSERVACIONES_"+sGXsfl_24_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            chkavSeleccion_Internalname = "vSELECCION_"+sGXsfl_24_idx ;
            edtavDetalle_Internalname = "vDETALLE_"+sGXsfl_24_idx ;
            edtavGttbus2_idmovimiento_Internalname = "vGTTBUS2_IDMOVIMIENTO_"+sGXsfl_24_idx ;
            edtavGnumeroidentificador_Internalname = "vGNUMEROIDENTIFICADOR_"+sGXsfl_24_idx ;
            edtavGttbus2_idbien_Internalname = "vGTTBUS2_IDBIEN_"+sGXsfl_24_idx ;
            edtavTtbus_descripcion_Internalname = "vTTBUS_DESCRIPCION_"+sGXsfl_24_idx ;
            edtavGttbus2_codposdesde_Internalname = "vGTTBUS2_CODPOSDESDE_"+sGXsfl_24_idx ;
            edtavDttbus3_des_Internalname = "vDTTBUS3_DES_"+sGXsfl_24_idx ;
            edtavGttbus2_respdesde_Internalname = "vGTTBUS2_RESPDESDE_"+sGXsfl_24_idx ;
            edtavDusu_des_Internalname = "vDUSU_DES_"+sGXsfl_24_idx ;
            edtavGttbus2_fechaenvio_Internalname = "vGTTBUS2_FECHAENVIO_"+sGXsfl_24_idx ;
            edtavGttbus2_fecharecepcion_Internalname = "vGTTBUS2_FECHARECEPCION_"+sGXsfl_24_idx ;
            edtavGttbus2_fechaenvio_Internalname = "vGTTBUS2_FECHAENVIO_"+sGXsfl_24_idx ;
            edtavGttbus2_motivoenvio_Internalname = "vGTTBUS2_MOTIVOENVIO_"+sGXsfl_24_idx ;
            edtavGttbus2_observaciones_Internalname = "vGTTBUS2_OBSERVACIONES_"+sGXsfl_24_idx ;
            /* Execute user event: E121P2 */
            E121P2 ();
            wbEnd = 24 ;
            WB1P0( ) ;
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

      protected void STRUP1P0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         edtavGttbus2_idmovimiento_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGttbus2_idmovimiento_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGttbus2_idmovimiento_Enabled), 5, 0)));
         edtavGnumeroidentificador_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGnumeroidentificador_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGnumeroidentificador_Enabled), 5, 0)));
         edtavGttbus2_idbien_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGttbus2_idbien_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGttbus2_idbien_Enabled), 5, 0)));
         edtavTtbus_descripcion_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTtbus_descripcion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTtbus_descripcion_Enabled), 5, 0)));
         edtavGttbus2_codposdesde_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGttbus2_codposdesde_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGttbus2_codposdesde_Enabled), 5, 0)));
         edtavDttbus3_des_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDttbus3_des_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDttbus3_des_Enabled), 5, 0)));
         edtavGttbus2_respdesde_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGttbus2_respdesde_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGttbus2_respdesde_Enabled), 5, 0)));
         edtavDusu_des_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDusu_des_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDusu_des_Enabled), 5, 0)));
         edtavGttbus2_fechaenvio_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGttbus2_fechaenvio_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGttbus2_fechaenvio_Enabled), 5, 0)));
         edtavGttbus2_fecharecepcion_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGttbus2_fecharecepcion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGttbus2_fecharecepcion_Enabled), 5, 0)));
         edtavGttbus2_motivoenvio_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGttbus2_motivoenvio_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGttbus2_motivoenvio_Enabled), 5, 0)));
         edtavGttbus2_observaciones_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGttbus2_observaciones_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGttbus2_observaciones_Enabled), 5, 0)));
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
            AV12TTBUS2_EstadoEnvio = (short)(NumberUtil.Val( cgiGet( cmbavTtbus2_estadoenvio_Internalname), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12TTBUS2_EstadoEnvio", StringUtil.Str( (decimal)(AV12TTBUS2_EstadoEnvio), 1, 0));
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ",", ".")) ;
            AV11USUARIO = cgiGet( "vUSUARIO") ;
            AV8SISTEMA = cgiGet( "vSISTEMA") ;
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

      private void E121P2( )
      {
         /* Grid1_Load Routine */
         AV27detalle = context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", "Modern") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDetalle_Internalname, "Bitmap", context.convertURL( AV27detalle));
         pr_default.dynParam(3, new Object[]{ new Object[]{
                                              AV12TTBUS2_EstadoEnvio ,
                                              A26TTBUS2_EstadoEnvio ,
                                              A25TTBUS2_RespHacia ,
                                              AV11USUARIO },
                                              new int[] {
                                              TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.STRING
                                              }
         });
         /* Using cursor H001P5 */
         pr_default.execute(3, new Object[] {AV11USUARIO, AV12TTBUS2_EstadoEnvio});
         while ( (pr_default.getStatus(3) != 101) )
         {
            A24TTBUS2_RespDesde = H001P5_A24TTBUS2_RespDesde[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24TTBUS2_RespDesde", A24TTBUS2_RespDesde);
            A48TTBUS2_CodPosDesde = H001P5_A48TTBUS2_CodPosDesde[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A48TTBUS2_CodPosDesde", StringUtil.LTrim( StringUtil.Str( (decimal)(A48TTBUS2_CodPosDesde), 3, 0)));
            A22TTBUS2_IdBien = H001P5_A22TTBUS2_IdBien[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22TTBUS2_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A22TTBUS2_IdBien), 8, 0)));
            A26TTBUS2_EstadoEnvio = H001P5_A26TTBUS2_EstadoEnvio[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26TTBUS2_EstadoEnvio", StringUtil.Str( (decimal)(A26TTBUS2_EstadoEnvio), 1, 0));
            A25TTBUS2_RespHacia = H001P5_A25TTBUS2_RespHacia[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25TTBUS2_RespHacia", A25TTBUS2_RespHacia);
            A45TTBUS2_FechaEnvio = H001P5_A45TTBUS2_FechaEnvio[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A45TTBUS2_FechaEnvio", context.localUtil.TToC( A45TTBUS2_FechaEnvio, 10, 5, 0, 3, "/", ":", " "));
            A46TTBUS2_FechaRecepcion = H001P5_A46TTBUS2_FechaRecepcion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46TTBUS2_FechaRecepcion", context.localUtil.TToC( A46TTBUS2_FechaRecepcion, 8, 5, 0, 3, "/", ":", " "));
            n46TTBUS2_FechaRecepcion = H001P5_n46TTBUS2_FechaRecepcion[0] ;
            A47TTBUS2_MotivoEnvio = H001P5_A47TTBUS2_MotivoEnvio[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A47TTBUS2_MotivoEnvio", A47TTBUS2_MotivoEnvio);
            A87TTBUS2_Observaciones = H001P5_A87TTBUS2_Observaciones[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A87TTBUS2_Observaciones", A87TTBUS2_Observaciones);
            n87TTBUS2_Observaciones = H001P5_n87TTBUS2_Observaciones[0] ;
            A52TTBUS2_IdMovimiento = H001P5_A52TTBUS2_IdMovimiento[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52TTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(A52TTBUS2_IdMovimiento), 12, 0)));
            AV18gTTBUS2_IdMovimiento = A52TTBUS2_IdMovimiento ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18gTTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18gTTBUS2_IdMovimiento), 12, 0)));
            new ptbus009(context ).execute(  A22TTBUS2_IdBien,  1, out  AV28gNumeroIdentificador) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22TTBUS2_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A22TTBUS2_IdBien), 8, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28gNumeroIdentificador", AV28gNumeroIdentificador);
            AV15gTTBUS2_IdBien = A22TTBUS2_IdBien ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15gTTBUS2_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15gTTBUS2_IdBien), 8, 0)));
            /* Using cursor H001P6 */
            pr_default.execute(4, new Object[] {A22TTBUS2_IdBien});
            while ( (pr_default.getStatus(4) != 101) )
            {
               A11TTBUS_Id = H001P6_A11TTBUS_Id[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
               A12TTBUS_Descripcion = H001P6_A12TTBUS_Descripcion[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
               AV9TTBUS_Descripcion = A12TTBUS_Descripcion ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9TTBUS_Descripcion", AV9TTBUS_Descripcion);
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(4);
            AV14gTTBUS2_CodPosDesde = A48TTBUS2_CodPosDesde ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14gTTBUS2_CodPosDesde", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14gTTBUS2_CodPosDesde), 3, 0)));
            /* Using cursor H001P7 */
            pr_default.execute(5, new Object[] {A48TTBUS2_CodPosDesde});
            while ( (pr_default.getStatus(5) != 101) )
            {
               A33TTBUS7_Pos = H001P7_A33TTBUS7_Pos[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
               A34TTBUS7_Des = H001P7_A34TTBUS7_Des[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34TTBUS7_Des", A34TTBUS7_Des);
               n34TTBUS7_Des = H001P7_n34TTBUS7_Des[0] ;
               A34TTBUS7_Des = H001P7_A34TTBUS7_Des[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34TTBUS7_Des", A34TTBUS7_Des);
               n34TTBUS7_Des = H001P7_n34TTBUS7_Des[0] ;
               AV13dTTBUS3_Des = A34TTBUS7_Des ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13dTTBUS3_Des", AV13dTTBUS3_Des);
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(5);
            AV24gTTBUS2_RespDesde = A24TTBUS2_RespDesde ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24gTTBUS2_RespDesde", AV24gTTBUS2_RespDesde);
            /* Using cursor H001P8 */
            pr_default.execute(6, new Object[] {A24TTBUS2_RespDesde});
            while ( (pr_default.getStatus(6) != 101) )
            {
               A6USU_COD = H001P8_A6USU_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
               A7USU_DES = H001P8_A7USU_DES[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7USU_DES", A7USU_DES);
               AV7dUSU_DES = A7USU_DES ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7dUSU_DES", AV7dUSU_DES);
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(6);
            AV20gTTBUS2_FechaEnvio = A45TTBUS2_FechaEnvio ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20gTTBUS2_FechaEnvio", context.localUtil.TToC( AV20gTTBUS2_FechaEnvio, 10, 5, 0, 3, "/", ":", " "));
            AV25gTTBUS2_FechaRecepcion = A46TTBUS2_FechaRecepcion ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25gTTBUS2_FechaRecepcion", context.localUtil.TToC( AV25gTTBUS2_FechaRecepcion, 8, 5, 0, 3, "/", ":", " "));
            AV21gTTBUS2_RespHacia = A25TTBUS2_RespHacia ;
            AV22gTTBUS2_MotivoEnvio = A47TTBUS2_MotivoEnvio ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22gTTBUS2_MotivoEnvio", AV22gTTBUS2_MotivoEnvio);
            AV23gTTBUS2_Observaciones = A87TTBUS2_Observaciones ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23gTTBUS2_Observaciones", AV23gTTBUS2_Observaciones);
            AV19gTTBUS2_EstadoEnvio = A26TTBUS2_EstadoEnvio ;
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
            pr_default.readNext(3);
         }
         pr_default.close(3);
         /* Using cursor H001P9 */
         pr_default.execute(7, new Object[] {AV11USUARIO});
         while ( (pr_default.getStatus(7) != 101) )
         {
            BRK1P7 = false ;
            A53TTBUS2_IdUsuario = H001P9_A53TTBUS2_IdUsuario[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A53TTBUS2_IdUsuario", A53TTBUS2_IdUsuario);
            A26TTBUS2_EstadoEnvio = H001P9_A26TTBUS2_EstadoEnvio[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26TTBUS2_EstadoEnvio", StringUtil.Str( (decimal)(A26TTBUS2_EstadoEnvio), 1, 0));
            A52TTBUS2_IdMovimiento = H001P9_A52TTBUS2_IdMovimiento[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52TTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(A52TTBUS2_IdMovimiento), 12, 0)));
            A22TTBUS2_IdBien = H001P9_A22TTBUS2_IdBien[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22TTBUS2_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A22TTBUS2_IdBien), 8, 0)));
            A48TTBUS2_CodPosDesde = H001P9_A48TTBUS2_CodPosDesde[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A48TTBUS2_CodPosDesde", StringUtil.LTrim( StringUtil.Str( (decimal)(A48TTBUS2_CodPosDesde), 3, 0)));
            A24TTBUS2_RespDesde = H001P9_A24TTBUS2_RespDesde[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24TTBUS2_RespDesde", A24TTBUS2_RespDesde);
            A45TTBUS2_FechaEnvio = H001P9_A45TTBUS2_FechaEnvio[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A45TTBUS2_FechaEnvio", context.localUtil.TToC( A45TTBUS2_FechaEnvio, 10, 5, 0, 3, "/", ":", " "));
            A25TTBUS2_RespHacia = H001P9_A25TTBUS2_RespHacia[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25TTBUS2_RespHacia", A25TTBUS2_RespHacia);
            A47TTBUS2_MotivoEnvio = H001P9_A47TTBUS2_MotivoEnvio[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A47TTBUS2_MotivoEnvio", A47TTBUS2_MotivoEnvio);
            A87TTBUS2_Observaciones = H001P9_A87TTBUS2_Observaciones[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A87TTBUS2_Observaciones", A87TTBUS2_Observaciones);
            n87TTBUS2_Observaciones = H001P9_n87TTBUS2_Observaciones[0] ;
            A102TTBUS2_TipoResp = H001P9_A102TTBUS2_TipoResp[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A102TTBUS2_TipoResp", A102TTBUS2_TipoResp);
            A26TTBUS2_EstadoEnvio = H001P9_A26TTBUS2_EstadoEnvio[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26TTBUS2_EstadoEnvio", StringUtil.Str( (decimal)(A26TTBUS2_EstadoEnvio), 1, 0));
            A22TTBUS2_IdBien = H001P9_A22TTBUS2_IdBien[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22TTBUS2_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A22TTBUS2_IdBien), 8, 0)));
            A48TTBUS2_CodPosDesde = H001P9_A48TTBUS2_CodPosDesde[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A48TTBUS2_CodPosDesde", StringUtil.LTrim( StringUtil.Str( (decimal)(A48TTBUS2_CodPosDesde), 3, 0)));
            A24TTBUS2_RespDesde = H001P9_A24TTBUS2_RespDesde[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24TTBUS2_RespDesde", A24TTBUS2_RespDesde);
            A45TTBUS2_FechaEnvio = H001P9_A45TTBUS2_FechaEnvio[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A45TTBUS2_FechaEnvio", context.localUtil.TToC( A45TTBUS2_FechaEnvio, 10, 5, 0, 3, "/", ":", " "));
            A25TTBUS2_RespHacia = H001P9_A25TTBUS2_RespHacia[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25TTBUS2_RespHacia", A25TTBUS2_RespHacia);
            A47TTBUS2_MotivoEnvio = H001P9_A47TTBUS2_MotivoEnvio[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A47TTBUS2_MotivoEnvio", A47TTBUS2_MotivoEnvio);
            A87TTBUS2_Observaciones = H001P9_A87TTBUS2_Observaciones[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A87TTBUS2_Observaciones", A87TTBUS2_Observaciones);
            n87TTBUS2_Observaciones = H001P9_n87TTBUS2_Observaciones[0] ;
            AV16TTBUS2_IdMovimiento = A52TTBUS2_IdMovimiento ;
            if ( StringUtil.StrCmp(A102TTBUS2_TipoResp, "R") == 0 )
            {
               while ( (pr_default.getStatus(7) != 101) && ( StringUtil.StrCmp(H001P9_A53TTBUS2_IdUsuario[0], A53TTBUS2_IdUsuario) == 0 ) && ( H001P9_A52TTBUS2_IdMovimiento[0] == A52TTBUS2_IdMovimiento ) )
               {
                  BRK1P7 = false ;
                  A26TTBUS2_EstadoEnvio = H001P9_A26TTBUS2_EstadoEnvio[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26TTBUS2_EstadoEnvio", StringUtil.Str( (decimal)(A26TTBUS2_EstadoEnvio), 1, 0));
                  A22TTBUS2_IdBien = H001P9_A22TTBUS2_IdBien[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22TTBUS2_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A22TTBUS2_IdBien), 8, 0)));
                  A48TTBUS2_CodPosDesde = H001P9_A48TTBUS2_CodPosDesde[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A48TTBUS2_CodPosDesde", StringUtil.LTrim( StringUtil.Str( (decimal)(A48TTBUS2_CodPosDesde), 3, 0)));
                  A24TTBUS2_RespDesde = H001P9_A24TTBUS2_RespDesde[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24TTBUS2_RespDesde", A24TTBUS2_RespDesde);
                  A45TTBUS2_FechaEnvio = H001P9_A45TTBUS2_FechaEnvio[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A45TTBUS2_FechaEnvio", context.localUtil.TToC( A45TTBUS2_FechaEnvio, 10, 5, 0, 3, "/", ":", " "));
                  A25TTBUS2_RespHacia = H001P9_A25TTBUS2_RespHacia[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25TTBUS2_RespHacia", A25TTBUS2_RespHacia);
                  A47TTBUS2_MotivoEnvio = H001P9_A47TTBUS2_MotivoEnvio[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A47TTBUS2_MotivoEnvio", A47TTBUS2_MotivoEnvio);
                  A87TTBUS2_Observaciones = H001P9_A87TTBUS2_Observaciones[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A87TTBUS2_Observaciones", A87TTBUS2_Observaciones);
                  n87TTBUS2_Observaciones = H001P9_n87TTBUS2_Observaciones[0] ;
                  A102TTBUS2_TipoResp = H001P9_A102TTBUS2_TipoResp[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A102TTBUS2_TipoResp", A102TTBUS2_TipoResp);
                  A26TTBUS2_EstadoEnvio = H001P9_A26TTBUS2_EstadoEnvio[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26TTBUS2_EstadoEnvio", StringUtil.Str( (decimal)(A26TTBUS2_EstadoEnvio), 1, 0));
                  A22TTBUS2_IdBien = H001P9_A22TTBUS2_IdBien[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22TTBUS2_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A22TTBUS2_IdBien), 8, 0)));
                  A48TTBUS2_CodPosDesde = H001P9_A48TTBUS2_CodPosDesde[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A48TTBUS2_CodPosDesde", StringUtil.LTrim( StringUtil.Str( (decimal)(A48TTBUS2_CodPosDesde), 3, 0)));
                  A24TTBUS2_RespDesde = H001P9_A24TTBUS2_RespDesde[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24TTBUS2_RespDesde", A24TTBUS2_RespDesde);
                  A45TTBUS2_FechaEnvio = H001P9_A45TTBUS2_FechaEnvio[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A45TTBUS2_FechaEnvio", context.localUtil.TToC( A45TTBUS2_FechaEnvio, 10, 5, 0, 3, "/", ":", " "));
                  A25TTBUS2_RespHacia = H001P9_A25TTBUS2_RespHacia[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25TTBUS2_RespHacia", A25TTBUS2_RespHacia);
                  A47TTBUS2_MotivoEnvio = H001P9_A47TTBUS2_MotivoEnvio[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A47TTBUS2_MotivoEnvio", A47TTBUS2_MotivoEnvio);
                  A87TTBUS2_Observaciones = H001P9_A87TTBUS2_Observaciones[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A87TTBUS2_Observaciones", A87TTBUS2_Observaciones);
                  n87TTBUS2_Observaciones = H001P9_n87TTBUS2_Observaciones[0] ;
                  if ( A52TTBUS2_IdMovimiento == AV16TTBUS2_IdMovimiento )
                  {
                     if ( (0==AV12TTBUS2_EstadoEnvio) || ( ( A26TTBUS2_EstadoEnvio == AV12TTBUS2_EstadoEnvio ) ) )
                     {
                        AV18gTTBUS2_IdMovimiento = A52TTBUS2_IdMovimiento ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18gTTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18gTTBUS2_IdMovimiento), 12, 0)));
                        AV15gTTBUS2_IdBien = A22TTBUS2_IdBien ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15gTTBUS2_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15gTTBUS2_IdBien), 8, 0)));
                        /* Using cursor H001P10 */
                        pr_default.execute(8, new Object[] {A22TTBUS2_IdBien});
                        while ( (pr_default.getStatus(8) != 101) )
                        {
                           A11TTBUS_Id = H001P10_A11TTBUS_Id[0] ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
                           A12TTBUS_Descripcion = H001P10_A12TTBUS_Descripcion[0] ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
                           AV9TTBUS_Descripcion = A12TTBUS_Descripcion ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9TTBUS_Descripcion", AV9TTBUS_Descripcion);
                           /* Exiting from a For First loop. */
                           if (true) break;
                        }
                        pr_default.close(8);
                        AV14gTTBUS2_CodPosDesde = A48TTBUS2_CodPosDesde ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14gTTBUS2_CodPosDesde", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14gTTBUS2_CodPosDesde), 3, 0)));
                        /* Using cursor H001P11 */
                        pr_default.execute(9, new Object[] {A48TTBUS2_CodPosDesde});
                        while ( (pr_default.getStatus(9) != 101) )
                        {
                           A33TTBUS7_Pos = H001P11_A33TTBUS7_Pos[0] ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
                           A34TTBUS7_Des = H001P11_A34TTBUS7_Des[0] ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34TTBUS7_Des", A34TTBUS7_Des);
                           n34TTBUS7_Des = H001P11_n34TTBUS7_Des[0] ;
                           A34TTBUS7_Des = H001P11_A34TTBUS7_Des[0] ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34TTBUS7_Des", A34TTBUS7_Des);
                           n34TTBUS7_Des = H001P11_n34TTBUS7_Des[0] ;
                           AV13dTTBUS3_Des = A34TTBUS7_Des ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13dTTBUS3_Des", AV13dTTBUS3_Des);
                           /* Exiting from a For First loop. */
                           if (true) break;
                        }
                        pr_default.close(9);
                        AV24gTTBUS2_RespDesde = A24TTBUS2_RespDesde ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24gTTBUS2_RespDesde", AV24gTTBUS2_RespDesde);
                        /* Using cursor H001P12 */
                        pr_default.execute(10, new Object[] {A24TTBUS2_RespDesde});
                        while ( (pr_default.getStatus(10) != 101) )
                        {
                           A6USU_COD = H001P12_A6USU_COD[0] ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
                           A7USU_DES = H001P12_A7USU_DES[0] ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7USU_DES", A7USU_DES);
                           AV7dUSU_DES = A7USU_DES ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7dUSU_DES", AV7dUSU_DES);
                           /* Exiting from a For First loop. */
                           if (true) break;
                        }
                        pr_default.close(10);
                        AV20gTTBUS2_FechaEnvio = A45TTBUS2_FechaEnvio ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20gTTBUS2_FechaEnvio", context.localUtil.TToC( AV20gTTBUS2_FechaEnvio, 10, 5, 0, 3, "/", ":", " "));
                        AV21gTTBUS2_RespHacia = A25TTBUS2_RespHacia ;
                        AV22gTTBUS2_MotivoEnvio = A47TTBUS2_MotivoEnvio ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22gTTBUS2_MotivoEnvio", AV22gTTBUS2_MotivoEnvio);
                        AV23gTTBUS2_Observaciones = A87TTBUS2_Observaciones ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23gTTBUS2_Observaciones", AV23gTTBUS2_Observaciones);
                        AV19gTTBUS2_EstadoEnvio = A26TTBUS2_EstadoEnvio ;
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
                  BRK1P7 = true ;
                  pr_default.readNext(7);
               }
            }
            if ( ! BRK1P7 )
            {
               BRK1P7 = true ;
               pr_default.readNext(7);
            }
         }
         pr_default.close(7);
      }

      protected void E111P2( )
      {
         /* 'Recibir Bien' Routine */
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
            edtavTtbus_descripcion_Internalname = "vTTBUS_DESCRIPCION_"+sGXsfl_24_fel_idx ;
            edtavGttbus2_codposdesde_Internalname = "vGTTBUS2_CODPOSDESDE_"+sGXsfl_24_fel_idx ;
            edtavDttbus3_des_Internalname = "vDTTBUS3_DES_"+sGXsfl_24_fel_idx ;
            edtavGttbus2_respdesde_Internalname = "vGTTBUS2_RESPDESDE_"+sGXsfl_24_fel_idx ;
            edtavDusu_des_Internalname = "vDUSU_DES_"+sGXsfl_24_fel_idx ;
            edtavGttbus2_fechaenvio_Internalname = "vGTTBUS2_FECHAENVIO_"+sGXsfl_24_fel_idx ;
            edtavGttbus2_fecharecepcion_Internalname = "vGTTBUS2_FECHARECEPCION_"+sGXsfl_24_fel_idx ;
            edtavGttbus2_fechaenvio_Internalname = "vGTTBUS2_FECHAENVIO_"+sGXsfl_24_fel_idx ;
            edtavGttbus2_motivoenvio_Internalname = "vGTTBUS2_MOTIVOENVIO_"+sGXsfl_24_fel_idx ;
            edtavGttbus2_observaciones_Internalname = "vGTTBUS2_OBSERVACIONES_"+sGXsfl_24_fel_idx ;
            if ( ! context.localUtil.VCNumber( cgiGet( chkavSeleccion_Internalname), "9") || ( ((StringUtil.StrCmp(cgiGet( chkavSeleccion_Internalname), "1")==0) ? 1 : 0) < 0 ) || ( ( ((StringUtil.StrCmp(cgiGet( chkavSeleccion_Internalname), "1")==0) ? 1 : 0) > 9 ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vSELECCION");
               GX_FocusControl = chkavSeleccion_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV26seleccion = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26seleccion", StringUtil.Str( (decimal)(AV26seleccion), 1, 0));
            }
            else
            {
               AV26seleccion = (short)(((StringUtil.StrCmp(cgiGet( chkavSeleccion_Internalname), "1")==0) ? 1 : 0)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26seleccion", StringUtil.Str( (decimal)(AV26seleccion), 1, 0));
            }
            AV27detalle = cgiGet( "GXimg"+edtavDetalle_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDetalle_Internalname, "Bitmap", context.convertURL( AV27detalle));
            if ( ! context.localUtil.VCNumber( cgiGet( edtavGttbus2_idmovimiento_Internalname), "ZZZZZZZZZZZ9") || ( context.localUtil.CToN( cgiGet( edtavGttbus2_idmovimiento_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavGttbus2_idmovimiento_Internalname), ",", ".") > Convert.ToDecimal( 999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vGTTBUS2_IDMOVIMIENTO");
               GX_FocusControl = edtavGttbus2_idmovimiento_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV18gTTBUS2_IdMovimiento = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18gTTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18gTTBUS2_IdMovimiento), 12, 0)));
            }
            else
            {
               AV18gTTBUS2_IdMovimiento = (long)(context.localUtil.CToN( cgiGet( edtavGttbus2_idmovimiento_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18gTTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18gTTBUS2_IdMovimiento), 12, 0)));
            }
            AV28gNumeroIdentificador = cgiGet( edtavGnumeroidentificador_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28gNumeroIdentificador", AV28gNumeroIdentificador);
            if ( ! context.localUtil.VCNumber( cgiGet( edtavGttbus2_idbien_Internalname), "ZZZZZZZ9") || ( context.localUtil.CToN( cgiGet( edtavGttbus2_idbien_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavGttbus2_idbien_Internalname), ",", ".") > Convert.ToDecimal( 99999999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vGTTBUS2_IDBIEN");
               GX_FocusControl = edtavGttbus2_idbien_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV15gTTBUS2_IdBien = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15gTTBUS2_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15gTTBUS2_IdBien), 8, 0)));
            }
            else
            {
               AV15gTTBUS2_IdBien = (int)(context.localUtil.CToN( cgiGet( edtavGttbus2_idbien_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15gTTBUS2_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15gTTBUS2_IdBien), 8, 0)));
            }
            AV9TTBUS_Descripcion = StringUtil.Upper( cgiGet( edtavTtbus_descripcion_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9TTBUS_Descripcion", AV9TTBUS_Descripcion);
            if ( ! context.localUtil.VCNumber( cgiGet( edtavGttbus2_codposdesde_Internalname), "ZZ9") || ( context.localUtil.CToN( cgiGet( edtavGttbus2_codposdesde_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavGttbus2_codposdesde_Internalname), ",", ".") > Convert.ToDecimal( 999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vGTTBUS2_CODPOSDESDE");
               GX_FocusControl = edtavGttbus2_codposdesde_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV14gTTBUS2_CodPosDesde = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14gTTBUS2_CodPosDesde", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14gTTBUS2_CodPosDesde), 3, 0)));
            }
            else
            {
               AV14gTTBUS2_CodPosDesde = (short)(context.localUtil.CToN( cgiGet( edtavGttbus2_codposdesde_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14gTTBUS2_CodPosDesde", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14gTTBUS2_CodPosDesde), 3, 0)));
            }
            AV13dTTBUS3_Des = cgiGet( edtavDttbus3_des_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13dTTBUS3_Des", AV13dTTBUS3_Des);
            AV24gTTBUS2_RespDesde = cgiGet( edtavGttbus2_respdesde_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24gTTBUS2_RespDesde", AV24gTTBUS2_RespDesde);
            AV7dUSU_DES = StringUtil.Upper( cgiGet( edtavDusu_des_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7dUSU_DES", AV7dUSU_DES);
            if ( context.localUtil.VCDateTime( cgiGet( edtavGttbus2_fechaenvio_Internalname), 4, 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"g TTBUS2_ Fecha Envio"}), 1, "vGTTBUS2_FECHAENVIO");
               GX_FocusControl = edtavGttbus2_fechaenvio_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV20gTTBUS2_FechaEnvio = (DateTime)(DateTime.MinValue) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20gTTBUS2_FechaEnvio", context.localUtil.TToC( AV20gTTBUS2_FechaEnvio, 10, 5, 0, 3, "/", ":", " "));
            }
            else
            {
               AV20gTTBUS2_FechaEnvio = context.localUtil.CToT( cgiGet( edtavGttbus2_fechaenvio_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20gTTBUS2_FechaEnvio", context.localUtil.TToC( AV20gTTBUS2_FechaEnvio, 10, 5, 0, 3, "/", ":", " "));
            }
            if ( context.localUtil.VCDateTime( cgiGet( edtavGttbus2_fecharecepcion_Internalname), 4, 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"g TTBUS2_ Fecha Recepcion"}), 1, "vGTTBUS2_FECHARECEPCION");
               GX_FocusControl = edtavGttbus2_fecharecepcion_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV25gTTBUS2_FechaRecepcion = (DateTime)(DateTime.MinValue) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25gTTBUS2_FechaRecepcion", context.localUtil.TToC( AV25gTTBUS2_FechaRecepcion, 8, 5, 0, 3, "/", ":", " "));
            }
            else
            {
               AV25gTTBUS2_FechaRecepcion = context.localUtil.CToT( cgiGet( edtavGttbus2_fecharecepcion_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25gTTBUS2_FechaRecepcion", context.localUtil.TToC( AV25gTTBUS2_FechaRecepcion, 8, 5, 0, 3, "/", ":", " "));
            }
            if ( context.localUtil.VCDateTime( cgiGet( edtavGttbus2_fechaenvio_Internalname), 4, 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"g TTBUS2_ Fecha Envio"}), 1, "vGTTBUS2_FECHAENVIO");
               GX_FocusControl = edtavGttbus2_fechaenvio_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV20gTTBUS2_FechaEnvio = (DateTime)(DateTime.MinValue) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20gTTBUS2_FechaEnvio", context.localUtil.TToC( AV20gTTBUS2_FechaEnvio, 10, 5, 0, 3, "/", ":", " "));
            }
            else
            {
               AV20gTTBUS2_FechaEnvio = context.localUtil.CToT( cgiGet( edtavGttbus2_fechaenvio_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20gTTBUS2_FechaEnvio", context.localUtil.TToC( AV20gTTBUS2_FechaEnvio, 10, 5, 0, 3, "/", ":", " "));
            }
            AV22gTTBUS2_MotivoEnvio = StringUtil.Upper( cgiGet( edtavGttbus2_motivoenvio_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22gTTBUS2_MotivoEnvio", AV22gTTBUS2_MotivoEnvio);
            AV23gTTBUS2_Observaciones = StringUtil.Upper( cgiGet( edtavGttbus2_observaciones_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23gTTBUS2_Observaciones", AV23gTTBUS2_Observaciones);
            if ( AV26seleccion == 1 )
            {
               if ( AV19gTTBUS2_EstadoEnvio == 1 )
               {
                  new ptbus004(context ).execute( ref  AV18gTTBUS2_IdMovimiento, ref  AV15gTTBUS2_IdBien) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18gTTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18gTTBUS2_IdMovimiento), 12, 0)));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15gTTBUS2_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15gTTBUS2_IdBien), 8, 0)));
                  GX_msglist.addItem("EL ENVÍO FUE MARCADO COMO RECIBIDO.");
               }
               else
               {
                  if ( AV19gTTBUS2_EstadoEnvio == 2 )
                  {
                     GX_msglist.addItem("NO PUEDE RECIBIR UN ENVÍO FINALIZADO.");
                  }
                  else if ( AV19gTTBUS2_EstadoEnvio == 3 )
                  {
                     GX_msglist.addItem("NO PUEDE RECIBIR UN ENVÍO CANCELADO.");
                  }
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
            edtavTtbus_descripcion_Internalname = "vTTBUS_DESCRIPCION_"+sGXsfl_24_idx ;
            edtavGttbus2_codposdesde_Internalname = "vGTTBUS2_CODPOSDESDE_"+sGXsfl_24_idx ;
            edtavDttbus3_des_Internalname = "vDTTBUS3_DES_"+sGXsfl_24_idx ;
            edtavGttbus2_respdesde_Internalname = "vGTTBUS2_RESPDESDE_"+sGXsfl_24_idx ;
            edtavDusu_des_Internalname = "vDUSU_DES_"+sGXsfl_24_idx ;
            edtavGttbus2_fechaenvio_Internalname = "vGTTBUS2_FECHAENVIO_"+sGXsfl_24_idx ;
            edtavGttbus2_fecharecepcion_Internalname = "vGTTBUS2_FECHARECEPCION_"+sGXsfl_24_idx ;
            edtavGttbus2_fechaenvio_Internalname = "vGTTBUS2_FECHAENVIO_"+sGXsfl_24_idx ;
            edtavGttbus2_motivoenvio_Internalname = "vGTTBUS2_MOTIVOENVIO_"+sGXsfl_24_idx ;
            edtavGttbus2_observaciones_Internalname = "vGTTBUS2_OBSERVACIONES_"+sGXsfl_24_idx ;
         }
         nGXsfl_24_fel_idx = 1 ;
      }

      protected void wb_table1_2_1P2( bool wbgen )
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
            wb_table2_10_1P2( true) ;
         }
         else
         {
            wb_table2_10_1P2( false) ;
         }
         return  ;
      }

      protected void wb_table2_10_1P2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "right")+"\">") ;
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
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Descripción") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "g TTBUS2_ Cod Pos Desde") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Posición Envío") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "g TTBUS2_ Resp Desde") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Responsable Envío") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Fecha Envío") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Fecha Recepción") ;
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
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV26seleccion), 1, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", context.convertURL( AV27detalle));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18gTTBUS2_IdMovimiento), 12, 0, ".", "")));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavGttbus2_idmovimiento_Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( AV28gNumeroIdentificador));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavGnumeroidentificador_Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV15gTTBUS2_IdBien), 8, 0, ".", "")));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavGttbus2_idbien_Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( AV9TTBUS_Descripcion));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavTtbus_descripcion_Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14gTTBUS2_CodPosDesde), 3, 0, ".", "")));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavGttbus2_codposdesde_Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( AV13dTTBUS3_Des));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavDttbus3_des_Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( AV24gTTBUS2_RespDesde));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavGttbus2_respdesde_Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( AV7dUSU_DES));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavDusu_des_Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", context.localUtil.Format(AV20gTTBUS2_FechaEnvio, "99/99/9999 99:99"));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavGttbus2_fechaenvio_Enabled), 5, 0, ".", "")));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavGttbus2_fechaenvio_Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", context.localUtil.Format(AV25gTTBUS2_FechaRecepcion, "99/99/99 99:99"));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavGttbus2_fecharecepcion_Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", context.localUtil.Format(AV20gTTBUS2_FechaEnvio, "99/99/9999 99:99"));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavGttbus2_fechaenvio_Enabled), 5, 0, ".", "")));
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 42,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtnrecibir_Internalname, "Confirmar Recepción de un Bien", "Confirmar Recepción de un Bien", "", StyleString, ClassString, 1, 1, "rounded", 5, bttBtnrecibir_Jsonclick, "E\\'RECIBIR BIEN\\'.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(24), 3, 0)+","+"null"+");", "", "HLP_HTBUS004c.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_1P2e( true) ;
         }
         else
         {
            wb_table1_2_1P2e( false) ;
         }
      }

      protected void wb_table2_10_1P2( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblock2_Internalname, 1, 1, 0, "Estado de Envío:", "", "", "", 0, lblTextblock2_Jsonclick, "", StyleString, ClassString, "HLP_HTBUS004c.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'" + sGXsfl_24_idx + "',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavTtbus2_estadoenvio, cmbavTtbus2_estadoenvio_Internalname, StringUtil.Str( (decimal)(AV12TTBUS2_EstadoEnvio), 1, 0), "", "int", 1, 1, 0, 1, 0, 1, "chr", 0, "", StyleString, ClassString, "", 0, cmbavTtbus2_estadoenvio_Jsonclick, "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(15);\"", true, "HLP_HTBUS004c.htm");
            cmbavTtbus2_estadoenvio.CurrentValue = StringUtil.Str( (decimal)(AV12TTBUS2_EstadoEnvio), 1, 0) ;
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
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttButton1_Internalname, "Buscar", "Buscar", "", StyleString, ClassString, 1, 1, "rounded", 5, bttButton1_Jsonclick, "EREFRESH.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(24), 3, 0)+","+"null"+");", "", "HLP_HTBUS004c.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_10_1P2e( true) ;
         }
         else
         {
            wb_table2_10_1P2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV11USUARIO = (String)getParm(obj,0) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11USUARIO", AV11USUARIO);
         AV8SISTEMA = (String)getParm(obj,1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8SISTEMA", AV8SISTEMA);
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
         PA1P2( ) ;
         WS1P2( ) ;
         WE1P2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?13222074");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         if ( nGXWrapped != 1 )
         {
            context.AddJavascriptSource("messages.spa.js", "?42940");
            context.AddJavascriptSource("htbus004c.js", "?13222074");
         }
         /* End function include_jscripts */
      }

      protected void sendrow_242( )
      {
         WB1P0( ) ;
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
            Grid1Row.AddColumnProperties("checkbox", 1, isAjaxCallMode( ), new Object[] {(String)chkavSeleccion_Internalname,StringUtil.Str( (decimal)(AV26seleccion), 1, 0),(String)"",(short)-1,(short)1,(String)"1",(String)"",(String)StyleString,(String)ClassString,TempTags+((chkavSeleccion.Enabled!=0)&&(chkavSeleccion.Visible!=0) ? " onclick=\"gx.fn.checkboxClick(25, this, 1, 0);gx.evt.onchange(this);\" " : " ")+((chkavSeleccion.Enabled!=0)&&(chkavSeleccion.Visible!=0) ? " onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(25);\"" : " ")});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Active Bitmap Variable */
            TempTags = " " + ((edtavDetalle_Enabled!=0)&&(edtavDetalle_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 26,'',false,'',24)\"" : " ") ;
            ClassString = "Image" ;
            StyleString = "" ;
            Grid1Row.AddColumnProperties("bitmap", 2, isAjaxCallMode( ), new Object[] {(String)edtavDetalle_Internalname,(String)"",(String)AV27detalle,(String)"Modern",(short)-1,(short)1,(String)"",(String)"Ver Identificadores",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"",(short)0,(short)0,(String)"",(String)"",(short)7,(String)edtavDetalle_Jsonclick,(String)"'"+""+"'"+",false,"+"'"+"e131p2_client"+"'",(String)StyleString,(String)ClassString,(String)"",(String)""+TempTags,(String)"''",(String)""});
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
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavGttbus2_idmovimiento_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18gTTBUS2_IdMovimiento), 12, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)12,(short)-1,(int)edtavGttbus2_idmovimiento_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(AV18gTTBUS2_IdMovimiento), "ZZZZZZZZZZZ9"),TempTags+((edtavGttbus2_idmovimiento_Enabled!=0)&&(edtavGttbus2_idmovimiento_Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((edtavGttbus2_idmovimiento_Enabled!=0)&&(edtavGttbus2_idmovimiento_Visible!=0) ? " onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(27);\"" : " "),(short)0,(String)edtavGttbus2_idmovimiento_Jsonclick,(String)"",(short)24,(short)1,(short)1,(bool)true,(String)"right"});
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
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavGnumeroidentificador_Internalname,StringUtil.RTrim( AV28gNumeroIdentificador),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)80,(short)-1,(int)edtavGnumeroidentificador_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( AV28gNumeroIdentificador, "")),TempTags+((edtavGnumeroidentificador_Enabled!=0)&&(edtavGnumeroidentificador_Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((edtavGnumeroidentificador_Enabled!=0)&&(edtavGnumeroidentificador_Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(28);\"" : " "),(short)0,(String)edtavGnumeroidentificador_Jsonclick,(String)"",(short)24,(short)1,(short)1,(bool)true,(String)"left"});
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
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavGttbus2_idbien_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(AV15gTTBUS2_IdBien), 8, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)8,(short)-1,(int)edtavGttbus2_idbien_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(AV15gTTBUS2_IdBien), "ZZZZZZZ9"),TempTags+((edtavGttbus2_idbien_Enabled!=0)&&(edtavGttbus2_idbien_Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((edtavGttbus2_idbien_Enabled!=0)&&(edtavGttbus2_idbien_Visible!=0) ? " onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(29);\"" : " "),(short)0,(String)edtavGttbus2_idbien_Jsonclick,(String)"",(short)24,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            TempTags = " " + ((edtavTtbus_descripcion_Enabled!=0)&&(edtavTtbus_descripcion_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 30,'',false,'"+sGXsfl_24_idx+"',24)\"" : " ") ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavTtbus_descripcion_Internalname,StringUtil.RTrim( AV9TTBUS_Descripcion),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)50,(short)-1,(int)edtavTtbus_descripcion_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( AV9TTBUS_Descripcion, "@!")),TempTags+((edtavTtbus_descripcion_Enabled!=0)&&(edtavTtbus_descripcion_Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((edtavTtbus_descripcion_Enabled!=0)&&(edtavTtbus_descripcion_Visible!=0) ? " onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(30);\"" : " "),(short)0,(String)edtavTtbus_descripcion_Jsonclick,(String)"",(short)24,(short)1,(short)0,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            TempTags = " " + ((edtavGttbus2_codposdesde_Enabled!=0)&&(edtavGttbus2_codposdesde_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 31,'',false,'"+sGXsfl_24_idx+"',24)\"" : " ") ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavGttbus2_codposdesde_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14gTTBUS2_CodPosDesde), 3, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)3,(short)0,(int)edtavGttbus2_codposdesde_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(AV14gTTBUS2_CodPosDesde), "ZZ9"),TempTags+((edtavGttbus2_codposdesde_Enabled!=0)&&(edtavGttbus2_codposdesde_Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((edtavGttbus2_codposdesde_Enabled!=0)&&(edtavGttbus2_codposdesde_Visible!=0) ? " onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(31);\"" : " "),(short)0,(String)edtavGttbus2_codposdesde_Jsonclick,(String)"",(short)24,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            TempTags = " " + ((edtavDttbus3_des_Enabled!=0)&&(edtavDttbus3_des_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 32,'',false,'"+sGXsfl_24_idx+"',24)\"" : " ") ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavDttbus3_des_Internalname,StringUtil.RTrim( AV13dTTBUS3_Des),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)50,(short)-1,(int)edtavDttbus3_des_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( AV13dTTBUS3_Des, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")),TempTags+((edtavDttbus3_des_Enabled!=0)&&(edtavDttbus3_des_Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((edtavDttbus3_des_Enabled!=0)&&(edtavDttbus3_des_Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(32);\"" : " "),(short)0,(String)edtavDttbus3_des_Jsonclick,(String)"",(short)24,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            TempTags = " " + ((edtavGttbus2_respdesde_Enabled!=0)&&(edtavGttbus2_respdesde_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 33,'',false,'"+sGXsfl_24_idx+"',24)\"" : " ") ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavGttbus2_respdesde_Internalname,StringUtil.RTrim( AV24gTTBUS2_RespDesde),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)15,(short)0,(int)edtavGttbus2_respdesde_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( AV24gTTBUS2_RespDesde, "XXXXXXXXXXXXXXX")),TempTags+((edtavGttbus2_respdesde_Enabled!=0)&&(edtavGttbus2_respdesde_Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((edtavGttbus2_respdesde_Enabled!=0)&&(edtavGttbus2_respdesde_Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(33);\"" : " "),(short)0,(String)edtavGttbus2_respdesde_Jsonclick,(String)"",(short)24,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            TempTags = " " + ((edtavDusu_des_Enabled!=0)&&(edtavDusu_des_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 34,'',false,'"+sGXsfl_24_idx+"',24)\"" : " ") ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavDusu_des_Internalname,StringUtil.RTrim( AV7dUSU_DES),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)50,(short)-1,(int)edtavDusu_des_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( AV7dUSU_DES, "@!")),TempTags+((edtavDusu_des_Enabled!=0)&&(edtavDusu_des_Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((edtavDusu_des_Enabled!=0)&&(edtavDusu_des_Visible!=0) ? " onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(34);\"" : " "),(short)0,(String)edtavDusu_des_Jsonclick,(String)"",(short)24,(short)1,(short)1,(bool)true,(String)"left"});
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
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavGttbus2_fechaenvio_Internalname,context.localUtil.Format(AV20gTTBUS2_FechaEnvio, "99/99/9999 99:99"),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)16,(short)-1,(int)edtavGttbus2_fechaenvio_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( AV20gTTBUS2_FechaEnvio, "99/99/9999 99:99"),TempTags+((edtavGttbus2_fechaenvio_Enabled!=0)&&(edtavGttbus2_fechaenvio_Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((edtavGttbus2_fechaenvio_Enabled!=0)&&(edtavGttbus2_fechaenvio_Visible!=0) ? " onblur=\""+"gx.date.valid_date(this, 10,'DMY',5,24,'spa',false,0);"+";gx.evt.onblur(35);\"" : " "),(short)0,(String)edtavGttbus2_fechaenvio_Jsonclick,(String)"",(short)24,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            TempTags = " " + ((edtavGttbus2_fecharecepcion_Enabled!=0)&&(edtavGttbus2_fecharecepcion_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 36,'',false,'"+sGXsfl_24_idx+"',24)\"" : " ") ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavGttbus2_fecharecepcion_Internalname,context.localUtil.Format(AV25gTTBUS2_FechaRecepcion, "99/99/99 99:99"),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)14,(short)-1,(int)edtavGttbus2_fecharecepcion_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( AV25gTTBUS2_FechaRecepcion, "99/99/99 99:99"),TempTags+((edtavGttbus2_fecharecepcion_Enabled!=0)&&(edtavGttbus2_fecharecepcion_Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((edtavGttbus2_fecharecepcion_Enabled!=0)&&(edtavGttbus2_fecharecepcion_Visible!=0) ? " onblur=\""+"gx.date.valid_date(this, 8,'DMY',5,24,'spa',false,0);"+";gx.evt.onblur(36);\"" : " "),(short)0,(String)edtavGttbus2_fecharecepcion_Jsonclick,(String)"",(short)24,(short)1,(short)1,(bool)true,(String)"right"});
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
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavGttbus2_fechaenvio_Internalname,context.localUtil.Format(AV20gTTBUS2_FechaEnvio, "99/99/9999 99:99"),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)16,(short)-1,(int)edtavGttbus2_fechaenvio_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( AV20gTTBUS2_FechaEnvio, "99/99/9999 99:99"),TempTags+((edtavGttbus2_fechaenvio_Enabled!=0)&&(edtavGttbus2_fechaenvio_Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((edtavGttbus2_fechaenvio_Enabled!=0)&&(edtavGttbus2_fechaenvio_Visible!=0) ? " onblur=\""+"gx.date.valid_date(this, 10,'DMY',5,24,'spa',false,0);"+";gx.evt.onblur(35);\"" : " "),(short)0,(String)edtavGttbus2_fechaenvio_Jsonclick,(String)"",(short)24,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            TempTags = " " + ((edtavGttbus2_motivoenvio_Enabled!=0)&&(edtavGttbus2_motivoenvio_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 38,'',false,'"+sGXsfl_24_idx+"',24)\"" : " ") ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavGttbus2_motivoenvio_Internalname,StringUtil.RTrim( AV22gTTBUS2_MotivoEnvio),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)100,(short)-1,(int)edtavGttbus2_motivoenvio_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( AV22gTTBUS2_MotivoEnvio, "@!")),TempTags+((edtavGttbus2_motivoenvio_Enabled!=0)&&(edtavGttbus2_motivoenvio_Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((edtavGttbus2_motivoenvio_Enabled!=0)&&(edtavGttbus2_motivoenvio_Visible!=0) ? " onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(38);\"" : " "),(short)0,(String)edtavGttbus2_motivoenvio_Jsonclick,(String)"",(short)24,(short)1,(short)0,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            TempTags = " " + ((edtavGttbus2_observaciones_Enabled!=0)&&(edtavGttbus2_observaciones_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 39,'',false,'"+sGXsfl_24_idx+"',24)\"" : " ") ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavGttbus2_observaciones_Internalname,StringUtil.RTrim( AV23gTTBUS2_Observaciones),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)400,(short)-1,(int)edtavGttbus2_observaciones_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( AV23gTTBUS2_Observaciones, "@!")),TempTags+((edtavGttbus2_observaciones_Enabled!=0)&&(edtavGttbus2_observaciones_Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((edtavGttbus2_observaciones_Enabled!=0)&&(edtavGttbus2_observaciones_Visible!=0) ? " onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(39);\"" : " "),(short)0,(String)edtavGttbus2_observaciones_Jsonclick,(String)"",(short)24,(short)1,(short)0,(bool)true,(String)"left"});
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_24_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_24_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_24_idx+1)) ;
            sGXsfl_24_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_24_idx), 4, 0)), 4, "0") ;
            chkavSeleccion_Internalname = "vSELECCION_"+sGXsfl_24_idx ;
            edtavDetalle_Internalname = "vDETALLE_"+sGXsfl_24_idx ;
            edtavGttbus2_idmovimiento_Internalname = "vGTTBUS2_IDMOVIMIENTO_"+sGXsfl_24_idx ;
            edtavGnumeroidentificador_Internalname = "vGNUMEROIDENTIFICADOR_"+sGXsfl_24_idx ;
            edtavGttbus2_idbien_Internalname = "vGTTBUS2_IDBIEN_"+sGXsfl_24_idx ;
            edtavTtbus_descripcion_Internalname = "vTTBUS_DESCRIPCION_"+sGXsfl_24_idx ;
            edtavGttbus2_codposdesde_Internalname = "vGTTBUS2_CODPOSDESDE_"+sGXsfl_24_idx ;
            edtavDttbus3_des_Internalname = "vDTTBUS3_DES_"+sGXsfl_24_idx ;
            edtavGttbus2_respdesde_Internalname = "vGTTBUS2_RESPDESDE_"+sGXsfl_24_idx ;
            edtavDusu_des_Internalname = "vDUSU_DES_"+sGXsfl_24_idx ;
            edtavGttbus2_fechaenvio_Internalname = "vGTTBUS2_FECHAENVIO_"+sGXsfl_24_idx ;
            edtavGttbus2_fecharecepcion_Internalname = "vGTTBUS2_FECHARECEPCION_"+sGXsfl_24_idx ;
            edtavGttbus2_fechaenvio_Internalname = "vGTTBUS2_FECHAENVIO_"+sGXsfl_24_idx ;
            edtavGttbus2_motivoenvio_Internalname = "vGTTBUS2_MOTIVOENVIO_"+sGXsfl_24_idx ;
            edtavGttbus2_observaciones_Internalname = "vGTTBUS2_OBSERVACIONES_"+sGXsfl_24_idx ;
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
         edtavGttbus2_observaciones_Jsonclick = "" ;
         edtavGttbus2_observaciones_Visible = -1 ;
         edtavGttbus2_motivoenvio_Jsonclick = "" ;
         edtavGttbus2_motivoenvio_Visible = -1 ;
         edtavGttbus2_fecharecepcion_Jsonclick = "" ;
         edtavGttbus2_fecharecepcion_Visible = -1 ;
         edtavGttbus2_fechaenvio_Jsonclick = "" ;
         edtavGttbus2_fechaenvio_Visible = -1 ;
         edtavDusu_des_Jsonclick = "" ;
         edtavDusu_des_Visible = -1 ;
         edtavGttbus2_respdesde_Jsonclick = "" ;
         edtavGttbus2_respdesde_Visible = 0 ;
         edtavDttbus3_des_Jsonclick = "" ;
         edtavDttbus3_des_Visible = -1 ;
         edtavGttbus2_codposdesde_Jsonclick = "" ;
         edtavGttbus2_codposdesde_Visible = 0 ;
         edtavTtbus_descripcion_Jsonclick = "" ;
         edtavTtbus_descripcion_Visible = -1 ;
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
         edtavGttbus2_observaciones_Enabled = 1 ;
         edtavGttbus2_motivoenvio_Enabled = 1 ;
         edtavGttbus2_fecharecepcion_Enabled = 1 ;
         edtavGttbus2_fechaenvio_Enabled = 1 ;
         edtavDusu_des_Enabled = 1 ;
         edtavGttbus2_respdesde_Enabled = 1 ;
         edtavDttbus3_des_Enabled = 1 ;
         edtavGttbus2_codposdesde_Enabled = 1 ;
         edtavTtbus_descripcion_Enabled = 1 ;
         edtavGttbus2_idbien_Enabled = 1 ;
         edtavGnumeroidentificador_Enabled = 1 ;
         edtavGttbus2_idmovimiento_Enabled = 1 ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 3 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Bienes de Uso a Recibir" ;
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
         wcpOAV11USUARIO = "" ;
         wcpOAV8SISTEMA = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         A12TTBUS_Descripcion = "" ;
         A47TTBUS2_MotivoEnvio = "" ;
         A87TTBUS2_Observaciones = "" ;
         edtavGttbus2_idmovimiento_Internalname = "" ;
         edtavGnumeroidentificador_Internalname = "" ;
         edtavGttbus2_idbien_Internalname = "" ;
         edtavTtbus_descripcion_Internalname = "" ;
         edtavGttbus2_codposdesde_Internalname = "" ;
         edtavDttbus3_des_Internalname = "" ;
         edtavGttbus2_respdesde_Internalname = "" ;
         edtavDusu_des_Internalname = "" ;
         edtavGttbus2_fechaenvio_Internalname = "" ;
         edtavGttbus2_fecharecepcion_Internalname = "" ;
         edtavGttbus2_motivoenvio_Internalname = "" ;
         edtavGttbus2_observaciones_Internalname = "" ;
         GXCCtl = "" ;
         chkavSeleccion_Internalname = "" ;
         A102TTBUS2_TipoResp = "" ;
         A53TTBUS2_IdUsuario = "" ;
         A25TTBUS2_RespHacia = "" ;
         A46TTBUS2_FechaRecepcion = (DateTime)(DateTime.MinValue) ;
         A45TTBUS2_FechaEnvio = (DateTime)(DateTime.MinValue) ;
         A7USU_DES = "" ;
         A6USU_COD = "" ;
         A24TTBUS2_RespDesde = "" ;
         A34TTBUS7_Des = "" ;
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
         AV27detalle = "" ;
         AV28gNumeroIdentificador = "" ;
         AV9TTBUS_Descripcion = "" ;
         AV13dTTBUS3_Des = "" ;
         AV24gTTBUS2_RespDesde = "" ;
         AV7dUSU_DES = "" ;
         AV20gTTBUS2_FechaEnvio = (DateTime)(DateTime.MinValue) ;
         AV25gTTBUS2_FechaRecepcion = (DateTime)(DateTime.MinValue) ;
         AV22gTTBUS2_MotivoEnvio = "" ;
         AV23gTTBUS2_Observaciones = "" ;
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxwrpcisep = "" ;
         scmdbuf = "" ;
         l12TTBUS_Descripcion = "" ;
         H001P2_A12TTBUS_Descripcion = new String[] {""} ;
         l47TTBUS2_MotivoEnvio = "" ;
         H001P3_A47TTBUS2_MotivoEnvio = new String[] {""} ;
         l87TTBUS2_Observaciones = "" ;
         H001P4_A87TTBUS2_Observaciones = new String[] {""} ;
         H001P4_n87TTBUS2_Observaciones = new bool[] {false} ;
         Grid1Container = new GXWebGrid( context);
         H001P5_A24TTBUS2_RespDesde = new String[] {""} ;
         H001P5_A48TTBUS2_CodPosDesde = new short[1] ;
         H001P5_A22TTBUS2_IdBien = new int[1] ;
         H001P5_A26TTBUS2_EstadoEnvio = new short[1] ;
         H001P5_A25TTBUS2_RespHacia = new String[] {""} ;
         H001P5_A45TTBUS2_FechaEnvio = new DateTime[] {DateTime.MinValue} ;
         H001P5_A46TTBUS2_FechaRecepcion = new DateTime[] {DateTime.MinValue} ;
         H001P5_n46TTBUS2_FechaRecepcion = new bool[] {false} ;
         H001P5_A47TTBUS2_MotivoEnvio = new String[] {""} ;
         H001P5_A87TTBUS2_Observaciones = new String[] {""} ;
         H001P5_n87TTBUS2_Observaciones = new bool[] {false} ;
         H001P5_A52TTBUS2_IdMovimiento = new long[1] ;
         H001P6_A11TTBUS_Id = new int[1] ;
         H001P6_A12TTBUS_Descripcion = new String[] {""} ;
         H001P7_A33TTBUS7_Pos = new short[1] ;
         H001P7_A34TTBUS7_Des = new String[] {""} ;
         H001P7_n34TTBUS7_Des = new bool[] {false} ;
         H001P8_A6USU_COD = new String[] {""} ;
         H001P8_A7USU_DES = new String[] {""} ;
         AV21gTTBUS2_RespHacia = "" ;
         H001P9_A53TTBUS2_IdUsuario = new String[] {""} ;
         H001P9_A26TTBUS2_EstadoEnvio = new short[1] ;
         H001P9_A52TTBUS2_IdMovimiento = new long[1] ;
         H001P9_A22TTBUS2_IdBien = new int[1] ;
         H001P9_A48TTBUS2_CodPosDesde = new short[1] ;
         H001P9_A24TTBUS2_RespDesde = new String[] {""} ;
         H001P9_A45TTBUS2_FechaEnvio = new DateTime[] {DateTime.MinValue} ;
         H001P9_A25TTBUS2_RespHacia = new String[] {""} ;
         H001P9_A47TTBUS2_MotivoEnvio = new String[] {""} ;
         H001P9_A87TTBUS2_Observaciones = new String[] {""} ;
         H001P9_n87TTBUS2_Observaciones = new bool[] {false} ;
         H001P9_A102TTBUS2_TipoResp = new String[] {""} ;
         H001P10_A11TTBUS_Id = new int[1] ;
         H001P10_A12TTBUS_Descripcion = new String[] {""} ;
         H001P11_A33TTBUS7_Pos = new short[1] ;
         H001P11_A34TTBUS7_Des = new String[] {""} ;
         H001P11_n34TTBUS7_Des = new bool[] {false} ;
         H001P12_A6USU_COD = new String[] {""} ;
         H001P12_A7USU_DES = new String[] {""} ;
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
         GXt_char14 = "" ;
         Grid1Column = new GXWebColumn();
         TempTags = "" ;
         bttBtnrecibir_Jsonclick = "" ;
         lblTextblock2_Jsonclick = "" ;
         bttButton1_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         ROClassString = "" ;
         GXt_char15 = "" ;
         GXt_char16 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.htbus004c__default(),
            new Object[][] {
                new Object[] {
               H001P2_A12TTBUS_Descripcion
               }
               , new Object[] {
               H001P3_A47TTBUS2_MotivoEnvio
               }
               , new Object[] {
               H001P4_A87TTBUS2_Observaciones, H001P4_n87TTBUS2_Observaciones
               }
               , new Object[] {
               H001P5_A24TTBUS2_RespDesde, H001P5_A48TTBUS2_CodPosDesde, H001P5_A22TTBUS2_IdBien, H001P5_A26TTBUS2_EstadoEnvio, H001P5_A25TTBUS2_RespHacia, H001P5_A45TTBUS2_FechaEnvio, H001P5_A46TTBUS2_FechaRecepcion, H001P5_n46TTBUS2_FechaRecepcion, H001P5_A47TTBUS2_MotivoEnvio, H001P5_A87TTBUS2_Observaciones,
               H001P5_n87TTBUS2_Observaciones, H001P5_A52TTBUS2_IdMovimiento
               }
               , new Object[] {
               H001P6_A11TTBUS_Id, H001P6_A12TTBUS_Descripcion
               }
               , new Object[] {
               H001P7_A33TTBUS7_Pos, H001P7_A34TTBUS7_Des, H001P7_n34TTBUS7_Des
               }
               , new Object[] {
               H001P8_A6USU_COD, H001P8_A7USU_DES
               }
               , new Object[] {
               H001P9_A53TTBUS2_IdUsuario, H001P9_A26TTBUS2_EstadoEnvio, H001P9_A52TTBUS2_IdMovimiento, H001P9_A22TTBUS2_IdBien, H001P9_A48TTBUS2_CodPosDesde, H001P9_A24TTBUS2_RespDesde, H001P9_A45TTBUS2_FechaEnvio, H001P9_A25TTBUS2_RespHacia, H001P9_A47TTBUS2_MotivoEnvio, H001P9_A87TTBUS2_Observaciones,
               H001P9_n87TTBUS2_Observaciones, H001P9_A102TTBUS2_TipoResp
               }
               , new Object[] {
               H001P10_A11TTBUS_Id, H001P10_A12TTBUS_Descripcion
               }
               , new Object[] {
               H001P11_A33TTBUS7_Pos, H001P11_A34TTBUS7_Des, H001P11_n34TTBUS7_Des
               }
               , new Object[] {
               H001P12_A6USU_COD, H001P12_A7USU_DES
               }
            }
         );
         AV12TTBUS2_EstadoEnvio = 1 ;
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
         edtavGttbus2_idmovimiento_Enabled = 0 ;
         edtavGnumeroidentificador_Enabled = 0 ;
         edtavGttbus2_idbien_Enabled = 0 ;
         edtavTtbus_descripcion_Enabled = 0 ;
         edtavGttbus2_codposdesde_Enabled = 0 ;
         edtavDttbus3_des_Enabled = 0 ;
         edtavGttbus2_respdesde_Enabled = 0 ;
         edtavDusu_des_Enabled = 0 ;
         edtavGttbus2_fechaenvio_Enabled = 0 ;
         edtavGttbus2_fecharecepcion_Enabled = 0 ;
         edtavGttbus2_motivoenvio_Enabled = 0 ;
         edtavGttbus2_observaciones_Enabled = 0 ;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_Grid1 ;
      private short nGXsfl_24_idx=1 ;
      private short AV12TTBUS2_EstadoEnvio ;
      private short A26TTBUS2_EstadoEnvio ;
      private short A33TTBUS7_Pos ;
      private short A48TTBUS2_CodPosDesde ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short nGXWrapped ;
      private short GRID1_nEOF ;
      private short wbEnd ;
      private short wbStart ;
      private short AV26seleccion ;
      private short AV14gTTBUS2_CodPosDesde ;
      private short nDonePA ;
      private short subGrid1_Rows ;
      private short AV19gTTBUS2_EstadoEnvio ;
      private short nGXsfl_24_fel_idx=1 ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short subGrid1_Collapsed ;
      private short subGrid1_Backstyle ;
      private int Grid1_PageSize24 ;
      private int edtavGttbus2_idmovimiento_Enabled ;
      private int edtavGnumeroidentificador_Enabled ;
      private int edtavGttbus2_idbien_Enabled ;
      private int edtavTtbus_descripcion_Enabled ;
      private int edtavGttbus2_codposdesde_Enabled ;
      private int edtavDttbus3_des_Enabled ;
      private int edtavGttbus2_respdesde_Enabled ;
      private int edtavDusu_des_Enabled ;
      private int edtavGttbus2_fechaenvio_Enabled ;
      private int edtavGttbus2_fecharecepcion_Enabled ;
      private int edtavGttbus2_motivoenvio_Enabled ;
      private int edtavGttbus2_observaciones_Enabled ;
      private int A11TTBUS_Id ;
      private int A22TTBUS2_IdBien ;
      private int GRID1_nFirstRecordOnPage ;
      private int AV15gTTBUS2_IdBien ;
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
      private int edtavTtbus_descripcion_Visible ;
      private int edtavGttbus2_codposdesde_Visible ;
      private int edtavDttbus3_des_Visible ;
      private int edtavGttbus2_respdesde_Visible ;
      private int edtavDusu_des_Visible ;
      private int edtavGttbus2_fechaenvio_Visible ;
      private int edtavGttbus2_fecharecepcion_Visible ;
      private int edtavGttbus2_motivoenvio_Visible ;
      private int edtavGttbus2_observaciones_Visible ;
      private long A52TTBUS2_IdMovimiento ;
      private long AV18gTTBUS2_IdMovimiento ;
      private long AV16TTBUS2_IdMovimiento ;
      private String AV11USUARIO ;
      private String AV8SISTEMA ;
      private String wcpOAV11USUARIO ;
      private String wcpOAV8SISTEMA ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_24_idx="0001" ;
      private String edtavGttbus2_idmovimiento_Internalname ;
      private String edtavGnumeroidentificador_Internalname ;
      private String edtavGttbus2_idbien_Internalname ;
      private String edtavTtbus_descripcion_Internalname ;
      private String edtavGttbus2_codposdesde_Internalname ;
      private String edtavDttbus3_des_Internalname ;
      private String edtavGttbus2_respdesde_Internalname ;
      private String edtavDusu_des_Internalname ;
      private String edtavGttbus2_fechaenvio_Internalname ;
      private String edtavGttbus2_fecharecepcion_Internalname ;
      private String edtavGttbus2_motivoenvio_Internalname ;
      private String edtavGttbus2_observaciones_Internalname ;
      private String GXCCtl ;
      private String chkavSeleccion_Internalname ;
      private String A102TTBUS2_TipoResp ;
      private String A53TTBUS2_IdUsuario ;
      private String A25TTBUS2_RespHacia ;
      private String A7USU_DES ;
      private String A6USU_COD ;
      private String A24TTBUS2_RespDesde ;
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
      private String AV13dTTBUS3_Des ;
      private String AV24gTTBUS2_RespDesde ;
      private String AV7dUSU_DES ;
      private String cmbavTtbus2_estadoenvio_Internalname ;
      private String gxwrpcisep ;
      private String scmdbuf ;
      private String AV21gTTBUS2_RespHacia ;
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
      private String GXt_char14 ;
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
      private String edtavTtbus_descripcion_Jsonclick ;
      private String edtavGttbus2_codposdesde_Jsonclick ;
      private String edtavDttbus3_des_Jsonclick ;
      private String edtavGttbus2_respdesde_Jsonclick ;
      private String edtavDusu_des_Jsonclick ;
      private String edtavGttbus2_fechaenvio_Jsonclick ;
      private String edtavGttbus2_fecharecepcion_Jsonclick ;
      private String edtavGttbus2_motivoenvio_Jsonclick ;
      private String GXt_char15 ;
      private String edtavGttbus2_observaciones_Jsonclick ;
      private String GXt_char16 ;
      private DateTime A46TTBUS2_FechaRecepcion ;
      private DateTime A45TTBUS2_FechaEnvio ;
      private DateTime AV20gTTBUS2_FechaEnvio ;
      private DateTime AV25gTTBUS2_FechaRecepcion ;
      private bool entryPointCalled ;
      private bool n87TTBUS2_Observaciones ;
      private bool n46TTBUS2_FechaRecepcion ;
      private bool n34TTBUS7_Des ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool BRK1P7 ;
      private String A12TTBUS_Descripcion ;
      private String A47TTBUS2_MotivoEnvio ;
      private String A87TTBUS2_Observaciones ;
      private String AV28gNumeroIdentificador ;
      private String AV9TTBUS_Descripcion ;
      private String AV22gTTBUS2_MotivoEnvio ;
      private String AV23gTTBUS2_Observaciones ;
      private String l12TTBUS_Descripcion ;
      private String l47TTBUS2_MotivoEnvio ;
      private String l87TTBUS2_Observaciones ;
      private String AV27detalle ;
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
      private IDataStoreProvider pr_default ;
      private String[] H001P2_A12TTBUS_Descripcion ;
      private String[] H001P3_A47TTBUS2_MotivoEnvio ;
      private String[] H001P4_A87TTBUS2_Observaciones ;
      private bool[] H001P4_n87TTBUS2_Observaciones ;
      private String[] H001P5_A24TTBUS2_RespDesde ;
      private short[] H001P5_A48TTBUS2_CodPosDesde ;
      private int[] H001P5_A22TTBUS2_IdBien ;
      private short[] H001P5_A26TTBUS2_EstadoEnvio ;
      private String[] H001P5_A25TTBUS2_RespHacia ;
      private DateTime[] H001P5_A45TTBUS2_FechaEnvio ;
      private DateTime[] H001P5_A46TTBUS2_FechaRecepcion ;
      private bool[] H001P5_n46TTBUS2_FechaRecepcion ;
      private String[] H001P5_A47TTBUS2_MotivoEnvio ;
      private String[] H001P5_A87TTBUS2_Observaciones ;
      private bool[] H001P5_n87TTBUS2_Observaciones ;
      private long[] H001P5_A52TTBUS2_IdMovimiento ;
      private int[] H001P6_A11TTBUS_Id ;
      private String[] H001P6_A12TTBUS_Descripcion ;
      private short[] H001P7_A33TTBUS7_Pos ;
      private String[] H001P7_A34TTBUS7_Des ;
      private bool[] H001P7_n34TTBUS7_Des ;
      private String[] H001P8_A6USU_COD ;
      private String[] H001P8_A7USU_DES ;
      private String[] H001P9_A53TTBUS2_IdUsuario ;
      private short[] H001P9_A26TTBUS2_EstadoEnvio ;
      private long[] H001P9_A52TTBUS2_IdMovimiento ;
      private int[] H001P9_A22TTBUS2_IdBien ;
      private short[] H001P9_A48TTBUS2_CodPosDesde ;
      private String[] H001P9_A24TTBUS2_RespDesde ;
      private DateTime[] H001P9_A45TTBUS2_FechaEnvio ;
      private String[] H001P9_A25TTBUS2_RespHacia ;
      private String[] H001P9_A47TTBUS2_MotivoEnvio ;
      private String[] H001P9_A87TTBUS2_Observaciones ;
      private bool[] H001P9_n87TTBUS2_Observaciones ;
      private String[] H001P9_A102TTBUS2_TipoResp ;
      private int[] H001P10_A11TTBUS_Id ;
      private String[] H001P10_A12TTBUS_Descripcion ;
      private short[] H001P11_A33TTBUS7_Pos ;
      private String[] H001P11_A34TTBUS7_Des ;
      private bool[] H001P11_n34TTBUS7_Des ;
      private String[] H001P12_A6USU_COD ;
      private String[] H001P12_A7USU_DES ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXWebForm Form ;
   }

   public class htbus004c__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H001P5( short AV12TTBUS2_EstadoEnvio ,
                                             short A26TTBUS2_EstadoEnvio ,
                                             String A25TTBUS2_RespHacia ,
                                             String AV11USUARIO )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int17 ;
         GXv_int17 = new short [2] ;
         Object[] GXv_Object18 ;
         GXv_Object18 = new Object [2] ;
         scmdbuf = "SELECT [TTBUS2_RespDesde], [TTBUS2_CodPosDesde], [TTBUS2_IdBien], [TTBUS2_EstadoEnvio], [TTBUS2_RespHacia], [TTBUS2_FechaEnvio], [TTBUS2_FechaRecepcion], [TTBUS2_MotivoEnvio], [TTBUS2_Observaciones], [TTBUS2_IdMovimiento] FROM [TTBUS002] WITH (NOLOCK)" ;
         scmdbuf = scmdbuf + " WHERE ([TTBUS2_RespHacia] = @AV11USUARIO)" ;
         if ( ! (0==AV12TTBUS2_EstadoEnvio) )
         {
            sWhereString = sWhereString + " and ([TTBUS2_EstadoEnvio] = @AV12TTBUS2_EstadoEnvio)" ;
         }
         else
         {
            GXv_int17[1] = 1 ;
         }
         scmdbuf = scmdbuf + sWhereString ;
         scmdbuf = scmdbuf + " ORDER BY [TTBUS2_IdMovimiento]" ;
         GXv_Object18[0] = scmdbuf ;
         GXv_Object18[1] = (Object)(GXv_int17) ;
         return GXv_Object18 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 3 :
                     return conditional_H001P5( (short)dynConstraints[0] , (short)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] );
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
          Object[] prmH001P2 ;
          prmH001P2 = new Object[] {
          new Object[] {"@TTBUS_Descripcion",SqlDbType.VarChar,50,0}
          } ;
          Object[] prmH001P3 ;
          prmH001P3 = new Object[] {
          new Object[] {"@TTBUS2_MotivoEnvio",SqlDbType.VarChar,100,0}
          } ;
          Object[] prmH001P4 ;
          prmH001P4 = new Object[] {
          new Object[] {"@TTBUS2_Observaciones",SqlDbType.VarChar,400,0}
          } ;
          Object[] prmH001P6 ;
          prmH001P6 = new Object[] {
          new Object[] {"@TTBUS2_IdBien",SqlDbType.Int,8,0}
          } ;
          Object[] prmH001P7 ;
          prmH001P7 = new Object[] {
          new Object[] {"@TTBUS2_CodPosDesde",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmH001P8 ;
          prmH001P8 = new Object[] {
          new Object[] {"@TTBUS2_RespDesde",SqlDbType.Char,15,0}
          } ;
          Object[] prmH001P9 ;
          prmH001P9 = new Object[] {
          new Object[] {"@AV11USUARIO",SqlDbType.Char,16,0}
          } ;
          Object[] prmH001P10 ;
          prmH001P10 = new Object[] {
          new Object[] {"@TTBUS2_IdBien",SqlDbType.Int,8,0}
          } ;
          Object[] prmH001P11 ;
          prmH001P11 = new Object[] {
          new Object[] {"@TTBUS2_CodPosDesde",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmH001P12 ;
          prmH001P12 = new Object[] {
          new Object[] {"@TTBUS2_RespDesde",SqlDbType.Char,15,0}
          } ;
          Object[] prmH001P5 ;
          prmH001P5 = new Object[] {
          new Object[] {"@AV11USUARIO",SqlDbType.Char,16,0} ,
          new Object[] {"@AV12TTBUS2_EstadoEnvio",SqlDbType.SmallInt,1,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H001P2", "SELECT DISTINCT TOP 5 [TTBUS_Descripcion] FROM [TTBUS000] WITH (NOLOCK) WHERE UPPER(CAST([TTBUS_Descripcion] AS char(50))) like UPPER(CAST(@TTBUS_Descripcion AS char(50))) ORDER BY [TTBUS_Descripcion] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001P2,0,0,true,false )
             ,new CursorDef("H001P3", "SELECT DISTINCT TOP 5 [TTBUS2_MotivoEnvio] FROM [TTBUS002] WITH (NOLOCK) WHERE UPPER(CAST([TTBUS2_MotivoEnvio] AS char(100))) like UPPER(CAST(@TTBUS2_MotivoEnvio AS char(100))) ORDER BY [TTBUS2_MotivoEnvio] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001P3,0,0,true,false )
             ,new CursorDef("H001P4", "SELECT DISTINCT TOP 5 [TTBUS2_Observaciones] FROM [TTBUS002] WITH (NOLOCK) WHERE UPPER(CAST([TTBUS2_Observaciones] AS char(400))) like UPPER(CAST(@TTBUS2_Observaciones AS char(400))) ORDER BY [TTBUS2_Observaciones] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001P4,0,0,true,false )
             ,new CursorDef("H001P5", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001P5,100,0,true,false )
             ,new CursorDef("H001P6", "SELECT [TTBUS_Id], [TTBUS_Descripcion] FROM [TTBUS000] WITH (NOLOCK) WHERE [TTBUS_Id] = @TTBUS2_IdBien ORDER BY [TTBUS_Id] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001P6,1,0,false,true )
             ,new CursorDef("H001P7", "SELECT T1.[TTBUS7_Pos] AS TTBUS7_Pos, T2.[W53DES] AS TTBUS7_Des FROM ([TTBUS007] T1 WITH (NOLOCK) INNER JOIN [T53FPOS] T2 WITH (NOLOCK) ON T2.[W53POS] = T1.[TTBUS7_Pos]) WHERE T1.[TTBUS7_Pos] = @TTBUS2_CodPosDesde ORDER BY T1.[TTBUS7_Pos] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001P7,1,0,false,true )
             ,new CursorDef("H001P8", "SELECT [USU_COD], [USU_DES] FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @TTBUS2_RespDesde ORDER BY [USU_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001P8,1,0,false,true )
             ,new CursorDef("H001P9", "SELECT T1.[TTBUS2_IdUsuario], T2.[TTBUS2_EstadoEnvio], T1.[TTBUS2_IdMovimiento], T2.[TTBUS2_IdBien], T2.[TTBUS2_CodPosDesde], T2.[TTBUS2_RespDesde], T2.[TTBUS2_FechaEnvio], T2.[TTBUS2_RespHacia], T2.[TTBUS2_MotivoEnvio], T2.[TTBUS2_Observaciones], T1.[TTBUS2_TipoResp] FROM ([TTBUS002_Det] T1 WITH (NOLOCK) INNER JOIN [TTBUS002] T2 WITH (NOLOCK) ON T2.[TTBUS2_IdMovimiento] = T1.[TTBUS2_IdMovimiento]) WHERE T1.[TTBUS2_IdUsuario] = @AV11USUARIO ORDER BY T1.[TTBUS2_IdUsuario], T1.[TTBUS2_IdMovimiento] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001P9,100,0,true,false )
             ,new CursorDef("H001P10", "SELECT [TTBUS_Id], [TTBUS_Descripcion] FROM [TTBUS000] WITH (NOLOCK) WHERE [TTBUS_Id] = @TTBUS2_IdBien ORDER BY [TTBUS_Id] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001P10,1,0,false,true )
             ,new CursorDef("H001P11", "SELECT T1.[TTBUS7_Pos] AS TTBUS7_Pos, T2.[W53DES] AS TTBUS7_Des FROM ([TTBUS007] T1 WITH (NOLOCK) INNER JOIN [T53FPOS] T2 WITH (NOLOCK) ON T2.[W53POS] = T1.[TTBUS7_Pos]) WHERE T1.[TTBUS7_Pos] = @TTBUS2_CodPosDesde ORDER BY T1.[TTBUS7_Pos] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001P11,1,0,false,true )
             ,new CursorDef("H001P12", "SELECT [USU_COD], [USU_DES] FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @TTBUS2_RespDesde ORDER BY [USU_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001P12,1,0,false,true )
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
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 15) ;
                ((DateTime[]) buf[5])[0] = rslt.getGXDateTime(6) ;
                ((DateTime[]) buf[6])[0] = rslt.getGXDateTime(7) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(7);
                ((String[]) buf[8])[0] = rslt.getVarchar(8) ;
                ((String[]) buf[9])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(9);
                ((long[]) buf[11])[0] = rslt.getLong(10) ;
                break;
             case 4 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
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
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((long[]) buf[2])[0] = rslt.getLong(3) ;
                ((int[]) buf[3])[0] = rslt.getInt(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((String[]) buf[5])[0] = rslt.getString(6, 15) ;
                ((DateTime[]) buf[6])[0] = rslt.getGXDateTime(7) ;
                ((String[]) buf[7])[0] = rslt.getString(8, 15) ;
                ((String[]) buf[8])[0] = rslt.getVarchar(9) ;
                ((String[]) buf[9])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(10);
                ((String[]) buf[11])[0] = rslt.getString(11, 1) ;
                break;
             case 8 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                break;
             case 9 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                break;
             case 10 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
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
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 2 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(1, (String)parms[1]);
                }
                break;
             case 3 :
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
             case 4 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 5 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 6 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 7 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 8 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 9 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 10 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
       }
    }

 }

}
