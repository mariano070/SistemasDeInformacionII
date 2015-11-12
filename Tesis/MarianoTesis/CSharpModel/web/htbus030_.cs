/*
               File: HTBUS030_
        Description: Consulta de Trazabilidad de Bienes de Uso
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:18:58.15
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
   public class htbus030_ : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public htbus030_( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public htbus030_( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( out int aP0_pTTBUS_Id )
      {
         this.AV14pTTBUS_Id = 0 ;
         executePrivate();
         aP0_pTTBUS_Id=this.AV14pTTBUS_Id;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbavTtbus7_pos = new GXCombobox();
         chkTTBUS_Alquilado = new GXCheckbox();
         cmbTTBUS_Estado = new GXCombobox();
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxSuggest"+"_"+"vFTTBUS_DESCRIPCION") == 0 )
            {
               A12TTBUS_Descripcion = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               GXSGVvFTTBUS_DESCRIPCION1Y0( A12TTBUS_Descripcion) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxSuggest"+"_"+"TTBUS_DESCRIPCION") == 0 )
            {
               A12TTBUS_Descripcion = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               GXSGATTBUS_DESCRIPCION1Y0( A12TTBUS_Descripcion) ;
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
               nGXsfl_49_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               sGXsfl_49_idx = GetNextPar( ) ;
               edtavSec_dre_Enabled = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSec_dre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavSec_dre_Enabled), 5, 0)));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxnrGrid1_newrow( nRC_Grid1, nGXsfl_49_idx, sGXsfl_49_idx) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid1") == 0 )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0 ;
               edtavSec_cre_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSec_cre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavSec_cre_Enabled), 5, 0)));
               cmbavTtbus7_pos.Name = "vTTBUS7_POS" ;
               cmbavTtbus7_pos.WebTags = "" ;
               if ( ( cmbavTtbus7_pos.ItemCount > 0 ) && (0==AV29TTBUS7_Pos) )
               {
                  AV29TTBUS7_Pos = (short)(NumberUtil.Val( cmbavTtbus7_pos.getItemValue(1), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(AV29TTBUS7_Pos), 3, 0)));
               }
               GXCCtl = "TTBUS_ALQUILADO_" + sGXsfl_49_idx ;
               chkTTBUS_Alquilado.Name = GXCCtl ;
               chkTTBUS_Alquilado.WebTags = "" ;
               chkTTBUS_Alquilado.Caption = "" ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkTTBUS_Alquilado_Internalname, "Caption", chkTTBUS_Alquilado.Caption);
               chkTTBUS_Alquilado.CheckedValue = "0" ;
               GXCCtl = "TTBUS_ESTADO_" + sGXsfl_49_idx ;
               cmbTTBUS_Estado.Name = GXCCtl ;
               cmbTTBUS_Estado.WebTags = "" ;
               cmbTTBUS_Estado.addItem("1", "ASIGNADO A UN SECTOR", 0);
               cmbTTBUS_Estado.addItem("2", "CAMBIANDO DE SECTOR", 0);
               cmbTTBUS_Estado.addItem("3", "BAJA A CONFIRMAR", 0);
               cmbTTBUS_Estado.addItem("4", "BAJA", 0);
               if ( ( cmbTTBUS_Estado.ItemCount > 0 ) && (0==A23TTBUS_Estado) )
               {
                  A23TTBUS_Estado = (short)(NumberUtil.Val( cmbTTBUS_Estado.getItemValue(1), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23TTBUS_Estado", StringUtil.Str( (decimal)(A23TTBUS_Estado), 1, 0));
               }
               Grid1_PageSize49 = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               AV25TTBUS_Id = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(AV25TTBUS_Id), 8, 0)));
               AV10fTTBUS_Descripcion = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10fTTBUS_Descripcion", AV10fTTBUS_Descripcion);
               AV34TTBUS_RubroBien = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34TTBUS_RubroBien", StringUtil.LTrim( StringUtil.Str( (decimal)(AV34TTBUS_RubroBien), 4, 0)));
               AV29TTBUS7_Pos = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(AV29TTBUS7_Pos), 3, 0)));
               AV24TTBUS_FechaCarga = context.localUtil.ParseDateParm( GetNextPar( )) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24TTBUS_FechaCarga", context.localUtil.Format(AV24TTBUS_FechaCarga, "99/99/9999"));
               edtavSec_dre_Enabled = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSec_dre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavSec_dre_Enabled), 5, 0)));
               A7USU_DES = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7USU_DES", A7USU_DES);
               A6USU_COD = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
               A25TTBUS2_RespHacia = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25TTBUS2_RespHacia", A25TTBUS2_RespHacia);
               A24TTBUS2_RespDesde = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24TTBUS2_RespDesde", A24TTBUS2_RespDesde);
               A36TTBUS7_DesResp = GetNextPar( ) ;
               n36TTBUS7_DesResp = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36TTBUS7_DesResp", A36TTBUS7_DesResp);
               A35TTBUS7_CodResp = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35TTBUS7_CodResp", A35TTBUS7_CodResp);
               A33TTBUS7_Pos = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxgrGrid1_refresh( Grid1_PageSize49, AV25TTBUS_Id, AV10fTTBUS_Descripcion, AV34TTBUS_RubroBien, AV29TTBUS7_Pos, AV24TTBUS_FechaCarga, A7USU_DES, A6USU_COD, A25TTBUS2_RespHacia, A24TTBUS2_RespDesde, A36TTBUS7_DesResp, A35TTBUS7_CodResp, A33TTBUS7_Pos) ;
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
               AV14pTTBUS_Id = (int)(NumberUtil.Val( gxfirstwebparm, ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14pTTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14pTTBUS_Id), 8, 0)));
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
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("promptmasterpage", "GeneXus.Programs.promptmasterpage", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
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
         PA1Y2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START1Y2( ) ;
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
         FormProcess = " onkeyup=\"gx.evt.onkeyup(event)\" onkeypress=\"gx.evt.onkeypress(event,true,false)\" onkeydown=\"gx.evt.onkeypress(null,true,false)\"" ;
         context.WriteHtmlText( "<body") ;
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            context.WriteHtmlText( " background=\""+context.convertURL( Form.Background)+"\"") ;
         }
         context.WriteHtmlText( " "+"class=\"Form\""+" "+" style=\"-moz-opacity:0;opacity:0;"+"background-color:"+context.BuildHTMLColor( Form.Backcolor)+"\""+FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("htbus030_.aspx") + "?" + UrlEncode("" +AV14pTTBUS_Id)+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH_vTTBUS_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV25TTBUS_Id), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vFTTBUS_DESCRIPCION", StringUtil.RTrim( AV10fTTBUS_Descripcion));
         GxWebStd.gx_hidden_field( context, "GXH_vTTBUS_RUBROBIEN", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV34TTBUS_RubroBien), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTTBUS7_POS", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV29TTBUS7_Pos), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTTBUS_FECHACARGA", context.localUtil.Format(AV24TTBUS_FechaCarga, "99/99/9999"));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPTTBUS_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14pTTBUS_Id), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "USU_DES", StringUtil.RTrim( A7USU_DES));
         GxWebStd.gx_hidden_field( context, "USU_COD", StringUtil.RTrim( A6USU_COD));
         GxWebStd.gx_hidden_field( context, "TTBUS2_RESPHACIA", StringUtil.RTrim( A25TTBUS2_RespHacia));
         GxWebStd.gx_hidden_field( context, "TTBUS2_RESPDESDE", StringUtil.RTrim( A24TTBUS2_RespDesde));
         GxWebStd.gx_hidden_field( context, "TTBUS7_DESRESP", StringUtil.RTrim( A36TTBUS7_DesResp));
         GxWebStd.gx_hidden_field( context, "TTBUS7_CODRESP", StringUtil.RTrim( A35TTBUS7_CodResp));
         GxWebStd.gx_hidden_field( context, "TTBUS7_POS", StringUtil.LTrim( StringUtil.NToC( (decimal)(A33TTBUS7_Pos), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 6, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendComponentObjects();
         SendServerCommands();
         SendState();
         context.WriteHtmlTextNl( "</form>") ;
         include_jscripts( ) ;
      }

      public override void RenderHtmlContent( )
      {
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            WE1Y2( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT1Y2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override String GetPgmname( )
      {
         return "HTBUS030_" ;
      }

      public override String GetPgmdesc( )
      {
         return "Consulta de Trazabilidad de Bienes de Uso" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("htbus030_.aspx") + "?" + UrlEncode("" +AV14pTTBUS_Id) ;
      }

      protected void WB1Y0( )
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
            wb_table1_2_1Y2( true) ;
         }
         else
         {
            wb_table1_2_1Y2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_1Y2e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START1Y2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "Consulta de Trazabilidad de Bienes de Uso", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP1Y0( ) ;
      }

      protected void WS1Y2( )
      {
         START1Y2( ) ;
         EVT1Y2( ) ;
      }

      protected void EVT1Y2( )
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
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vTTBUS_ID"), ",", ".") != Convert.ToDecimal( AV25TTBUS_Id )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vFTTBUS_DESCRIPCION"), AV10fTTBUS_Descripcion) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vTTBUS_RUBROBIEN"), ",", ".") != Convert.ToDecimal( AV34TTBUS_RubroBien )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vTTBUS7_POS"), ",", ".") != Convert.ToDecimal( AV29TTBUS7_Pos )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( context.localUtil.CToD( cgiGet( "GXH_vTTBUS_FECHACARGA"), 4) != AV24TTBUS_FechaCarga )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
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
                           else if ( StringUtil.StrCmp(sEvt, "'BUSCAR'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E111Y2 */
                              E111Y2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'MOVIMIENTOS'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E121Y2 */
                              E121Y2 ();
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
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 15), "'VISUALIZACION'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 10), "GRID1.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 13), "'MOVIMIENTOS'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 8), "'BUSCAR'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 15), "'VISUALIZACION'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) )
                           {
                              nGXsfl_49_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                              sGXsfl_49_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_49_idx), 4, 0)), 4, "0") ;
                              edtavVisualizacion_Internalname = "vVISUALIZACION_"+sGXsfl_49_idx ;
                              edtTTBUS_Id_Internalname = "TTBUS_ID_"+sGXsfl_49_idx ;
                              edtTTBUS_Descripcion_Internalname = "TTBUS_DESCRIPCION_"+sGXsfl_49_idx ;
                              edtTTBUS_FechaCarga_Internalname = "TTBUS_FECHACARGA_"+sGXsfl_49_idx ;
                              edtTTBUS_RubroBien_Internalname = "TTBUS_RUBROBIEN_"+sGXsfl_49_idx ;
                              edtTTBUS_RubroDesc_Internalname = "TTBUS_RUBRODESC_"+sGXsfl_49_idx ;
                              edtTTBUS_FechaBaja_Internalname = "TTBUS_FECHABAJA_"+sGXsfl_49_idx ;
                              chkTTBUS_Alquilado_Internalname = "TTBUS_ALQUILADO_"+sGXsfl_49_idx ;
                              edtTTBUS_CodProveedor_Internalname = "TTBUS_CODPROVEEDOR_"+sGXsfl_49_idx ;
                              edtTTBUS_DesProveedor_Internalname = "TTBUS_DESPROVEEDOR_"+sGXsfl_49_idx ;
                              cmbTTBUS_Estado_Internalname = "TTBUS_ESTADO_"+sGXsfl_49_idx ;
                              edtTTBUS_CodPosicion_Internalname = "TTBUS_CODPOSICION_"+sGXsfl_49_idx ;
                              edtTTBUS_DesPosicion_Internalname = "TTBUS_DESPOSICION_"+sGXsfl_49_idx ;
                              edtavSec_cre_Internalname = "vSEC_CRE_"+sGXsfl_49_idx ;
                              edtavSec_dre_Internalname = "vSEC_DRE_"+sGXsfl_49_idx ;
                              edtHARDWARE_ID_Internalname = "HARDWARE_ID_"+sGXsfl_49_idx ;
                              AV31visualizacion = cgiGet( "GXimg"+edtavVisualizacion_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVisualizacion_Internalname, "Bitmap", context.convertURL( AV31visualizacion));
                              A11TTBUS_Id = (int)(context.localUtil.CToN( cgiGet( edtTTBUS_Id_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
                              A12TTBUS_Descripcion = StringUtil.Upper( cgiGet( edtTTBUS_Descripcion_Internalname)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
                              A13TTBUS_FechaCarga = context.localUtil.CToD( cgiGet( edtTTBUS_FechaCarga_Internalname), 4) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13TTBUS_FechaCarga", context.localUtil.Format(A13TTBUS_FechaCarga, "99/99/9999"));
                              A17TTBUS_RubroBien = (short)(context.localUtil.CToN( cgiGet( edtTTBUS_RubroBien_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17TTBUS_RubroBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A17TTBUS_RubroBien), 4, 0)));
                              A18TTBUS_RubroDesc = StringUtil.Upper( cgiGet( edtTTBUS_RubroDesc_Internalname)) ;
                              n18TTBUS_RubroDesc = false ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18TTBUS_RubroDesc", A18TTBUS_RubroDesc);
                              A16TTBUS_FechaBaja = context.localUtil.CToD( cgiGet( edtTTBUS_FechaBaja_Internalname), 4) ;
                              n16TTBUS_FechaBaja = false ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16TTBUS_FechaBaja", context.localUtil.Format(A16TTBUS_FechaBaja, "99/99/9999"));
                              A29TTBUS_Alquilado = (short)(((StringUtil.StrCmp(cgiGet( chkTTBUS_Alquilado_Internalname), "1")==0) ? 1 : 0)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29TTBUS_Alquilado", StringUtil.Str( (decimal)(A29TTBUS_Alquilado), 1, 0));
                              A27TTBUS_CodProveedor = (int)(context.localUtil.CToN( cgiGet( edtTTBUS_CodProveedor_Internalname), ",", ".")) ;
                              n27TTBUS_CodProveedor = false ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27TTBUS_CodProveedor", StringUtil.LTrim( StringUtil.Str( (decimal)(A27TTBUS_CodProveedor), 8, 0)));
                              A30TTBUS_DesProveedor = cgiGet( edtTTBUS_DesProveedor_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30TTBUS_DesProveedor", A30TTBUS_DesProveedor);
                              cmbTTBUS_Estado.Name = cmbTTBUS_Estado_Internalname ;
                              cmbTTBUS_Estado.CurrentValue = cgiGet( cmbTTBUS_Estado_Internalname) ;
                              A23TTBUS_Estado = (short)(NumberUtil.Val( cgiGet( cmbTTBUS_Estado_Internalname), ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23TTBUS_Estado", StringUtil.Str( (decimal)(A23TTBUS_Estado), 1, 0));
                              A37TTBUS_CodPosicion = (short)(context.localUtil.CToN( cgiGet( edtTTBUS_CodPosicion_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37TTBUS_CodPosicion", StringUtil.LTrim( StringUtil.Str( (decimal)(A37TTBUS_CodPosicion), 3, 0)));
                              A38TTBUS_DesPosicion = cgiGet( edtTTBUS_DesPosicion_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A38TTBUS_DesPosicion", A38TTBUS_DesPosicion);
                              AV16SEC_CRE = cgiGet( edtavSec_cre_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16SEC_CRE", AV16SEC_CRE);
                              AV17SEC_DRE = cgiGet( edtavSec_dre_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17SEC_DRE", AV17SEC_DRE);
                              A10HARDWARE_ID = (short)(context.localUtil.CToN( cgiGet( edtHARDWARE_ID_Internalname), ",", ".")) ;
                              n10HARDWARE_ID = false ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10HARDWARE_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A10HARDWARE_ID), 4, 0)));
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E131Y2 */
                                    E131Y2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'VISUALIZACION'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E141Y2 */
                                    E141Y2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID1.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E151Y2 */
                                    E151Y2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'MOVIMIENTOS'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E121Y2 */
                                    E121Y2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false ;
                                       /* Set Refresh If Ttbus_id Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTTBUS_ID"), ",", ".") != Convert.ToDecimal( AV25TTBUS_Id )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Fttbus_descripcion Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vFTTBUS_DESCRIPCION"), AV10fTTBUS_Descripcion) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Ttbus_rubrobien Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTTBUS_RUBROBIEN"), ",", ".") != Convert.ToDecimal( AV34TTBUS_RubroBien )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Ttbus7_pos Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTTBUS7_POS"), ",", ".") != Convert.ToDecimal( AV29TTBUS7_Pos )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Ttbus_fechacarga Changed */
                                       if ( context.localUtil.CToD( cgiGet( "GXH_vTTBUS_FECHACARGA"), 4) != AV24TTBUS_FechaCarga )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: E161Y2 */
                                          E161Y2 ();
                                       }
                                       dynload_actions( ) ;
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'BUSCAR'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E111Y2 */
                                    E111Y2 ();
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

      protected void WE1Y2( )
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

      protected void PA1Y2( )
      {
         if ( nDonePA == 0 )
         {
            cmbavTtbus7_pos.Name = "vTTBUS7_POS" ;
            cmbavTtbus7_pos.WebTags = "" ;
            if ( ( cmbavTtbus7_pos.ItemCount > 0 ) && (0==AV29TTBUS7_Pos) )
            {
               AV29TTBUS7_Pos = (short)(NumberUtil.Val( cmbavTtbus7_pos.getItemValue(1), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(AV29TTBUS7_Pos), 3, 0)));
            }
            GXCCtl = "TTBUS_ALQUILADO_" + sGXsfl_49_idx ;
            chkTTBUS_Alquilado.Name = GXCCtl ;
            chkTTBUS_Alquilado.WebTags = "" ;
            chkTTBUS_Alquilado.Caption = "" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkTTBUS_Alquilado_Internalname, "Caption", chkTTBUS_Alquilado.Caption);
            chkTTBUS_Alquilado.CheckedValue = "0" ;
            GXCCtl = "TTBUS_ESTADO_" + sGXsfl_49_idx ;
            cmbTTBUS_Estado.Name = GXCCtl ;
            cmbTTBUS_Estado.WebTags = "" ;
            cmbTTBUS_Estado.addItem("1", "ASIGNADO A UN SECTOR", 0);
            cmbTTBUS_Estado.addItem("2", "CAMBIANDO DE SECTOR", 0);
            cmbTTBUS_Estado.addItem("3", "BAJA A CONFIRMAR", 0);
            cmbTTBUS_Estado.addItem("4", "BAJA", 0);
            if ( ( cmbTTBUS_Estado.ItemCount > 0 ) && (0==A23TTBUS_Estado) )
            {
               A23TTBUS_Estado = (short)(NumberUtil.Val( cmbTTBUS_Estado.getItemValue(1), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23TTBUS_Estado", StringUtil.Str( (decimal)(A23TTBUS_Estado), 1, 0));
            }
            GX_FocusControl = edtavTtbus_id_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void GXSGVvFTTBUS_DESCRIPCION1Y0( String A12TTBUS_Descripcion )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
         }
         context.GX_webresponse.AddString("(new Array( new Array(");
         GXSGVvFTTBUS_DESCRIPCION_data1Y0( A12TTBUS_Descripcion) ;
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

      protected void GXSGVvFTTBUS_DESCRIPCION_data1Y0( String A12TTBUS_Descripcion )
      {
         l12TTBUS_Descripcion = StringUtil.PadR( StringUtil.RTrim( A12TTBUS_Descripcion), 50, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
         /* Using cursor H001Y2 */
         pr_default.execute(0, new Object[] {l12TTBUS_Descripcion});
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         while ( (pr_default.getStatus(0) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.RTrim( H001Y2_A12TTBUS_Descripcion[0]));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( H001Y2_A12TTBUS_Descripcion[0]));
            pr_default.readNext(0);
         }
         pr_default.close(0);
      }

      protected void GXSGATTBUS_DESCRIPCION1Y0( String A12TTBUS_Descripcion )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
         }
         context.GX_webresponse.AddString("(new Array( new Array(");
         GXSGATTBUS_DESCRIPCION_data1Y0( A12TTBUS_Descripcion) ;
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

      protected void GXSGATTBUS_DESCRIPCION_data1Y0( String A12TTBUS_Descripcion )
      {
         l12TTBUS_Descripcion = StringUtil.PadR( StringUtil.RTrim( A12TTBUS_Descripcion), 50, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
         /* Using cursor H001Y3 */
         pr_default.execute(1, new Object[] {l12TTBUS_Descripcion});
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         while ( (pr_default.getStatus(1) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.RTrim( H001Y3_A12TTBUS_Descripcion[0]));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( H001Y3_A12TTBUS_Descripcion[0]));
            pr_default.readNext(1);
         }
         pr_default.close(1);
      }

      protected void gxnrGrid1_newrow( short nRC_Grid1 ,
                                       short nGXsfl_49_idx ,
                                       String sGXsfl_49_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         edtavVisualizacion_Internalname = "vVISUALIZACION_"+sGXsfl_49_idx ;
         edtTTBUS_Id_Internalname = "TTBUS_ID_"+sGXsfl_49_idx ;
         edtTTBUS_Descripcion_Internalname = "TTBUS_DESCRIPCION_"+sGXsfl_49_idx ;
         edtTTBUS_FechaCarga_Internalname = "TTBUS_FECHACARGA_"+sGXsfl_49_idx ;
         edtTTBUS_RubroBien_Internalname = "TTBUS_RUBROBIEN_"+sGXsfl_49_idx ;
         edtTTBUS_RubroDesc_Internalname = "TTBUS_RUBRODESC_"+sGXsfl_49_idx ;
         edtTTBUS_FechaBaja_Internalname = "TTBUS_FECHABAJA_"+sGXsfl_49_idx ;
         chkTTBUS_Alquilado_Internalname = "TTBUS_ALQUILADO_"+sGXsfl_49_idx ;
         edtTTBUS_CodProveedor_Internalname = "TTBUS_CODPROVEEDOR_"+sGXsfl_49_idx ;
         edtTTBUS_DesProveedor_Internalname = "TTBUS_DESPROVEEDOR_"+sGXsfl_49_idx ;
         cmbTTBUS_Estado_Internalname = "TTBUS_ESTADO_"+sGXsfl_49_idx ;
         edtTTBUS_CodPosicion_Internalname = "TTBUS_CODPOSICION_"+sGXsfl_49_idx ;
         edtTTBUS_DesPosicion_Internalname = "TTBUS_DESPOSICION_"+sGXsfl_49_idx ;
         edtavSec_cre_Internalname = "vSEC_CRE_"+sGXsfl_49_idx ;
         edtavSec_dre_Internalname = "vSEC_DRE_"+sGXsfl_49_idx ;
         edtHARDWARE_ID_Internalname = "HARDWARE_ID_"+sGXsfl_49_idx ;
         while ( nGXsfl_49_idx <= nRC_Grid1 )
         {
            sendrow_492( ) ;
            nGXsfl_49_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_49_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_49_idx+1)) ;
            sGXsfl_49_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_49_idx), 4, 0)), 4, "0") ;
            edtavVisualizacion_Internalname = "vVISUALIZACION_"+sGXsfl_49_idx ;
            edtTTBUS_Id_Internalname = "TTBUS_ID_"+sGXsfl_49_idx ;
            edtTTBUS_Descripcion_Internalname = "TTBUS_DESCRIPCION_"+sGXsfl_49_idx ;
            edtTTBUS_FechaCarga_Internalname = "TTBUS_FECHACARGA_"+sGXsfl_49_idx ;
            edtTTBUS_RubroBien_Internalname = "TTBUS_RUBROBIEN_"+sGXsfl_49_idx ;
            edtTTBUS_RubroDesc_Internalname = "TTBUS_RUBRODESC_"+sGXsfl_49_idx ;
            edtTTBUS_FechaBaja_Internalname = "TTBUS_FECHABAJA_"+sGXsfl_49_idx ;
            chkTTBUS_Alquilado_Internalname = "TTBUS_ALQUILADO_"+sGXsfl_49_idx ;
            edtTTBUS_CodProveedor_Internalname = "TTBUS_CODPROVEEDOR_"+sGXsfl_49_idx ;
            edtTTBUS_DesProveedor_Internalname = "TTBUS_DESPROVEEDOR_"+sGXsfl_49_idx ;
            cmbTTBUS_Estado_Internalname = "TTBUS_ESTADO_"+sGXsfl_49_idx ;
            edtTTBUS_CodPosicion_Internalname = "TTBUS_CODPOSICION_"+sGXsfl_49_idx ;
            edtTTBUS_DesPosicion_Internalname = "TTBUS_DESPOSICION_"+sGXsfl_49_idx ;
            edtavSec_cre_Internalname = "vSEC_CRE_"+sGXsfl_49_idx ;
            edtavSec_dre_Internalname = "vSEC_DRE_"+sGXsfl_49_idx ;
            edtHARDWARE_ID_Internalname = "HARDWARE_ID_"+sGXsfl_49_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int Grid1_PageSize49 ,
                                        int AV25TTBUS_Id ,
                                        String AV10fTTBUS_Descripcion ,
                                        short AV34TTBUS_RubroBien ,
                                        short AV29TTBUS7_Pos ,
                                        DateTime AV24TTBUS_FechaCarga ,
                                        String A7USU_DES ,
                                        String A6USU_COD ,
                                        String A25TTBUS2_RespHacia ,
                                        String A24TTBUS2_RespDesde ,
                                        String A36TTBUS7_DesResp ,
                                        String A35TTBUS7_CodResp ,
                                        short A33TTBUS7_Pos )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         subGrid1_Rows = (short)(Grid1_PageSize49) ;
         RF1Y2( ) ;
         enableOutput();
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxgrGrid1_refresh */
      }

      protected void Refresh( )
      {
         RF1Y2( ) ;
         /* End function Refresh */
      }

      protected void RF1Y2( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 49 ;
         nGXsfl_49_idx = 1 ;
         sGXsfl_49_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_49_idx), 4, 0)), 4, "0") ;
         edtavVisualizacion_Internalname = "vVISUALIZACION_"+sGXsfl_49_idx ;
         edtTTBUS_Id_Internalname = "TTBUS_ID_"+sGXsfl_49_idx ;
         edtTTBUS_Descripcion_Internalname = "TTBUS_DESCRIPCION_"+sGXsfl_49_idx ;
         edtTTBUS_FechaCarga_Internalname = "TTBUS_FECHACARGA_"+sGXsfl_49_idx ;
         edtTTBUS_RubroBien_Internalname = "TTBUS_RUBROBIEN_"+sGXsfl_49_idx ;
         edtTTBUS_RubroDesc_Internalname = "TTBUS_RUBRODESC_"+sGXsfl_49_idx ;
         edtTTBUS_FechaBaja_Internalname = "TTBUS_FECHABAJA_"+sGXsfl_49_idx ;
         chkTTBUS_Alquilado_Internalname = "TTBUS_ALQUILADO_"+sGXsfl_49_idx ;
         edtTTBUS_CodProveedor_Internalname = "TTBUS_CODPROVEEDOR_"+sGXsfl_49_idx ;
         edtTTBUS_DesProveedor_Internalname = "TTBUS_DESPROVEEDOR_"+sGXsfl_49_idx ;
         cmbTTBUS_Estado_Internalname = "TTBUS_ESTADO_"+sGXsfl_49_idx ;
         edtTTBUS_CodPosicion_Internalname = "TTBUS_CODPOSICION_"+sGXsfl_49_idx ;
         edtTTBUS_DesPosicion_Internalname = "TTBUS_DESPOSICION_"+sGXsfl_49_idx ;
         edtavSec_cre_Internalname = "vSEC_CRE_"+sGXsfl_49_idx ;
         edtavSec_dre_Internalname = "vSEC_DRE_"+sGXsfl_49_idx ;
         edtHARDWARE_ID_Internalname = "HARDWARE_ID_"+sGXsfl_49_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtavVisualizacion_Internalname = "vVISUALIZACION_"+sGXsfl_49_idx ;
            edtTTBUS_Id_Internalname = "TTBUS_ID_"+sGXsfl_49_idx ;
            edtTTBUS_Descripcion_Internalname = "TTBUS_DESCRIPCION_"+sGXsfl_49_idx ;
            edtTTBUS_FechaCarga_Internalname = "TTBUS_FECHACARGA_"+sGXsfl_49_idx ;
            edtTTBUS_RubroBien_Internalname = "TTBUS_RUBROBIEN_"+sGXsfl_49_idx ;
            edtTTBUS_RubroDesc_Internalname = "TTBUS_RUBRODESC_"+sGXsfl_49_idx ;
            edtTTBUS_FechaBaja_Internalname = "TTBUS_FECHABAJA_"+sGXsfl_49_idx ;
            chkTTBUS_Alquilado_Internalname = "TTBUS_ALQUILADO_"+sGXsfl_49_idx ;
            edtTTBUS_CodProveedor_Internalname = "TTBUS_CODPROVEEDOR_"+sGXsfl_49_idx ;
            edtTTBUS_DesProveedor_Internalname = "TTBUS_DESPROVEEDOR_"+sGXsfl_49_idx ;
            cmbTTBUS_Estado_Internalname = "TTBUS_ESTADO_"+sGXsfl_49_idx ;
            edtTTBUS_CodPosicion_Internalname = "TTBUS_CODPOSICION_"+sGXsfl_49_idx ;
            edtTTBUS_DesPosicion_Internalname = "TTBUS_DESPOSICION_"+sGXsfl_49_idx ;
            edtavSec_cre_Internalname = "vSEC_CRE_"+sGXsfl_49_idx ;
            edtavSec_dre_Internalname = "vSEC_DRE_"+sGXsfl_49_idx ;
            edtHARDWARE_ID_Internalname = "HARDWARE_ID_"+sGXsfl_49_idx ;
            pr_default.dynParam(2, new Object[]{ new Object[]{
                                                 AV29TTBUS7_Pos ,
                                                 AV10fTTBUS_Descripcion ,
                                                 AV24TTBUS_FechaCarga ,
                                                 AV34TTBUS_RubroBien ,
                                                 A37TTBUS_CodPosicion ,
                                                 A12TTBUS_Descripcion ,
                                                 AV22TTBUS_Descripcion ,
                                                 A13TTBUS_FechaCarga ,
                                                 A17TTBUS_RubroBien ,
                                                 A16TTBUS_FechaBaja ,
                                                 A10HARDWARE_ID ,
                                                 AV25TTBUS_Id },
                                                 new int[] {
                                                 TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.DATE, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DATE, TypeConstants.SHORT, TypeConstants.DATE,
                                                 TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.INT
                                                 }
            });
            lV22TTBUS_Descripcion = StringUtil.PadR( StringUtil.RTrim( AV22TTBUS_Descripcion), 50, "%") ;
            /* Using cursor H001Y4 */
            pr_default.execute(2, new Object[] {AV25TTBUS_Id, AV29TTBUS7_Pos, lV22TTBUS_Descripcion, AV24TTBUS_FechaCarga, AV34TTBUS_RubroBien});
            nGXsfl_49_idx = 1 ;
            GRID1_nEOF = 0 ;
            while ( ( (pr_default.getStatus(2) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) ) )
            {
               A11TTBUS_Id = H001Y4_A11TTBUS_Id[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
               A37TTBUS_CodPosicion = H001Y4_A37TTBUS_CodPosicion[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37TTBUS_CodPosicion", StringUtil.LTrim( StringUtil.Str( (decimal)(A37TTBUS_CodPosicion), 3, 0)));
               A10HARDWARE_ID = H001Y4_A10HARDWARE_ID[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10HARDWARE_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A10HARDWARE_ID), 4, 0)));
               n10HARDWARE_ID = H001Y4_n10HARDWARE_ID[0] ;
               A38TTBUS_DesPosicion = H001Y4_A38TTBUS_DesPosicion[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A38TTBUS_DesPosicion", A38TTBUS_DesPosicion);
               A23TTBUS_Estado = H001Y4_A23TTBUS_Estado[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23TTBUS_Estado", StringUtil.Str( (decimal)(A23TTBUS_Estado), 1, 0));
               A30TTBUS_DesProveedor = H001Y4_A30TTBUS_DesProveedor[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30TTBUS_DesProveedor", A30TTBUS_DesProveedor);
               A27TTBUS_CodProveedor = H001Y4_A27TTBUS_CodProveedor[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27TTBUS_CodProveedor", StringUtil.LTrim( StringUtil.Str( (decimal)(A27TTBUS_CodProveedor), 8, 0)));
               n27TTBUS_CodProveedor = H001Y4_n27TTBUS_CodProveedor[0] ;
               A29TTBUS_Alquilado = H001Y4_A29TTBUS_Alquilado[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29TTBUS_Alquilado", StringUtil.Str( (decimal)(A29TTBUS_Alquilado), 1, 0));
               A16TTBUS_FechaBaja = H001Y4_A16TTBUS_FechaBaja[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16TTBUS_FechaBaja", context.localUtil.Format(A16TTBUS_FechaBaja, "99/99/9999"));
               n16TTBUS_FechaBaja = H001Y4_n16TTBUS_FechaBaja[0] ;
               A18TTBUS_RubroDesc = H001Y4_A18TTBUS_RubroDesc[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18TTBUS_RubroDesc", A18TTBUS_RubroDesc);
               n18TTBUS_RubroDesc = H001Y4_n18TTBUS_RubroDesc[0] ;
               A17TTBUS_RubroBien = H001Y4_A17TTBUS_RubroBien[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17TTBUS_RubroBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A17TTBUS_RubroBien), 4, 0)));
               A13TTBUS_FechaCarga = H001Y4_A13TTBUS_FechaCarga[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13TTBUS_FechaCarga", context.localUtil.Format(A13TTBUS_FechaCarga, "99/99/9999"));
               A12TTBUS_Descripcion = H001Y4_A12TTBUS_Descripcion[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
               A18TTBUS_RubroDesc = H001Y4_A18TTBUS_RubroDesc[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18TTBUS_RubroDesc", A18TTBUS_RubroDesc);
               n18TTBUS_RubroDesc = H001Y4_n18TTBUS_RubroDesc[0] ;
               /* Execute user event: E151Y2 */
               E151Y2 ();
               pr_default.readNext(2);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(2) == 101) ? 1 : 0)) ;
            pr_default.close(2);
            wbEnd = 49 ;
            WB1Y0( ) ;
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
         pr_default.dynParam(3, new Object[]{ new Object[]{
                                              AV29TTBUS7_Pos ,
                                              AV10fTTBUS_Descripcion ,
                                              AV24TTBUS_FechaCarga ,
                                              AV34TTBUS_RubroBien ,
                                              A37TTBUS_CodPosicion ,
                                              A12TTBUS_Descripcion ,
                                              AV22TTBUS_Descripcion ,
                                              A13TTBUS_FechaCarga ,
                                              A17TTBUS_RubroBien ,
                                              A16TTBUS_FechaBaja ,
                                              A10HARDWARE_ID ,
                                              AV25TTBUS_Id },
                                              new int[] {
                                              TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.DATE, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DATE, TypeConstants.SHORT, TypeConstants.DATE,
                                              TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.INT
                                              }
         });
         lV22TTBUS_Descripcion = StringUtil.PadR( StringUtil.RTrim( AV22TTBUS_Descripcion), 50, "%") ;
         /* Using cursor H001Y5 */
         pr_default.execute(3, new Object[] {AV25TTBUS_Id, AV29TTBUS7_Pos, lV22TTBUS_Descripcion, AV24TTBUS_FechaCarga, AV34TTBUS_RubroBien});
         GRID1_nRecordCount = H001Y5_AGRID1_nRecordCount[0] ;
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

      protected void STRUP1Y0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         edtavSec_cre_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSec_cre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavSec_cre_Enabled), 5, 0)));
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E131Y2 */
         E131Y2 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ! context.localUtil.VCNumber( cgiGet( edtavTtbus_id_Internalname), "ZZZZZZZ9") || ( context.localUtil.CToN( cgiGet( edtavTtbus_id_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavTtbus_id_Internalname), ",", ".") > Convert.ToDecimal( 99999999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vTTBUS_ID");
               GX_FocusControl = edtavTtbus_id_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV25TTBUS_Id = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(AV25TTBUS_Id), 8, 0)));
            }
            else
            {
               AV25TTBUS_Id = (int)(context.localUtil.CToN( cgiGet( edtavTtbus_id_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(AV25TTBUS_Id), 8, 0)));
            }
            AV10fTTBUS_Descripcion = StringUtil.Upper( cgiGet( edtavFttbus_descripcion_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10fTTBUS_Descripcion", AV10fTTBUS_Descripcion);
            if ( ! context.localUtil.VCNumber( cgiGet( edtavTtbus_rubrobien_Internalname), "ZZZ9") || ( context.localUtil.CToN( cgiGet( edtavTtbus_rubrobien_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavTtbus_rubrobien_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vTTBUS_RUBROBIEN");
               GX_FocusControl = edtavTtbus_rubrobien_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV34TTBUS_RubroBien = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34TTBUS_RubroBien", StringUtil.LTrim( StringUtil.Str( (decimal)(AV34TTBUS_RubroBien), 4, 0)));
            }
            else
            {
               AV34TTBUS_RubroBien = (short)(context.localUtil.CToN( cgiGet( edtavTtbus_rubrobien_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34TTBUS_RubroBien", StringUtil.LTrim( StringUtil.Str( (decimal)(AV34TTBUS_RubroBien), 4, 0)));
            }
            cmbavTtbus7_pos.Name = cmbavTtbus7_pos_Internalname ;
            cmbavTtbus7_pos.CurrentValue = cgiGet( cmbavTtbus7_pos_Internalname) ;
            AV29TTBUS7_Pos = (short)(NumberUtil.Val( cgiGet( cmbavTtbus7_pos_Internalname), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(AV29TTBUS7_Pos), 3, 0)));
            if ( context.localUtil.VCDate( cgiGet( edtavTtbus_fechacarga_Internalname), 4) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"TTBUS_ Fecha Carga"}), 1, "vTTBUS_FECHACARGA");
               GX_FocusControl = edtavTtbus_fechacarga_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV24TTBUS_FechaCarga = DateTime.MinValue ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24TTBUS_FechaCarga", context.localUtil.Format(AV24TTBUS_FechaCarga, "99/99/9999"));
            }
            else
            {
               AV24TTBUS_FechaCarga = context.localUtil.CToD( cgiGet( edtavTtbus_fechacarga_Internalname), 4) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24TTBUS_FechaCarga", context.localUtil.Format(AV24TTBUS_FechaCarga, "99/99/9999"));
            }
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ",", ".")) ;
            AV14pTTBUS_Id = (int)(context.localUtil.CToN( cgiGet( "vPTTBUS_ID"), ",", ".")) ;
            GRID1_nFirstRecordOnPage = (int)(context.localUtil.CToN( cgiGet( "GRID1_nFirstRecordOnPage"), ",", ".")) ;
            GRID1_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID1_nEOF"), ",", ".")) ;
            /* Read subfile selected row values. */
            nGXsfl_49_idx = (short)(context.localUtil.CToN( cgiGet( subGrid1_Internalname+"_ROW"), ",", ".")) ;
            sGXsfl_49_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_49_idx), 4, 0)), 4, "0") ;
            edtavVisualizacion_Internalname = "vVISUALIZACION_"+sGXsfl_49_idx ;
            edtTTBUS_Id_Internalname = "TTBUS_ID_"+sGXsfl_49_idx ;
            edtTTBUS_Descripcion_Internalname = "TTBUS_DESCRIPCION_"+sGXsfl_49_idx ;
            edtTTBUS_FechaCarga_Internalname = "TTBUS_FECHACARGA_"+sGXsfl_49_idx ;
            edtTTBUS_RubroBien_Internalname = "TTBUS_RUBROBIEN_"+sGXsfl_49_idx ;
            edtTTBUS_RubroDesc_Internalname = "TTBUS_RUBRODESC_"+sGXsfl_49_idx ;
            edtTTBUS_FechaBaja_Internalname = "TTBUS_FECHABAJA_"+sGXsfl_49_idx ;
            chkTTBUS_Alquilado_Internalname = "TTBUS_ALQUILADO_"+sGXsfl_49_idx ;
            edtTTBUS_CodProveedor_Internalname = "TTBUS_CODPROVEEDOR_"+sGXsfl_49_idx ;
            edtTTBUS_DesProveedor_Internalname = "TTBUS_DESPROVEEDOR_"+sGXsfl_49_idx ;
            cmbTTBUS_Estado_Internalname = "TTBUS_ESTADO_"+sGXsfl_49_idx ;
            edtTTBUS_CodPosicion_Internalname = "TTBUS_CODPOSICION_"+sGXsfl_49_idx ;
            edtTTBUS_DesPosicion_Internalname = "TTBUS_DESPOSICION_"+sGXsfl_49_idx ;
            edtavSec_cre_Internalname = "vSEC_CRE_"+sGXsfl_49_idx ;
            edtavSec_dre_Internalname = "vSEC_DRE_"+sGXsfl_49_idx ;
            edtHARDWARE_ID_Internalname = "HARDWARE_ID_"+sGXsfl_49_idx ;
            if ( nGXsfl_49_idx > 0 )
            {
               AV31visualizacion = cgiGet( "GXimg"+edtavVisualizacion_Internalname) ;
               A11TTBUS_Id = (int)(context.localUtil.CToN( cgiGet( edtTTBUS_Id_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
               A12TTBUS_Descripcion = StringUtil.Upper( cgiGet( edtTTBUS_Descripcion_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
               A13TTBUS_FechaCarga = context.localUtil.CToD( cgiGet( edtTTBUS_FechaCarga_Internalname), 4) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13TTBUS_FechaCarga", context.localUtil.Format(A13TTBUS_FechaCarga, "99/99/9999"));
               A17TTBUS_RubroBien = (short)(context.localUtil.CToN( cgiGet( edtTTBUS_RubroBien_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17TTBUS_RubroBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A17TTBUS_RubroBien), 4, 0)));
               A18TTBUS_RubroDesc = StringUtil.Upper( cgiGet( edtTTBUS_RubroDesc_Internalname)) ;
               n18TTBUS_RubroDesc = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18TTBUS_RubroDesc", A18TTBUS_RubroDesc);
               A16TTBUS_FechaBaja = context.localUtil.CToD( cgiGet( edtTTBUS_FechaBaja_Internalname), 4) ;
               n16TTBUS_FechaBaja = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16TTBUS_FechaBaja", context.localUtil.Format(A16TTBUS_FechaBaja, "99/99/9999"));
               A29TTBUS_Alquilado = (short)(((StringUtil.StrCmp(cgiGet( chkTTBUS_Alquilado_Internalname), "1")==0) ? 1 : 0)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29TTBUS_Alquilado", StringUtil.Str( (decimal)(A29TTBUS_Alquilado), 1, 0));
               A27TTBUS_CodProveedor = (int)(context.localUtil.CToN( cgiGet( edtTTBUS_CodProveedor_Internalname), ",", ".")) ;
               n27TTBUS_CodProveedor = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27TTBUS_CodProveedor", StringUtil.LTrim( StringUtil.Str( (decimal)(A27TTBUS_CodProveedor), 8, 0)));
               A30TTBUS_DesProveedor = cgiGet( edtTTBUS_DesProveedor_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30TTBUS_DesProveedor", A30TTBUS_DesProveedor);
               cmbTTBUS_Estado.Name = cmbTTBUS_Estado_Internalname ;
               cmbTTBUS_Estado.CurrentValue = cgiGet( cmbTTBUS_Estado_Internalname) ;
               A23TTBUS_Estado = (short)(NumberUtil.Val( cgiGet( cmbTTBUS_Estado_Internalname), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23TTBUS_Estado", StringUtil.Str( (decimal)(A23TTBUS_Estado), 1, 0));
               A37TTBUS_CodPosicion = (short)(context.localUtil.CToN( cgiGet( edtTTBUS_CodPosicion_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37TTBUS_CodPosicion", StringUtil.LTrim( StringUtil.Str( (decimal)(A37TTBUS_CodPosicion), 3, 0)));
               A38TTBUS_DesPosicion = cgiGet( edtTTBUS_DesPosicion_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A38TTBUS_DesPosicion", A38TTBUS_DesPosicion);
               AV16SEC_CRE = cgiGet( edtavSec_cre_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16SEC_CRE", AV16SEC_CRE);
               AV17SEC_DRE = cgiGet( edtavSec_dre_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17SEC_DRE", AV17SEC_DRE);
               A10HARDWARE_ID = (short)(context.localUtil.CToN( cgiGet( edtHARDWARE_ID_Internalname), ",", ".")) ;
               n10HARDWARE_ID = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10HARDWARE_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A10HARDWARE_ID), 4, 0)));
            }
            /* Read hidden variables. */
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: E131Y2 */
         E131Y2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E131Y2( )
      {
         /* Start Routine */
         new loadcontext(context ).execute( out  AV7Context) ;
         AV30USUARIO = AV7Context.gxTpr_User ;
         edtavSec_dre_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSec_dre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavSec_dre_Enabled), 5, 0)));
         AV12inicio = (short)(NumberUtil.Val( AV18SESION.Get("Inicio"), ".")) ;
         if ( AV12inicio < 2 )
         {
            AV12inicio = (short)(AV12inicio+1) ;
            AV18SESION.Set("Inicio", StringUtil.Str( (decimal)(AV12inicio), 1, 0));
            context.DoAjaxRefresh();
         }
         /* Execute user subroutine: S112 */
         S112 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E141Y2( )
      {
         /* 'Visualizacion' Routine */
         context.wjLoc = formatLink("ttbus000.aspx") + "?" + UrlEncode("" +A11TTBUS_Id) + "," + UrlEncode(StringUtil.RTrim("DSP")) + "," + UrlEncode("" +A37TTBUS_CodPosicion) + "," + UrlEncode(StringUtil.RTrim(AV16SEC_CRE)) + "," + UrlEncode("" +AV23TTBUS_Estado) + "," + UrlEncode("" +1) + "," + UrlEncode(StringUtil.RTrim(AV19SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV30USUARIO)) ;
      }

      private void E151Y2( )
      {
         /* Grid1_Load Routine */
         AV31visualizacion = context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", "Modern") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVisualizacion_Internalname, "Bitmap", context.convertURL( AV31visualizacion));
         if ( A23TTBUS_Estado == 1 )
         {
            /* Using cursor H001Y6 */
            pr_default.execute(4, new Object[] {A37TTBUS_CodPosicion});
            while ( (pr_default.getStatus(4) != 101) )
            {
               A33TTBUS7_Pos = H001Y6_A33TTBUS7_Pos[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
               A35TTBUS7_CodResp = H001Y6_A35TTBUS7_CodResp[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35TTBUS7_CodResp", A35TTBUS7_CodResp);
               A36TTBUS7_DesResp = H001Y6_A36TTBUS7_DesResp[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36TTBUS7_DesResp", A36TTBUS7_DesResp);
               n36TTBUS7_DesResp = H001Y6_n36TTBUS7_DesResp[0] ;
               A36TTBUS7_DesResp = H001Y6_A36TTBUS7_DesResp[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36TTBUS7_DesResp", A36TTBUS7_DesResp);
               n36TTBUS7_DesResp = H001Y6_n36TTBUS7_DesResp[0] ;
               AV16SEC_CRE = A35TTBUS7_CodResp ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16SEC_CRE", AV16SEC_CRE);
               AV17SEC_DRE = A36TTBUS7_DesResp ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17SEC_DRE", AV17SEC_DRE);
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(4);
         }
         else
         {
            /* Using cursor H001Y7 */
            pr_default.execute(5, new Object[] {A11TTBUS_Id});
            while ( (pr_default.getStatus(5) != 101) )
            {
               A22TTBUS2_IdBien = H001Y7_A22TTBUS2_IdBien[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22TTBUS2_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A22TTBUS2_IdBien), 8, 0)));
               A26TTBUS2_EstadoEnvio = H001Y7_A26TTBUS2_EstadoEnvio[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26TTBUS2_EstadoEnvio", StringUtil.Str( (decimal)(A26TTBUS2_EstadoEnvio), 1, 0));
               A24TTBUS2_RespDesde = H001Y7_A24TTBUS2_RespDesde[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24TTBUS2_RespDesde", A24TTBUS2_RespDesde);
               A25TTBUS2_RespHacia = H001Y7_A25TTBUS2_RespHacia[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25TTBUS2_RespHacia", A25TTBUS2_RespHacia);
               AV26TTBUS2_RespDesde = A24TTBUS2_RespDesde ;
               AV27TTBUS2_RespHacia = A25TTBUS2_RespHacia ;
               /* Execute user subroutine: S124 */
               S124 ();
               if ( returnInSub )
               {
                  pr_default.close(5);
                  returnInSub = true;
                  if (true) return;
               }
               pr_default.readNext(5);
            }
            pr_default.close(5);
            AV17SEC_DRE = StringUtil.Trim( AV8dUSU_DES) + " Y " + StringUtil.Trim( AV11hUSU_DES) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17SEC_DRE", AV17SEC_DRE);
         }
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 49 ;
         }
         if ( ( subGrid1_Islastpage == 1 ) || ( 10 == 0 ) || ( ( GRID1_nCurrentRecord >= GRID1_nFirstRecordOnPage ) && ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) )
         {
            sendrow_492( ) ;
         }
         GRID1_nCurrentRecord = (int)(GRID1_nCurrentRecord+1) ;
      }

      protected void E121Y2( )
      {
         /* 'Movimientos' Routine */
         AV18SESION.Set("CONT_MOV", "1");
         context.PopUp(formatLink("htbus002.aspx") + "?" + UrlEncode("" +A11TTBUS_Id) + "," + UrlEncode(StringUtil.RTrim(A12TTBUS_Descripcion)) + "," + UrlEncode(StringUtil.RTrim(AV19SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV30USUARIO)), new Object[] {"A11TTBUS_Id","A12TTBUS_Descripcion","AV19SISTEMA","AV30USUARIO"});
      }

      protected void S112( )
      {
         /* 'CARGA POSICIONES' Routine */
         AV6band = 0 ;
         /* Using cursor H001Y8 */
         pr_default.execute(6, new Object[] {AV30USUARIO});
         while ( (pr_default.getStatus(6) != 101) )
         {
            A40TTBUS8_CodUsuario = H001Y8_A40TTBUS8_CodUsuario[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40TTBUS8_CodUsuario", A40TTBUS8_CodUsuario);
            AV6band = 1 ;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(6);
         if ( ( ( AV6band == 1 ) ) || ( ( StringUtil.StrCmp(AV30USUARIO, "SUPERVISOR") == 0 ) ) )
         {
            cmbavTtbus7_pos.addItem(" -1", "TODAS", 0);
            /* Using cursor H001Y9 */
            pr_default.execute(7);
            while ( (pr_default.getStatus(7) != 101) )
            {
               A34TTBUS7_Des = H001Y9_A34TTBUS7_Des[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34TTBUS7_Des", A34TTBUS7_Des);
               n34TTBUS7_Des = H001Y9_n34TTBUS7_Des[0] ;
               A33TTBUS7_Pos = H001Y9_A33TTBUS7_Pos[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
               A34TTBUS7_Des = H001Y9_A34TTBUS7_Des[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34TTBUS7_Des", A34TTBUS7_Des);
               n34TTBUS7_Des = H001Y9_n34TTBUS7_Des[0] ;
               cmbavTtbus7_pos.addItem(StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0), A34TTBUS7_Des, 0);
               pr_default.readNext(7);
            }
            pr_default.close(7);
            AV29TTBUS7_Pos = -1 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(AV29TTBUS7_Pos), 3, 0)));
         }
         else
         {
            /* Using cursor H001Y10 */
            pr_default.execute(8);
            while ( (pr_default.getStatus(8) != 101) )
            {
               A34TTBUS7_Des = H001Y10_A34TTBUS7_Des[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34TTBUS7_Des", A34TTBUS7_Des);
               n34TTBUS7_Des = H001Y10_n34TTBUS7_Des[0] ;
               A35TTBUS7_CodResp = H001Y10_A35TTBUS7_CodResp[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35TTBUS7_CodResp", A35TTBUS7_CodResp);
               A33TTBUS7_Pos = H001Y10_A33TTBUS7_Pos[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
               A34TTBUS7_Des = H001Y10_A34TTBUS7_Des[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34TTBUS7_Des", A34TTBUS7_Des);
               n34TTBUS7_Des = H001Y10_n34TTBUS7_Des[0] ;
               AV32vTTBUS7_Pos = A33TTBUS7_Pos ;
               if ( StringUtil.StrCmp(A35TTBUS7_CodResp, AV30USUARIO) == 0 )
               {
                  cmbavTtbus7_pos.addItem(StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0), A34TTBUS7_Des, 0);
               }
               else
               {
                  /* Using cursor H001Y11 */
                  pr_default.execute(9, new Object[] {AV32vTTBUS7_Pos, AV30USUARIO});
                  while ( (pr_default.getStatus(9) != 101) )
                  {
                     A39TTBUS7_CodUsuario = H001Y11_A39TTBUS7_CodUsuario[0] ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39TTBUS7_CodUsuario", A39TTBUS7_CodUsuario);
                     A33TTBUS7_Pos = H001Y11_A33TTBUS7_Pos[0] ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
                     cmbavTtbus7_pos.addItem(StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0), A34TTBUS7_Des, 0);
                     /* Exiting from a For First loop. */
                     if (true) break;
                  }
                  pr_default.close(9);
               }
               pr_default.readNext(8);
            }
            pr_default.close(8);
         }
      }

      protected void S124( )
      {
         /* 'RESPONSABLES' Routine */
         /* Using cursor H001Y12 */
         pr_default.execute(10, new Object[] {AV26TTBUS2_RespDesde});
         while ( (pr_default.getStatus(10) != 101) )
         {
            A6USU_COD = H001Y12_A6USU_COD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
            A7USU_DES = H001Y12_A7USU_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7USU_DES", A7USU_DES);
            AV8dUSU_DES = A7USU_DES ;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(10);
         /* Using cursor H001Y13 */
         pr_default.execute(11, new Object[] {AV27TTBUS2_RespHacia});
         while ( (pr_default.getStatus(11) != 101) )
         {
            A6USU_COD = H001Y13_A6USU_COD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
            A7USU_DES = H001Y13_A7USU_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7USU_DES", A7USU_DES);
            AV11hUSU_DES = A7USU_DES ;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(11);
      }

      protected void E111Y2( )
      {
         /* 'Buscar' Routine */
         AV22TTBUS_Descripcion = "%" + StringUtil.Trim( AV10fTTBUS_Descripcion) + "%" ;
      }

      public void GXEnter( )
      {
         /* Execute user event: E161Y2 */
         E161Y2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E161Y2( )
      {
         /* Enter Routine */
         AV14pTTBUS_Id = A11TTBUS_Id ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14pTTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14pTTBUS_Id), 8, 0)));
         context.setWebReturnParms(new Object[] {(int)AV14pTTBUS_Id});
         context.nUserReturn = 1 ;
         returnInSub = true;
         if (true) return;
      }

      protected void wb_table1_2_1Y2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            sStyleString = sStyleString + " height: " + StringUtil.LTrim( StringUtil.Str( (decimal)(57), 10, 0)) + "px" + ";" ;
            sStyleString = sStyleString + " width: " + StringUtil.LTrim( StringUtil.Str( (decimal)(824), 10, 0)) + "px" + ";" ;
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
            wb_table2_8_1Y2( true) ;
         }
         else
         {
            wb_table2_8_1Y2( false) ;
         }
         return  ;
      }

      protected void wb_table2_8_1Y2e( bool wbgen )
      {
         if ( wbgen )
         {
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
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "N� Bien") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Descripci�n") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Fecha Carga") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "C�d. Rubro del bien") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Desc. Rubro del bien") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Fecha Baja") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Alquilado") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Proveedor") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Proveedor") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" width="+StringUtil.LTrim( StringUtil.Str( (decimal)(150), 4, 0))+"px"+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Estado") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Cod. Posici�n Actual Bien") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Posici�n Actual") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "SEC_ CRE") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" width="+StringUtil.LTrim( StringUtil.Str( (decimal)(150), 4, 0))+"px"+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Responsable Actual") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "ID") ;
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
               Grid1Column.AddObjectProperty("Value", context.convertURL( AV31visualizacion));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A11TTBUS_Id), 8, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A12TTBUS_Descripcion));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", context.localUtil.Format(A13TTBUS_FechaCarga, "99/99/9999"));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A17TTBUS_RubroBien), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A18TTBUS_RubroDesc));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", context.localUtil.Format(A16TTBUS_FechaBaja, "99/99/9999"));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A29TTBUS_Alquilado), 1, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A27TTBUS_CodProveedor), 8, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A30TTBUS_DesProveedor));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A23TTBUS_Estado), 1, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A37TTBUS_CodPosicion), 3, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A38TTBUS_DesPosicion));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( AV16SEC_CRE));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavSec_cre_Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( AV17SEC_DRE));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavSec_dre_Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A10HARDWARE_ID), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Allowselection", "true");
               Grid1Container.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Selectioncolor), 9, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowhover", "true");
               Grid1Container.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Hoveringcolor), 9, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowcollapsing", "false");
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 9, 0, ".", "")));
            }
         }
         if ( wbEnd == 49 )
         {
            wbEnd = 0 ;
            nRC_Grid1 = (short)(nGXsfl_49_idx-1) ;
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
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "left")+";height:24px\">") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttButton1_Internalname, "Ver Movimientos del Bien", "Ver Movimientos del Bien", "", StyleString, ClassString, 1, 1, "rounded", 5, bttButton1_Jsonclick, "E\\'MOVIMIENTOS\\'.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(49), 3, 0)+","+"null"+");", "", "HLP_HTBUS030_.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_1Y2e( true) ;
         }
         else
         {
            wb_table1_2_1Y2e( false) ;
         }
      }

      protected void wb_table2_8_1Y2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            sStyleString = sStyleString + " height: " + StringUtil.LTrim( StringUtil.Str( (decimal)(36), 10, 0)) + "px" + ";" ;
            sStyleString = sStyleString + " width: " + StringUtil.LTrim( StringUtil.Str( (decimal)(191), 10, 0)) + "px" + ";" ;
            GxWebStd.gx_table_start( context, tblTable3_Internalname, tblTable3_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, 1, 1, 0, "N� Bien:", "", "", "", 0, lblTextblock1_Jsonclick, "", StyleString, ClassString, "HLP_HTBUS030_.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'" + sGXsfl_49_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavTtbus_id_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV25TTBUS_Id), 8, 0, ",", "")), "", 8, "chr", 1, "row", 8, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(AV25TTBUS_Id), "ZZZZZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(13);\"", 0, edtavTtbus_id_Jsonclick, "", 0, 1, -1, true, "right", "HLP_HTBUS030_.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock5_Internalname, 1, 1, 0, "Descripci�n:", "", "", "", 0, lblTextblock5_Jsonclick, "", StyleString, ClassString, "HLP_HTBUS030_.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'" + sGXsfl_49_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavFttbus_descripcion_Internalname, StringUtil.RTrim( AV10fTTBUS_Descripcion), "", 50, "chr", 1, "row", 50, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV10fTTBUS_Descripcion, "@!")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(18);\"", 0, edtavFttbus_descripcion_Jsonclick, "", 0, 1, 0, true, "left", "HLP_HTBUS030_.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock2_Internalname, 1, 1, 0, "Rubro:", "", "", "", 0, lblTextblock2_Jsonclick, "", StyleString, ClassString, "HLP_HTBUS030_.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'" + sGXsfl_49_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavTtbus_rubrobien_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV34TTBUS_RubroBien), 4, 0, ",", "")), "", 4, "chr", 1, "row", 4, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(AV34TTBUS_RubroBien), "ZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(23);\"", 0, edtavTtbus_rubrobien_Jsonclick, "", 0, 1, -1, true, "right", "HLP_HTBUS030_.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock4_Internalname, 1, 1, 0, "Posici�n:", "", "", "", 0, lblTextblock4_Jsonclick, "", StyleString, ClassString, "HLP_HTBUS030_.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 28,'',false,'" + sGXsfl_49_idx + "',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavTtbus7_pos, cmbavTtbus7_pos_Internalname, StringUtil.Str( (decimal)(AV29TTBUS7_Pos), 3, 0), "", "int", 1, 1, 0, 1, 0, 3, "chr", 0, "", StyleString, ClassString, "", 0, cmbavTtbus7_pos_Jsonclick, "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(28);\"", true, "HLP_HTBUS030_.htm");
            cmbavTtbus7_pos.CurrentValue = StringUtil.Str( (decimal)(AV29TTBUS7_Pos), 3, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavTtbus7_pos_Internalname, "Values", (String)(cmbavTtbus7_pos.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "&nbsp;&nbsp; ") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock6_Internalname, 1, 1, 0, "Fecha de Carga:", "", "", "", 0, lblTextblock6_Jsonclick, "", StyleString, ClassString, "HLP_HTBUS030_.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 33,'',false,'" + sGXsfl_49_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtavTtbus_fechacarga_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavTtbus_fechacarga_Internalname, context.localUtil.Format(AV24TTBUS_FechaCarga, "99/99/9999"), "", 10, "chr", 1, "row", 10, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( AV24TTBUS_FechaCarga, "99/99/9999"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',0,24,'spa',false,0);"+";gx.evt.onblur(33);\"", 0, edtavTtbus_fechacarga_Jsonclick, "", 0, 1, -1, true, "right", "HLP_HTBUS030_.htm");
            GxWebStd.gx_bitmap( context, edtavTtbus_fechacarga_Internalname+"_dp_trigger", "", "calendar-img.gif", "", ((1==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, "", "", 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_HTBUS030_.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "&nbsp;&nbsp; ") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 40,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttButton3_Internalname, "Buscar", "Buscar", "", StyleString, ClassString, 1, 1, "rounded", 5, bttButton3_Jsonclick, "E\\'BUSCAR\\'.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(49), 3, 0)+","+"null"+");", "", "HLP_HTBUS030_.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_8_1Y2e( true) ;
         }
         else
         {
            wb_table2_8_1Y2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV14pTTBUS_Id = Convert.ToInt32(getParm(obj,0)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14pTTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14pTTBUS_Id), 8, 0)));
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
         PA1Y2( ) ;
         WS1Y2( ) ;
         WE1Y2( ) ;
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
         AddThemeStyleSheetFile("", "Modern.css", "?19542497");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?11185957");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("htbus030_.js", "?11185957");
         /* End function include_jscripts */
      }

      protected void sendrow_492( )
      {
         WB1Y0( ) ;
         if ( ( 10 * 1 == 0 ) || ( nGXsfl_49_idx <= subGrid1_Recordsperpage( ) * 1 ) )
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
               if ( ((int)(nGXsfl_49_idx) % (2)) == 0 )
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
            /* Active Bitmap Variable */
            TempTags = " " + ((edtavVisualizacion_Enabled!=0)&&(edtavVisualizacion_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 50,'',false,'',49)\"" : " ") ;
            ClassString = "Image" ;
            StyleString = "" ;
            Grid1Row.AddColumnProperties("bitmap", 2, isAjaxCallMode( ), new Object[] {(String)edtavVisualizacion_Internalname,(String)"",(String)AV31visualizacion,(String)"Modern",(short)-1,(short)1,(String)"",(String)"Visualizaci�n",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"",(short)0,(short)0,(String)"",(String)"",(short)5,(String)edtavVisualizacion_Jsonclick,"E\\'VISUALIZACION\\'."+sGXsfl_49_idx,(String)StyleString,(String)ClassString,(String)"",(String)""+TempTags,(String)"''",(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS_Id_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A11TTBUS_Id), 8, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)8,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A11TTBUS_Id), "ZZZZZZZ9"),(String)"",(short)5,(String)edtTTBUS_Id_Jsonclick,"EENTER."+sGXsfl_49_idx,(short)49,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS_Descripcion_Internalname,StringUtil.RTrim( A12TTBUS_Descripcion),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)50,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A12TTBUS_Descripcion, "@!")),(String)"",(short)0,(String)edtTTBUS_Descripcion_Jsonclick,(String)"",(short)49,(short)1,(short)0,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS_FechaCarga_Internalname,context.localUtil.Format(A13TTBUS_FechaCarga, "99/99/9999"),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)10,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( A13TTBUS_FechaCarga, "99/99/9999"),(String)"",(short)0,(String)edtTTBUS_FechaCarga_Jsonclick,(String)"",(short)49,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS_RubroBien_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A17TTBUS_RubroBien), 4, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)4,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A17TTBUS_RubroBien), "ZZZ9"),(String)"",(short)0,(String)edtTTBUS_RubroBien_Jsonclick,(String)"",(short)49,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS_RubroDesc_Internalname,StringUtil.RTrim( A18TTBUS_RubroDesc),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)30,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A18TTBUS_RubroDesc, "@!")),(String)"",(short)0,(String)edtTTBUS_RubroDesc_Jsonclick,(String)"",(short)49,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS_FechaBaja_Internalname,context.localUtil.Format(A16TTBUS_FechaBaja, "99/99/9999"),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)10,(short)0,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( A16TTBUS_FechaBaja, "99/99/9999"),(String)"",(short)0,(String)edtTTBUS_FechaBaja_Jsonclick,(String)"",(short)49,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Check box */
            ClassString = "Attribute" ;
            StyleString = "" ;
            Grid1Row.AddColumnProperties("checkbox", 1, isAjaxCallMode( ), new Object[] {(String)chkTTBUS_Alquilado_Internalname,StringUtil.Str( (decimal)(A29TTBUS_Alquilado), 1, 0),(String)"",(short)-1,(short)0,(String)"1",(String)"",(String)StyleString,(String)ClassString,(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS_CodProveedor_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A27TTBUS_CodProveedor), 8, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)8,(short)0,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A27TTBUS_CodProveedor), "ZZZZZ9"),(String)"",(short)0,(String)edtTTBUS_CodProveedor_Jsonclick,(String)"",(short)49,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS_DesProveedor_Internalname,StringUtil.RTrim( A30TTBUS_DesProveedor),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)30,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A30TTBUS_DesProveedor, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")),(String)"",(short)0,(String)edtTTBUS_DesProveedor_Jsonclick,(String)"",(short)49,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            ClassString = "Attribute" ;
            StyleString = "" ;
            if ( ( nGXsfl_49_idx == 1 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "TTBUS_ESTADO_" + sGXsfl_49_idx ;
               cmbTTBUS_Estado.Name = GXCCtl ;
               cmbTTBUS_Estado.WebTags = "" ;
               cmbTTBUS_Estado.addItem("1", "ASIGNADO A UN SECTOR", 0);
               cmbTTBUS_Estado.addItem("2", "CAMBIANDO DE SECTOR", 0);
               cmbTTBUS_Estado.addItem("3", "BAJA A CONFIRMAR", 0);
               cmbTTBUS_Estado.addItem("4", "BAJA", 0);
               if ( ( cmbTTBUS_Estado.ItemCount > 0 ) && (0==A23TTBUS_Estado) )
               {
                  A23TTBUS_Estado = (short)(NumberUtil.Val( cmbTTBUS_Estado.getItemValue(1), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23TTBUS_Estado", StringUtil.Str( (decimal)(A23TTBUS_Estado), 1, 0));
               }
            }
            /* ComboBox */
            Grid1Row.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbTTBUS_Estado,(String)cmbTTBUS_Estado_Internalname,StringUtil.Str( (decimal)(A23TTBUS_Estado), 1, 0),(String)"",(String)"int",(short)-1,(short)0,(short)0,(short)1,(short)0,(short)150,(String)"px",(short)0,(String)"",(String)StyleString,(String)ClassString,(String)"",(short)0,(String)cmbTTBUS_Estado_Jsonclick,(String)"",(String)"",(bool)true});
            cmbTTBUS_Estado.CurrentValue = StringUtil.Str( (decimal)(A23TTBUS_Estado), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbTTBUS_Estado_Internalname, "Values", (String)(cmbTTBUS_Estado.ToJavascriptSource()));
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS_CodPosicion_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A37TTBUS_CodPosicion), 3, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)3,(short)0,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A37TTBUS_CodPosicion), "ZZ9"),(String)"",(short)0,(String)edtTTBUS_CodPosicion_Jsonclick,(String)"",(short)49,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS_DesPosicion_Internalname,StringUtil.RTrim( A38TTBUS_DesPosicion),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)50,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A38TTBUS_DesPosicion, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")),(String)"",(short)0,(String)edtTTBUS_DesPosicion_Jsonclick,(String)"",(short)49,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            TempTags = " " + ((edtavSec_cre_Enabled!=0)&&(edtavSec_cre_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 63,'',false,'"+sGXsfl_49_idx+"',49)\"" : " ") ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavSec_cre_Internalname,StringUtil.RTrim( AV16SEC_CRE),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)15,(short)0,(int)edtavSec_cre_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( AV16SEC_CRE, "XXXXXXXXXXXXXXX")),TempTags+((edtavSec_cre_Enabled!=0)&&(edtavSec_cre_Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((edtavSec_cre_Enabled!=0)&&(edtavSec_cre_Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(63);\"" : " "),(short)0,(String)edtavSec_cre_Jsonclick,(String)"",(short)49,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            TempTags = " " + ((edtavSec_dre_Enabled!=0)&&(edtavSec_dre_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 64,'',false,'"+sGXsfl_49_idx+"',49)\"" : " ") ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavSec_dre_Internalname,StringUtil.RTrim( AV17SEC_DRE),(String)"",(short)150,(String)"px",(short)17,(String)"",(short)50,(short)-1,(int)edtavSec_dre_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( AV17SEC_DRE, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")),TempTags+((edtavSec_dre_Enabled!=0)&&(edtavSec_dre_Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((edtavSec_dre_Enabled!=0)&&(edtavSec_dre_Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(64);\"" : " "),(short)0,(String)edtavSec_dre_Jsonclick,(String)"",(short)49,(short)1,(short)-1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtHARDWARE_ID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A10HARDWARE_ID), 4, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)4,(short)0,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A10HARDWARE_ID), "ZZZ9"),(String)"",(short)0,(String)edtHARDWARE_ID_Jsonclick,(String)"",(short)49,(short)1,(short)1,(bool)true,(String)"right"});
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_49_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_49_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_49_idx+1)) ;
            sGXsfl_49_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_49_idx), 4, 0)), 4, "0") ;
            edtavVisualizacion_Internalname = "vVISUALIZACION_"+sGXsfl_49_idx ;
            edtTTBUS_Id_Internalname = "TTBUS_ID_"+sGXsfl_49_idx ;
            edtTTBUS_Descripcion_Internalname = "TTBUS_DESCRIPCION_"+sGXsfl_49_idx ;
            edtTTBUS_FechaCarga_Internalname = "TTBUS_FECHACARGA_"+sGXsfl_49_idx ;
            edtTTBUS_RubroBien_Internalname = "TTBUS_RUBROBIEN_"+sGXsfl_49_idx ;
            edtTTBUS_RubroDesc_Internalname = "TTBUS_RUBRODESC_"+sGXsfl_49_idx ;
            edtTTBUS_FechaBaja_Internalname = "TTBUS_FECHABAJA_"+sGXsfl_49_idx ;
            chkTTBUS_Alquilado_Internalname = "TTBUS_ALQUILADO_"+sGXsfl_49_idx ;
            edtTTBUS_CodProveedor_Internalname = "TTBUS_CODPROVEEDOR_"+sGXsfl_49_idx ;
            edtTTBUS_DesProveedor_Internalname = "TTBUS_DESPROVEEDOR_"+sGXsfl_49_idx ;
            cmbTTBUS_Estado_Internalname = "TTBUS_ESTADO_"+sGXsfl_49_idx ;
            edtTTBUS_CodPosicion_Internalname = "TTBUS_CODPOSICION_"+sGXsfl_49_idx ;
            edtTTBUS_DesPosicion_Internalname = "TTBUS_DESPOSICION_"+sGXsfl_49_idx ;
            edtavSec_cre_Internalname = "vSEC_CRE_"+sGXsfl_49_idx ;
            edtavSec_dre_Internalname = "vSEC_DRE_"+sGXsfl_49_idx ;
            edtHARDWARE_ID_Internalname = "HARDWARE_ID_"+sGXsfl_49_idx ;
         }
         /* End function sendrow_492 */
      }

      protected void init_default_properties( )
      {
         lblTextblock1_Internalname = "TEXTBLOCK1" ;
         edtavTtbus_id_Internalname = "vTTBUS_ID" ;
         lblTextblock5_Internalname = "TEXTBLOCK5" ;
         edtavFttbus_descripcion_Internalname = "vFTTBUS_DESCRIPCION" ;
         lblTextblock2_Internalname = "TEXTBLOCK2" ;
         edtavTtbus_rubrobien_Internalname = "vTTBUS_RUBROBIEN" ;
         lblTextblock4_Internalname = "TEXTBLOCK4" ;
         cmbavTtbus7_pos_Internalname = "vTTBUS7_POS" ;
         lblTextblock6_Internalname = "TEXTBLOCK6" ;
         edtavTtbus_fechacarga_Internalname = "vTTBUS_FECHACARGA" ;
         bttButton3_Internalname = "BUTTON3" ;
         tblTable3_Internalname = "TABLE3" ;
         bttButton1_Internalname = "BUTTON1" ;
         tblTable1_Internalname = "TABLE1" ;
         Form.Internalname = "FORM" ;
         subGrid1_Internalname = "GRID1" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         edtHARDWARE_ID_Jsonclick = "" ;
         edtavSec_dre_Jsonclick = "" ;
         edtavSec_dre_Visible = -1 ;
         edtavSec_cre_Jsonclick = "" ;
         edtavSec_cre_Visible = 0 ;
         edtTTBUS_DesPosicion_Jsonclick = "" ;
         edtTTBUS_CodPosicion_Jsonclick = "" ;
         cmbTTBUS_Estado_Jsonclick = "" ;
         edtTTBUS_DesProveedor_Jsonclick = "" ;
         edtTTBUS_CodProveedor_Jsonclick = "" ;
         edtTTBUS_FechaBaja_Jsonclick = "" ;
         edtTTBUS_RubroDesc_Jsonclick = "" ;
         edtTTBUS_RubroBien_Jsonclick = "" ;
         edtTTBUS_FechaCarga_Jsonclick = "" ;
         edtTTBUS_Descripcion_Jsonclick = "" ;
         edtTTBUS_Id_Jsonclick = "" ;
         edtavVisualizacion_Jsonclick = "" ;
         edtavVisualizacion_Visible = -1 ;
         edtavVisualizacion_Enabled = 1 ;
         edtavTtbus_fechacarga_Jsonclick = "" ;
         cmbavTtbus7_pos_Jsonclick = "" ;
         edtavTtbus_rubrobien_Jsonclick = "" ;
         edtavFttbus_descripcion_Jsonclick = "" ;
         edtavTtbus_id_Jsonclick = "" ;
         subGrid1_Hoveringcolor = (int)(0x00C0C0) ;
         subGrid1_Selectioncolor = (int)(0x80FFFF) ;
         edtavSec_cre_Enabled = 1 ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 3 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Consulta de Trazabilidad de Bienes de Uso" ;
         chkTTBUS_Alquilado.Caption = "" ;
         edtavSec_dre_Enabled = 1 ;
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
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         A12TTBUS_Descripcion = "" ;
         edtavSec_dre_Internalname = "" ;
         edtavSec_cre_Internalname = "" ;
         GXCCtl = "" ;
         chkTTBUS_Alquilado_Internalname = "" ;
         AV10fTTBUS_Descripcion = "" ;
         AV24TTBUS_FechaCarga = DateTime.MinValue ;
         A7USU_DES = "" ;
         A6USU_COD = "" ;
         A25TTBUS2_RespHacia = "" ;
         A24TTBUS2_RespDesde = "" ;
         A36TTBUS7_DesResp = "" ;
         A35TTBUS7_CodResp = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         GX_FocusControl = "" ;
         Form = new GXWebForm();
         sPrefix = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         edtavVisualizacion_Internalname = "" ;
         edtTTBUS_Id_Internalname = "" ;
         edtTTBUS_Descripcion_Internalname = "" ;
         edtTTBUS_FechaCarga_Internalname = "" ;
         edtTTBUS_RubroBien_Internalname = "" ;
         edtTTBUS_RubroDesc_Internalname = "" ;
         edtTTBUS_FechaBaja_Internalname = "" ;
         edtTTBUS_CodProveedor_Internalname = "" ;
         edtTTBUS_DesProveedor_Internalname = "" ;
         cmbTTBUS_Estado_Internalname = "" ;
         edtTTBUS_CodPosicion_Internalname = "" ;
         edtTTBUS_DesPosicion_Internalname = "" ;
         edtHARDWARE_ID_Internalname = "" ;
         AV31visualizacion = "" ;
         A13TTBUS_FechaCarga = DateTime.MinValue ;
         A18TTBUS_RubroDesc = "" ;
         A16TTBUS_FechaBaja = DateTime.MinValue ;
         A30TTBUS_DesProveedor = "" ;
         A38TTBUS_DesPosicion = "" ;
         AV16SEC_CRE = "" ;
         AV17SEC_DRE = "" ;
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxwrpcisep = "" ;
         scmdbuf = "" ;
         l12TTBUS_Descripcion = "" ;
         H001Y2_A12TTBUS_Descripcion = new String[] {""} ;
         H001Y3_A12TTBUS_Descripcion = new String[] {""} ;
         Grid1Container = new GXWebGrid( context);
         AV22TTBUS_Descripcion = "" ;
         lV22TTBUS_Descripcion = "" ;
         H001Y4_A11TTBUS_Id = new int[1] ;
         H001Y4_A37TTBUS_CodPosicion = new short[1] ;
         H001Y4_A10HARDWARE_ID = new short[1] ;
         H001Y4_n10HARDWARE_ID = new bool[] {false} ;
         H001Y4_A38TTBUS_DesPosicion = new String[] {""} ;
         H001Y4_A23TTBUS_Estado = new short[1] ;
         H001Y4_A30TTBUS_DesProveedor = new String[] {""} ;
         H001Y4_A27TTBUS_CodProveedor = new int[1] ;
         H001Y4_n27TTBUS_CodProveedor = new bool[] {false} ;
         H001Y4_A29TTBUS_Alquilado = new short[1] ;
         H001Y4_A16TTBUS_FechaBaja = new DateTime[] {DateTime.MinValue} ;
         H001Y4_n16TTBUS_FechaBaja = new bool[] {false} ;
         H001Y4_A18TTBUS_RubroDesc = new String[] {""} ;
         H001Y4_n18TTBUS_RubroDesc = new bool[] {false} ;
         H001Y4_A17TTBUS_RubroBien = new short[1] ;
         H001Y4_A13TTBUS_FechaCarga = new DateTime[] {DateTime.MinValue} ;
         H001Y4_A12TTBUS_Descripcion = new String[] {""} ;
         H001Y5_AGRID1_nRecordCount = new int[1] ;
         AV7Context = new SdtContext(context);
         AV30USUARIO = "" ;
         AV18SESION = new GxWebSession( context);
         AV23TTBUS_Estado = 1 ;
         AV19SISTEMA = "" ;
         H001Y6_A33TTBUS7_Pos = new short[1] ;
         H001Y6_A35TTBUS7_CodResp = new String[] {""} ;
         H001Y6_A36TTBUS7_DesResp = new String[] {""} ;
         H001Y6_n36TTBUS7_DesResp = new bool[] {false} ;
         H001Y7_A52TTBUS2_IdMovimiento = new long[1] ;
         H001Y7_A22TTBUS2_IdBien = new int[1] ;
         H001Y7_A26TTBUS2_EstadoEnvio = new short[1] ;
         H001Y7_A24TTBUS2_RespDesde = new String[] {""} ;
         H001Y7_A25TTBUS2_RespHacia = new String[] {""} ;
         AV26TTBUS2_RespDesde = "" ;
         AV27TTBUS2_RespHacia = "" ;
         AV8dUSU_DES = "" ;
         AV11hUSU_DES = "" ;
         H001Y8_A40TTBUS8_CodUsuario = new String[] {""} ;
         A40TTBUS8_CodUsuario = "" ;
         H001Y9_A34TTBUS7_Des = new String[] {""} ;
         H001Y9_n34TTBUS7_Des = new bool[] {false} ;
         H001Y9_A33TTBUS7_Pos = new short[1] ;
         A34TTBUS7_Des = "" ;
         H001Y10_A34TTBUS7_Des = new String[] {""} ;
         H001Y10_n34TTBUS7_Des = new bool[] {false} ;
         H001Y10_A35TTBUS7_CodResp = new String[] {""} ;
         H001Y10_A33TTBUS7_Pos = new short[1] ;
         H001Y11_A39TTBUS7_CodUsuario = new String[] {""} ;
         H001Y11_A33TTBUS7_Pos = new short[1] ;
         A39TTBUS7_CodUsuario = "" ;
         H001Y12_A6USU_COD = new String[] {""} ;
         H001Y12_A7USU_DES = new String[] {""} ;
         H001Y13_A6USU_COD = new String[] {""} ;
         H001Y13_A7USU_DES = new String[] {""} ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         subGrid1_Linesclass = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
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
         bttButton1_Jsonclick = "" ;
         lblTextblock1_Jsonclick = "" ;
         lblTextblock5_Jsonclick = "" ;
         lblTextblock2_Jsonclick = "" ;
         lblTextblock4_Jsonclick = "" ;
         lblTextblock6_Jsonclick = "" ;
         GXt_char15 = "" ;
         bttButton3_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         ROClassString = "" ;
         GXt_char16 = "" ;
         GXt_char17 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.htbus030___default(),
            new Object[][] {
                new Object[] {
               H001Y2_A12TTBUS_Descripcion
               }
               , new Object[] {
               H001Y3_A12TTBUS_Descripcion
               }
               , new Object[] {
               H001Y4_A11TTBUS_Id, H001Y4_A37TTBUS_CodPosicion, H001Y4_A10HARDWARE_ID, H001Y4_n10HARDWARE_ID, H001Y4_A38TTBUS_DesPosicion, H001Y4_A23TTBUS_Estado, H001Y4_A30TTBUS_DesProveedor, H001Y4_A27TTBUS_CodProveedor, H001Y4_n27TTBUS_CodProveedor, H001Y4_A29TTBUS_Alquilado,
               H001Y4_A16TTBUS_FechaBaja, H001Y4_n16TTBUS_FechaBaja, H001Y4_A18TTBUS_RubroDesc, H001Y4_n18TTBUS_RubroDesc, H001Y4_A17TTBUS_RubroBien, H001Y4_A13TTBUS_FechaCarga, H001Y4_A12TTBUS_Descripcion
               }
               , new Object[] {
               H001Y5_AGRID1_nRecordCount
               }
               , new Object[] {
               H001Y6_A33TTBUS7_Pos, H001Y6_A35TTBUS7_CodResp, H001Y6_A36TTBUS7_DesResp, H001Y6_n36TTBUS7_DesResp
               }
               , new Object[] {
               H001Y7_A52TTBUS2_IdMovimiento, H001Y7_A22TTBUS2_IdBien, H001Y7_A26TTBUS2_EstadoEnvio, H001Y7_A24TTBUS2_RespDesde, H001Y7_A25TTBUS2_RespHacia
               }
               , new Object[] {
               H001Y8_A40TTBUS8_CodUsuario
               }
               , new Object[] {
               H001Y9_A34TTBUS7_Des, H001Y9_n34TTBUS7_Des, H001Y9_A33TTBUS7_Pos
               }
               , new Object[] {
               H001Y10_A34TTBUS7_Des, H001Y10_n34TTBUS7_Des, H001Y10_A35TTBUS7_CodResp, H001Y10_A33TTBUS7_Pos
               }
               , new Object[] {
               H001Y11_A39TTBUS7_CodUsuario, H001Y11_A33TTBUS7_Pos
               }
               , new Object[] {
               H001Y12_A6USU_COD, H001Y12_A7USU_DES
               }
               , new Object[] {
               H001Y13_A6USU_COD, H001Y13_A7USU_DES
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
         edtavSec_cre_Enabled = 0 ;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_Grid1 ;
      private short nGXsfl_49_idx=1 ;
      private short AV29TTBUS7_Pos ;
      private short A23TTBUS_Estado ;
      private short AV34TTBUS_RubroBien ;
      private short A33TTBUS7_Pos ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short GRID1_nEOF ;
      private short wbEnd ;
      private short wbStart ;
      private short A17TTBUS_RubroBien ;
      private short A29TTBUS_Alquilado ;
      private short A37TTBUS_CodPosicion ;
      private short A10HARDWARE_ID ;
      private short nDonePA ;
      private short subGrid1_Rows ;
      private short AV12inicio ;
      private short AV23TTBUS_Estado ;
      private short A26TTBUS2_EstadoEnvio ;
      private short AV6band ;
      private short AV32vTTBUS7_Pos ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short subGrid1_Collapsed ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int edtavSec_dre_Enabled ;
      private int Grid1_PageSize49 ;
      private int edtavSec_cre_Enabled ;
      private int AV25TTBUS_Id ;
      private int AV14pTTBUS_Id ;
      private int GRID1_nFirstRecordOnPage ;
      private int A11TTBUS_Id ;
      private int A27TTBUS_CodProveedor ;
      private int gxdynajaxindex ;
      private int subGrid1_Islastpage ;
      private int GRID1_nCurrentRecord ;
      private int GRID1_nRecordCount ;
      private int A22TTBUS2_IdBien ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int subGrid1_Selectioncolor ;
      private int subGrid1_Hoveringcolor ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private int edtavVisualizacion_Enabled ;
      private int edtavVisualizacion_Visible ;
      private int edtavSec_cre_Visible ;
      private int edtavSec_dre_Visible ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_49_idx="0001" ;
      private String edtavSec_dre_Internalname ;
      private String edtavSec_cre_Internalname ;
      private String GXCCtl ;
      private String chkTTBUS_Alquilado_Internalname ;
      private String A7USU_DES ;
      private String A6USU_COD ;
      private String A25TTBUS2_RespHacia ;
      private String A24TTBUS2_RespDesde ;
      private String A36TTBUS7_DesResp ;
      private String A35TTBUS7_CodResp ;
      private String sDynURL ;
      private String FormProcess ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavVisualizacion_Internalname ;
      private String edtTTBUS_Id_Internalname ;
      private String edtTTBUS_Descripcion_Internalname ;
      private String edtTTBUS_FechaCarga_Internalname ;
      private String edtTTBUS_RubroBien_Internalname ;
      private String edtTTBUS_RubroDesc_Internalname ;
      private String edtTTBUS_FechaBaja_Internalname ;
      private String edtTTBUS_CodProveedor_Internalname ;
      private String edtTTBUS_DesProveedor_Internalname ;
      private String cmbTTBUS_Estado_Internalname ;
      private String edtTTBUS_CodPosicion_Internalname ;
      private String edtTTBUS_DesPosicion_Internalname ;
      private String edtHARDWARE_ID_Internalname ;
      private String A18TTBUS_RubroDesc ;
      private String A30TTBUS_DesProveedor ;
      private String A38TTBUS_DesPosicion ;
      private String AV16SEC_CRE ;
      private String AV17SEC_DRE ;
      private String edtavTtbus_id_Internalname ;
      private String gxwrpcisep ;
      private String scmdbuf ;
      private String edtavFttbus_descripcion_Internalname ;
      private String edtavTtbus_rubrobien_Internalname ;
      private String cmbavTtbus7_pos_Internalname ;
      private String edtavTtbus_fechacarga_Internalname ;
      private String subGrid1_Internalname ;
      private String AV30USUARIO ;
      private String AV19SISTEMA ;
      private String AV26TTBUS2_RespDesde ;
      private String AV27TTBUS2_RespHacia ;
      private String AV8dUSU_DES ;
      private String AV11hUSU_DES ;
      private String A40TTBUS8_CodUsuario ;
      private String A34TTBUS7_Des ;
      private String A39TTBUS7_CodUsuario ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String GXt_char3 ;
      private String GXt_char2 ;
      private String GXt_char1 ;
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
      private String bttButton1_Internalname ;
      private String bttButton1_Jsonclick ;
      private String tblTable3_Internalname ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
      private String edtavTtbus_id_Jsonclick ;
      private String lblTextblock5_Internalname ;
      private String lblTextblock5_Jsonclick ;
      private String edtavFttbus_descripcion_Jsonclick ;
      private String lblTextblock2_Internalname ;
      private String lblTextblock2_Jsonclick ;
      private String edtavTtbus_rubrobien_Jsonclick ;
      private String lblTextblock4_Internalname ;
      private String lblTextblock4_Jsonclick ;
      private String cmbavTtbus7_pos_Jsonclick ;
      private String lblTextblock6_Internalname ;
      private String lblTextblock6_Jsonclick ;
      private String edtavTtbus_fechacarga_Jsonclick ;
      private String GXt_char15 ;
      private String bttButton3_Internalname ;
      private String bttButton3_Jsonclick ;
      private String edtavVisualizacion_Jsonclick ;
      private String ROClassString ;
      private String edtTTBUS_Id_Jsonclick ;
      private String edtTTBUS_Descripcion_Jsonclick ;
      private String edtTTBUS_FechaCarga_Jsonclick ;
      private String edtTTBUS_RubroBien_Jsonclick ;
      private String edtTTBUS_RubroDesc_Jsonclick ;
      private String edtTTBUS_FechaBaja_Jsonclick ;
      private String edtTTBUS_CodProveedor_Jsonclick ;
      private String edtTTBUS_DesProveedor_Jsonclick ;
      private String cmbTTBUS_Estado_Jsonclick ;
      private String edtTTBUS_CodPosicion_Jsonclick ;
      private String edtTTBUS_DesPosicion_Jsonclick ;
      private String edtavSec_cre_Jsonclick ;
      private String GXt_char16 ;
      private String edtavSec_dre_Jsonclick ;
      private String edtHARDWARE_ID_Jsonclick ;
      private String GXt_char17 ;
      private DateTime AV24TTBUS_FechaCarga ;
      private DateTime A13TTBUS_FechaCarga ;
      private DateTime A16TTBUS_FechaBaja ;
      private bool entryPointCalled ;
      private bool n36TTBUS7_DesResp ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n18TTBUS_RubroDesc ;
      private bool n16TTBUS_FechaBaja ;
      private bool n27TTBUS_CodProveedor ;
      private bool n10HARDWARE_ID ;
      private bool returnInSub ;
      private bool n34TTBUS7_Des ;
      private String A12TTBUS_Descripcion ;
      private String AV10fTTBUS_Descripcion ;
      private String l12TTBUS_Descripcion ;
      private String AV22TTBUS_Descripcion ;
      private String lV22TTBUS_Descripcion ;
      private String AV31visualizacion ;
      private GxWebSession AV18SESION ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbavTtbus7_pos ;
      private GXCheckbox chkTTBUS_Alquilado ;
      private GXCombobox cmbTTBUS_Estado ;
      private IDataStoreProvider pr_default ;
      private String[] H001Y2_A12TTBUS_Descripcion ;
      private String[] H001Y3_A12TTBUS_Descripcion ;
      private int[] H001Y4_A11TTBUS_Id ;
      private short[] H001Y4_A37TTBUS_CodPosicion ;
      private short[] H001Y4_A10HARDWARE_ID ;
      private bool[] H001Y4_n10HARDWARE_ID ;
      private String[] H001Y4_A38TTBUS_DesPosicion ;
      private short[] H001Y4_A23TTBUS_Estado ;
      private String[] H001Y4_A30TTBUS_DesProveedor ;
      private int[] H001Y4_A27TTBUS_CodProveedor ;
      private bool[] H001Y4_n27TTBUS_CodProveedor ;
      private short[] H001Y4_A29TTBUS_Alquilado ;
      private DateTime[] H001Y4_A16TTBUS_FechaBaja ;
      private bool[] H001Y4_n16TTBUS_FechaBaja ;
      private String[] H001Y4_A18TTBUS_RubroDesc ;
      private bool[] H001Y4_n18TTBUS_RubroDesc ;
      private short[] H001Y4_A17TTBUS_RubroBien ;
      private DateTime[] H001Y4_A13TTBUS_FechaCarga ;
      private String[] H001Y4_A12TTBUS_Descripcion ;
      private int[] H001Y5_AGRID1_nRecordCount ;
      private short[] H001Y6_A33TTBUS7_Pos ;
      private String[] H001Y6_A35TTBUS7_CodResp ;
      private String[] H001Y6_A36TTBUS7_DesResp ;
      private bool[] H001Y6_n36TTBUS7_DesResp ;
      private long[] H001Y7_A52TTBUS2_IdMovimiento ;
      private int[] H001Y7_A22TTBUS2_IdBien ;
      private short[] H001Y7_A26TTBUS2_EstadoEnvio ;
      private String[] H001Y7_A24TTBUS2_RespDesde ;
      private String[] H001Y7_A25TTBUS2_RespHacia ;
      private String[] H001Y8_A40TTBUS8_CodUsuario ;
      private String[] H001Y9_A34TTBUS7_Des ;
      private bool[] H001Y9_n34TTBUS7_Des ;
      private short[] H001Y9_A33TTBUS7_Pos ;
      private String[] H001Y10_A34TTBUS7_Des ;
      private bool[] H001Y10_n34TTBUS7_Des ;
      private String[] H001Y10_A35TTBUS7_CodResp ;
      private short[] H001Y10_A33TTBUS7_Pos ;
      private String[] H001Y11_A39TTBUS7_CodUsuario ;
      private short[] H001Y11_A33TTBUS7_Pos ;
      private String[] H001Y12_A6USU_COD ;
      private String[] H001Y12_A7USU_DES ;
      private String[] H001Y13_A6USU_COD ;
      private String[] H001Y13_A7USU_DES ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private int aP0_pTTBUS_Id ;
      private GXWebForm Form ;
      private SdtContext AV7Context ;
   }

   public class htbus030___default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H001Y4( short AV29TTBUS7_Pos ,
                                             String AV10fTTBUS_Descripcion ,
                                             DateTime AV24TTBUS_FechaCarga ,
                                             short AV34TTBUS_RubroBien ,
                                             short A37TTBUS_CodPosicion ,
                                             String A12TTBUS_Descripcion ,
                                             String AV22TTBUS_Descripcion ,
                                             DateTime A13TTBUS_FechaCarga ,
                                             short A17TTBUS_RubroBien ,
                                             DateTime A16TTBUS_FechaBaja ,
                                             short A10HARDWARE_ID ,
                                             int AV25TTBUS_Id )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int18 ;
         GXv_int18 = new short [5] ;
         Object[] GXv_Object19 ;
         GXv_Object19 = new Object [2] ;
         scmdbuf = "SELECT T1.[TTBUS_Id], T1.[TTBUS_CodPosicion], T1.[HARDWARE_ID], T1.[TTBUS_DesPosicion], T1.[TTBUS_Estado], T1.[TTBUS_DesProveedor], T1.[TTBUS_CodProveedor], T1.[TTBUS_Alquilado], T1.[TTBUS_FechaBaja], T2.[RBR_DES] AS TTBUS_RubroDesc, T1.[TTBUS_RubroBien] AS TTBUS_RubroBien, T1.[TTBUS_FechaCarga], T1.[TTBUS_Descripcion] FROM ([TTBUS000] T1 WITH (NOLOCK) INNER JOIN [BUS002] T2 WITH (NOLOCK) ON T2.[RBR_COD] = T1.[TTBUS_RubroBien])" ;
         scmdbuf = scmdbuf + " WHERE (T1.[TTBUS_Id] >= @AV25TTBUS_Id)" ;
         scmdbuf = scmdbuf + " and ((T1.[TTBUS_FechaBaja] = convert( DATETIME, '17530101', 112 )))" ;
         scmdbuf = scmdbuf + " and (T1.[HARDWARE_ID] = 0)" ;
         if ( AV29TTBUS7_Pos != -1 )
         {
            sWhereString = sWhereString + " and (T1.[TTBUS_CodPosicion] = @AV29TTBUS7_Pos)" ;
         }
         else
         {
            GXv_int18[1] = 1 ;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV10fTTBUS_Descripcion)) )
         {
            sWhereString = sWhereString + " and (T1.[TTBUS_Descripcion] like @AV22TTBUS_Descripcion)" ;
         }
         else
         {
            GXv_int18[2] = 1 ;
         }
         if ( ! (DateTime.MinValue==AV24TTBUS_FechaCarga) )
         {
            sWhereString = sWhereString + " and (T1.[TTBUS_FechaCarga] >= @AV24TTBUS_FechaCarga)" ;
         }
         else
         {
            GXv_int18[3] = 1 ;
         }
         if ( ! (0==AV34TTBUS_RubroBien) )
         {
            sWhereString = sWhereString + " and (T1.[TTBUS_RubroBien] = @AV34TTBUS_RubroBien)" ;
         }
         else
         {
            GXv_int18[4] = 1 ;
         }
         scmdbuf = scmdbuf + sWhereString ;
         scmdbuf = scmdbuf + " ORDER BY T1.[TTBUS_Id]" ;
         scmdbuf = scmdbuf + " OPTION (FAST 11)" ;
         GXv_Object19[0] = scmdbuf ;
         GXv_Object19[1] = (Object)(GXv_int18) ;
         return GXv_Object19 ;
      }

      protected Object[] conditional_H001Y5( short AV29TTBUS7_Pos ,
                                             String AV10fTTBUS_Descripcion ,
                                             DateTime AV24TTBUS_FechaCarga ,
                                             short AV34TTBUS_RubroBien ,
                                             short A37TTBUS_CodPosicion ,
                                             String A12TTBUS_Descripcion ,
                                             String AV22TTBUS_Descripcion ,
                                             DateTime A13TTBUS_FechaCarga ,
                                             short A17TTBUS_RubroBien ,
                                             DateTime A16TTBUS_FechaBaja ,
                                             short A10HARDWARE_ID ,
                                             int AV25TTBUS_Id )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int20 ;
         GXv_int20 = new short [5] ;
         Object[] GXv_Object21 ;
         GXv_Object21 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM ([TTBUS000] T1 WITH (NOLOCK) INNER JOIN [BUS002] T2 WITH (NOLOCK) ON T2.[RBR_COD] = T1.[TTBUS_RubroBien])" ;
         scmdbuf = scmdbuf + " WHERE (T1.[TTBUS_Id] >= @AV25TTBUS_Id)" ;
         scmdbuf = scmdbuf + " and ((T1.[TTBUS_FechaBaja] = convert( DATETIME, '17530101', 112 )))" ;
         scmdbuf = scmdbuf + " and (T1.[HARDWARE_ID] = 0)" ;
         if ( AV29TTBUS7_Pos != -1 )
         {
            sWhereString = sWhereString + " and (T1.[TTBUS_CodPosicion] = @AV29TTBUS7_Pos)" ;
         }
         else
         {
            GXv_int20[1] = 1 ;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV10fTTBUS_Descripcion)) )
         {
            sWhereString = sWhereString + " and (T1.[TTBUS_Descripcion] like @AV22TTBUS_Descripcion)" ;
         }
         else
         {
            GXv_int20[2] = 1 ;
         }
         if ( ! (DateTime.MinValue==AV24TTBUS_FechaCarga) )
         {
            sWhereString = sWhereString + " and (T1.[TTBUS_FechaCarga] >= @AV24TTBUS_FechaCarga)" ;
         }
         else
         {
            GXv_int20[3] = 1 ;
         }
         if ( ! (0==AV34TTBUS_RubroBien) )
         {
            sWhereString = sWhereString + " and (T1.[TTBUS_RubroBien] = @AV34TTBUS_RubroBien)" ;
         }
         else
         {
            GXv_int20[4] = 1 ;
         }
         scmdbuf = scmdbuf + sWhereString ;
         scmdbuf = scmdbuf + "" ;
         GXv_Object21[0] = scmdbuf ;
         GXv_Object21[1] = (Object)(GXv_int20) ;
         return GXv_Object21 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 2 :
                     return conditional_H001Y4( (short)dynConstraints[0] , (String)dynConstraints[1] , (DateTime)dynConstraints[2] , (short)dynConstraints[3] , (short)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (DateTime)dynConstraints[7] , (short)dynConstraints[8] , (DateTime)dynConstraints[9] , (short)dynConstraints[10] , (int)dynConstraints[11] );
               case 3 :
                     return conditional_H001Y5( (short)dynConstraints[0] , (String)dynConstraints[1] , (DateTime)dynConstraints[2] , (short)dynConstraints[3] , (short)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (DateTime)dynConstraints[7] , (short)dynConstraints[8] , (DateTime)dynConstraints[9] , (short)dynConstraints[10] , (int)dynConstraints[11] );
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
         ,new ForEachCursor(def[11])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH001Y2 ;
          prmH001Y2 = new Object[] {
          new Object[] {"@TTBUS_Descripcion",SqlDbType.VarChar,50,0}
          } ;
          Object[] prmH001Y3 ;
          prmH001Y3 = new Object[] {
          new Object[] {"@TTBUS_Descripcion",SqlDbType.VarChar,50,0}
          } ;
          Object[] prmH001Y6 ;
          prmH001Y6 = new Object[] {
          new Object[] {"@TTBUS_CodPosicion",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmH001Y7 ;
          prmH001Y7 = new Object[] {
          new Object[] {"@TTBUS_Id",SqlDbType.Int,8,0}
          } ;
          Object[] prmH001Y8 ;
          prmH001Y8 = new Object[] {
          new Object[] {"@AV30USUARIO",SqlDbType.Char,16,0}
          } ;
          Object[] prmH001Y9 ;
          prmH001Y9 = new Object[] {
          } ;
          Object[] prmH001Y10 ;
          prmH001Y10 = new Object[] {
          } ;
          Object[] prmH001Y11 ;
          prmH001Y11 = new Object[] {
          new Object[] {"@AV32vTTBUS7_Pos",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV30USUARIO",SqlDbType.Char,16,0}
          } ;
          Object[] prmH001Y12 ;
          prmH001Y12 = new Object[] {
          new Object[] {"@AV26TTBUS2_RespDesde",SqlDbType.Char,15,0}
          } ;
          Object[] prmH001Y13 ;
          prmH001Y13 = new Object[] {
          new Object[] {"@AV27TTBUS2_RespHacia",SqlDbType.Char,15,0}
          } ;
          Object[] prmH001Y4 ;
          prmH001Y4 = new Object[] {
          new Object[] {"@AV25TTBUS_Id",SqlDbType.Int,8,0} ,
          new Object[] {"@AV29TTBUS7_Pos",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV22TTBUS_Descripcion",SqlDbType.VarChar,50,0} ,
          new Object[] {"@AV24TTBUS_FechaCarga",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV34TTBUS_RubroBien",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmH001Y5 ;
          prmH001Y5 = new Object[] {
          new Object[] {"@AV25TTBUS_Id",SqlDbType.Int,8,0} ,
          new Object[] {"@AV29TTBUS7_Pos",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV22TTBUS_Descripcion",SqlDbType.VarChar,50,0} ,
          new Object[] {"@AV24TTBUS_FechaCarga",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV34TTBUS_RubroBien",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H001Y2", "SELECT DISTINCT TOP 5 [TTBUS_Descripcion] FROM [TTBUS000] WITH (NOLOCK) WHERE UPPER(CAST([TTBUS_Descripcion] AS char(50))) like UPPER(CAST(@TTBUS_Descripcion AS char(50))) ORDER BY [TTBUS_Descripcion] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001Y2,0,0,true,false )
             ,new CursorDef("H001Y3", "SELECT DISTINCT TOP 5 [TTBUS_Descripcion] FROM [TTBUS000] WITH (NOLOCK) WHERE UPPER(CAST([TTBUS_Descripcion] AS char(50))) like UPPER(CAST(@TTBUS_Descripcion AS char(50))) ORDER BY [TTBUS_Descripcion] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001Y3,0,0,true,false )
             ,new CursorDef("H001Y4", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001Y4,11,0,true,false )
             ,new CursorDef("H001Y5", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001Y5,1,0,true,false )
             ,new CursorDef("H001Y6", "SELECT T1.[TTBUS7_Pos] AS TTBUS7_Pos, T1.[TTBUS7_CodResp] AS TTBUS7_CodResp, T2.[USU_DES] AS TTBUS7_DesResp FROM ([TTBUS007] T1 WITH (NOLOCK) INNER JOIN [SEG002] T2 WITH (NOLOCK) ON T2.[USU_COD] = T1.[TTBUS7_CodResp]) WHERE T1.[TTBUS7_Pos] = @TTBUS_CodPosicion ORDER BY T1.[TTBUS7_Pos] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001Y6,1,0,false,true )
             ,new CursorDef("H001Y7", "SELECT [TTBUS2_IdMovimiento], [TTBUS2_IdBien], [TTBUS2_EstadoEnvio], [TTBUS2_RespDesde], [TTBUS2_RespHacia] FROM [TTBUS002] WITH (NOLOCK) WHERE ([TTBUS2_IdBien] = @TTBUS_Id) AND ([TTBUS2_EstadoEnvio] = 1) ORDER BY [TTBUS2_IdMovimiento] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001Y7,100,0,true,false )
             ,new CursorDef("H001Y8", "SELECT [TTBUS8_CodUsuario] FROM [TTBUS008] WITH (NOLOCK) WHERE [TTBUS8_CodUsuario] = @AV30USUARIO ORDER BY [TTBUS8_CodUsuario] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001Y8,1,0,false,true )
             ,new CursorDef("H001Y9", "SELECT T2.[W53DES] AS TTBUS7_Des, T1.[TTBUS7_Pos] AS TTBUS7_Pos FROM ([TTBUS007] T1 WITH (NOLOCK) INNER JOIN [T53FPOS] T2 WITH (NOLOCK) ON T2.[W53POS] = T1.[TTBUS7_Pos]) ORDER BY T1.[TTBUS7_Pos] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001Y9,100,0,false,false )
             ,new CursorDef("H001Y10", "SELECT T2.[W53DES] AS TTBUS7_Des, T1.[TTBUS7_CodResp] AS TTBUS7_CodResp, T1.[TTBUS7_Pos] AS TTBUS7_Pos FROM ([TTBUS007] T1 WITH (NOLOCK) INNER JOIN [T53FPOS] T2 WITH (NOLOCK) ON T2.[W53POS] = T1.[TTBUS7_Pos]) ORDER BY T1.[TTBUS7_Pos] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001Y10,100,0,true,false )
             ,new CursorDef("H001Y11", "SELECT [TTBUS7_CodUsuario], [TTBUS7_Pos] AS TTBUS7_Pos FROM [TTBUS007Permisos] WITH (NOLOCK) WHERE [TTBUS7_Pos] = @AV32vTTBUS7_Pos and [TTBUS7_CodUsuario] = @AV30USUARIO ORDER BY [TTBUS7_Pos], [TTBUS7_CodUsuario] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001Y11,1,0,false,true )
             ,new CursorDef("H001Y12", "SELECT [USU_COD], [USU_DES] FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @AV26TTBUS2_RespDesde ORDER BY [USU_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001Y12,1,0,false,true )
             ,new CursorDef("H001Y13", "SELECT [USU_COD], [USU_DES] FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @AV27TTBUS2_RespHacia ORDER BY [USU_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001Y13,1,0,false,true )
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
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((String[]) buf[4])[0] = rslt.getString(4, 50) ;
                ((short[]) buf[5])[0] = rslt.getShort(5) ;
                ((String[]) buf[6])[0] = rslt.getString(6, 30) ;
                ((int[]) buf[7])[0] = rslt.getInt(7) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(7);
                ((short[]) buf[9])[0] = rslt.getShort(8) ;
                ((DateTime[]) buf[10])[0] = rslt.getGXDate(9) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(9);
                ((String[]) buf[12])[0] = rslt.getString(10, 30) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(10);
                ((short[]) buf[14])[0] = rslt.getShort(11) ;
                ((DateTime[]) buf[15])[0] = rslt.getGXDate(12) ;
                ((String[]) buf[16])[0] = rslt.getVarchar(13) ;
                break;
             case 3 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 16) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 50) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                break;
             case 5 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 15) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 15) ;
                break;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                break;
             case 7 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((short[]) buf[2])[0] = rslt.getShort(2) ;
                break;
             case 8 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getString(2, 16) ;
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
                break;
             case 9 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                break;
             case 10 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                break;
             case 11 :
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
                sIdx = 0 ;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1) ;
                   stmt.SetParameter(sIdx, (int)parms[5]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1) ;
                   stmt.SetParameter(sIdx, (short)parms[6]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1) ;
                   stmt.SetParameter(sIdx, (String)parms[7]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1) ;
                   stmt.SetParameter(sIdx, (DateTime)parms[8]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1) ;
                   stmt.SetParameter(sIdx, (short)parms[9]);
                }
                break;
             case 3 :
                sIdx = 0 ;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1) ;
                   stmt.SetParameter(sIdx, (int)parms[5]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1) ;
                   stmt.SetParameter(sIdx, (short)parms[6]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1) ;
                   stmt.SetParameter(sIdx, (String)parms[7]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1) ;
                   stmt.SetParameter(sIdx, (DateTime)parms[8]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1) ;
                   stmt.SetParameter(sIdx, (short)parms[9]);
                }
                break;
             case 4 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 5 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 6 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 9 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 10 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 11 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
       }
    }

 }

}
