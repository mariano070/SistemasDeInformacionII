/*
               File: HTBUS002
        Description: Historial de Movimietos de Bienes de Uso
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 4/2/2014 19:29:17.22
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
   public class htbus002 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public htbus002( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public htbus002( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref int aP0_TTBUS_Id ,
                           ref String aP1_TTBUS_Descripcion ,
                           ref String aP2_SISTEMA ,
                           ref String aP3_USUARIO )
      {
         this.AV7TTBUS_Id = aP0_TTBUS_Id;
         this.AV15TTBUS_Descripcion = aP1_TTBUS_Descripcion;
         this.AV5SISTEMA = aP2_SISTEMA;
         this.AV6USUARIO = aP3_USUARIO;
         executePrivate();
         aP0_TTBUS_Id=this.AV7TTBUS_Id;
         aP1_TTBUS_Descripcion=this.AV15TTBUS_Descripcion;
         aP2_SISTEMA=this.AV5SISTEMA;
         aP3_USUARIO=this.AV6USUARIO;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbTTBUS2_EstadoEnvio = new GXCombobox();
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxSuggest"+"_"+"TTBUS2_MOTIVOENVIO") == 0 )
            {
               A47TTBUS2_MotivoEnvio = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A47TTBUS2_MotivoEnvio", A47TTBUS2_MotivoEnvio);
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               GXSGATTBUS2_MOTIVOENVIO1R0( A47TTBUS2_MotivoEnvio) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxSuggest"+"_"+"TTBUS2_OBSERVACIONES") == 0 )
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
               GXSGATTBUS2_OBSERVACIONES1R0( A87TTBUS2_Observaciones) ;
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
               nGXsfl_13_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               sGXsfl_13_idx = GetNextPar( ) ;
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxnrGrid1_newrow( nRC_Grid1, nGXsfl_13_idx, sGXsfl_13_idx) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid1") == 0 )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0 ;
               GXCCtl = "TTBUS2_ESTADOENVIO_" + sGXsfl_13_idx ;
               cmbTTBUS2_EstadoEnvio.Name = GXCCtl ;
               cmbTTBUS2_EstadoEnvio.WebTags = "" ;
               cmbTTBUS2_EstadoEnvio.addItem("1", "No Finalizado", 0);
               cmbTTBUS2_EstadoEnvio.addItem("2", "Finalizado", 0);
               cmbTTBUS2_EstadoEnvio.addItem("3", "Cancelado", 0);
               if ( ( cmbTTBUS2_EstadoEnvio.ItemCount > 0 ) && (0==A26TTBUS2_EstadoEnvio) )
               {
                  A26TTBUS2_EstadoEnvio = (short)(NumberUtil.Val( cmbTTBUS2_EstadoEnvio.getItemValue(1), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26TTBUS2_EstadoEnvio", StringUtil.Str( (decimal)(A26TTBUS2_EstadoEnvio), 1, 0));
               }
               Grid1_PageSize13 = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               AV7TTBUS_Id = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7TTBUS_Id), 8, 0)));
               A7USU_DES = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7USU_DES", A7USU_DES);
               A6USU_COD = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
               A34TTBUS7_Des = GetNextPar( ) ;
               n34TTBUS7_Des = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34TTBUS7_Des", A34TTBUS7_Des);
               A33TTBUS7_Pos = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
               AV18cont = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxgrGrid1_refresh( Grid1_PageSize13, AV7TTBUS_Id, A7USU_DES, A6USU_COD, A34TTBUS7_Des, A33TTBUS7_Pos, AV18cont) ;
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
               AV7TTBUS_Id = (int)(NumberUtil.Val( gxfirstwebparm, ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7TTBUS_Id), 8, 0)));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV15TTBUS_Descripcion = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15TTBUS_Descripcion", AV15TTBUS_Descripcion);
                  AV5SISTEMA = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5SISTEMA", AV5SISTEMA);
                  AV6USUARIO = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6USUARIO", AV6USUARIO);
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
         PA1R2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START1R2( ) ;
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
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("htbus002.aspx") + "?" + UrlEncode("" +AV7TTBUS_Id) + "," + UrlEncode(StringUtil.RTrim(AV15TTBUS_Descripcion)) + "," + UrlEncode(StringUtil.RTrim(AV5SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV6USUARIO))+"\" class=\""+"Form"+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "vTTBUS_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7TTBUS_Id), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vTTBUS_DESCRIPCION", StringUtil.RTrim( AV15TTBUS_Descripcion));
         GxWebStd.gx_hidden_field( context, "vSISTEMA", StringUtil.RTrim( AV5SISTEMA));
         GxWebStd.gx_hidden_field( context, "vUSUARIO", StringUtil.RTrim( AV6USUARIO));
         GxWebStd.gx_hidden_field( context, "USU_DES", StringUtil.RTrim( A7USU_DES));
         GxWebStd.gx_hidden_field( context, "USU_COD", StringUtil.RTrim( A6USU_COD));
         GxWebStd.gx_hidden_field( context, "TTBUS7_DES", StringUtil.RTrim( A34TTBUS7_Des));
         GxWebStd.gx_hidden_field( context, "TTBUS7_POS", StringUtil.LTrim( StringUtil.NToC( (decimal)(A33TTBUS7_Pos), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vCONT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18cont), 8, 0, ",", "")));
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
            WE1R2( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT1R2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return false ;
      }

      public override String GetPgmname( )
      {
         return "HTBUS002" ;
      }

      public override String GetPgmdesc( )
      {
         return "Historial de Movimietos de Bienes de Uso" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("htbus002.aspx") + "?" + UrlEncode("" +AV7TTBUS_Id) + "," + UrlEncode(StringUtil.RTrim(AV15TTBUS_Descripcion)) + "," + UrlEncode(StringUtil.RTrim(AV5SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV6USUARIO)) ;
      }

      protected void WB1R0( )
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
            wb_table1_2_1R2( true) ;
         }
         else
         {
            wb_table1_2_1R2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_1R2e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START1R2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "Historial de Movimietos de Bienes de Uso", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP1R0( ) ;
      }

      protected void WS1R2( )
      {
         START1R2( ) ;
         EVT1R2( ) ;
      }

      protected void EVT1R2( )
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
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 10), "GRID1.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) )
                           {
                              nGXsfl_13_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                              sGXsfl_13_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_13_idx), 4, 0)), 4, "0") ;
                              edtTTBUS2_IdMovimiento_Internalname = "TTBUS2_IDMOVIMIENTO_"+sGXsfl_13_idx ;
                              edtTTBUS2_IdBien_Internalname = "TTBUS2_IDBIEN_"+sGXsfl_13_idx ;
                              edtTTBUS2_CodPosDesde_Internalname = "TTBUS2_CODPOSDESDE_"+sGXsfl_13_idx ;
                              edtavDttbus3_des_Internalname = "vDTTBUS3_DES_"+sGXsfl_13_idx ;
                              edtTTBUS2_RespDesde_Internalname = "TTBUS2_RESPDESDE_"+sGXsfl_13_idx ;
                              edtavDusu_des_Internalname = "vDUSU_DES_"+sGXsfl_13_idx ;
                              edtTTBUS2_FechaEnvio_Internalname = "TTBUS2_FECHAENVIO_"+sGXsfl_13_idx ;
                              edtTTBUS2_CodPosHacia_Internalname = "TTBUS2_CODPOSHACIA_"+sGXsfl_13_idx ;
                              edtavHttbus3_des_Internalname = "vHTTBUS3_DES_"+sGXsfl_13_idx ;
                              edtTTBUS2_RespHacia_Internalname = "TTBUS2_RESPHACIA_"+sGXsfl_13_idx ;
                              edtavHusu_des_Internalname = "vHUSU_DES_"+sGXsfl_13_idx ;
                              edtTTBUS2_FechaRecepcion_Internalname = "TTBUS2_FECHARECEPCION_"+sGXsfl_13_idx ;
                              cmbTTBUS2_EstadoEnvio_Internalname = "TTBUS2_ESTADOENVIO_"+sGXsfl_13_idx ;
                              edtTTBUS2_MotivoEnvio_Internalname = "TTBUS2_MOTIVOENVIO_"+sGXsfl_13_idx ;
                              edtTTBUS2_Observaciones_Internalname = "TTBUS2_OBSERVACIONES_"+sGXsfl_13_idx ;
                              A52TTBUS2_IdMovimiento = (long)(context.localUtil.CToN( cgiGet( edtTTBUS2_IdMovimiento_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52TTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(A52TTBUS2_IdMovimiento), 12, 0)));
                              A22TTBUS2_IdBien = (int)(context.localUtil.CToN( cgiGet( edtTTBUS2_IdBien_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22TTBUS2_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A22TTBUS2_IdBien), 8, 0)));
                              A48TTBUS2_CodPosDesde = (short)(context.localUtil.CToN( cgiGet( edtTTBUS2_CodPosDesde_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A48TTBUS2_CodPosDesde", StringUtil.LTrim( StringUtil.Str( (decimal)(A48TTBUS2_CodPosDesde), 3, 0)));
                              AV17dTTBUS3_Des = cgiGet( edtavDttbus3_des_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17dTTBUS3_Des", AV17dTTBUS3_Des);
                              A24TTBUS2_RespDesde = cgiGet( edtTTBUS2_RespDesde_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24TTBUS2_RespDesde", A24TTBUS2_RespDesde);
                              AV13dUSU_DES = StringUtil.Upper( cgiGet( edtavDusu_des_Internalname)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13dUSU_DES", AV13dUSU_DES);
                              A45TTBUS2_FechaEnvio = context.localUtil.CToT( cgiGet( edtTTBUS2_FechaEnvio_Internalname)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A45TTBUS2_FechaEnvio", context.localUtil.TToC( A45TTBUS2_FechaEnvio, 10, 5, 0, 3, "/", ":", " "));
                              A49TTBUS2_CodPosHacia = (short)(context.localUtil.CToN( cgiGet( edtTTBUS2_CodPosHacia_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A49TTBUS2_CodPosHacia", StringUtil.LTrim( StringUtil.Str( (decimal)(A49TTBUS2_CodPosHacia), 3, 0)));
                              AV16hTTBUS3_Des = cgiGet( edtavHttbus3_des_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16hTTBUS3_Des", AV16hTTBUS3_Des);
                              A25TTBUS2_RespHacia = cgiGet( edtTTBUS2_RespHacia_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25TTBUS2_RespHacia", A25TTBUS2_RespHacia);
                              AV14hUSU_DES = StringUtil.Upper( cgiGet( edtavHusu_des_Internalname)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14hUSU_DES", AV14hUSU_DES);
                              A46TTBUS2_FechaRecepcion = context.localUtil.CToT( cgiGet( edtTTBUS2_FechaRecepcion_Internalname)) ;
                              n46TTBUS2_FechaRecepcion = false ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46TTBUS2_FechaRecepcion", context.localUtil.TToC( A46TTBUS2_FechaRecepcion, 8, 5, 0, 3, "/", ":", " "));
                              cmbTTBUS2_EstadoEnvio.Name = cmbTTBUS2_EstadoEnvio_Internalname ;
                              cmbTTBUS2_EstadoEnvio.CurrentValue = cgiGet( cmbTTBUS2_EstadoEnvio_Internalname) ;
                              A26TTBUS2_EstadoEnvio = (short)(NumberUtil.Val( cgiGet( cmbTTBUS2_EstadoEnvio_Internalname), ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26TTBUS2_EstadoEnvio", StringUtil.Str( (decimal)(A26TTBUS2_EstadoEnvio), 1, 0));
                              A47TTBUS2_MotivoEnvio = StringUtil.Upper( cgiGet( edtTTBUS2_MotivoEnvio_Internalname)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A47TTBUS2_MotivoEnvio", A47TTBUS2_MotivoEnvio);
                              A87TTBUS2_Observaciones = StringUtil.Upper( cgiGet( edtTTBUS2_Observaciones_Internalname)) ;
                              n87TTBUS2_Observaciones = false ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A87TTBUS2_Observaciones", A87TTBUS2_Observaciones);
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E111R2 */
                                    E111R2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID1.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E121R2 */
                                    E121R2 ();
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

      protected void WE1R2( )
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

      protected void PA1R2( )
      {
         if ( nDonePA == 0 )
         {
            GXCCtl = "TTBUS2_ESTADOENVIO_" + sGXsfl_13_idx ;
            cmbTTBUS2_EstadoEnvio.Name = GXCCtl ;
            cmbTTBUS2_EstadoEnvio.WebTags = "" ;
            cmbTTBUS2_EstadoEnvio.addItem("1", "No Finalizado", 0);
            cmbTTBUS2_EstadoEnvio.addItem("2", "Finalizado", 0);
            cmbTTBUS2_EstadoEnvio.addItem("3", "Cancelado", 0);
            if ( ( cmbTTBUS2_EstadoEnvio.ItemCount > 0 ) && (0==A26TTBUS2_EstadoEnvio) )
            {
               A26TTBUS2_EstadoEnvio = (short)(NumberUtil.Val( cmbTTBUS2_EstadoEnvio.getItemValue(1), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26TTBUS2_EstadoEnvio", StringUtil.Str( (decimal)(A26TTBUS2_EstadoEnvio), 1, 0));
            }
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void GXSGATTBUS2_MOTIVOENVIO1R0( String A47TTBUS2_MotivoEnvio )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
         }
         context.GX_webresponse.AddString("(new Array( new Array(");
         GXSGATTBUS2_MOTIVOENVIO_data1R0( A47TTBUS2_MotivoEnvio) ;
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

      protected void GXSGATTBUS2_MOTIVOENVIO_data1R0( String A47TTBUS2_MotivoEnvio )
      {
         l47TTBUS2_MotivoEnvio = StringUtil.PadR( StringUtil.RTrim( A47TTBUS2_MotivoEnvio), 100, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A47TTBUS2_MotivoEnvio", A47TTBUS2_MotivoEnvio);
         /* Using cursor H001R2 */
         pr_default.execute(0, new Object[] {l47TTBUS2_MotivoEnvio});
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         while ( (pr_default.getStatus(0) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.RTrim( H001R2_A47TTBUS2_MotivoEnvio[0]));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( H001R2_A47TTBUS2_MotivoEnvio[0]));
            pr_default.readNext(0);
         }
         pr_default.close(0);
      }

      protected void GXSGATTBUS2_OBSERVACIONES1R0( String A87TTBUS2_Observaciones )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
         }
         context.GX_webresponse.AddString("(new Array( new Array(");
         GXSGATTBUS2_OBSERVACIONES_data1R0( A87TTBUS2_Observaciones) ;
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

      protected void GXSGATTBUS2_OBSERVACIONES_data1R0( String A87TTBUS2_Observaciones )
      {
         l87TTBUS2_Observaciones = StringUtil.PadR( StringUtil.RTrim( A87TTBUS2_Observaciones), 400, "%") ;
         n87TTBUS2_Observaciones = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A87TTBUS2_Observaciones", A87TTBUS2_Observaciones);
         /* Using cursor H001R3 */
         pr_default.execute(1, new Object[] {n87TTBUS2_Observaciones, l87TTBUS2_Observaciones});
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         while ( (pr_default.getStatus(1) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.RTrim( H001R3_A87TTBUS2_Observaciones[0]));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( H001R3_A87TTBUS2_Observaciones[0]));
            pr_default.readNext(1);
         }
         pr_default.close(1);
      }

      protected void gxnrGrid1_newrow( short nRC_Grid1 ,
                                       short nGXsfl_13_idx ,
                                       String sGXsfl_13_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         edtTTBUS2_IdMovimiento_Internalname = "TTBUS2_IDMOVIMIENTO_"+sGXsfl_13_idx ;
         edtTTBUS2_IdBien_Internalname = "TTBUS2_IDBIEN_"+sGXsfl_13_idx ;
         edtTTBUS2_CodPosDesde_Internalname = "TTBUS2_CODPOSDESDE_"+sGXsfl_13_idx ;
         edtavDttbus3_des_Internalname = "vDTTBUS3_DES_"+sGXsfl_13_idx ;
         edtTTBUS2_RespDesde_Internalname = "TTBUS2_RESPDESDE_"+sGXsfl_13_idx ;
         edtavDusu_des_Internalname = "vDUSU_DES_"+sGXsfl_13_idx ;
         edtTTBUS2_FechaEnvio_Internalname = "TTBUS2_FECHAENVIO_"+sGXsfl_13_idx ;
         edtTTBUS2_CodPosHacia_Internalname = "TTBUS2_CODPOSHACIA_"+sGXsfl_13_idx ;
         edtavHttbus3_des_Internalname = "vHTTBUS3_DES_"+sGXsfl_13_idx ;
         edtTTBUS2_RespHacia_Internalname = "TTBUS2_RESPHACIA_"+sGXsfl_13_idx ;
         edtavHusu_des_Internalname = "vHUSU_DES_"+sGXsfl_13_idx ;
         edtTTBUS2_FechaRecepcion_Internalname = "TTBUS2_FECHARECEPCION_"+sGXsfl_13_idx ;
         cmbTTBUS2_EstadoEnvio_Internalname = "TTBUS2_ESTADOENVIO_"+sGXsfl_13_idx ;
         edtTTBUS2_MotivoEnvio_Internalname = "TTBUS2_MOTIVOENVIO_"+sGXsfl_13_idx ;
         edtTTBUS2_Observaciones_Internalname = "TTBUS2_OBSERVACIONES_"+sGXsfl_13_idx ;
         while ( nGXsfl_13_idx <= nRC_Grid1 )
         {
            sendrow_132( ) ;
            nGXsfl_13_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_13_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_13_idx+1)) ;
            sGXsfl_13_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_13_idx), 4, 0)), 4, "0") ;
            edtTTBUS2_IdMovimiento_Internalname = "TTBUS2_IDMOVIMIENTO_"+sGXsfl_13_idx ;
            edtTTBUS2_IdBien_Internalname = "TTBUS2_IDBIEN_"+sGXsfl_13_idx ;
            edtTTBUS2_CodPosDesde_Internalname = "TTBUS2_CODPOSDESDE_"+sGXsfl_13_idx ;
            edtavDttbus3_des_Internalname = "vDTTBUS3_DES_"+sGXsfl_13_idx ;
            edtTTBUS2_RespDesde_Internalname = "TTBUS2_RESPDESDE_"+sGXsfl_13_idx ;
            edtavDusu_des_Internalname = "vDUSU_DES_"+sGXsfl_13_idx ;
            edtTTBUS2_FechaEnvio_Internalname = "TTBUS2_FECHAENVIO_"+sGXsfl_13_idx ;
            edtTTBUS2_CodPosHacia_Internalname = "TTBUS2_CODPOSHACIA_"+sGXsfl_13_idx ;
            edtavHttbus3_des_Internalname = "vHTTBUS3_DES_"+sGXsfl_13_idx ;
            edtTTBUS2_RespHacia_Internalname = "TTBUS2_RESPHACIA_"+sGXsfl_13_idx ;
            edtavHusu_des_Internalname = "vHUSU_DES_"+sGXsfl_13_idx ;
            edtTTBUS2_FechaRecepcion_Internalname = "TTBUS2_FECHARECEPCION_"+sGXsfl_13_idx ;
            cmbTTBUS2_EstadoEnvio_Internalname = "TTBUS2_ESTADOENVIO_"+sGXsfl_13_idx ;
            edtTTBUS2_MotivoEnvio_Internalname = "TTBUS2_MOTIVOENVIO_"+sGXsfl_13_idx ;
            edtTTBUS2_Observaciones_Internalname = "TTBUS2_OBSERVACIONES_"+sGXsfl_13_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int Grid1_PageSize13 ,
                                        int AV7TTBUS_Id ,
                                        String A7USU_DES ,
                                        String A6USU_COD ,
                                        String A34TTBUS7_Des ,
                                        short A33TTBUS7_Pos ,
                                        int AV18cont )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         subGrid1_Rows = (short)(Grid1_PageSize13) ;
         RF1R2( ) ;
         enableOutput();
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxgrGrid1_refresh */
      }

      protected void Refresh( )
      {
         RF1R2( ) ;
         /* End function Refresh */
      }

      protected void RF1R2( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 13 ;
         nGXsfl_13_idx = 1 ;
         sGXsfl_13_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_13_idx), 4, 0)), 4, "0") ;
         edtTTBUS2_IdMovimiento_Internalname = "TTBUS2_IDMOVIMIENTO_"+sGXsfl_13_idx ;
         edtTTBUS2_IdBien_Internalname = "TTBUS2_IDBIEN_"+sGXsfl_13_idx ;
         edtTTBUS2_CodPosDesde_Internalname = "TTBUS2_CODPOSDESDE_"+sGXsfl_13_idx ;
         edtavDttbus3_des_Internalname = "vDTTBUS3_DES_"+sGXsfl_13_idx ;
         edtTTBUS2_RespDesde_Internalname = "TTBUS2_RESPDESDE_"+sGXsfl_13_idx ;
         edtavDusu_des_Internalname = "vDUSU_DES_"+sGXsfl_13_idx ;
         edtTTBUS2_FechaEnvio_Internalname = "TTBUS2_FECHAENVIO_"+sGXsfl_13_idx ;
         edtTTBUS2_CodPosHacia_Internalname = "TTBUS2_CODPOSHACIA_"+sGXsfl_13_idx ;
         edtavHttbus3_des_Internalname = "vHTTBUS3_DES_"+sGXsfl_13_idx ;
         edtTTBUS2_RespHacia_Internalname = "TTBUS2_RESPHACIA_"+sGXsfl_13_idx ;
         edtavHusu_des_Internalname = "vHUSU_DES_"+sGXsfl_13_idx ;
         edtTTBUS2_FechaRecepcion_Internalname = "TTBUS2_FECHARECEPCION_"+sGXsfl_13_idx ;
         cmbTTBUS2_EstadoEnvio_Internalname = "TTBUS2_ESTADOENVIO_"+sGXsfl_13_idx ;
         edtTTBUS2_MotivoEnvio_Internalname = "TTBUS2_MOTIVOENVIO_"+sGXsfl_13_idx ;
         edtTTBUS2_Observaciones_Internalname = "TTBUS2_OBSERVACIONES_"+sGXsfl_13_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtTTBUS2_IdMovimiento_Internalname = "TTBUS2_IDMOVIMIENTO_"+sGXsfl_13_idx ;
            edtTTBUS2_IdBien_Internalname = "TTBUS2_IDBIEN_"+sGXsfl_13_idx ;
            edtTTBUS2_CodPosDesde_Internalname = "TTBUS2_CODPOSDESDE_"+sGXsfl_13_idx ;
            edtavDttbus3_des_Internalname = "vDTTBUS3_DES_"+sGXsfl_13_idx ;
            edtTTBUS2_RespDesde_Internalname = "TTBUS2_RESPDESDE_"+sGXsfl_13_idx ;
            edtavDusu_des_Internalname = "vDUSU_DES_"+sGXsfl_13_idx ;
            edtTTBUS2_FechaEnvio_Internalname = "TTBUS2_FECHAENVIO_"+sGXsfl_13_idx ;
            edtTTBUS2_CodPosHacia_Internalname = "TTBUS2_CODPOSHACIA_"+sGXsfl_13_idx ;
            edtavHttbus3_des_Internalname = "vHTTBUS3_DES_"+sGXsfl_13_idx ;
            edtTTBUS2_RespHacia_Internalname = "TTBUS2_RESPHACIA_"+sGXsfl_13_idx ;
            edtavHusu_des_Internalname = "vHUSU_DES_"+sGXsfl_13_idx ;
            edtTTBUS2_FechaRecepcion_Internalname = "TTBUS2_FECHARECEPCION_"+sGXsfl_13_idx ;
            cmbTTBUS2_EstadoEnvio_Internalname = "TTBUS2_ESTADOENVIO_"+sGXsfl_13_idx ;
            edtTTBUS2_MotivoEnvio_Internalname = "TTBUS2_MOTIVOENVIO_"+sGXsfl_13_idx ;
            edtTTBUS2_Observaciones_Internalname = "TTBUS2_OBSERVACIONES_"+sGXsfl_13_idx ;
            /* Using cursor H001R4 */
            pr_default.execute(2, new Object[] {AV7TTBUS_Id});
            nGXsfl_13_idx = 1 ;
            GRID1_nEOF = 0 ;
            while ( ( (pr_default.getStatus(2) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) ) )
            {
               A25TTBUS2_RespHacia = H001R4_A25TTBUS2_RespHacia[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25TTBUS2_RespHacia", A25TTBUS2_RespHacia);
               A24TTBUS2_RespDesde = H001R4_A24TTBUS2_RespDesde[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24TTBUS2_RespDesde", A24TTBUS2_RespDesde);
               A49TTBUS2_CodPosHacia = H001R4_A49TTBUS2_CodPosHacia[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A49TTBUS2_CodPosHacia", StringUtil.LTrim( StringUtil.Str( (decimal)(A49TTBUS2_CodPosHacia), 3, 0)));
               A48TTBUS2_CodPosDesde = H001R4_A48TTBUS2_CodPosDesde[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A48TTBUS2_CodPosDesde", StringUtil.LTrim( StringUtil.Str( (decimal)(A48TTBUS2_CodPosDesde), 3, 0)));
               A87TTBUS2_Observaciones = H001R4_A87TTBUS2_Observaciones[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A87TTBUS2_Observaciones", A87TTBUS2_Observaciones);
               n87TTBUS2_Observaciones = H001R4_n87TTBUS2_Observaciones[0] ;
               A47TTBUS2_MotivoEnvio = H001R4_A47TTBUS2_MotivoEnvio[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A47TTBUS2_MotivoEnvio", A47TTBUS2_MotivoEnvio);
               A26TTBUS2_EstadoEnvio = H001R4_A26TTBUS2_EstadoEnvio[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26TTBUS2_EstadoEnvio", StringUtil.Str( (decimal)(A26TTBUS2_EstadoEnvio), 1, 0));
               A46TTBUS2_FechaRecepcion = H001R4_A46TTBUS2_FechaRecepcion[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46TTBUS2_FechaRecepcion", context.localUtil.TToC( A46TTBUS2_FechaRecepcion, 8, 5, 0, 3, "/", ":", " "));
               n46TTBUS2_FechaRecepcion = H001R4_n46TTBUS2_FechaRecepcion[0] ;
               A45TTBUS2_FechaEnvio = H001R4_A45TTBUS2_FechaEnvio[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A45TTBUS2_FechaEnvio", context.localUtil.TToC( A45TTBUS2_FechaEnvio, 10, 5, 0, 3, "/", ":", " "));
               A22TTBUS2_IdBien = H001R4_A22TTBUS2_IdBien[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22TTBUS2_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A22TTBUS2_IdBien), 8, 0)));
               A52TTBUS2_IdMovimiento = H001R4_A52TTBUS2_IdMovimiento[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52TTBUS2_IdMovimiento", StringUtil.LTrim( StringUtil.Str( (decimal)(A52TTBUS2_IdMovimiento), 12, 0)));
               /* Execute user event: E121R2 */
               E121R2 ();
               pr_default.readNext(2);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(2) == 101) ? 1 : 0)) ;
            pr_default.close(2);
            wbEnd = 13 ;
            WB1R0( ) ;
         }
      }

      protected int subGrid1_Pagecount( )
      {
         GRID1_nRecordCount = subGrid1_Recordcount( ) ;
         if ( ((int)(GRID1_nRecordCount) % (subGrid1_Recordsperpage( ))) == 0 )
         {
            return (int)(NumberUtil.Int( (long)(GRID1_nRecordCount/ (decimal)(subGrid1_Recordsperpage( ))))) ;
         }
         return (int)(NumberUtil.Int( (long)(GRID1_nRecordCount/ (decimal)(subGrid1_Recordsperpage( ))))+1) ;
      }

      protected int subGrid1_Recordcount( )
      {
         /* Using cursor H001R5 */
         pr_default.execute(3, new Object[] {AV7TTBUS_Id});
         GRID1_nRecordCount = H001R5_AGRID1_nRecordCount[0] ;
         pr_default.close(3);
         return GRID1_nRecordCount ;
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
         return (int)(NumberUtil.Int( (long)(GRID1_nFirstRecordOnPage/ (decimal)(subGrid1_Recordsperpage( ))))+1) ;
      }

      protected short subgrid1_firstpage( )
      {
         GRID1_nFirstRecordOnPage = 0 ;
         return 0 ;
      }

      protected short subgrid1_nextpage( )
      {
         GRID1_nRecordCount = subGrid1_Recordcount( ) ;
         if ( ( GRID1_nRecordCount >= subGrid1_Recordsperpage( ) ) && ( GRID1_nEOF == 0 ) )
         {
            GRID1_nFirstRecordOnPage = (int)(GRID1_nFirstRecordOnPage+subGrid1_Recordsperpage( )) ;
         }
         else
         {
            return 2 ;
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
         GRID1_nRecordCount = subGrid1_Recordcount( ) ;
         if ( GRID1_nRecordCount > subGrid1_Recordsperpage( ) )
         {
            if ( ((int)(GRID1_nRecordCount) % (subGrid1_Recordsperpage( ))) == 0 )
            {
               GRID1_nFirstRecordOnPage = (int)(GRID1_nRecordCount-subGrid1_Recordsperpage( )) ;
            }
            else
            {
               GRID1_nFirstRecordOnPage = (int)(GRID1_nRecordCount-((int)(GRID1_nRecordCount) % (subGrid1_Recordsperpage( )))) ;
            }
         }
         else
         {
            GRID1_nFirstRecordOnPage = 0 ;
         }
         return 0 ;
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

      protected void STRUP1R0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E111R2 */
         E111R2 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ",", ".")) ;
            AV7TTBUS_Id = (int)(context.localUtil.CToN( cgiGet( "vTTBUS_ID"), ",", ".")) ;
            AV15TTBUS_Descripcion = cgiGet( "vTTBUS_DESCRIPCION") ;
            AV5SISTEMA = cgiGet( "vSISTEMA") ;
            AV6USUARIO = cgiGet( "vUSUARIO") ;
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

      protected void GXStart( )
      {
         /* Execute user event: E111R2 */
         E111R2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E111R2( )
      {
         /* Start Routine */
         lblTbxtitulo_Caption = "Movimientos de "+AV15TTBUS_Descripcion ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblTbxtitulo_Internalname, "Caption", lblTbxtitulo_Caption);
      }

      private void E121R2( )
      {
         /* Grid1_Load Routine */
         AV18cont = (int)(AV18cont+1) ;
         /* Using cursor H001R6 */
         pr_default.execute(4, new Object[] {A48TTBUS2_CodPosDesde});
         while ( (pr_default.getStatus(4) != 101) )
         {
            A33TTBUS7_Pos = H001R6_A33TTBUS7_Pos[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
            A34TTBUS7_Des = H001R6_A34TTBUS7_Des[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34TTBUS7_Des", A34TTBUS7_Des);
            n34TTBUS7_Des = H001R6_n34TTBUS7_Des[0] ;
            A34TTBUS7_Des = H001R6_A34TTBUS7_Des[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34TTBUS7_Des", A34TTBUS7_Des);
            n34TTBUS7_Des = H001R6_n34TTBUS7_Des[0] ;
            AV17dTTBUS3_Des = A34TTBUS7_Des ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17dTTBUS3_Des", AV17dTTBUS3_Des);
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(4);
         /* Using cursor H001R7 */
         pr_default.execute(5, new Object[] {A49TTBUS2_CodPosHacia});
         while ( (pr_default.getStatus(5) != 101) )
         {
            A33TTBUS7_Pos = H001R7_A33TTBUS7_Pos[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
            A34TTBUS7_Des = H001R7_A34TTBUS7_Des[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34TTBUS7_Des", A34TTBUS7_Des);
            n34TTBUS7_Des = H001R7_n34TTBUS7_Des[0] ;
            A34TTBUS7_Des = H001R7_A34TTBUS7_Des[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34TTBUS7_Des", A34TTBUS7_Des);
            n34TTBUS7_Des = H001R7_n34TTBUS7_Des[0] ;
            AV16hTTBUS3_Des = A34TTBUS7_Des ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16hTTBUS3_Des", AV16hTTBUS3_Des);
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(5);
         /* Using cursor H001R8 */
         pr_default.execute(6, new Object[] {A24TTBUS2_RespDesde});
         while ( (pr_default.getStatus(6) != 101) )
         {
            A6USU_COD = H001R8_A6USU_COD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
            A7USU_DES = H001R8_A7USU_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7USU_DES", A7USU_DES);
            if ( (Convert.ToDecimal( AV18cont ) == NumberUtil.Val( AV19SESION.Get("CONT_MOV"), ".") ) )
            {
               AV13dUSU_DES = "Responsable de carga: " + StringUtil.Trim( A7USU_DES) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13dUSU_DES", AV13dUSU_DES);
            }
            else
            {
               AV13dUSU_DES = A7USU_DES ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13dUSU_DES", AV13dUSU_DES);
            }
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(6);
         /* Using cursor H001R9 */
         pr_default.execute(7, new Object[] {A25TTBUS2_RespHacia});
         while ( (pr_default.getStatus(7) != 101) )
         {
            A6USU_COD = H001R9_A6USU_COD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
            A7USU_DES = H001R9_A7USU_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7USU_DES", A7USU_DES);
            AV14hUSU_DES = A7USU_DES ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14hUSU_DES", AV14hUSU_DES);
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(7);
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 13 ;
         }
         if ( ( subGrid1_Islastpage == 1 ) || ( 10 == 0 ) || ( ( GRID1_nCurrentRecord >= GRID1_nFirstRecordOnPage ) && ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) )
         {
            sendrow_132( ) ;
         }
         GRID1_nCurrentRecord = (int)(GRID1_nCurrentRecord+1) ;
      }

      protected void wb_table1_2_1R2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            sStyleString = sStyleString + " height: " + StringUtil.LTrim( StringUtil.Str( (decimal)(104), 10, 0)) + "px" + ";" ;
            sStyleString = sStyleString + " width: " + StringUtil.LTrim( StringUtil.Str( (decimal)(478), 10, 0)) + "px" + ";" ;
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
            /* Text block */
            ClassString = "SubTitle" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTbxtitulo_Internalname, 1, 1, 0, lblTbxtitulo_Caption, "", "", "", 0, lblTbxtitulo_Jsonclick, "", StyleString, ClassString, "HLP_HTBUS002.htm");
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
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Id Movimiento") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Id Bien") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Código Posición Desde") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Posición Desde") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Responsable de envío") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" width="+StringUtil.LTrim( StringUtil.Str( (decimal)(150), 4, 0))+"px"+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Responsable Envío") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Fecha Envío") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Código Posición Hacia") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Posición Recepción") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Responsable de recepción") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" width="+StringUtil.LTrim( StringUtil.Str( (decimal)(150), 4, 0))+"px"+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Responsable Recepción") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Fecha Recepción") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Estado de Envío") ;
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
               Grid1Container.Clear();
               Grid1Container.SetWrapped(nGXWrapped);
               Grid1Container.AddObjectProperty("GridName", "Grid1");
               Grid1Container.AddObjectProperty("Class", "Grid");
               Grid1Container.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Backcolorstyle), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("CmpContext", "");
               Grid1Container.AddObjectProperty("InMasterPage", "false");
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A52TTBUS2_IdMovimiento), 12, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A22TTBUS2_IdBien), 8, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A48TTBUS2_CodPosDesde), 3, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( AV17dTTBUS3_Des));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A24TTBUS2_RespDesde));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( AV13dUSU_DES));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", context.localUtil.Format(A45TTBUS2_FechaEnvio, "99/99/9999 99:99"));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A49TTBUS2_CodPosHacia), 3, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( AV16hTTBUS3_Des));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A25TTBUS2_RespHacia));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( AV14hUSU_DES));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", context.localUtil.Format(A46TTBUS2_FechaRecepcion, "99/99/99 99:99"));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A26TTBUS2_EstadoEnvio), 1, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A47TTBUS2_MotivoEnvio));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A87TTBUS2_Observaciones));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Allowselection", "false");
               Grid1Container.AddObjectProperty("Allowcollapsing", "false");
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 9, 0, ".", "")));
            }
         }
         if ( wbEnd == 13 )
         {
            wbEnd = 0 ;
            nRC_Grid1 = (short)(nGXsfl_13_idx-1) ;
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
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_1R2e( true) ;
         }
         else
         {
            wb_table1_2_1R2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV7TTBUS_Id = Convert.ToInt32(getParm(obj,0)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7TTBUS_Id), 8, 0)));
         AV15TTBUS_Descripcion = (String)getParm(obj,1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15TTBUS_Descripcion", AV15TTBUS_Descripcion);
         AV5SISTEMA = (String)getParm(obj,2) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5SISTEMA", AV5SISTEMA);
         AV6USUARIO = (String)getParm(obj,3) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6USUARIO", AV6USUARIO);
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
         PA1R2( ) ;
         WS1R2( ) ;
         WE1R2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?19291777");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         if ( nGXWrapped != 1 )
         {
            context.AddJavascriptSource("messages.spa.js", "?42940");
            context.AddJavascriptSource("htbus002.js", "?19291778");
         }
         /* End function include_jscripts */
      }

      protected void sendrow_132( )
      {
         WB1R0( ) ;
         if ( ( 10 * 1 == 0 ) || ( nGXsfl_13_idx <= subGrid1_Recordsperpage( ) * 1 ) )
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
               if ( ((int)(nGXsfl_13_idx) % (2)) == 0 )
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
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS2_IdMovimiento_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A52TTBUS2_IdMovimiento), 12, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)12,(short)0,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A52TTBUS2_IdMovimiento), "ZZZZZZZZZZZ9"),(String)"",(short)0,(String)edtTTBUS2_IdMovimiento_Jsonclick,(String)"",(short)13,(short)1,(short)1,(bool)false,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS2_IdBien_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A22TTBUS2_IdBien), 8, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)8,(short)0,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A22TTBUS2_IdBien), "ZZZZZZZ9"),(String)"",(short)0,(String)edtTTBUS2_IdBien_Jsonclick,(String)"",(short)13,(short)1,(short)1,(bool)false,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS2_CodPosDesde_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A48TTBUS2_CodPosDesde), 3, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)3,(short)0,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A48TTBUS2_CodPosDesde), "ZZ9"),(String)"",(short)0,(String)edtTTBUS2_CodPosDesde_Jsonclick,(String)"",(short)13,(short)1,(short)1,(bool)false,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavDttbus3_des_Internalname,StringUtil.RTrim( AV17dTTBUS3_Des),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)50,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( AV17dTTBUS3_Des, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")),(String)"",(short)0,(String)edtavDttbus3_des_Jsonclick,(String)"",(short)13,(short)1,(short)-1,(bool)false,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS2_RespDesde_Internalname,StringUtil.RTrim( A24TTBUS2_RespDesde),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)15,(short)0,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A24TTBUS2_RespDesde, "XXXXXXXXXXXXXXX")),(String)"",(short)0,(String)edtTTBUS2_RespDesde_Jsonclick,(String)"",(short)13,(short)1,(short)1,(bool)false,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavDusu_des_Internalname,StringUtil.RTrim( AV13dUSU_DES),(String)"",(short)150,(String)"px",(short)17,(String)"",(short)50,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( AV13dUSU_DES, "@!")),(String)"",(short)0,(String)edtavDusu_des_Jsonclick,(String)"",(short)13,(short)1,(short)-1,(bool)false,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS2_FechaEnvio_Internalname,context.localUtil.Format(A45TTBUS2_FechaEnvio, "99/99/9999 99:99"),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)16,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( A45TTBUS2_FechaEnvio, "99/99/9999 99:99"),(String)"",(short)0,(String)edtTTBUS2_FechaEnvio_Jsonclick,(String)"",(short)13,(short)1,(short)1,(bool)false,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS2_CodPosHacia_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A49TTBUS2_CodPosHacia), 3, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)3,(short)0,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A49TTBUS2_CodPosHacia), "ZZ9"),(String)"",(short)0,(String)edtTTBUS2_CodPosHacia_Jsonclick,(String)"",(short)13,(short)1,(short)1,(bool)false,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavHttbus3_des_Internalname,StringUtil.RTrim( AV16hTTBUS3_Des),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)50,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( AV16hTTBUS3_Des, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")),(String)"",(short)0,(String)edtavHttbus3_des_Jsonclick,(String)"",(short)13,(short)1,(short)-1,(bool)false,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS2_RespHacia_Internalname,StringUtil.RTrim( A25TTBUS2_RespHacia),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)15,(short)0,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A25TTBUS2_RespHacia, "XXXXXXXXXXXXXXX")),(String)"",(short)0,(String)edtTTBUS2_RespHacia_Jsonclick,(String)"",(short)13,(short)1,(short)1,(bool)false,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavHusu_des_Internalname,StringUtil.RTrim( AV14hUSU_DES),(String)"",(short)150,(String)"px",(short)17,(String)"",(short)50,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( AV14hUSU_DES, "@!")),(String)"",(short)0,(String)edtavHusu_des_Jsonclick,(String)"",(short)13,(short)1,(short)-1,(bool)false,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS2_FechaRecepcion_Internalname,context.localUtil.Format(A46TTBUS2_FechaRecepcion, "99/99/99 99:99"),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)14,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( A46TTBUS2_FechaRecepcion, "99/99/99 99:99"),(String)"",(short)0,(String)edtTTBUS2_FechaRecepcion_Jsonclick,(String)"",(short)13,(short)1,(short)1,(bool)false,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            ClassString = "Attribute" ;
            StyleString = "" ;
            if ( ( nGXsfl_13_idx == 1 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "TTBUS2_ESTADOENVIO_" + sGXsfl_13_idx ;
               cmbTTBUS2_EstadoEnvio.Name = GXCCtl ;
               cmbTTBUS2_EstadoEnvio.WebTags = "" ;
               cmbTTBUS2_EstadoEnvio.addItem("1", "No Finalizado", 0);
               cmbTTBUS2_EstadoEnvio.addItem("2", "Finalizado", 0);
               cmbTTBUS2_EstadoEnvio.addItem("3", "Cancelado", 0);
               if ( ( cmbTTBUS2_EstadoEnvio.ItemCount > 0 ) && (0==A26TTBUS2_EstadoEnvio) )
               {
                  A26TTBUS2_EstadoEnvio = (short)(NumberUtil.Val( cmbTTBUS2_EstadoEnvio.getItemValue(1), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26TTBUS2_EstadoEnvio", StringUtil.Str( (decimal)(A26TTBUS2_EstadoEnvio), 1, 0));
               }
            }
            /* ComboBox */
            Grid1Row.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbTTBUS2_EstadoEnvio,(String)cmbTTBUS2_EstadoEnvio_Internalname,StringUtil.Str( (decimal)(A26TTBUS2_EstadoEnvio), 1, 0),(String)"",(String)"int",(short)-1,(short)0,(short)0,(short)1,(short)0,(short)0,(String)"px",(short)0,(String)"",(String)StyleString,(String)ClassString,(String)"",(short)0,(String)cmbTTBUS2_EstadoEnvio_Jsonclick,(String)"",(String)"",(bool)false});
            cmbTTBUS2_EstadoEnvio.CurrentValue = StringUtil.Str( (decimal)(A26TTBUS2_EstadoEnvio), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbTTBUS2_EstadoEnvio_Internalname, "Values", (String)(cmbTTBUS2_EstadoEnvio.ToJavascriptSource()));
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS2_MotivoEnvio_Internalname,StringUtil.RTrim( A47TTBUS2_MotivoEnvio),(String)"",(short)200,(String)"px",(short)17,(String)"",(short)100,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A47TTBUS2_MotivoEnvio, "@!")),(String)"",(short)0,(String)edtTTBUS2_MotivoEnvio_Jsonclick,(String)"",(short)13,(short)1,(short)0,(bool)false,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS2_Observaciones_Internalname,StringUtil.RTrim( A87TTBUS2_Observaciones),(String)"",(short)300,(String)"px",(short)17,(String)"",(short)400,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A87TTBUS2_Observaciones, "@!")),(String)"",(short)0,(String)edtTTBUS2_Observaciones_Jsonclick,(String)"",(short)13,(short)1,(short)0,(bool)false,(String)"left"});
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_13_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_13_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_13_idx+1)) ;
            sGXsfl_13_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_13_idx), 4, 0)), 4, "0") ;
            edtTTBUS2_IdMovimiento_Internalname = "TTBUS2_IDMOVIMIENTO_"+sGXsfl_13_idx ;
            edtTTBUS2_IdBien_Internalname = "TTBUS2_IDBIEN_"+sGXsfl_13_idx ;
            edtTTBUS2_CodPosDesde_Internalname = "TTBUS2_CODPOSDESDE_"+sGXsfl_13_idx ;
            edtavDttbus3_des_Internalname = "vDTTBUS3_DES_"+sGXsfl_13_idx ;
            edtTTBUS2_RespDesde_Internalname = "TTBUS2_RESPDESDE_"+sGXsfl_13_idx ;
            edtavDusu_des_Internalname = "vDUSU_DES_"+sGXsfl_13_idx ;
            edtTTBUS2_FechaEnvio_Internalname = "TTBUS2_FECHAENVIO_"+sGXsfl_13_idx ;
            edtTTBUS2_CodPosHacia_Internalname = "TTBUS2_CODPOSHACIA_"+sGXsfl_13_idx ;
            edtavHttbus3_des_Internalname = "vHTTBUS3_DES_"+sGXsfl_13_idx ;
            edtTTBUS2_RespHacia_Internalname = "TTBUS2_RESPHACIA_"+sGXsfl_13_idx ;
            edtavHusu_des_Internalname = "vHUSU_DES_"+sGXsfl_13_idx ;
            edtTTBUS2_FechaRecepcion_Internalname = "TTBUS2_FECHARECEPCION_"+sGXsfl_13_idx ;
            cmbTTBUS2_EstadoEnvio_Internalname = "TTBUS2_ESTADOENVIO_"+sGXsfl_13_idx ;
            edtTTBUS2_MotivoEnvio_Internalname = "TTBUS2_MOTIVOENVIO_"+sGXsfl_13_idx ;
            edtTTBUS2_Observaciones_Internalname = "TTBUS2_OBSERVACIONES_"+sGXsfl_13_idx ;
         }
         /* End function sendrow_132 */
      }

      protected void init_default_properties( )
      {
         lblTbxtitulo_Internalname = "TBXTITULO" ;
         tblTable1_Internalname = "TABLE1" ;
         Form.Internalname = "FORM" ;
         subGrid1_Internalname = "GRID1" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         edtTTBUS2_Observaciones_Jsonclick = "" ;
         edtTTBUS2_MotivoEnvio_Jsonclick = "" ;
         cmbTTBUS2_EstadoEnvio_Jsonclick = "" ;
         edtTTBUS2_FechaRecepcion_Jsonclick = "" ;
         edtavHusu_des_Jsonclick = "" ;
         edtTTBUS2_RespHacia_Jsonclick = "" ;
         edtavHttbus3_des_Jsonclick = "" ;
         edtTTBUS2_CodPosHacia_Jsonclick = "" ;
         edtTTBUS2_FechaEnvio_Jsonclick = "" ;
         edtavDusu_des_Jsonclick = "" ;
         edtTTBUS2_RespDesde_Jsonclick = "" ;
         edtavDttbus3_des_Jsonclick = "" ;
         edtTTBUS2_CodPosDesde_Jsonclick = "" ;
         edtTTBUS2_IdBien_Jsonclick = "" ;
         edtTTBUS2_IdMovimiento_Jsonclick = "" ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 3 ;
         lblTbxtitulo_Caption = "" ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Historial de Movimietos de Bienes de Uso" ;
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
         wcpOAV15TTBUS_Descripcion = "" ;
         wcpOAV5SISTEMA = "" ;
         wcpOAV6USUARIO = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         A47TTBUS2_MotivoEnvio = "" ;
         A87TTBUS2_Observaciones = "" ;
         GXCCtl = "" ;
         A7USU_DES = "" ;
         A6USU_COD = "" ;
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
         edtTTBUS2_IdMovimiento_Internalname = "" ;
         edtTTBUS2_IdBien_Internalname = "" ;
         edtTTBUS2_CodPosDesde_Internalname = "" ;
         edtavDttbus3_des_Internalname = "" ;
         edtTTBUS2_RespDesde_Internalname = "" ;
         edtavDusu_des_Internalname = "" ;
         edtTTBUS2_FechaEnvio_Internalname = "" ;
         edtTTBUS2_CodPosHacia_Internalname = "" ;
         edtavHttbus3_des_Internalname = "" ;
         edtTTBUS2_RespHacia_Internalname = "" ;
         edtavHusu_des_Internalname = "" ;
         edtTTBUS2_FechaRecepcion_Internalname = "" ;
         cmbTTBUS2_EstadoEnvio_Internalname = "" ;
         edtTTBUS2_MotivoEnvio_Internalname = "" ;
         edtTTBUS2_Observaciones_Internalname = "" ;
         AV17dTTBUS3_Des = "" ;
         A24TTBUS2_RespDesde = "" ;
         AV13dUSU_DES = "" ;
         A45TTBUS2_FechaEnvio = (DateTime)(DateTime.MinValue) ;
         AV16hTTBUS3_Des = "" ;
         A25TTBUS2_RespHacia = "" ;
         AV14hUSU_DES = "" ;
         A46TTBUS2_FechaRecepcion = (DateTime)(DateTime.MinValue) ;
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxwrpcisep = "" ;
         scmdbuf = "" ;
         l47TTBUS2_MotivoEnvio = "" ;
         H001R2_A47TTBUS2_MotivoEnvio = new String[] {""} ;
         l87TTBUS2_Observaciones = "" ;
         H001R3_A87TTBUS2_Observaciones = new String[] {""} ;
         H001R3_n87TTBUS2_Observaciones = new bool[] {false} ;
         Grid1Container = new GXWebGrid( context);
         H001R4_A25TTBUS2_RespHacia = new String[] {""} ;
         H001R4_A24TTBUS2_RespDesde = new String[] {""} ;
         H001R4_A49TTBUS2_CodPosHacia = new short[1] ;
         H001R4_A48TTBUS2_CodPosDesde = new short[1] ;
         H001R4_A87TTBUS2_Observaciones = new String[] {""} ;
         H001R4_n87TTBUS2_Observaciones = new bool[] {false} ;
         H001R4_A47TTBUS2_MotivoEnvio = new String[] {""} ;
         H001R4_A26TTBUS2_EstadoEnvio = new short[1] ;
         H001R4_A46TTBUS2_FechaRecepcion = new DateTime[] {DateTime.MinValue} ;
         H001R4_n46TTBUS2_FechaRecepcion = new bool[] {false} ;
         H001R4_A45TTBUS2_FechaEnvio = new DateTime[] {DateTime.MinValue} ;
         H001R4_A22TTBUS2_IdBien = new int[1] ;
         H001R4_A52TTBUS2_IdMovimiento = new long[1] ;
         H001R5_AGRID1_nRecordCount = new int[1] ;
         H001R6_A33TTBUS7_Pos = new short[1] ;
         H001R6_A34TTBUS7_Des = new String[] {""} ;
         H001R6_n34TTBUS7_Des = new bool[] {false} ;
         H001R7_A33TTBUS7_Pos = new short[1] ;
         H001R7_A34TTBUS7_Des = new String[] {""} ;
         H001R7_n34TTBUS7_Des = new bool[] {false} ;
         H001R8_A6USU_COD = new String[] {""} ;
         H001R8_A7USU_DES = new String[] {""} ;
         AV19SESION = new GxWebSession( context);
         H001R9_A6USU_COD = new String[] {""} ;
         H001R9_A7USU_DES = new String[] {""} ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         lblTbxtitulo_Jsonclick = "" ;
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
         GXt_char15 = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         ROClassString = "" ;
         GXt_char16 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.htbus002__default(),
            new Object[][] {
                new Object[] {
               H001R2_A47TTBUS2_MotivoEnvio
               }
               , new Object[] {
               H001R3_A87TTBUS2_Observaciones, H001R3_n87TTBUS2_Observaciones
               }
               , new Object[] {
               H001R4_A25TTBUS2_RespHacia, H001R4_A24TTBUS2_RespDesde, H001R4_A49TTBUS2_CodPosHacia, H001R4_A48TTBUS2_CodPosDesde, H001R4_A87TTBUS2_Observaciones, H001R4_n87TTBUS2_Observaciones, H001R4_A47TTBUS2_MotivoEnvio, H001R4_A26TTBUS2_EstadoEnvio, H001R4_A46TTBUS2_FechaRecepcion, H001R4_n46TTBUS2_FechaRecepcion,
               H001R4_A45TTBUS2_FechaEnvio, H001R4_A22TTBUS2_IdBien, H001R4_A52TTBUS2_IdMovimiento
               }
               , new Object[] {
               H001R5_AGRID1_nRecordCount
               }
               , new Object[] {
               H001R6_A33TTBUS7_Pos, H001R6_A34TTBUS7_Des, H001R6_n34TTBUS7_Des
               }
               , new Object[] {
               H001R7_A33TTBUS7_Pos, H001R7_A34TTBUS7_Des, H001R7_n34TTBUS7_Des
               }
               , new Object[] {
               H001R8_A6USU_COD, H001R8_A7USU_DES
               }
               , new Object[] {
               H001R9_A6USU_COD, H001R9_A7USU_DES
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_Grid1 ;
      private short nGXsfl_13_idx=1 ;
      private short A26TTBUS2_EstadoEnvio ;
      private short A33TTBUS7_Pos ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short nGXWrapped ;
      private short GRID1_nEOF ;
      private short wbEnd ;
      private short wbStart ;
      private short A48TTBUS2_CodPosDesde ;
      private short A49TTBUS2_CodPosHacia ;
      private short nDonePA ;
      private short subGrid1_Rows ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short subGrid1_Collapsed ;
      private short subGrid1_Backstyle ;
      private int AV7TTBUS_Id ;
      private int wcpOAV7TTBUS_Id ;
      private int Grid1_PageSize13 ;
      private int AV18cont ;
      private int GRID1_nFirstRecordOnPage ;
      private int A22TTBUS2_IdBien ;
      private int gxdynajaxindex ;
      private int subGrid1_Islastpage ;
      private int GRID1_nCurrentRecord ;
      private int GRID1_nRecordCount ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private long A52TTBUS2_IdMovimiento ;
      private String AV5SISTEMA ;
      private String AV6USUARIO ;
      private String wcpOAV5SISTEMA ;
      private String wcpOAV6USUARIO ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_13_idx="0001" ;
      private String GXCCtl ;
      private String A7USU_DES ;
      private String A6USU_COD ;
      private String A34TTBUS7_Des ;
      private String sDynURL ;
      private String FormProcess ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtTTBUS2_IdMovimiento_Internalname ;
      private String edtTTBUS2_IdBien_Internalname ;
      private String edtTTBUS2_CodPosDesde_Internalname ;
      private String edtavDttbus3_des_Internalname ;
      private String edtTTBUS2_RespDesde_Internalname ;
      private String edtavDusu_des_Internalname ;
      private String edtTTBUS2_FechaEnvio_Internalname ;
      private String edtTTBUS2_CodPosHacia_Internalname ;
      private String edtavHttbus3_des_Internalname ;
      private String edtTTBUS2_RespHacia_Internalname ;
      private String edtavHusu_des_Internalname ;
      private String edtTTBUS2_FechaRecepcion_Internalname ;
      private String cmbTTBUS2_EstadoEnvio_Internalname ;
      private String edtTTBUS2_MotivoEnvio_Internalname ;
      private String edtTTBUS2_Observaciones_Internalname ;
      private String AV17dTTBUS3_Des ;
      private String A24TTBUS2_RespDesde ;
      private String AV13dUSU_DES ;
      private String AV16hTTBUS3_Des ;
      private String A25TTBUS2_RespHacia ;
      private String AV14hUSU_DES ;
      private String gxwrpcisep ;
      private String scmdbuf ;
      private String lblTbxtitulo_Caption ;
      private String lblTbxtitulo_Internalname ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String lblTbxtitulo_Jsonclick ;
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
      private String GXt_char15 ;
      private String ROClassString ;
      private String edtTTBUS2_IdMovimiento_Jsonclick ;
      private String edtTTBUS2_IdBien_Jsonclick ;
      private String edtTTBUS2_CodPosDesde_Jsonclick ;
      private String edtavDttbus3_des_Jsonclick ;
      private String edtTTBUS2_RespDesde_Jsonclick ;
      private String edtavDusu_des_Jsonclick ;
      private String edtTTBUS2_FechaEnvio_Jsonclick ;
      private String edtTTBUS2_CodPosHacia_Jsonclick ;
      private String edtavHttbus3_des_Jsonclick ;
      private String edtTTBUS2_RespHacia_Jsonclick ;
      private String edtavHusu_des_Jsonclick ;
      private String edtTTBUS2_FechaRecepcion_Jsonclick ;
      private String cmbTTBUS2_EstadoEnvio_Jsonclick ;
      private String edtTTBUS2_MotivoEnvio_Jsonclick ;
      private String edtTTBUS2_Observaciones_Jsonclick ;
      private String GXt_char16 ;
      private DateTime A45TTBUS2_FechaEnvio ;
      private DateTime A46TTBUS2_FechaRecepcion ;
      private bool entryPointCalled ;
      private bool n87TTBUS2_Observaciones ;
      private bool n34TTBUS7_Des ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n46TTBUS2_FechaRecepcion ;
      private bool returnInSub ;
      private String AV15TTBUS_Descripcion ;
      private String wcpOAV15TTBUS_Descripcion ;
      private String A47TTBUS2_MotivoEnvio ;
      private String A87TTBUS2_Observaciones ;
      private String l47TTBUS2_MotivoEnvio ;
      private String l87TTBUS2_Observaciones ;
      private GxWebSession AV19SESION ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private int aP0_TTBUS_Id ;
      private String aP1_TTBUS_Descripcion ;
      private String aP2_SISTEMA ;
      private String aP3_USUARIO ;
      private GXCombobox cmbTTBUS2_EstadoEnvio ;
      private IDataStoreProvider pr_default ;
      private String[] H001R2_A47TTBUS2_MotivoEnvio ;
      private String[] H001R3_A87TTBUS2_Observaciones ;
      private bool[] H001R3_n87TTBUS2_Observaciones ;
      private String[] H001R4_A25TTBUS2_RespHacia ;
      private String[] H001R4_A24TTBUS2_RespDesde ;
      private short[] H001R4_A49TTBUS2_CodPosHacia ;
      private short[] H001R4_A48TTBUS2_CodPosDesde ;
      private String[] H001R4_A87TTBUS2_Observaciones ;
      private bool[] H001R4_n87TTBUS2_Observaciones ;
      private String[] H001R4_A47TTBUS2_MotivoEnvio ;
      private short[] H001R4_A26TTBUS2_EstadoEnvio ;
      private DateTime[] H001R4_A46TTBUS2_FechaRecepcion ;
      private bool[] H001R4_n46TTBUS2_FechaRecepcion ;
      private DateTime[] H001R4_A45TTBUS2_FechaEnvio ;
      private int[] H001R4_A22TTBUS2_IdBien ;
      private long[] H001R4_A52TTBUS2_IdMovimiento ;
      private int[] H001R5_AGRID1_nRecordCount ;
      private short[] H001R6_A33TTBUS7_Pos ;
      private String[] H001R6_A34TTBUS7_Des ;
      private bool[] H001R6_n34TTBUS7_Des ;
      private short[] H001R7_A33TTBUS7_Pos ;
      private String[] H001R7_A34TTBUS7_Des ;
      private bool[] H001R7_n34TTBUS7_Des ;
      private String[] H001R8_A6USU_COD ;
      private String[] H001R8_A7USU_DES ;
      private String[] H001R9_A6USU_COD ;
      private String[] H001R9_A7USU_DES ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXWebForm Form ;
   }

   public class htbus002__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH001R2 ;
          prmH001R2 = new Object[] {
          new Object[] {"@TTBUS2_MotivoEnvio",SqlDbType.VarChar,100,0}
          } ;
          Object[] prmH001R3 ;
          prmH001R3 = new Object[] {
          new Object[] {"@TTBUS2_Observaciones",SqlDbType.VarChar,400,0}
          } ;
          Object[] prmH001R4 ;
          prmH001R4 = new Object[] {
          new Object[] {"@AV7TTBUS_Id",SqlDbType.Int,8,0}
          } ;
          Object[] prmH001R5 ;
          prmH001R5 = new Object[] {
          new Object[] {"@AV7TTBUS_Id",SqlDbType.Int,8,0}
          } ;
          Object[] prmH001R6 ;
          prmH001R6 = new Object[] {
          new Object[] {"@TTBUS2_CodPosDesde",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmH001R7 ;
          prmH001R7 = new Object[] {
          new Object[] {"@TTBUS2_CodPosHacia",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmH001R8 ;
          prmH001R8 = new Object[] {
          new Object[] {"@TTBUS2_RespDesde",SqlDbType.Char,15,0}
          } ;
          Object[] prmH001R9 ;
          prmH001R9 = new Object[] {
          new Object[] {"@TTBUS2_RespHacia",SqlDbType.Char,15,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H001R2", "SELECT DISTINCT TOP 5 [TTBUS2_MotivoEnvio] FROM [TTBUS002] WITH (NOLOCK) WHERE UPPER(CAST([TTBUS2_MotivoEnvio] AS char(100))) like UPPER(CAST(@TTBUS2_MotivoEnvio AS char(100))) ORDER BY [TTBUS2_MotivoEnvio] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001R2,0,0,true,false )
             ,new CursorDef("H001R3", "SELECT DISTINCT TOP 5 [TTBUS2_Observaciones] FROM [TTBUS002] WITH (NOLOCK) WHERE UPPER(CAST([TTBUS2_Observaciones] AS char(400))) like UPPER(CAST(@TTBUS2_Observaciones AS char(400))) ORDER BY [TTBUS2_Observaciones] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001R3,0,0,true,false )
             ,new CursorDef("H001R4", "SELECT [TTBUS2_RespHacia], [TTBUS2_RespDesde], [TTBUS2_CodPosHacia], [TTBUS2_CodPosDesde], [TTBUS2_Observaciones], [TTBUS2_MotivoEnvio], [TTBUS2_EstadoEnvio], [TTBUS2_FechaRecepcion], [TTBUS2_FechaEnvio], [TTBUS2_IdBien], [TTBUS2_IdMovimiento] FROM [TTBUS002] WITH (NOLOCK) WHERE [TTBUS2_IdBien] = @AV7TTBUS_Id ORDER BY [TTBUS2_FechaEnvio]  OPTION (FAST 11)",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001R4,11,0,true,false )
             ,new CursorDef("H001R5", "SELECT COUNT(*) FROM [TTBUS002] WITH (NOLOCK) WHERE [TTBUS2_IdBien] = @AV7TTBUS_Id ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001R5,1,0,true,false )
             ,new CursorDef("H001R6", "SELECT T1.[TTBUS7_Pos] AS TTBUS7_Pos, T2.[W53DES] AS TTBUS7_Des FROM ([TTBUS007] T1 WITH (NOLOCK) INNER JOIN [T53FPOS] T2 WITH (NOLOCK) ON T2.[W53POS] = T1.[TTBUS7_Pos]) WHERE T1.[TTBUS7_Pos] = @TTBUS2_CodPosDesde ORDER BY T1.[TTBUS7_Pos] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001R6,1,0,false,true )
             ,new CursorDef("H001R7", "SELECT T1.[TTBUS7_Pos] AS TTBUS7_Pos, T2.[W53DES] AS TTBUS7_Des FROM ([TTBUS007] T1 WITH (NOLOCK) INNER JOIN [T53FPOS] T2 WITH (NOLOCK) ON T2.[W53POS] = T1.[TTBUS7_Pos]) WHERE T1.[TTBUS7_Pos] = @TTBUS2_CodPosHacia ORDER BY T1.[TTBUS7_Pos] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001R7,1,0,false,true )
             ,new CursorDef("H001R8", "SELECT [USU_COD], [USU_DES] FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @TTBUS2_RespDesde ORDER BY [USU_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001R8,1,0,false,true )
             ,new CursorDef("H001R9", "SELECT [USU_COD], [USU_DES] FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @TTBUS2_RespHacia ORDER BY [USU_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001R9,1,0,false,true )
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
                ((String[]) buf[1])[0] = rslt.getString(2, 15) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(5);
                ((String[]) buf[6])[0] = rslt.getVarchar(6) ;
                ((short[]) buf[7])[0] = rslt.getShort(7) ;
                ((DateTime[]) buf[8])[0] = rslt.getGXDateTime(8) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(8);
                ((DateTime[]) buf[10])[0] = rslt.getGXDateTime(9) ;
                ((int[]) buf[11])[0] = rslt.getInt(10) ;
                ((long[]) buf[12])[0] = rslt.getLong(11) ;
                break;
             case 3 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
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
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
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
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 3 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 4 :
                stmt.SetParameter(1, (short)parms[0]);
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
       }
    }

 }

}
