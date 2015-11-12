/*
               File: WWTBUS000
        Description: Work With ACT. DE BIENES DE USO
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:7:57.56
       Program type: Main program
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
using GeneXus.Http.Server;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class wwtbus000 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public wwtbus000( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public wwtbus000( IGxContext context )
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

      public void execute( )
      {
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Grid") == 0 )
            {
               nRC_Grid = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               nGXsfl_26_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               sGXsfl_26_idx = GetNextPar( ) ;
               edtavDelete_Tooltiptext = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Tooltiptext", edtavDelete_Tooltiptext);
               AV15Delete = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Bitmap", context.convertURL( AV15Delete));
               edtavUpdate_Tooltiptext = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Tooltiptext", edtavUpdate_Tooltiptext);
               AV14Update = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Bitmap", context.convertURL( AV14Update));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxnrGrid_newrow( nRC_Grid, nGXsfl_26_idx, sGXsfl_26_idx, AV15Delete, AV14Update) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid") == 0 )
            {
               /* GeneXus formulas. */
               AV21Pgmname = "WWTBUS000" ;
               context.Gx_err = 0 ;
               Grid_PageSize26 = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               AV13BUS_DES = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13BUS_DES", AV13BUS_DES);
               edtavDelete_Tooltiptext = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Tooltiptext", edtavDelete_Tooltiptext);
               AV15Delete = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Bitmap", context.convertURL( AV15Delete));
               edtavUpdate_Tooltiptext = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Tooltiptext", edtavUpdate_Tooltiptext);
               AV14Update = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Bitmap", context.convertURL( AV14Update));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxgrGrid_refresh( Grid_PageSize26, AV13BUS_DES, AV15Delete, AV14Update) ;
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
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("appmasterpage", "GeneXus.Programs.appmasterpage", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
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
         PA292( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START292( ) ;
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
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("wwtbus000.aspx") +"\" class=\""+"Form"+"\">") ;
            GxWebStd.gx_hidden_field( context, "_EventName", "");
            GxWebStd.gx_hidden_field( context, "_EventGridId", "");
            GxWebStd.gx_hidden_field( context, "_EventRowId", "");
         }
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH_vBUS_DES", StringUtil.RTrim( AV13BUS_DES));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vUSUARIO", StringUtil.RTrim( AV17USUARIO));
         GxWebStd.gx_hidden_field( context, "vSISTEMA", StringUtil.RTrim( AV16SISTEMA));
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 6, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 3, 0, ".", "")));
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
            WE292( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT292( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return false ;
      }

      public override String GetPgmname( )
      {
         return "WWTBUS000" ;
      }

      public override String GetPgmdesc( )
      {
         return "Work With ACT. DE BIENES DE USO" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("wwtbus000.aspx")  ;
      }

      protected void WB290( )
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
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, "", "", "", "false");
            wb_table1_2_292( true) ;
         }
         else
         {
            wb_table1_2_292( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_292e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START292( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "Work With ACT. DE BIENES DE USO", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP290( ) ;
      }

      protected void WS292( )
      {
         START292( ) ;
         EVT292( ) ;
      }

      protected void EVT292( )
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
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vBUS_DES"), AV13BUS_DES) != 0 )
                  {
                     GRID_nFirstRecordOnPage = 0 ;
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
                           else if ( StringUtil.StrCmp(sEvt, "'DOINSERT'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E11292 */
                              E11292 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGING") == 0 )
                           {
                              context.wbHandled = 1 ;
                              sEvt = cgiGet( "GRIDPAGING") ;
                              if ( StringUtil.StrCmp(sEvt, "FIRST") == 0 )
                              {
                                 subgrid_firstpage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "PREV") == 0 )
                              {
                                 subgrid_previouspage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                              {
                                 subgrid_nextpage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "LAST") == 0 )
                              {
                                 subgrid_lastpage( ) ;
                              }
                           }
                        }
                        else
                        {
                           sEvtType = StringUtil.Right( sEvt, 4) ;
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4)) ;
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 7), "REFRESH") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 8), "'EDITAR'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 9), "GRID.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 10), "'DOINSERT'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 8), "'EDITAR'") == 0 ) )
                           {
                              nGXsfl_26_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                              sGXsfl_26_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_26_idx), 4, 0)), 4, "0") ;
                              edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_26_idx ;
                              edtavDelete_Internalname = "vDELETE_"+sGXsfl_26_idx ;
                              edtBUS_EMP_Internalname = "BUS_EMP_"+sGXsfl_26_idx ;
                              edtBUS_RUB_Internalname = "BUS_RUB_"+sGXsfl_26_idx ;
                              edtBUS_COD_Internalname = "BUS_COD_"+sGXsfl_26_idx ;
                              edtBUS_PAR_Internalname = "BUS_PAR_"+sGXsfl_26_idx ;
                              edtBUS_DES_Internalname = "BUS_DES_"+sGXsfl_26_idx ;
                              edtBUS_FAL_Internalname = "BUS_FAL_"+sGXsfl_26_idx ;
                              edtBUS_FAD_Internalname = "BUS_FAD_"+sGXsfl_26_idx ;
                              edtBUS_VUA_Internalname = "BUS_VUA_"+sGXsfl_26_idx ;
                              edtBUS_VAO_Internalname = "BUS_VAO_"+sGXsfl_26_idx ;
                              edtBUS_COM_Internalname = "BUS_COM_"+sGXsfl_26_idx ;
                              edtBUS_CBD_Internalname = "BUS_CBD_"+sGXsfl_26_idx ;
                              edtBUS_NCO_Internalname = "BUS_NCO_"+sGXsfl_26_idx ;
                              edtBUS_ARE_Internalname = "BUS_ARE_"+sGXsfl_26_idx ;
                              edtBUS_ARD_Internalname = "BUS_ARD_"+sGXsfl_26_idx ;
                              edtBUS_SEC_Internalname = "BUS_SEC_"+sGXsfl_26_idx ;
                              edtBUS_SED_Internalname = "BUS_SED_"+sGXsfl_26_idx ;
                              edtBUS_TIP_Internalname = "BUS_TIP_"+sGXsfl_26_idx ;
                              edtBUS_TID_Internalname = "BUS_TID_"+sGXsfl_26_idx ;
                              edtBUS_FBA_Internalname = "BUS_FBA_"+sGXsfl_26_idx ;
                              edtBUS_MBA_Internalname = "BUS_MBA_"+sGXsfl_26_idx ;
                              edtBUS_FPR_Internalname = "BUS_FPR_"+sGXsfl_26_idx ;
                              edtBUS_VUT_Internalname = "BUS_VUT_"+sGXsfl_26_idx ;
                              edtBUS_COE_Internalname = "BUS_COE_"+sGXsfl_26_idx ;
                              edtBUS_VOC_Internalname = "BUS_VOC_"+sGXsfl_26_idx ;
                              edtBUS_VOA_Internalname = "BUS_VOA_"+sGXsfl_26_idx ;
                              edtBUS_AAA_Internalname = "BUS_AAA_"+sGXsfl_26_idx ;
                              edtBUS_AEA_Internalname = "BUS_AEA_"+sGXsfl_26_idx ;
                              edtBUS_VAH_Internalname = "BUS_VAH_"+sGXsfl_26_idx ;
                              edtBUS_VHF_Internalname = "BUS_VHF_"+sGXsfl_26_idx ;
                              edtBUS_VOH_Internalname = "BUS_VOH_"+sGXsfl_26_idx ;
                              edtBUS_AAH_Internalname = "BUS_AAH_"+sGXsfl_26_idx ;
                              edtBUS_AEH_Internalname = "BUS_AEH_"+sGXsfl_26_idx ;
                              edtBUS_VRA_Internalname = "BUS_VRA_"+sGXsfl_26_idx ;
                              edtBUS_VRH_Internalname = "BUS_VRH_"+sGXsfl_26_idx ;
                              edtBUS_VUR_Internalname = "BUS_VUR_"+sGXsfl_26_idx ;
                              edtBUS_RUD_Internalname = "BUS_RUD_"+sGXsfl_26_idx ;
                              edtBUS_AMO_Internalname = "BUS_AMO_"+sGXsfl_26_idx ;
                              edtBUS_IDT_Internalname = "BUS_IDT_"+sGXsfl_26_idx ;
                              AV14Update = cgiGet( "GXimg"+edtavUpdate_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Bitmap", context.convertURL( AV14Update));
                              AV15Delete = cgiGet( "GXimg"+edtavDelete_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Bitmap", context.convertURL( AV15Delete));
                              A8BUS_EMP = StringUtil.Upper( cgiGet( edtBUS_EMP_Internalname)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8BUS_EMP", A8BUS_EMP);
                              A1BUS_RUB = (short)(context.localUtil.CToN( cgiGet( edtBUS_RUB_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1BUS_RUB", StringUtil.LTrim( StringUtil.Str( (decimal)(A1BUS_RUB), 4, 0)));
                              A3BUS_COD = (short)(context.localUtil.CToN( cgiGet( edtBUS_COD_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3BUS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A3BUS_COD), 4, 0)));
                              A4BUS_PAR = (short)(context.localUtil.CToN( cgiGet( edtBUS_PAR_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4BUS_PAR", StringUtil.LTrim( StringUtil.Str( (decimal)(A4BUS_PAR), 2, 0)));
                              A54BUS_DES = StringUtil.Upper( cgiGet( edtBUS_DES_Internalname)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A54BUS_DES", A54BUS_DES);
                              A170BUS_FAL = context.localUtil.CToD( cgiGet( edtBUS_FAL_Internalname), 4) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A170BUS_FAL", context.localUtil.Format(A170BUS_FAL, "99/99/9999"));
                              A55BUS_FAD = context.localUtil.CToD( cgiGet( edtBUS_FAD_Internalname), 4) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A55BUS_FAD", context.localUtil.Format(A55BUS_FAD, "99/99/9999"));
                              A329BUS_VUA = (short)(context.localUtil.CToN( cgiGet( edtBUS_VUA_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A329BUS_VUA", StringUtil.LTrim( StringUtil.Str( (decimal)(A329BUS_VUA), 4, 0)));
                              A330BUS_VAO = context.localUtil.CToN( cgiGet( edtBUS_VAO_Internalname), ",", ".") ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A330BUS_VAO", StringUtil.LTrim( StringUtil.Str( A330BUS_VAO, 18, 7)));
                              A331BUS_COM = StringUtil.Upper( cgiGet( edtBUS_COM_Internalname)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A331BUS_COM", A331BUS_COM);
                              A350BUS_CBD = StringUtil.Upper( cgiGet( edtBUS_CBD_Internalname)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A350BUS_CBD", A350BUS_CBD);
                              A333BUS_NCO = cgiGet( edtBUS_NCO_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A333BUS_NCO", A333BUS_NCO);
                              A171BUS_ARE = (short)(context.localUtil.CToN( cgiGet( edtBUS_ARE_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A171BUS_ARE", StringUtil.LTrim( StringUtil.Str( (decimal)(A171BUS_ARE), 4, 0)));
                              A175BUS_ARD = StringUtil.Upper( cgiGet( edtBUS_ARD_Internalname)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A175BUS_ARD", A175BUS_ARD);
                              A172BUS_SEC = (short)(context.localUtil.CToN( cgiGet( edtBUS_SEC_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A172BUS_SEC", StringUtil.LTrim( StringUtil.Str( (decimal)(A172BUS_SEC), 2, 0)));
                              A176BUS_SED = StringUtil.Upper( cgiGet( edtBUS_SED_Internalname)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A176BUS_SED", A176BUS_SED);
                              A56BUS_TIP = (short)(context.localUtil.CToN( cgiGet( edtBUS_TIP_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A56BUS_TIP", StringUtil.LTrim( StringUtil.Str( (decimal)(A56BUS_TIP), 3, 0)));
                              A59BUS_TID = StringUtil.Upper( cgiGet( edtBUS_TID_Internalname)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A59BUS_TID", A59BUS_TID);
                              A174BUS_FBA = context.localUtil.CToD( cgiGet( edtBUS_FBA_Internalname), 4) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A174BUS_FBA", context.localUtil.Format(A174BUS_FBA, "99/99/9999"));
                              A334BUS_MBA = cgiGet( edtBUS_MBA_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A334BUS_MBA", A334BUS_MBA);
                              A340BUS_FPR = context.localUtil.CToD( cgiGet( edtBUS_FPR_Internalname), 4) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A340BUS_FPR", context.localUtil.Format(A340BUS_FPR, "99/99/9999"));
                              A335BUS_VUT = (short)(context.localUtil.CToN( cgiGet( edtBUS_VUT_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A335BUS_VUT", StringUtil.LTrim( StringUtil.Str( (decimal)(A335BUS_VUT), 4, 0)));
                              A336BUS_COE = context.localUtil.CToN( cgiGet( edtBUS_COE_Internalname), ",", ".") ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A336BUS_COE", StringUtil.LTrim( StringUtil.Str( A336BUS_COE, 18, 7)));
                              A341BUS_VOC = context.localUtil.CToN( cgiGet( edtBUS_VOC_Internalname), ",", ".") ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A341BUS_VOC", StringUtil.LTrim( StringUtil.Str( A341BUS_VOC, 18, 7)));
                              A337BUS_VOA = context.localUtil.CToN( cgiGet( edtBUS_VOA_Internalname), ",", ".") ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A337BUS_VOA", StringUtil.LTrim( StringUtil.Str( A337BUS_VOA, 18, 7)));
                              A338BUS_AAA = context.localUtil.CToN( cgiGet( edtBUS_AAA_Internalname), ",", ".") ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A338BUS_AAA", StringUtil.LTrim( StringUtil.Str( A338BUS_AAA, 10, 2)));
                              A339BUS_AEA = context.localUtil.CToN( cgiGet( edtBUS_AEA_Internalname), ",", ".") ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A339BUS_AEA", StringUtil.LTrim( StringUtil.Str( A339BUS_AEA, 10, 2)));
                              A342BUS_VAH = context.localUtil.CToN( cgiGet( edtBUS_VAH_Internalname), ",", ".") ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A342BUS_VAH", StringUtil.LTrim( StringUtil.Str( A342BUS_VAH, 18, 7)));
                              A343BUS_VHF = context.localUtil.CToD( cgiGet( edtBUS_VHF_Internalname), 4) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A343BUS_VHF", context.localUtil.Format(A343BUS_VHF, "99/99/9999"));
                              A344BUS_VOH = context.localUtil.CToN( cgiGet( edtBUS_VOH_Internalname), ",", ".") ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A344BUS_VOH", StringUtil.LTrim( StringUtil.Str( A344BUS_VOH, 18, 7)));
                              A345BUS_AAH = context.localUtil.CToN( cgiGet( edtBUS_AAH_Internalname), ",", ".") ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A345BUS_AAH", StringUtil.LTrim( StringUtil.Str( A345BUS_AAH, 10, 2)));
                              A346BUS_AEH = context.localUtil.CToN( cgiGet( edtBUS_AEH_Internalname), ",", ".") ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A346BUS_AEH", StringUtil.LTrim( StringUtil.Str( A346BUS_AEH, 10, 2)));
                              A347BUS_VRA = context.localUtil.CToN( cgiGet( edtBUS_VRA_Internalname), ",", ".") ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A347BUS_VRA", StringUtil.LTrim( StringUtil.Str( A347BUS_VRA, 18, 7)));
                              A348BUS_VRH = context.localUtil.CToN( cgiGet( edtBUS_VRH_Internalname), ",", ".") ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A348BUS_VRH", StringUtil.LTrim( StringUtil.Str( A348BUS_VRH, 18, 7)));
                              A349BUS_VUR = (short)(context.localUtil.CToN( cgiGet( edtBUS_VUR_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A349BUS_VUR", StringUtil.LTrim( StringUtil.Str( (decimal)(A349BUS_VUR), 4, 0)));
                              A61BUS_RUD = cgiGet( edtBUS_RUD_Internalname) ;
                              n61BUS_RUD = false ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A61BUS_RUD", A61BUS_RUD);
                              A178BUS_AMO = StringUtil.Upper( cgiGet( edtBUS_AMO_Internalname)) ;
                              n178BUS_AMO = false ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A178BUS_AMO", A178BUS_AMO);
                              A103BUS_IDT = (int)(context.localUtil.CToN( cgiGet( edtBUS_IDT_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A103BUS_IDT", StringUtil.LTrim( StringUtil.Str( (decimal)(A103BUS_IDT), 8, 0)));
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E12292 */
                                    E12292 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E13292 */
                                    E13292 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'EDITAR'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E14292 */
                                    E14292 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E15292 */
                                    E15292 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'DOINSERT'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E11292 */
                                    E11292 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false ;
                                       /* Set Refresh If Bus_des Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vBUS_DES"), AV13BUS_DES) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
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

      protected void WE292( )
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

      protected void PA292( )
      {
         if ( nDonePA == 0 )
         {
            GX_FocusControl = edtavBus_des_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGrid_newrow( short nRC_Grid ,
                                      short nGXsfl_26_idx ,
                                      String sGXsfl_26_idx ,
                                      String AV15Delete ,
                                      String AV14Update )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_26_idx ;
         edtavDelete_Internalname = "vDELETE_"+sGXsfl_26_idx ;
         edtBUS_EMP_Internalname = "BUS_EMP_"+sGXsfl_26_idx ;
         edtBUS_RUB_Internalname = "BUS_RUB_"+sGXsfl_26_idx ;
         edtBUS_COD_Internalname = "BUS_COD_"+sGXsfl_26_idx ;
         edtBUS_PAR_Internalname = "BUS_PAR_"+sGXsfl_26_idx ;
         edtBUS_DES_Internalname = "BUS_DES_"+sGXsfl_26_idx ;
         edtBUS_FAL_Internalname = "BUS_FAL_"+sGXsfl_26_idx ;
         edtBUS_FAD_Internalname = "BUS_FAD_"+sGXsfl_26_idx ;
         edtBUS_VUA_Internalname = "BUS_VUA_"+sGXsfl_26_idx ;
         edtBUS_VAO_Internalname = "BUS_VAO_"+sGXsfl_26_idx ;
         edtBUS_COM_Internalname = "BUS_COM_"+sGXsfl_26_idx ;
         edtBUS_CBD_Internalname = "BUS_CBD_"+sGXsfl_26_idx ;
         edtBUS_NCO_Internalname = "BUS_NCO_"+sGXsfl_26_idx ;
         edtBUS_ARE_Internalname = "BUS_ARE_"+sGXsfl_26_idx ;
         edtBUS_ARD_Internalname = "BUS_ARD_"+sGXsfl_26_idx ;
         edtBUS_SEC_Internalname = "BUS_SEC_"+sGXsfl_26_idx ;
         edtBUS_SED_Internalname = "BUS_SED_"+sGXsfl_26_idx ;
         edtBUS_TIP_Internalname = "BUS_TIP_"+sGXsfl_26_idx ;
         edtBUS_TID_Internalname = "BUS_TID_"+sGXsfl_26_idx ;
         edtBUS_FBA_Internalname = "BUS_FBA_"+sGXsfl_26_idx ;
         edtBUS_MBA_Internalname = "BUS_MBA_"+sGXsfl_26_idx ;
         edtBUS_FPR_Internalname = "BUS_FPR_"+sGXsfl_26_idx ;
         edtBUS_VUT_Internalname = "BUS_VUT_"+sGXsfl_26_idx ;
         edtBUS_COE_Internalname = "BUS_COE_"+sGXsfl_26_idx ;
         edtBUS_VOC_Internalname = "BUS_VOC_"+sGXsfl_26_idx ;
         edtBUS_VOA_Internalname = "BUS_VOA_"+sGXsfl_26_idx ;
         edtBUS_AAA_Internalname = "BUS_AAA_"+sGXsfl_26_idx ;
         edtBUS_AEA_Internalname = "BUS_AEA_"+sGXsfl_26_idx ;
         edtBUS_VAH_Internalname = "BUS_VAH_"+sGXsfl_26_idx ;
         edtBUS_VHF_Internalname = "BUS_VHF_"+sGXsfl_26_idx ;
         edtBUS_VOH_Internalname = "BUS_VOH_"+sGXsfl_26_idx ;
         edtBUS_AAH_Internalname = "BUS_AAH_"+sGXsfl_26_idx ;
         edtBUS_AEH_Internalname = "BUS_AEH_"+sGXsfl_26_idx ;
         edtBUS_VRA_Internalname = "BUS_VRA_"+sGXsfl_26_idx ;
         edtBUS_VRH_Internalname = "BUS_VRH_"+sGXsfl_26_idx ;
         edtBUS_VUR_Internalname = "BUS_VUR_"+sGXsfl_26_idx ;
         edtBUS_RUD_Internalname = "BUS_RUD_"+sGXsfl_26_idx ;
         edtBUS_AMO_Internalname = "BUS_AMO_"+sGXsfl_26_idx ;
         edtBUS_IDT_Internalname = "BUS_IDT_"+sGXsfl_26_idx ;
         while ( nGXsfl_26_idx <= nRC_Grid )
         {
            sendrow_262( ) ;
            nGXsfl_26_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_26_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_26_idx+1)) ;
            sGXsfl_26_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_26_idx), 4, 0)), 4, "0") ;
            edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_26_idx ;
            edtavDelete_Internalname = "vDELETE_"+sGXsfl_26_idx ;
            edtBUS_EMP_Internalname = "BUS_EMP_"+sGXsfl_26_idx ;
            edtBUS_RUB_Internalname = "BUS_RUB_"+sGXsfl_26_idx ;
            edtBUS_COD_Internalname = "BUS_COD_"+sGXsfl_26_idx ;
            edtBUS_PAR_Internalname = "BUS_PAR_"+sGXsfl_26_idx ;
            edtBUS_DES_Internalname = "BUS_DES_"+sGXsfl_26_idx ;
            edtBUS_FAL_Internalname = "BUS_FAL_"+sGXsfl_26_idx ;
            edtBUS_FAD_Internalname = "BUS_FAD_"+sGXsfl_26_idx ;
            edtBUS_VUA_Internalname = "BUS_VUA_"+sGXsfl_26_idx ;
            edtBUS_VAO_Internalname = "BUS_VAO_"+sGXsfl_26_idx ;
            edtBUS_COM_Internalname = "BUS_COM_"+sGXsfl_26_idx ;
            edtBUS_CBD_Internalname = "BUS_CBD_"+sGXsfl_26_idx ;
            edtBUS_NCO_Internalname = "BUS_NCO_"+sGXsfl_26_idx ;
            edtBUS_ARE_Internalname = "BUS_ARE_"+sGXsfl_26_idx ;
            edtBUS_ARD_Internalname = "BUS_ARD_"+sGXsfl_26_idx ;
            edtBUS_SEC_Internalname = "BUS_SEC_"+sGXsfl_26_idx ;
            edtBUS_SED_Internalname = "BUS_SED_"+sGXsfl_26_idx ;
            edtBUS_TIP_Internalname = "BUS_TIP_"+sGXsfl_26_idx ;
            edtBUS_TID_Internalname = "BUS_TID_"+sGXsfl_26_idx ;
            edtBUS_FBA_Internalname = "BUS_FBA_"+sGXsfl_26_idx ;
            edtBUS_MBA_Internalname = "BUS_MBA_"+sGXsfl_26_idx ;
            edtBUS_FPR_Internalname = "BUS_FPR_"+sGXsfl_26_idx ;
            edtBUS_VUT_Internalname = "BUS_VUT_"+sGXsfl_26_idx ;
            edtBUS_COE_Internalname = "BUS_COE_"+sGXsfl_26_idx ;
            edtBUS_VOC_Internalname = "BUS_VOC_"+sGXsfl_26_idx ;
            edtBUS_VOA_Internalname = "BUS_VOA_"+sGXsfl_26_idx ;
            edtBUS_AAA_Internalname = "BUS_AAA_"+sGXsfl_26_idx ;
            edtBUS_AEA_Internalname = "BUS_AEA_"+sGXsfl_26_idx ;
            edtBUS_VAH_Internalname = "BUS_VAH_"+sGXsfl_26_idx ;
            edtBUS_VHF_Internalname = "BUS_VHF_"+sGXsfl_26_idx ;
            edtBUS_VOH_Internalname = "BUS_VOH_"+sGXsfl_26_idx ;
            edtBUS_AAH_Internalname = "BUS_AAH_"+sGXsfl_26_idx ;
            edtBUS_AEH_Internalname = "BUS_AEH_"+sGXsfl_26_idx ;
            edtBUS_VRA_Internalname = "BUS_VRA_"+sGXsfl_26_idx ;
            edtBUS_VRH_Internalname = "BUS_VRH_"+sGXsfl_26_idx ;
            edtBUS_VUR_Internalname = "BUS_VUR_"+sGXsfl_26_idx ;
            edtBUS_RUD_Internalname = "BUS_RUD_"+sGXsfl_26_idx ;
            edtBUS_AMO_Internalname = "BUS_AMO_"+sGXsfl_26_idx ;
            edtBUS_IDT_Internalname = "BUS_IDT_"+sGXsfl_26_idx ;
         }
         context.GX_webresponse.AddString(GridContainer.ToJavascriptSource());
         /* End function gxnrGrid_newrow */
      }

      protected void gxgrGrid_refresh( int Grid_PageSize26 ,
                                       String AV13BUS_DES ,
                                       String AV15Delete ,
                                       String AV14Update )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         subGrid_Rows = (short)(Grid_PageSize26) ;
         RF292( ) ;
         enableOutput();
         context.GX_webresponse.AddString(GridContainer.ToJavascriptSource());
         /* End function gxgrGrid_refresh */
      }

      protected void Refresh( )
      {
         RF292( ) ;
         /* End function Refresh */
      }

      protected void RF292( )
      {
         GridContainer.PageSize = subGrid_Recordsperpage( ) ;
         wbStart = 26 ;
         nGXsfl_26_idx = 1 ;
         sGXsfl_26_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_26_idx), 4, 0)), 4, "0") ;
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_26_idx ;
         edtavDelete_Internalname = "vDELETE_"+sGXsfl_26_idx ;
         edtBUS_EMP_Internalname = "BUS_EMP_"+sGXsfl_26_idx ;
         edtBUS_RUB_Internalname = "BUS_RUB_"+sGXsfl_26_idx ;
         edtBUS_COD_Internalname = "BUS_COD_"+sGXsfl_26_idx ;
         edtBUS_PAR_Internalname = "BUS_PAR_"+sGXsfl_26_idx ;
         edtBUS_DES_Internalname = "BUS_DES_"+sGXsfl_26_idx ;
         edtBUS_FAL_Internalname = "BUS_FAL_"+sGXsfl_26_idx ;
         edtBUS_FAD_Internalname = "BUS_FAD_"+sGXsfl_26_idx ;
         edtBUS_VUA_Internalname = "BUS_VUA_"+sGXsfl_26_idx ;
         edtBUS_VAO_Internalname = "BUS_VAO_"+sGXsfl_26_idx ;
         edtBUS_COM_Internalname = "BUS_COM_"+sGXsfl_26_idx ;
         edtBUS_CBD_Internalname = "BUS_CBD_"+sGXsfl_26_idx ;
         edtBUS_NCO_Internalname = "BUS_NCO_"+sGXsfl_26_idx ;
         edtBUS_ARE_Internalname = "BUS_ARE_"+sGXsfl_26_idx ;
         edtBUS_ARD_Internalname = "BUS_ARD_"+sGXsfl_26_idx ;
         edtBUS_SEC_Internalname = "BUS_SEC_"+sGXsfl_26_idx ;
         edtBUS_SED_Internalname = "BUS_SED_"+sGXsfl_26_idx ;
         edtBUS_TIP_Internalname = "BUS_TIP_"+sGXsfl_26_idx ;
         edtBUS_TID_Internalname = "BUS_TID_"+sGXsfl_26_idx ;
         edtBUS_FBA_Internalname = "BUS_FBA_"+sGXsfl_26_idx ;
         edtBUS_MBA_Internalname = "BUS_MBA_"+sGXsfl_26_idx ;
         edtBUS_FPR_Internalname = "BUS_FPR_"+sGXsfl_26_idx ;
         edtBUS_VUT_Internalname = "BUS_VUT_"+sGXsfl_26_idx ;
         edtBUS_COE_Internalname = "BUS_COE_"+sGXsfl_26_idx ;
         edtBUS_VOC_Internalname = "BUS_VOC_"+sGXsfl_26_idx ;
         edtBUS_VOA_Internalname = "BUS_VOA_"+sGXsfl_26_idx ;
         edtBUS_AAA_Internalname = "BUS_AAA_"+sGXsfl_26_idx ;
         edtBUS_AEA_Internalname = "BUS_AEA_"+sGXsfl_26_idx ;
         edtBUS_VAH_Internalname = "BUS_VAH_"+sGXsfl_26_idx ;
         edtBUS_VHF_Internalname = "BUS_VHF_"+sGXsfl_26_idx ;
         edtBUS_VOH_Internalname = "BUS_VOH_"+sGXsfl_26_idx ;
         edtBUS_AAH_Internalname = "BUS_AAH_"+sGXsfl_26_idx ;
         edtBUS_AEH_Internalname = "BUS_AEH_"+sGXsfl_26_idx ;
         edtBUS_VRA_Internalname = "BUS_VRA_"+sGXsfl_26_idx ;
         edtBUS_VRH_Internalname = "BUS_VRH_"+sGXsfl_26_idx ;
         edtBUS_VUR_Internalname = "BUS_VUR_"+sGXsfl_26_idx ;
         edtBUS_RUD_Internalname = "BUS_RUD_"+sGXsfl_26_idx ;
         edtBUS_AMO_Internalname = "BUS_AMO_"+sGXsfl_26_idx ;
         edtBUS_IDT_Internalname = "BUS_IDT_"+sGXsfl_26_idx ;
         /* Execute user event: E13292 */
         E13292 ();
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_26_idx ;
            edtavDelete_Internalname = "vDELETE_"+sGXsfl_26_idx ;
            edtBUS_EMP_Internalname = "BUS_EMP_"+sGXsfl_26_idx ;
            edtBUS_RUB_Internalname = "BUS_RUB_"+sGXsfl_26_idx ;
            edtBUS_COD_Internalname = "BUS_COD_"+sGXsfl_26_idx ;
            edtBUS_PAR_Internalname = "BUS_PAR_"+sGXsfl_26_idx ;
            edtBUS_DES_Internalname = "BUS_DES_"+sGXsfl_26_idx ;
            edtBUS_FAL_Internalname = "BUS_FAL_"+sGXsfl_26_idx ;
            edtBUS_FAD_Internalname = "BUS_FAD_"+sGXsfl_26_idx ;
            edtBUS_VUA_Internalname = "BUS_VUA_"+sGXsfl_26_idx ;
            edtBUS_VAO_Internalname = "BUS_VAO_"+sGXsfl_26_idx ;
            edtBUS_COM_Internalname = "BUS_COM_"+sGXsfl_26_idx ;
            edtBUS_CBD_Internalname = "BUS_CBD_"+sGXsfl_26_idx ;
            edtBUS_NCO_Internalname = "BUS_NCO_"+sGXsfl_26_idx ;
            edtBUS_ARE_Internalname = "BUS_ARE_"+sGXsfl_26_idx ;
            edtBUS_ARD_Internalname = "BUS_ARD_"+sGXsfl_26_idx ;
            edtBUS_SEC_Internalname = "BUS_SEC_"+sGXsfl_26_idx ;
            edtBUS_SED_Internalname = "BUS_SED_"+sGXsfl_26_idx ;
            edtBUS_TIP_Internalname = "BUS_TIP_"+sGXsfl_26_idx ;
            edtBUS_TID_Internalname = "BUS_TID_"+sGXsfl_26_idx ;
            edtBUS_FBA_Internalname = "BUS_FBA_"+sGXsfl_26_idx ;
            edtBUS_MBA_Internalname = "BUS_MBA_"+sGXsfl_26_idx ;
            edtBUS_FPR_Internalname = "BUS_FPR_"+sGXsfl_26_idx ;
            edtBUS_VUT_Internalname = "BUS_VUT_"+sGXsfl_26_idx ;
            edtBUS_COE_Internalname = "BUS_COE_"+sGXsfl_26_idx ;
            edtBUS_VOC_Internalname = "BUS_VOC_"+sGXsfl_26_idx ;
            edtBUS_VOA_Internalname = "BUS_VOA_"+sGXsfl_26_idx ;
            edtBUS_AAA_Internalname = "BUS_AAA_"+sGXsfl_26_idx ;
            edtBUS_AEA_Internalname = "BUS_AEA_"+sGXsfl_26_idx ;
            edtBUS_VAH_Internalname = "BUS_VAH_"+sGXsfl_26_idx ;
            edtBUS_VHF_Internalname = "BUS_VHF_"+sGXsfl_26_idx ;
            edtBUS_VOH_Internalname = "BUS_VOH_"+sGXsfl_26_idx ;
            edtBUS_AAH_Internalname = "BUS_AAH_"+sGXsfl_26_idx ;
            edtBUS_AEH_Internalname = "BUS_AEH_"+sGXsfl_26_idx ;
            edtBUS_VRA_Internalname = "BUS_VRA_"+sGXsfl_26_idx ;
            edtBUS_VRH_Internalname = "BUS_VRH_"+sGXsfl_26_idx ;
            edtBUS_VUR_Internalname = "BUS_VUR_"+sGXsfl_26_idx ;
            edtBUS_RUD_Internalname = "BUS_RUD_"+sGXsfl_26_idx ;
            edtBUS_AMO_Internalname = "BUS_AMO_"+sGXsfl_26_idx ;
            edtBUS_IDT_Internalname = "BUS_IDT_"+sGXsfl_26_idx ;
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV13BUS_DES ,
                                                 A54BUS_DES },
                                                 new int[] {
                                                 TypeConstants.STRING, TypeConstants.STRING
                                                 }
            });
            lV13BUS_DES = StringUtil.PadR( StringUtil.RTrim( AV13BUS_DES), 50, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13BUS_DES", AV13BUS_DES);
            /* Using cursor H00292 */
            pr_default.execute(0, new Object[] {lV13BUS_DES});
            nGXsfl_26_idx = 1 ;
            GRID_nEOF = 0 ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < GRID_nFirstRecordOnPage + subGrid_Recordsperpage( ) ) ) ) )
            {
               A103BUS_IDT = H00292_A103BUS_IDT[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A103BUS_IDT", StringUtil.LTrim( StringUtil.Str( (decimal)(A103BUS_IDT), 8, 0)));
               A178BUS_AMO = H00292_A178BUS_AMO[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A178BUS_AMO", A178BUS_AMO);
               n178BUS_AMO = H00292_n178BUS_AMO[0] ;
               A61BUS_RUD = H00292_A61BUS_RUD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A61BUS_RUD", A61BUS_RUD);
               n61BUS_RUD = H00292_n61BUS_RUD[0] ;
               A343BUS_VHF = H00292_A343BUS_VHF[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A343BUS_VHF", context.localUtil.Format(A343BUS_VHF, "99/99/9999"));
               A342BUS_VAH = H00292_A342BUS_VAH[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A342BUS_VAH", StringUtil.LTrim( StringUtil.Str( A342BUS_VAH, 18, 7)));
               A341BUS_VOC = H00292_A341BUS_VOC[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A341BUS_VOC", StringUtil.LTrim( StringUtil.Str( A341BUS_VOC, 18, 7)));
               A336BUS_COE = H00292_A336BUS_COE[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A336BUS_COE", StringUtil.LTrim( StringUtil.Str( A336BUS_COE, 18, 7)));
               A340BUS_FPR = H00292_A340BUS_FPR[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A340BUS_FPR", context.localUtil.Format(A340BUS_FPR, "99/99/9999"));
               A334BUS_MBA = H00292_A334BUS_MBA[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A334BUS_MBA", A334BUS_MBA);
               A174BUS_FBA = H00292_A174BUS_FBA[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A174BUS_FBA", context.localUtil.Format(A174BUS_FBA, "99/99/9999"));
               A59BUS_TID = H00292_A59BUS_TID[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A59BUS_TID", A59BUS_TID);
               A56BUS_TIP = H00292_A56BUS_TIP[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A56BUS_TIP", StringUtil.LTrim( StringUtil.Str( (decimal)(A56BUS_TIP), 3, 0)));
               A176BUS_SED = H00292_A176BUS_SED[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A176BUS_SED", A176BUS_SED);
               A172BUS_SEC = H00292_A172BUS_SEC[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A172BUS_SEC", StringUtil.LTrim( StringUtil.Str( (decimal)(A172BUS_SEC), 2, 0)));
               A175BUS_ARD = H00292_A175BUS_ARD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A175BUS_ARD", A175BUS_ARD);
               A171BUS_ARE = H00292_A171BUS_ARE[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A171BUS_ARE", StringUtil.LTrim( StringUtil.Str( (decimal)(A171BUS_ARE), 4, 0)));
               A333BUS_NCO = H00292_A333BUS_NCO[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A333BUS_NCO", A333BUS_NCO);
               A350BUS_CBD = H00292_A350BUS_CBD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A350BUS_CBD", A350BUS_CBD);
               A331BUS_COM = H00292_A331BUS_COM[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A331BUS_COM", A331BUS_COM);
               A330BUS_VAO = H00292_A330BUS_VAO[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A330BUS_VAO", StringUtil.LTrim( StringUtil.Str( A330BUS_VAO, 18, 7)));
               A55BUS_FAD = H00292_A55BUS_FAD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A55BUS_FAD", context.localUtil.Format(A55BUS_FAD, "99/99/9999"));
               A170BUS_FAL = H00292_A170BUS_FAL[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A170BUS_FAL", context.localUtil.Format(A170BUS_FAL, "99/99/9999"));
               A54BUS_DES = H00292_A54BUS_DES[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A54BUS_DES", A54BUS_DES);
               A4BUS_PAR = H00292_A4BUS_PAR[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4BUS_PAR", StringUtil.LTrim( StringUtil.Str( (decimal)(A4BUS_PAR), 2, 0)));
               A3BUS_COD = H00292_A3BUS_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3BUS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A3BUS_COD), 4, 0)));
               A1BUS_RUB = H00292_A1BUS_RUB[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1BUS_RUB", StringUtil.LTrim( StringUtil.Str( (decimal)(A1BUS_RUB), 4, 0)));
               A8BUS_EMP = H00292_A8BUS_EMP[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8BUS_EMP", A8BUS_EMP);
               A339BUS_AEA = H00292_A339BUS_AEA[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A339BUS_AEA", StringUtil.LTrim( StringUtil.Str( A339BUS_AEA, 10, 2)));
               A338BUS_AAA = H00292_A338BUS_AAA[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A338BUS_AAA", StringUtil.LTrim( StringUtil.Str( A338BUS_AAA, 10, 2)));
               A337BUS_VOA = H00292_A337BUS_VOA[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A337BUS_VOA", StringUtil.LTrim( StringUtil.Str( A337BUS_VOA, 18, 7)));
               A346BUS_AEH = H00292_A346BUS_AEH[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A346BUS_AEH", StringUtil.LTrim( StringUtil.Str( A346BUS_AEH, 10, 2)));
               A345BUS_AAH = H00292_A345BUS_AAH[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A345BUS_AAH", StringUtil.LTrim( StringUtil.Str( A345BUS_AAH, 10, 2)));
               A344BUS_VOH = H00292_A344BUS_VOH[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A344BUS_VOH", StringUtil.LTrim( StringUtil.Str( A344BUS_VOH, 18, 7)));
               A335BUS_VUT = H00292_A335BUS_VUT[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A335BUS_VUT", StringUtil.LTrim( StringUtil.Str( (decimal)(A335BUS_VUT), 4, 0)));
               A329BUS_VUA = H00292_A329BUS_VUA[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A329BUS_VUA", StringUtil.LTrim( StringUtil.Str( (decimal)(A329BUS_VUA), 4, 0)));
               A178BUS_AMO = H00292_A178BUS_AMO[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A178BUS_AMO", A178BUS_AMO);
               n178BUS_AMO = H00292_n178BUS_AMO[0] ;
               A61BUS_RUD = H00292_A61BUS_RUD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A61BUS_RUD", A61BUS_RUD);
               n61BUS_RUD = H00292_n61BUS_RUD[0] ;
               A349BUS_VUR = (short)(A329BUS_VUA-A335BUS_VUT) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A349BUS_VUR", StringUtil.LTrim( StringUtil.Str( (decimal)(A349BUS_VUR), 4, 0)));
               A348BUS_VRH = (decimal)(A344BUS_VOH-A345BUS_AAH-A346BUS_AEH) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A348BUS_VRH", StringUtil.LTrim( StringUtil.Str( A348BUS_VRH, 18, 7)));
               A347BUS_VRA = (decimal)(A337BUS_VOA-A338BUS_AAA-A339BUS_AEA) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A347BUS_VRA", StringUtil.LTrim( StringUtil.Str( A347BUS_VRA, 18, 7)));
               /* Execute user event: E15292 */
               E15292 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0)) ;
            pr_default.close(0);
            wbEnd = 26 ;
            WB290( ) ;
         }
      }

      protected int subGrid_Pagecount( )
      {
         GRID_nRecordCount = subGrid_Recordcount( ) ;
         if ( ((int)(GRID_nRecordCount) % (subGrid_Recordsperpage( ))) == 0 )
         {
            return (int)(NumberUtil.Int( (long)(GRID_nRecordCount/ (decimal)(subGrid_Recordsperpage( ))))) ;
         }
         return (int)(NumberUtil.Int( (long)(GRID_nRecordCount/ (decimal)(subGrid_Recordsperpage( ))))+1) ;
      }

      protected int subGrid_Recordcount( )
      {
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              AV13BUS_DES ,
                                              A54BUS_DES },
                                              new int[] {
                                              TypeConstants.STRING, TypeConstants.STRING
                                              }
         });
         lV13BUS_DES = StringUtil.PadR( StringUtil.RTrim( AV13BUS_DES), 50, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13BUS_DES", AV13BUS_DES);
         /* Using cursor H00293 */
         pr_default.execute(1, new Object[] {lV13BUS_DES});
         GRID_nRecordCount = H00293_AGRID_nRecordCount[0] ;
         pr_default.close(1);
         return GRID_nRecordCount ;
      }

      protected int subGrid_Recordsperpage( )
      {
         if ( subGrid_Rows > 0 )
         {
            if ( 1 > 0 )
            {
               return (int)(subGrid_Rows*1) ;
            }
            else
            {
               return (int)(subGrid_Rows) ;
            }
         }
         return (int)(-1) ;
      }

      protected int subGrid_Currentpage( )
      {
         return (int)(NumberUtil.Int( (long)(GRID_nFirstRecordOnPage/ (decimal)(subGrid_Recordsperpage( ))))+1) ;
      }

      protected short subgrid_firstpage( )
      {
         GRID_nFirstRecordOnPage = 0 ;
         return 0 ;
      }

      protected short subgrid_nextpage( )
      {
         GRID_nRecordCount = subGrid_Recordcount( ) ;
         if ( ( GRID_nRecordCount >= subGrid_Recordsperpage( ) ) && ( GRID_nEOF == 0 ) )
         {
            GRID_nFirstRecordOnPage = (int)(GRID_nFirstRecordOnPage+subGrid_Recordsperpage( )) ;
         }
         else
         {
            return 2 ;
         }
         return 0 ;
      }

      protected short subgrid_previouspage( )
      {
         if ( GRID_nFirstRecordOnPage >= subGrid_Recordsperpage( ) )
         {
            GRID_nFirstRecordOnPage = (int)(GRID_nFirstRecordOnPage-subGrid_Recordsperpage( )) ;
         }
         else
         {
            return 2 ;
         }
         return 0 ;
      }

      protected short subgrid_lastpage( )
      {
         GRID_nRecordCount = subGrid_Recordcount( ) ;
         if ( GRID_nRecordCount > subGrid_Recordsperpage( ) )
         {
            if ( ((int)(GRID_nRecordCount) % (subGrid_Recordsperpage( ))) == 0 )
            {
               GRID_nFirstRecordOnPage = (int)(GRID_nRecordCount-subGrid_Recordsperpage( )) ;
            }
            else
            {
               GRID_nFirstRecordOnPage = (int)(GRID_nRecordCount-((int)(GRID_nRecordCount) % (subGrid_Recordsperpage( )))) ;
            }
         }
         else
         {
            GRID_nFirstRecordOnPage = 0 ;
         }
         return 0 ;
      }

      protected int subgrid_gotopage( int nPageNo )
      {
         if ( nPageNo > 0 )
         {
            int gx_pageCount = subGrid_Pagecount( ) ;
            if ( ( nPageNo <= gx_pageCount ) || ( gx_pageCount == -1 ) )
            {
               GRID_nFirstRecordOnPage = (int)(subGrid_Recordsperpage( )*(nPageNo-1)) ;
            }
            else
            {
               GRID_nFirstRecordOnPage = (int)(subGrid_Recordsperpage( )*(gx_pageCount-1)) ;
            }
         }
         else
         {
            GRID_nFirstRecordOnPage = 0 ;
         }
         return (int)(0) ;
      }

      protected void STRUP290( )
      {
         /* Before Start, stand alone formulas. */
         AV21Pgmname = "WWTBUS000" ;
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E12292 */
         E12292 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            AV13BUS_DES = StringUtil.Upper( cgiGet( edtavBus_des_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13BUS_DES", AV13BUS_DES);
            /* Read saved values. */
            nRC_Grid = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid"), ",", ".")) ;
            AV17USUARIO = cgiGet( "vUSUARIO") ;
            AV16SISTEMA = cgiGet( "vSISTEMA") ;
            GRID_nFirstRecordOnPage = (int)(context.localUtil.CToN( cgiGet( "GRID_nFirstRecordOnPage"), ",", ".")) ;
            GRID_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID_nEOF"), ",", ".")) ;
            subGrid_Rows = (short)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ",", ".")) ;
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
         /* Execute user event: E12292 */
         E12292 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E12292( )
      {
         /* Start Routine */
         new isauthorized(context ).execute(  AV21Pgmname, out  AV5IsAuthorized) ;
         if ( ! AV5IsAuthorized )
         {
            context.wjLoc = formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV21Pgmname)) ;
         }
         subGrid_Rows = 10 ;
         AV14Update = context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", "Modern") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Bitmap", context.convertURL( AV14Update));
         edtavUpdate_Tooltiptext = "Modifica" ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Tooltiptext", edtavUpdate_Tooltiptext);
         AV15Delete = context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "Modern") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Bitmap", context.convertURL( AV15Delete));
         edtavDelete_Tooltiptext = "Eliminar" ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Tooltiptext", edtavDelete_Tooltiptext);
         Form.Caption = "Trabajar con DE BIENES DE USO" ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption);
         /* Execute user subroutine: S112 */
         S112 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         /* Execute user subroutine: S122 */
         S122 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E13292( )
      {
         /* Refresh Routine */
         /* Execute user subroutine: S132 */
         S132 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E14292( )
      {
         /* 'Editar' Routine */
         AV18SESION.Set("BUS_IDT", StringUtil.Trim( StringUtil.Str( (decimal)(A103BUS_IDT), 8, 0)));
         context.wjLoc = formatLink("tbus000.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode(StringUtil.RTrim(A8BUS_EMP)) + "," + UrlEncode("" +A1BUS_RUB) + "," + UrlEncode("" +A3BUS_COD) + "," + UrlEncode("" +A4BUS_PAR) ;
      }

      private void E15292( )
      {
         /* Grid_Load Routine */
         edtavDelete_Link = formatLink("tbus000.aspx") + "?" + UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode(StringUtil.RTrim(A8BUS_EMP)) + "," + UrlEncode("" +A1BUS_RUB) + "," + UrlEncode("" +A3BUS_COD) + "," + UrlEncode("" +A4BUS_PAR) ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Link", edtavDelete_Link);
         edtBUS_DES_Link = formatLink("viewtbus000.aspx") + "?" + UrlEncode(StringUtil.RTrim(A8BUS_EMP)) + "," + UrlEncode("" +A1BUS_RUB) + "," + UrlEncode("" +A3BUS_COD) + "," + UrlEncode("" +A4BUS_PAR) + "," + UrlEncode(StringUtil.RTrim("")) ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_DES_Internalname, "Link", edtBUS_DES_Link);
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 26 ;
         }
         if ( ( subGrid_Islastpage == 1 ) || ( subGrid_Rows == 0 ) || ( ( GRID_nCurrentRecord >= GRID_nFirstRecordOnPage ) && ( GRID_nCurrentRecord < GRID_nFirstRecordOnPage + subGrid_Recordsperpage( ) ) ) )
         {
            sendrow_262( ) ;
         }
         GRID_nCurrentRecord = (int)(GRID_nCurrentRecord+1) ;
      }

      protected void E11292( )
      {
         /* 'DoInsert' Routine */
         context.wjLoc = formatLink("tbus000.aspx") + "?" + UrlEncode(StringUtil.RTrim("INS")) + "," + UrlEncode(StringUtil.RTrim("")) + "," + UrlEncode("" +0) + "," + UrlEncode("" +0) + "," + UrlEncode("" +0) ;
      }

      protected void S122( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV8HTTPRequest.Method, "GET") == 0 )
         {
            AV9GridState.FromXml(AV7Session.Get(AV21Pgmname+"GridState"), "");
            if ( AV9GridState.gxTpr_Filtervalues.Count >= 1 )
            {
               AV13BUS_DES = ((SdtGridState_FilterValue)AV9GridState.gxTpr_Filtervalues.Item(1)).gxTpr_Value ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13BUS_DES", AV13BUS_DES);
            }
            if ( AV9GridState.gxTpr_Currentpage > 0 )
            {
               subgrid_gotopage( AV9GridState.gxTpr_Currentpage) ;
            }
         }
      }

      protected void S132( )
      {
         /* 'SAVEGRIDSTATE' Routine */
         AV9GridState.FromXml(AV7Session.Get(AV21Pgmname+"GridState"), "");
         AV9GridState.gxTpr_Currentpage = (short)(subGrid_Currentpage( )) ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV9GridState", (Object)(AV9GridState));
         AV9GridState.gxTpr_Filtervalues.Clear();
         AV10GridStateFilterValue = new SdtGridState_FilterValue(context) ;
         AV10GridStateFilterValue.gxTpr_Value = AV13BUS_DES ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10GridStateFilterValue", (Object)(AV10GridStateFilterValue));
         AV9GridState.gxTpr_Filtervalues.Add(AV10GridStateFilterValue, 0);
         AV7Session.Set(AV21Pgmname+"GridState", AV9GridState.ToXml(false, "GridState", "MarianoTesis"));
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV11TrnContext = new SdtTransactionContext(context) ;
         AV11TrnContext.gxTpr_Callerobject = AV21Pgmname ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV11TrnContext", (Object)(AV11TrnContext));
         AV11TrnContext.gxTpr_Callerondelete = true ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV11TrnContext", (Object)(AV11TrnContext));
         AV11TrnContext.gxTpr_Callerurl = AV8HTTPRequest.ScriptName+"?"+AV8HTTPRequest.QueryString ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV11TrnContext", (Object)(AV11TrnContext));
         AV11TrnContext.gxTpr_Transactionname = "TBUS000" ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV11TrnContext", (Object)(AV11TrnContext));
         AV7Session.Set("TrnContext", AV11TrnContext.ToXml(false, "TransactionContext", "MarianoTesis"));
      }

      protected void wb_table1_2_292( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable_Internalname, tblTable_Internalname, "", "ViewTable", 0, "", "", 0, 0, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class=\"SubTitle\" >") ;
            /* Text block */
            ClassString = "" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTitletext_Internalname, 1, 1, 0, "Trabajar con DE BIENES DE USO", "", "", "", 0, lblTitletext_Jsonclick, "", StyleString, ClassString, "HLP_WWTBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_8_292( true) ;
         }
         else
         {
            wb_table2_8_292( false) ;
         }
         return  ;
      }

      protected void wb_table2_8_292e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table3_19_292( true) ;
         }
         else
         {
            wb_table3_19_292( false) ;
         }
         return  ;
      }

      protected void wb_table3_19_292e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_292e( true) ;
         }
         else
         {
            wb_table1_2_292e( false) ;
         }
      }

      protected void wb_table3_19_292( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablegridcontainer_Internalname, tblTablegridcontainer_Internalname, "", "Table", 0, "", "", 0, 0, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "right")+"\">") ;
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"" ;
            ClassString = "PagingButtons" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgInsert_Internalname, "", context.GetImagePath( "5649fbb8-8ce0-4810-a5ce-bd649ea83c3a", "", "Modern"), "Modern", 1, 1, "", "Agrega", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgInsert_Jsonclick, "E\\'DOINSERT\\'.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_WWTBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" colspan=\"2\" >") ;
            /*  Grid Control  */
            GridContainer.SetWrapped(nGXWrapped);
            if ( GridContainer.GetWrapped() == 1 )
            {
               sStyleString = "" ;
               GxWebStd.gx_table_start( context, subGrid_Internalname, subGrid_Internalname, "", "WorkWith", 0, "", "", 4, 2, sStyleString, "", 0);
               /* Subfile titles */
               context.WriteHtmlText( "<tr") ;
               context.WriteHtmlTextNl( ">") ;
               if ( subGrid_Backcolorstyle == 0 )
               {
                  subGrid_Titlebackstyle = 0 ;
                  if ( StringUtil.Len( subGrid_Class) > 0 )
                  {
                     subGrid_Linesclass = subGrid_Class+"Title" ;
                  }
               }
               else
               {
                  subGrid_Titlebackstyle = 1 ;
                  if ( subGrid_Backcolorstyle == 1 )
                  {
                     subGrid_Titlebackcolor = subGrid_Allbackcolor ;
                     if ( StringUtil.Len( subGrid_Class) > 0 )
                     {
                        subGrid_Linesclass = subGrid_Class+"UniformTitle" ;
                     }
                  }
                  else
                  {
                     if ( StringUtil.Len( subGrid_Class) > 0 )
                     {
                        subGrid_Linesclass = subGrid_Class+"Title" ;
                     }
                  }
               }
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "EMPRESA") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "RUBRO") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "CODIGO") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "PARTIDA") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "DESCRIPCION") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "ALTA") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "ADQUISICION") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "VIDA UTIL ASIGNADA AL BIEN") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "VALOR DE ORIGEN DEL BIEN") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "COMPROBANTE DE COMPRA") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "DE COMPRA") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "NUMERO DEL COMP. DE COMPRA") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "AREA") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "SECTOR") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "AREA A QUE PERTENECE EL BIEN") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "ÁREA") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "CODIGO DE TIPO DE BIEN") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "TIPO") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "BAJA") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "MOTIVO DE BAJA DEL BIEN") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "FECHA DE PROCESO AJUSTE") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "VIDA UTIL TRANSCURRIDA") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "ULTIMO COEFICIENTE DE CALCULO") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "VALOR ORIGEN AJUSTADO (C)") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "VALOR DE ORIGEN AJUSTADO") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "AMORTIZ. ACUMULADAS AJUSTADAS") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "AMORTIZ. DEL EJERCICIO AJUST.") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "VALOR HISTORICO BASE") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "FECHA VALOR HISTORICO BASE") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "VALOR DE ORIGEN HISTORICO") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "AMORTIZ. ACUMULADAS VAL HISTOR") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "AMORTIZ. DEL EJERCICIO HISTORI") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "VALOR RESIDUAL AJ (FORMULA)") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "VALOR RESIDUAL HIST(FORMULA)") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "VIDA UTIL RESIDUAL (FORMULA)") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "RUBRO") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "AMORTIZABLE") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "ID EN TRAZABILIDAD") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlTextNl( "</tr>") ;
            }
            else
            {
               GridContainer.Clear();
               GridContainer.SetWrapped(nGXWrapped);
               GridContainer.AddObjectProperty("GridName", "Grid");
               GridContainer.AddObjectProperty("Class", "WorkWith");
               GridContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(4), 4, 0, ".", "")));
               GridContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               GridContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Backcolorstyle), 1, 0, ".", "")));
               GridContainer.AddObjectProperty("CmpContext", "");
               GridContainer.AddObjectProperty("InMasterPage", "false");
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", context.convertURL( AV14Update));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavUpdate_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", context.convertURL( AV15Delete));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDelete_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDelete_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A8BUS_EMP));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A1BUS_RUB), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A3BUS_COD), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A4BUS_PAR), 2, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A54BUS_DES));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtBUS_DES_Link));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", context.localUtil.Format(A170BUS_FAL, "99/99/9999"));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", context.localUtil.Format(A55BUS_FAD, "99/99/9999"));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A329BUS_VUA), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A330BUS_VAO, 18, 7, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A331BUS_COM));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A350BUS_CBD));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A333BUS_NCO));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A171BUS_ARE), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A175BUS_ARD));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A172BUS_SEC), 2, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A176BUS_SED));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A56BUS_TIP), 3, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A59BUS_TID));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", context.localUtil.Format(A174BUS_FBA, "99/99/9999"));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A334BUS_MBA));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", context.localUtil.Format(A340BUS_FPR, "99/99/9999"));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A335BUS_VUT), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A336BUS_COE, 18, 7, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A341BUS_VOC, 18, 7, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A337BUS_VOA, 18, 7, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A338BUS_AAA, 10, 2, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A339BUS_AEA, 10, 2, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A342BUS_VAH, 18, 7, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", context.localUtil.Format(A343BUS_VHF, "99/99/9999"));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A344BUS_VOH, 18, 7, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A345BUS_AAH, 10, 2, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A346BUS_AEH, 10, 2, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A347BUS_VRA, 18, 7, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A348BUS_VRH, 18, 7, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A349BUS_VUR), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A61BUS_RUD));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A178BUS_AMO));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A103BUS_IDT), 8, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridContainer.AddObjectProperty("Allowselection", "false");
               GridContainer.AddObjectProperty("Allowcollapsing", "false");
               GridContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Collapsed), 9, 0, ".", "")));
            }
         }
         if ( wbEnd == 26 )
         {
            wbEnd = 0 ;
            nRC_Grid = (short)(nGXsfl_26_idx-1) ;
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
            }
            else
            {
               GridContainer.AddObjectProperty("GRID_nEOF", GRID_nEOF);
               GridContainer.AddObjectProperty("GRID_nFirstRecordOnPage", GRID_nFirstRecordOnPage);
               sStyleString = " style=\"display:none;\"" ;
               sStyleString = "" ;
               context.WriteHtmlText( "<div id=\""+"GridContainer"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Grid", (Object)(GridContainer));
               GxWebStd.gx_hidden_field( context, "GridContainerData", GridContainer.ToJavascriptSource());
               if ( context.isAjaxRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "GridContainerData"+"V", GridContainer.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"GridContainerData"+"V"+"\" value='"+GridContainer.GridValuesHidden()+"'>") ;
               }
            }
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_19_292e( true) ;
         }
         else
         {
            wb_table3_19_292e( false) ;
         }
      }

      protected void wb_table2_8_292( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablesearch_Internalname, tblTablesearch_Internalname, "", "", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblFiltertextbus_des_Internalname, 1, 1, 0, "DESCRIPCION DEL BIEN", "", "", "", 0, lblFiltertextbus_des_Jsonclick, "", StyleString, ClassString, "HLP_WWTBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'" + sGXsfl_26_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavBus_des_Internalname, StringUtil.RTrim( AV13BUS_DES), "", 50, "chr", 1, "row", 50, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV13BUS_DES, "@!")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(13);\"", 0, edtavBus_des_Jsonclick, "", 0, 1, -1, true, "left", "HLP_WWTBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "Separator" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTableseparator_Internalname, 1, 1, 0, " ", "", "", "", 0, lblTableseparator_Jsonclick, "", StyleString, ClassString, "HLP_WWTBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_8_292e( true) ;
         }
         else
         {
            wb_table2_8_292e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
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
         PA292( ) ;
         WS292( ) ;
         WE292( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1175917");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         if ( nGXWrapped != 1 )
         {
            context.AddJavascriptSource("messages.spa.js", "?42940");
            context.AddJavascriptSource("gxdec.js", "?42940");
            context.AddJavascriptSource("wwtbus000.js", "?1175917");
         }
         /* End function include_jscripts */
      }

      protected void sendrow_262( )
      {
         WB290( ) ;
         if ( ( subGrid_Rows * 1 == 0 ) || ( nGXsfl_26_idx <= subGrid_Recordsperpage( ) * 1 ) )
         {
            GridRow = GXWebRow.GetNew(context,GridContainer) ;
            if ( subGrid_Backcolorstyle == 0 )
            {
               /* None style subfile background logic. */
               subGrid_Backstyle = 0 ;
               if ( StringUtil.StrCmp(subGrid_Class, "") != 0 )
               {
                  subGrid_Linesclass = subGrid_Class+"Odd" ;
               }
            }
            else if ( subGrid_Backcolorstyle == 1 )
            {
               /* Uniform style subfile background logic. */
               subGrid_Backstyle = 0 ;
               subGrid_Backcolor = subGrid_Allbackcolor ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "GridContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid_Backcolor), 9, 0)));
               if ( StringUtil.StrCmp(subGrid_Class, "") != 0 )
               {
                  subGrid_Linesclass = subGrid_Class+"Uniform" ;
               }
            }
            else if ( subGrid_Backcolorstyle == 2 )
            {
               /* Header style subfile background logic. */
               subGrid_Backstyle = 1 ;
               if ( StringUtil.StrCmp(subGrid_Class, "") != 0 )
               {
                  subGrid_Linesclass = subGrid_Class+"Odd" ;
               }
               subGrid_Backcolor = (int)(0xF0F0F0) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "GridContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid_Backcolor), 9, 0)));
            }
            else if ( subGrid_Backcolorstyle == 3 )
            {
               /* Report style subfile background logic. */
               subGrid_Backstyle = 1 ;
               if ( ((int)(nGXsfl_26_idx) % (2)) == 0 )
               {
                  subGrid_Backcolor = (int)(0xE5E5E5) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, "GridContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid_Backcolor), 9, 0)));
                  if ( StringUtil.StrCmp(subGrid_Class, "") != 0 )
                  {
                     subGrid_Linesclass = subGrid_Class+"Even" ;
                  }
               }
               else
               {
                  subGrid_Backcolor = (int)(0xF0F0F0) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, "GridContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid_Backcolor), 9, 0)));
                  if ( StringUtil.StrCmp(subGrid_Class, "") != 0 )
                  {
                     subGrid_Linesclass = subGrid_Class+"Odd" ;
                  }
               }
            }
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<tr ") ;
               context.WriteHtmlText( " class=\""+subGrid_Linesclass+"\" style=\""+""+"\"") ;
               context.WriteHtmlText( ">") ;
            }
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Active Bitmap Variable */
            TempTags = " " + ((edtavUpdate_Enabled!=0)&&(edtavUpdate_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 27,'',false,'',26)\"" : " ") ;
            ClassString = "Image" ;
            StyleString = "" ;
            GridRow.AddColumnProperties("bitmap", 2, isAjaxCallMode( ), new Object[] {(String)edtavUpdate_Internalname,(String)"",(String)AV14Update,(String)"Modern",(short)-1,(short)1,(String)"",(String)edtavUpdate_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"",(short)0,(short)0,(String)"",(String)"",(short)5,(String)edtavUpdate_Jsonclick,"E\\'EDITAR\\'."+sGXsfl_26_idx,(String)StyleString,(String)ClassString,(String)"",(String)""+TempTags,(String)"''",(String)""});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "Image" ;
            StyleString = "" ;
            GridRow.AddColumnProperties("bitmap", 2, isAjaxCallMode( ), new Object[] {(String)edtavDelete_Internalname,(String)"",(String)AV15Delete,(String)"Modern",(short)-1,(short)1,(String)"",(String)edtavDelete_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"",(short)0,(short)0,(String)edtavDelete_Link,(String)"",(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"''",(String)""});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBUS_EMP_Internalname,StringUtil.RTrim( A8BUS_EMP),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)1,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A8BUS_EMP, "!")),(String)"",(short)0,(String)edtBUS_EMP_Jsonclick,(String)"",(short)26,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBUS_RUB_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A1BUS_RUB), 4, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)4,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A1BUS_RUB), "ZZZ9"),(String)"",(short)0,(String)edtBUS_RUB_Jsonclick,(String)"",(short)26,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBUS_COD_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A3BUS_COD), 4, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)4,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A3BUS_COD), "ZZZ9"),(String)"",(short)0,(String)edtBUS_COD_Jsonclick,(String)"",(short)26,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBUS_PAR_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A4BUS_PAR), 2, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)2,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A4BUS_PAR), "Z9"),(String)"",(short)0,(String)edtBUS_PAR_Jsonclick,(String)"",(short)26,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBUS_DES_Internalname,StringUtil.RTrim( A54BUS_DES),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)50,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)edtBUS_DES_Link,(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A54BUS_DES, "@!")),(String)"",(short)0,(String)edtBUS_DES_Jsonclick,(String)"",(short)26,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBUS_FAL_Internalname,context.localUtil.Format(A170BUS_FAL, "99/99/9999"),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)10,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( A170BUS_FAL, "99/99/9999"),(String)"",(short)0,(String)edtBUS_FAL_Jsonclick,(String)"",(short)26,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBUS_FAD_Internalname,context.localUtil.Format(A55BUS_FAD, "99/99/9999"),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)10,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( A55BUS_FAD, "99/99/9999"),(String)"",(short)0,(String)edtBUS_FAD_Jsonclick,(String)"",(short)26,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBUS_VUA_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A329BUS_VUA), 4, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)4,(short)0,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A329BUS_VUA), "ZZZ9"),(String)"",(short)0,(String)edtBUS_VUA_Jsonclick,(String)"",(short)26,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBUS_VAO_Internalname,StringUtil.LTrim( StringUtil.NToC( A330BUS_VAO, 18, 7, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)18,(short)0,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( A330BUS_VAO, "ZZZZZZZZZ9.9999999"),(String)"",(short)0,(String)edtBUS_VAO_Jsonclick,(String)"",(short)26,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBUS_COM_Internalname,StringUtil.RTrim( A331BUS_COM),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)2,(short)0,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A331BUS_COM, "@!")),(String)"",(short)0,(String)edtBUS_COM_Jsonclick,(String)"",(short)26,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBUS_CBD_Internalname,StringUtil.RTrim( A350BUS_CBD),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)20,(short)0,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A350BUS_CBD, "@!")),(String)"",(short)0,(String)edtBUS_CBD_Jsonclick,(String)"",(short)26,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBUS_NCO_Internalname,StringUtil.RTrim( A333BUS_NCO),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)12,(short)0,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A333BUS_NCO, "999999999999")),(String)"",(short)0,(String)edtBUS_NCO_Jsonclick,(String)"",(short)26,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBUS_ARE_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A171BUS_ARE), 4, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)4,(short)0,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A171BUS_ARE), "ZZZ9"),(String)"",(short)0,(String)edtBUS_ARE_Jsonclick,(String)"",(short)26,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBUS_ARD_Internalname,StringUtil.RTrim( A175BUS_ARD),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)30,(short)0,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A175BUS_ARD, "@!")),(String)"",(short)0,(String)edtBUS_ARD_Jsonclick,(String)"",(short)26,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBUS_SEC_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A172BUS_SEC), 2, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)2,(short)0,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A172BUS_SEC), "Z9"),(String)"",(short)0,(String)edtBUS_SEC_Jsonclick,(String)"",(short)26,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBUS_SED_Internalname,StringUtil.RTrim( A176BUS_SED),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)30,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A176BUS_SED, "@!")),(String)"",(short)0,(String)edtBUS_SED_Jsonclick,(String)"",(short)26,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBUS_TIP_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A56BUS_TIP), 3, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)3,(short)0,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A56BUS_TIP), "ZZ9"),(String)"",(short)0,(String)edtBUS_TIP_Jsonclick,(String)"",(short)26,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBUS_TID_Internalname,StringUtil.RTrim( A59BUS_TID),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)20,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A59BUS_TID, "@!")),(String)"",(short)0,(String)edtBUS_TID_Jsonclick,(String)"",(short)26,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBUS_FBA_Internalname,context.localUtil.Format(A174BUS_FBA, "99/99/9999"),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)10,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( A174BUS_FBA, "99/99/9999"),(String)"",(short)0,(String)edtBUS_FBA_Jsonclick,(String)"",(short)26,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBUS_MBA_Internalname,StringUtil.RTrim( A334BUS_MBA),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)30,(short)0,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A334BUS_MBA, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")),(String)"",(short)0,(String)edtBUS_MBA_Jsonclick,(String)"",(short)26,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBUS_FPR_Internalname,context.localUtil.Format(A340BUS_FPR, "99/99/9999"),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)10,(short)0,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( A340BUS_FPR, "99/99/9999"),(String)"",(short)0,(String)edtBUS_FPR_Jsonclick,(String)"",(short)26,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBUS_VUT_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A335BUS_VUT), 4, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)4,(short)0,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A335BUS_VUT), "ZZZ9"),(String)"",(short)0,(String)edtBUS_VUT_Jsonclick,(String)"",(short)26,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBUS_COE_Internalname,StringUtil.LTrim( StringUtil.NToC( A336BUS_COE, 18, 7, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)18,(short)0,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( A336BUS_COE, "ZZZZZZZZZ9.9999999"),(String)"",(short)0,(String)edtBUS_COE_Jsonclick,(String)"",(short)26,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBUS_VOC_Internalname,StringUtil.LTrim( StringUtil.NToC( A341BUS_VOC, 18, 7, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)18,(short)0,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( A341BUS_VOC, "ZZZZZZZZZ9.9999999"),(String)"",(short)0,(String)edtBUS_VOC_Jsonclick,(String)"",(short)26,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBUS_VOA_Internalname,StringUtil.LTrim( StringUtil.NToC( A337BUS_VOA, 18, 7, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)18,(short)0,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( A337BUS_VOA, "ZZZZZZZZZ9.9999999"),(String)"",(short)0,(String)edtBUS_VOA_Jsonclick,(String)"",(short)26,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBUS_AAA_Internalname,StringUtil.LTrim( StringUtil.NToC( A338BUS_AAA, 10, 2, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)10,(short)0,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( A338BUS_AAA, "ZZZZZZ9.99"),(String)"",(short)0,(String)edtBUS_AAA_Jsonclick,(String)"",(short)26,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBUS_AEA_Internalname,StringUtil.LTrim( StringUtil.NToC( A339BUS_AEA, 10, 2, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)10,(short)0,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( A339BUS_AEA, "ZZZZZZ9.99"),(String)"",(short)0,(String)edtBUS_AEA_Jsonclick,(String)"",(short)26,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBUS_VAH_Internalname,StringUtil.LTrim( StringUtil.NToC( A342BUS_VAH, 18, 7, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)18,(short)0,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( A342BUS_VAH, "ZZZZZZZZZ9.9999999"),(String)"",(short)0,(String)edtBUS_VAH_Jsonclick,(String)"",(short)26,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBUS_VHF_Internalname,context.localUtil.Format(A343BUS_VHF, "99/99/9999"),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)10,(short)0,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( A343BUS_VHF, "99/99/9999"),(String)"",(short)0,(String)edtBUS_VHF_Jsonclick,(String)"",(short)26,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBUS_VOH_Internalname,StringUtil.LTrim( StringUtil.NToC( A344BUS_VOH, 18, 7, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)18,(short)0,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( A344BUS_VOH, "ZZZZZZZZZ9.9999999"),(String)"",(short)0,(String)edtBUS_VOH_Jsonclick,(String)"",(short)26,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBUS_AAH_Internalname,StringUtil.LTrim( StringUtil.NToC( A345BUS_AAH, 10, 2, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)10,(short)0,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( A345BUS_AAH, "ZZZZZZ9.99"),(String)"",(short)0,(String)edtBUS_AAH_Jsonclick,(String)"",(short)26,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBUS_AEH_Internalname,StringUtil.LTrim( StringUtil.NToC( A346BUS_AEH, 10, 2, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)10,(short)0,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( A346BUS_AEH, "ZZZZZZ9.99"),(String)"",(short)0,(String)edtBUS_AEH_Jsonclick,(String)"",(short)26,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBUS_VRA_Internalname,StringUtil.LTrim( StringUtil.NToC( A347BUS_VRA, 18, 7, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)18,(short)0,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( A347BUS_VRA, "ZZZZZZZZZ9.9999999"),(String)"",(short)0,(String)edtBUS_VRA_Jsonclick,(String)"",(short)26,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBUS_VRH_Internalname,StringUtil.LTrim( StringUtil.NToC( A348BUS_VRH, 18, 7, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)18,(short)0,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( A348BUS_VRH, "ZZZZZZZZZ9.9999999"),(String)"",(short)0,(String)edtBUS_VRH_Jsonclick,(String)"",(short)26,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBUS_VUR_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A349BUS_VUR), 4, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)4,(short)0,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A349BUS_VUR), "ZZZ9"),(String)"",(short)0,(String)edtBUS_VUR_Jsonclick,(String)"",(short)26,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBUS_RUD_Internalname,StringUtil.RTrim( A61BUS_RUD),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)30,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A61BUS_RUD, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")),(String)"",(short)0,(String)edtBUS_RUD_Jsonclick,(String)"",(short)26,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBUS_AMO_Internalname,StringUtil.RTrim( A178BUS_AMO),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)1,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A178BUS_AMO, "!")),(String)"",(short)0,(String)edtBUS_AMO_Jsonclick,(String)"",(short)26,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBUS_IDT_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A103BUS_IDT), 8, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)8,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A103BUS_IDT), "ZZZZZZZ9"),(String)"",(short)7,(String)edtBUS_IDT_Jsonclick,(String)"'"+""+"'"+",false,"+"'"+"e16292_client"+"'",(short)26,(short)1,(short)1,(bool)true,(String)"right"});
            GridContainer.AddRow(GridRow);
            nGXsfl_26_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_26_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_26_idx+1)) ;
            sGXsfl_26_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_26_idx), 4, 0)), 4, "0") ;
            edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_26_idx ;
            edtavDelete_Internalname = "vDELETE_"+sGXsfl_26_idx ;
            edtBUS_EMP_Internalname = "BUS_EMP_"+sGXsfl_26_idx ;
            edtBUS_RUB_Internalname = "BUS_RUB_"+sGXsfl_26_idx ;
            edtBUS_COD_Internalname = "BUS_COD_"+sGXsfl_26_idx ;
            edtBUS_PAR_Internalname = "BUS_PAR_"+sGXsfl_26_idx ;
            edtBUS_DES_Internalname = "BUS_DES_"+sGXsfl_26_idx ;
            edtBUS_FAL_Internalname = "BUS_FAL_"+sGXsfl_26_idx ;
            edtBUS_FAD_Internalname = "BUS_FAD_"+sGXsfl_26_idx ;
            edtBUS_VUA_Internalname = "BUS_VUA_"+sGXsfl_26_idx ;
            edtBUS_VAO_Internalname = "BUS_VAO_"+sGXsfl_26_idx ;
            edtBUS_COM_Internalname = "BUS_COM_"+sGXsfl_26_idx ;
            edtBUS_CBD_Internalname = "BUS_CBD_"+sGXsfl_26_idx ;
            edtBUS_NCO_Internalname = "BUS_NCO_"+sGXsfl_26_idx ;
            edtBUS_ARE_Internalname = "BUS_ARE_"+sGXsfl_26_idx ;
            edtBUS_ARD_Internalname = "BUS_ARD_"+sGXsfl_26_idx ;
            edtBUS_SEC_Internalname = "BUS_SEC_"+sGXsfl_26_idx ;
            edtBUS_SED_Internalname = "BUS_SED_"+sGXsfl_26_idx ;
            edtBUS_TIP_Internalname = "BUS_TIP_"+sGXsfl_26_idx ;
            edtBUS_TID_Internalname = "BUS_TID_"+sGXsfl_26_idx ;
            edtBUS_FBA_Internalname = "BUS_FBA_"+sGXsfl_26_idx ;
            edtBUS_MBA_Internalname = "BUS_MBA_"+sGXsfl_26_idx ;
            edtBUS_FPR_Internalname = "BUS_FPR_"+sGXsfl_26_idx ;
            edtBUS_VUT_Internalname = "BUS_VUT_"+sGXsfl_26_idx ;
            edtBUS_COE_Internalname = "BUS_COE_"+sGXsfl_26_idx ;
            edtBUS_VOC_Internalname = "BUS_VOC_"+sGXsfl_26_idx ;
            edtBUS_VOA_Internalname = "BUS_VOA_"+sGXsfl_26_idx ;
            edtBUS_AAA_Internalname = "BUS_AAA_"+sGXsfl_26_idx ;
            edtBUS_AEA_Internalname = "BUS_AEA_"+sGXsfl_26_idx ;
            edtBUS_VAH_Internalname = "BUS_VAH_"+sGXsfl_26_idx ;
            edtBUS_VHF_Internalname = "BUS_VHF_"+sGXsfl_26_idx ;
            edtBUS_VOH_Internalname = "BUS_VOH_"+sGXsfl_26_idx ;
            edtBUS_AAH_Internalname = "BUS_AAH_"+sGXsfl_26_idx ;
            edtBUS_AEH_Internalname = "BUS_AEH_"+sGXsfl_26_idx ;
            edtBUS_VRA_Internalname = "BUS_VRA_"+sGXsfl_26_idx ;
            edtBUS_VRH_Internalname = "BUS_VRH_"+sGXsfl_26_idx ;
            edtBUS_VUR_Internalname = "BUS_VUR_"+sGXsfl_26_idx ;
            edtBUS_RUD_Internalname = "BUS_RUD_"+sGXsfl_26_idx ;
            edtBUS_AMO_Internalname = "BUS_AMO_"+sGXsfl_26_idx ;
            edtBUS_IDT_Internalname = "BUS_IDT_"+sGXsfl_26_idx ;
         }
         /* End function sendrow_262 */
      }

      protected void init_default_properties( )
      {
         lblTitletext_Internalname = "TITLETEXT" ;
         lblFiltertextbus_des_Internalname = "FILTERTEXTBUS_DES" ;
         edtavBus_des_Internalname = "vBUS_DES" ;
         lblTableseparator_Internalname = "TABLESEPARATOR" ;
         tblTablesearch_Internalname = "TABLESEARCH" ;
         imgInsert_Internalname = "INSERT" ;
         tblTablegridcontainer_Internalname = "TABLEGRIDCONTAINER" ;
         tblTable_Internalname = "TABLE" ;
         Form.Internalname = "FORM" ;
         subGrid_Internalname = "GRID" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         edtBUS_IDT_Jsonclick = "" ;
         edtBUS_AMO_Jsonclick = "" ;
         edtBUS_RUD_Jsonclick = "" ;
         edtBUS_VUR_Jsonclick = "" ;
         edtBUS_VRH_Jsonclick = "" ;
         edtBUS_VRA_Jsonclick = "" ;
         edtBUS_AEH_Jsonclick = "" ;
         edtBUS_AAH_Jsonclick = "" ;
         edtBUS_VOH_Jsonclick = "" ;
         edtBUS_VHF_Jsonclick = "" ;
         edtBUS_VAH_Jsonclick = "" ;
         edtBUS_AEA_Jsonclick = "" ;
         edtBUS_AAA_Jsonclick = "" ;
         edtBUS_VOA_Jsonclick = "" ;
         edtBUS_VOC_Jsonclick = "" ;
         edtBUS_COE_Jsonclick = "" ;
         edtBUS_VUT_Jsonclick = "" ;
         edtBUS_FPR_Jsonclick = "" ;
         edtBUS_MBA_Jsonclick = "" ;
         edtBUS_FBA_Jsonclick = "" ;
         edtBUS_TID_Jsonclick = "" ;
         edtBUS_TIP_Jsonclick = "" ;
         edtBUS_SED_Jsonclick = "" ;
         edtBUS_SEC_Jsonclick = "" ;
         edtBUS_ARD_Jsonclick = "" ;
         edtBUS_ARE_Jsonclick = "" ;
         edtBUS_NCO_Jsonclick = "" ;
         edtBUS_CBD_Jsonclick = "" ;
         edtBUS_COM_Jsonclick = "" ;
         edtBUS_VAO_Jsonclick = "" ;
         edtBUS_VUA_Jsonclick = "" ;
         edtBUS_FAD_Jsonclick = "" ;
         edtBUS_FAL_Jsonclick = "" ;
         edtBUS_DES_Jsonclick = "" ;
         edtBUS_PAR_Jsonclick = "" ;
         edtBUS_COD_Jsonclick = "" ;
         edtBUS_RUB_Jsonclick = "" ;
         edtBUS_EMP_Jsonclick = "" ;
         edtavUpdate_Jsonclick = "" ;
         edtavUpdate_Visible = -1 ;
         edtavUpdate_Enabled = 1 ;
         edtavBus_des_Jsonclick = "" ;
         subGrid_Class = "WorkWith" ;
         subGrid_Backcolorstyle = 3 ;
         edtBUS_DES_Link = "" ;
         edtavDelete_Link = "" ;
         subGrid_Rows = 0 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Work With ACT. DE BIENES DE USO" ;
         edtavUpdate_Tooltiptext = "Modifica" ;
         edtavDelete_Tooltiptext = "Eliminar" ;
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
         edtavDelete_Internalname = "" ;
         AV15Delete = "" ;
         edtavUpdate_Internalname = "" ;
         AV14Update = "" ;
         AV21Pgmname = "" ;
         AV13BUS_DES = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         AV17USUARIO = "" ;
         AV16SISTEMA = "" ;
         GX_FocusControl = "" ;
         Form = new GXWebForm();
         sPrefix = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         edtBUS_EMP_Internalname = "" ;
         edtBUS_RUB_Internalname = "" ;
         edtBUS_COD_Internalname = "" ;
         edtBUS_PAR_Internalname = "" ;
         edtBUS_DES_Internalname = "" ;
         edtBUS_FAL_Internalname = "" ;
         edtBUS_FAD_Internalname = "" ;
         edtBUS_VUA_Internalname = "" ;
         edtBUS_VAO_Internalname = "" ;
         edtBUS_COM_Internalname = "" ;
         edtBUS_CBD_Internalname = "" ;
         edtBUS_NCO_Internalname = "" ;
         edtBUS_ARE_Internalname = "" ;
         edtBUS_ARD_Internalname = "" ;
         edtBUS_SEC_Internalname = "" ;
         edtBUS_SED_Internalname = "" ;
         edtBUS_TIP_Internalname = "" ;
         edtBUS_TID_Internalname = "" ;
         edtBUS_FBA_Internalname = "" ;
         edtBUS_MBA_Internalname = "" ;
         edtBUS_FPR_Internalname = "" ;
         edtBUS_VUT_Internalname = "" ;
         edtBUS_COE_Internalname = "" ;
         edtBUS_VOC_Internalname = "" ;
         edtBUS_VOA_Internalname = "" ;
         edtBUS_AAA_Internalname = "" ;
         edtBUS_AEA_Internalname = "" ;
         edtBUS_VAH_Internalname = "" ;
         edtBUS_VHF_Internalname = "" ;
         edtBUS_VOH_Internalname = "" ;
         edtBUS_AAH_Internalname = "" ;
         edtBUS_AEH_Internalname = "" ;
         edtBUS_VRA_Internalname = "" ;
         edtBUS_VRH_Internalname = "" ;
         edtBUS_VUR_Internalname = "" ;
         edtBUS_RUD_Internalname = "" ;
         edtBUS_AMO_Internalname = "" ;
         edtBUS_IDT_Internalname = "" ;
         A8BUS_EMP = "" ;
         A54BUS_DES = "" ;
         A170BUS_FAL = DateTime.MinValue ;
         A55BUS_FAD = DateTime.MinValue ;
         A331BUS_COM = "" ;
         A350BUS_CBD = "" ;
         A333BUS_NCO = "" ;
         A175BUS_ARD = "" ;
         A176BUS_SED = "" ;
         A59BUS_TID = "" ;
         A174BUS_FBA = DateTime.MinValue ;
         A334BUS_MBA = "" ;
         A340BUS_FPR = DateTime.MinValue ;
         A343BUS_VHF = DateTime.MinValue ;
         A61BUS_RUD = "" ;
         A178BUS_AMO = "" ;
         GridContainer = new GXWebGrid( context);
         scmdbuf = "" ;
         lV13BUS_DES = "" ;
         H00292_A103BUS_IDT = new int[1] ;
         H00292_A178BUS_AMO = new String[] {""} ;
         H00292_n178BUS_AMO = new bool[] {false} ;
         H00292_A61BUS_RUD = new String[] {""} ;
         H00292_n61BUS_RUD = new bool[] {false} ;
         H00292_A343BUS_VHF = new DateTime[] {DateTime.MinValue} ;
         H00292_A342BUS_VAH = new decimal[1] ;
         H00292_A341BUS_VOC = new decimal[1] ;
         H00292_A336BUS_COE = new decimal[1] ;
         H00292_A340BUS_FPR = new DateTime[] {DateTime.MinValue} ;
         H00292_A334BUS_MBA = new String[] {""} ;
         H00292_A174BUS_FBA = new DateTime[] {DateTime.MinValue} ;
         H00292_A59BUS_TID = new String[] {""} ;
         H00292_A56BUS_TIP = new short[1] ;
         H00292_A176BUS_SED = new String[] {""} ;
         H00292_A172BUS_SEC = new short[1] ;
         H00292_A175BUS_ARD = new String[] {""} ;
         H00292_A171BUS_ARE = new short[1] ;
         H00292_A333BUS_NCO = new String[] {""} ;
         H00292_A350BUS_CBD = new String[] {""} ;
         H00292_A331BUS_COM = new String[] {""} ;
         H00292_A330BUS_VAO = new decimal[1] ;
         H00292_A55BUS_FAD = new DateTime[] {DateTime.MinValue} ;
         H00292_A170BUS_FAL = new DateTime[] {DateTime.MinValue} ;
         H00292_A54BUS_DES = new String[] {""} ;
         H00292_A4BUS_PAR = new short[1] ;
         H00292_A3BUS_COD = new short[1] ;
         H00292_A1BUS_RUB = new short[1] ;
         H00292_A8BUS_EMP = new String[] {""} ;
         H00292_A339BUS_AEA = new decimal[1] ;
         H00292_A338BUS_AAA = new decimal[1] ;
         H00292_A337BUS_VOA = new decimal[1] ;
         H00292_A346BUS_AEH = new decimal[1] ;
         H00292_A345BUS_AAH = new decimal[1] ;
         H00292_A344BUS_VOH = new decimal[1] ;
         H00292_A335BUS_VUT = new short[1] ;
         H00292_A329BUS_VUA = new short[1] ;
         H00293_AGRID_nRecordCount = new int[1] ;
         AV18SESION = new GxWebSession( context);
         AV8HTTPRequest = new GxHttpRequest( context);
         AV9GridState = new SdtGridState(context);
         AV7Session = new GxWebSession( context);
         AV10GridStateFilterValue = new SdtGridState_FilterValue(context);
         AV11TrnContext = new SdtTransactionContext(context);
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         lblTitletext_Jsonclick = "" ;
         TempTags = "" ;
         imgInsert_Jsonclick = "" ;
         subGrid_Linesclass = "" ;
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
         GXt_char15 = "" ;
         GXt_char16 = "" ;
         GXt_char17 = "" ;
         GXt_char18 = "" ;
         GXt_char19 = "" ;
         GXt_char20 = "" ;
         GXt_char21 = "" ;
         GXt_char22 = "" ;
         GXt_char23 = "" ;
         GXt_char24 = "" ;
         GXt_char25 = "" ;
         GXt_char26 = "" ;
         GXt_char27 = "" ;
         GXt_char28 = "" ;
         GXt_char29 = "" ;
         GXt_char30 = "" ;
         GXt_char31 = "" ;
         GXt_char32 = "" ;
         GXt_char33 = "" ;
         GXt_char34 = "" ;
         GXt_char35 = "" ;
         GXt_char36 = "" ;
         GXt_char37 = "" ;
         GXt_char38 = "" ;
         GXt_char39 = "" ;
         GridColumn = new GXWebColumn();
         lblFiltertextbus_des_Jsonclick = "" ;
         lblTableseparator_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         GridRow = new GXWebRow();
         GXt_char40 = "" ;
         ROClassString = "" ;
         GXt_char41 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wwtbus000__default(),
            new Object[][] {
                new Object[] {
               H00292_A103BUS_IDT, H00292_A178BUS_AMO, H00292_n178BUS_AMO, H00292_A61BUS_RUD, H00292_n61BUS_RUD, H00292_A343BUS_VHF, H00292_A342BUS_VAH, H00292_A341BUS_VOC, H00292_A336BUS_COE, H00292_A340BUS_FPR,
               H00292_A334BUS_MBA, H00292_A174BUS_FBA, H00292_A59BUS_TID, H00292_A56BUS_TIP, H00292_A176BUS_SED, H00292_A172BUS_SEC, H00292_A175BUS_ARD, H00292_A171BUS_ARE, H00292_A333BUS_NCO, H00292_A350BUS_CBD,
               H00292_A331BUS_COM, H00292_A330BUS_VAO, H00292_A55BUS_FAD, H00292_A170BUS_FAL, H00292_A54BUS_DES, H00292_A4BUS_PAR, H00292_A3BUS_COD, H00292_A1BUS_RUB, H00292_A8BUS_EMP, H00292_A339BUS_AEA,
               H00292_A338BUS_AAA, H00292_A337BUS_VOA, H00292_A346BUS_AEH, H00292_A345BUS_AAH, H00292_A344BUS_VOH, H00292_A335BUS_VUT, H00292_A329BUS_VUA
               }
               , new Object[] {
               H00293_AGRID_nRecordCount
               }
            }
         );
         AV21Pgmname = "WWTBUS000" ;
         /* GeneXus formulas. */
         AV21Pgmname = "WWTBUS000" ;
         context.Gx_err = 0 ;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_Grid ;
      private short nGXsfl_26_idx=1 ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short nGXWrapped ;
      private short GRID_nEOF ;
      private short subGrid_Rows ;
      private short wbEnd ;
      private short wbStart ;
      private short A1BUS_RUB ;
      private short A3BUS_COD ;
      private short A4BUS_PAR ;
      private short A329BUS_VUA ;
      private short A171BUS_ARE ;
      private short A172BUS_SEC ;
      private short A56BUS_TIP ;
      private short A335BUS_VUT ;
      private short A349BUS_VUR ;
      private short nDonePA ;
      private short subGrid_Backcolorstyle ;
      private short subGrid_Titlebackstyle ;
      private short subGrid_Collapsed ;
      private short subGrid_Backstyle ;
      private int Grid_PageSize26 ;
      private int GRID_nFirstRecordOnPage ;
      private int A103BUS_IDT ;
      private int subGrid_Islastpage ;
      private int GRID_nCurrentRecord ;
      private int GRID_nRecordCount ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private int edtavUpdate_Enabled ;
      private int edtavUpdate_Visible ;
      private decimal A330BUS_VAO ;
      private decimal A336BUS_COE ;
      private decimal A341BUS_VOC ;
      private decimal A337BUS_VOA ;
      private decimal A338BUS_AAA ;
      private decimal A339BUS_AEA ;
      private decimal A342BUS_VAH ;
      private decimal A344BUS_VOH ;
      private decimal A345BUS_AAH ;
      private decimal A346BUS_AEH ;
      private decimal A347BUS_VRA ;
      private decimal A348BUS_VRH ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_26_idx="0001" ;
      private String edtavDelete_Tooltiptext ;
      private String edtavDelete_Internalname ;
      private String edtavUpdate_Tooltiptext ;
      private String edtavUpdate_Internalname ;
      private String AV21Pgmname ;
      private String AV13BUS_DES ;
      private String sDynURL ;
      private String FormProcess ;
      private String AV17USUARIO ;
      private String AV16SISTEMA ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtBUS_EMP_Internalname ;
      private String edtBUS_RUB_Internalname ;
      private String edtBUS_COD_Internalname ;
      private String edtBUS_PAR_Internalname ;
      private String edtBUS_DES_Internalname ;
      private String edtBUS_FAL_Internalname ;
      private String edtBUS_FAD_Internalname ;
      private String edtBUS_VUA_Internalname ;
      private String edtBUS_VAO_Internalname ;
      private String edtBUS_COM_Internalname ;
      private String edtBUS_CBD_Internalname ;
      private String edtBUS_NCO_Internalname ;
      private String edtBUS_ARE_Internalname ;
      private String edtBUS_ARD_Internalname ;
      private String edtBUS_SEC_Internalname ;
      private String edtBUS_SED_Internalname ;
      private String edtBUS_TIP_Internalname ;
      private String edtBUS_TID_Internalname ;
      private String edtBUS_FBA_Internalname ;
      private String edtBUS_MBA_Internalname ;
      private String edtBUS_FPR_Internalname ;
      private String edtBUS_VUT_Internalname ;
      private String edtBUS_COE_Internalname ;
      private String edtBUS_VOC_Internalname ;
      private String edtBUS_VOA_Internalname ;
      private String edtBUS_AAA_Internalname ;
      private String edtBUS_AEA_Internalname ;
      private String edtBUS_VAH_Internalname ;
      private String edtBUS_VHF_Internalname ;
      private String edtBUS_VOH_Internalname ;
      private String edtBUS_AAH_Internalname ;
      private String edtBUS_AEH_Internalname ;
      private String edtBUS_VRA_Internalname ;
      private String edtBUS_VRH_Internalname ;
      private String edtBUS_VUR_Internalname ;
      private String edtBUS_RUD_Internalname ;
      private String edtBUS_AMO_Internalname ;
      private String edtBUS_IDT_Internalname ;
      private String A8BUS_EMP ;
      private String A54BUS_DES ;
      private String A331BUS_COM ;
      private String A350BUS_CBD ;
      private String A333BUS_NCO ;
      private String A175BUS_ARD ;
      private String A176BUS_SED ;
      private String A59BUS_TID ;
      private String A334BUS_MBA ;
      private String A61BUS_RUD ;
      private String A178BUS_AMO ;
      private String edtavBus_des_Internalname ;
      private String scmdbuf ;
      private String lV13BUS_DES ;
      private String edtavDelete_Link ;
      private String edtBUS_DES_Link ;
      private String sStyleString ;
      private String tblTable_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String lblTitletext_Internalname ;
      private String lblTitletext_Jsonclick ;
      private String tblTablegridcontainer_Internalname ;
      private String TempTags ;
      private String imgInsert_Internalname ;
      private String imgInsert_Jsonclick ;
      private String subGrid_Internalname ;
      private String subGrid_Class ;
      private String subGrid_Linesclass ;
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
      private String GXt_char16 ;
      private String GXt_char17 ;
      private String GXt_char18 ;
      private String GXt_char19 ;
      private String GXt_char20 ;
      private String GXt_char21 ;
      private String GXt_char22 ;
      private String GXt_char23 ;
      private String GXt_char24 ;
      private String GXt_char25 ;
      private String GXt_char26 ;
      private String GXt_char27 ;
      private String GXt_char28 ;
      private String GXt_char29 ;
      private String GXt_char30 ;
      private String GXt_char31 ;
      private String GXt_char32 ;
      private String GXt_char33 ;
      private String GXt_char34 ;
      private String GXt_char35 ;
      private String GXt_char36 ;
      private String GXt_char37 ;
      private String GXt_char38 ;
      private String GXt_char39 ;
      private String tblTablesearch_Internalname ;
      private String lblFiltertextbus_des_Internalname ;
      private String lblFiltertextbus_des_Jsonclick ;
      private String edtavBus_des_Jsonclick ;
      private String lblTableseparator_Internalname ;
      private String lblTableseparator_Jsonclick ;
      private String edtavUpdate_Jsonclick ;
      private String GXt_char40 ;
      private String ROClassString ;
      private String edtBUS_EMP_Jsonclick ;
      private String edtBUS_RUB_Jsonclick ;
      private String edtBUS_COD_Jsonclick ;
      private String edtBUS_PAR_Jsonclick ;
      private String edtBUS_DES_Jsonclick ;
      private String edtBUS_FAL_Jsonclick ;
      private String edtBUS_FAD_Jsonclick ;
      private String edtBUS_VUA_Jsonclick ;
      private String edtBUS_VAO_Jsonclick ;
      private String edtBUS_COM_Jsonclick ;
      private String edtBUS_CBD_Jsonclick ;
      private String edtBUS_NCO_Jsonclick ;
      private String edtBUS_ARE_Jsonclick ;
      private String edtBUS_ARD_Jsonclick ;
      private String edtBUS_SEC_Jsonclick ;
      private String edtBUS_SED_Jsonclick ;
      private String edtBUS_TIP_Jsonclick ;
      private String edtBUS_TID_Jsonclick ;
      private String edtBUS_FBA_Jsonclick ;
      private String edtBUS_MBA_Jsonclick ;
      private String edtBUS_FPR_Jsonclick ;
      private String edtBUS_VUT_Jsonclick ;
      private String edtBUS_COE_Jsonclick ;
      private String edtBUS_VOC_Jsonclick ;
      private String edtBUS_VOA_Jsonclick ;
      private String edtBUS_AAA_Jsonclick ;
      private String edtBUS_AEA_Jsonclick ;
      private String edtBUS_VAH_Jsonclick ;
      private String edtBUS_VHF_Jsonclick ;
      private String edtBUS_VOH_Jsonclick ;
      private String edtBUS_AAH_Jsonclick ;
      private String edtBUS_AEH_Jsonclick ;
      private String edtBUS_VRA_Jsonclick ;
      private String edtBUS_VRH_Jsonclick ;
      private String edtBUS_VUR_Jsonclick ;
      private String edtBUS_RUD_Jsonclick ;
      private String edtBUS_AMO_Jsonclick ;
      private String edtBUS_IDT_Jsonclick ;
      private String GXt_char41 ;
      private DateTime A170BUS_FAL ;
      private DateTime A55BUS_FAD ;
      private DateTime A174BUS_FBA ;
      private DateTime A340BUS_FPR ;
      private DateTime A343BUS_VHF ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n61BUS_RUD ;
      private bool n178BUS_AMO ;
      private bool returnInSub ;
      private bool AV5IsAuthorized ;
      private String AV15Delete ;
      private String AV14Update ;
      private GxWebSession AV7Session ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] H00292_A103BUS_IDT ;
      private String[] H00292_A178BUS_AMO ;
      private bool[] H00292_n178BUS_AMO ;
      private String[] H00292_A61BUS_RUD ;
      private bool[] H00292_n61BUS_RUD ;
      private DateTime[] H00292_A343BUS_VHF ;
      private decimal[] H00292_A342BUS_VAH ;
      private decimal[] H00292_A341BUS_VOC ;
      private decimal[] H00292_A336BUS_COE ;
      private DateTime[] H00292_A340BUS_FPR ;
      private String[] H00292_A334BUS_MBA ;
      private DateTime[] H00292_A174BUS_FBA ;
      private String[] H00292_A59BUS_TID ;
      private short[] H00292_A56BUS_TIP ;
      private String[] H00292_A176BUS_SED ;
      private short[] H00292_A172BUS_SEC ;
      private String[] H00292_A175BUS_ARD ;
      private short[] H00292_A171BUS_ARE ;
      private String[] H00292_A333BUS_NCO ;
      private String[] H00292_A350BUS_CBD ;
      private String[] H00292_A331BUS_COM ;
      private decimal[] H00292_A330BUS_VAO ;
      private DateTime[] H00292_A55BUS_FAD ;
      private DateTime[] H00292_A170BUS_FAL ;
      private String[] H00292_A54BUS_DES ;
      private short[] H00292_A4BUS_PAR ;
      private short[] H00292_A3BUS_COD ;
      private short[] H00292_A1BUS_RUB ;
      private String[] H00292_A8BUS_EMP ;
      private decimal[] H00292_A339BUS_AEA ;
      private decimal[] H00292_A338BUS_AAA ;
      private decimal[] H00292_A337BUS_VOA ;
      private decimal[] H00292_A346BUS_AEH ;
      private decimal[] H00292_A345BUS_AAH ;
      private decimal[] H00292_A344BUS_VOH ;
      private short[] H00292_A335BUS_VUT ;
      private short[] H00292_A329BUS_VUA ;
      private int[] H00293_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV8HTTPRequest ;
      private GxWebSession AV18SESION ;
      private GXWebForm Form ;
      private SdtGridState AV9GridState ;
      private SdtGridState_FilterValue AV10GridStateFilterValue ;
      private SdtTransactionContext AV11TrnContext ;
   }

   public class wwtbus000__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H00292( String AV13BUS_DES ,
                                             String A54BUS_DES )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int42 ;
         GXv_int42 = new short [1] ;
         Object[] GXv_Object43 ;
         GXv_Object43 = new Object [2] ;
         scmdbuf = "SELECT T1.[BUS_IDT], T2.[RBR_AMO] AS BUS_AMO, T2.[RBR_DES] AS BUS_RUD, T1.[BUS_VHF], T1.[BUS_VAH], T1.[BUS_VOC], T1.[BUS_COE], T1.[BUS_FPR], T1.[BUS_MBA], T1.[BUS_FBA], T1.[BUS_TID], T1.[BUS_TIP], T1.[BUS_SED], T1.[BUS_SEC], T1.[BUS_ARD], T1.[BUS_ARE], T1.[BUS_NCO], T1.[BUS_CBD], T1.[BUS_COM], T1.[BUS_VAO], T1.[BUS_FAD], T1.[BUS_FAL], T1.[BUS_DES], T1.[BUS_PAR], T1.[BUS_COD], T1.[BUS_RUB] AS BUS_RUB, T1.[BUS_EMP], T1.[BUS_AEA], T1.[BUS_AAA], T1.[BUS_VOA], T1.[BUS_AEH], T1.[BUS_AAH], T1.[BUS_VOH], T1.[BUS_VUT], T1.[BUS_VUA] FROM ([BUS000] T1 WITH (NOLOCK) INNER JOIN [BUS002] T2 WITH (NOLOCK) ON T2.[RBR_COD] = T1.[BUS_RUB])" ;
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV13BUS_DES)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BUS_DES] like @AV13BUS_DES)" ;
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BUS_DES] like @AV13BUS_DES)" ;
            }
         }
         else
         {
            GXv_int42[0] = 1 ;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE " + sWhereString ;
         }
         scmdbuf = scmdbuf + " ORDER BY T1.[BUS_DES]" ;
         GXv_Object43[0] = scmdbuf ;
         GXv_Object43[1] = (Object)(GXv_int42) ;
         return GXv_Object43 ;
      }

      protected Object[] conditional_H00293( String AV13BUS_DES ,
                                             String A54BUS_DES )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int44 ;
         GXv_int44 = new short [1] ;
         Object[] GXv_Object45 ;
         GXv_Object45 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM ([BUS000] T1 WITH (NOLOCK) INNER JOIN [BUS002] T2 WITH (NOLOCK) ON T2.[RBR_COD] = T1.[BUS_RUB])" ;
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV13BUS_DES)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BUS_DES] like @AV13BUS_DES)" ;
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BUS_DES] like @AV13BUS_DES)" ;
            }
         }
         else
         {
            GXv_int44[0] = 1 ;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE " + sWhereString ;
         }
         scmdbuf = scmdbuf + "" ;
         GXv_Object45[0] = scmdbuf ;
         GXv_Object45[1] = (Object)(GXv_int44) ;
         return GXv_Object45 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_H00292( (String)dynConstraints[0] , (String)dynConstraints[1] );
               case 1 :
                     return conditional_H00293( (String)dynConstraints[0] , (String)dynConstraints[1] );
         }
         return base.getDynamicStatement(cursor, dynConstraints);
      }

      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH00292 ;
          prmH00292 = new Object[] {
          new Object[] {"@AV13BUS_DES",SqlDbType.Char,50,0}
          } ;
          Object[] prmH00293 ;
          prmH00293 = new Object[] {
          new Object[] {"@AV13BUS_DES",SqlDbType.Char,50,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00292", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00292,11,0,true,false )
             ,new CursorDef("H00293", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00293,1,0,true,false )
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
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 1) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getString(3, 30) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((DateTime[]) buf[5])[0] = rslt.getGXDate(4) ;
                ((decimal[]) buf[6])[0] = rslt.getDecimal(5) ;
                ((decimal[]) buf[7])[0] = rslt.getDecimal(6) ;
                ((decimal[]) buf[8])[0] = rslt.getDecimal(7) ;
                ((DateTime[]) buf[9])[0] = rslt.getGXDate(8) ;
                ((String[]) buf[10])[0] = rslt.getString(9, 30) ;
                ((DateTime[]) buf[11])[0] = rslt.getGXDate(10) ;
                ((String[]) buf[12])[0] = rslt.getString(11, 20) ;
                ((short[]) buf[13])[0] = rslt.getShort(12) ;
                ((String[]) buf[14])[0] = rslt.getString(13, 30) ;
                ((short[]) buf[15])[0] = rslt.getShort(14) ;
                ((String[]) buf[16])[0] = rslt.getString(15, 30) ;
                ((short[]) buf[17])[0] = rslt.getShort(16) ;
                ((String[]) buf[18])[0] = rslt.getString(17, 12) ;
                ((String[]) buf[19])[0] = rslt.getString(18, 20) ;
                ((String[]) buf[20])[0] = rslt.getString(19, 2) ;
                ((decimal[]) buf[21])[0] = rslt.getDecimal(20) ;
                ((DateTime[]) buf[22])[0] = rslt.getGXDate(21) ;
                ((DateTime[]) buf[23])[0] = rslt.getGXDate(22) ;
                ((String[]) buf[24])[0] = rslt.getString(23, 50) ;
                ((short[]) buf[25])[0] = rslt.getShort(24) ;
                ((short[]) buf[26])[0] = rslt.getShort(25) ;
                ((short[]) buf[27])[0] = rslt.getShort(26) ;
                ((String[]) buf[28])[0] = rslt.getString(27, 1) ;
                ((decimal[]) buf[29])[0] = rslt.getDecimal(28) ;
                ((decimal[]) buf[30])[0] = rslt.getDecimal(29) ;
                ((decimal[]) buf[31])[0] = rslt.getDecimal(30) ;
                ((decimal[]) buf[32])[0] = rslt.getDecimal(31) ;
                ((decimal[]) buf[33])[0] = rslt.getDecimal(32) ;
                ((decimal[]) buf[34])[0] = rslt.getDecimal(33) ;
                ((short[]) buf[35])[0] = rslt.getShort(34) ;
                ((short[]) buf[36])[0] = rslt.getShort(35) ;
                break;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
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
                sIdx = 0 ;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1) ;
                   stmt.SetParameter(sIdx, (String)parms[1]);
                }
                break;
             case 1 :
                sIdx = 0 ;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1) ;
                   stmt.SetParameter(sIdx, (String)parms[1]);
                }
                break;
       }
    }

 }

}
