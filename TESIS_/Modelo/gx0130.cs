/*
               File: Gx0130
        Description: Selection List REDES
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:18:20.3
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
   public class gx0130 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx0130( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public gx0130( IGxContext context )
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

      public void execute( out long aP0_pTHDW_UBI_COD_ ,
                           out long aP1_pRed_Id )
      {
         this.AV13pTHDW_UBI_COD_ = 0 ;
         this.AV14pRed_Id = 0 ;
         executePrivate();
         aP0_pTHDW_UBI_COD_=this.AV13pTHDW_UBI_COD_;
         aP1_pRed_Id=this.AV14pRed_Id;
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Grid1") == 0 )
            {
               nRC_Grid1 = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               nGXsfl_51_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               sGXsfl_51_idx = GetNextPar( ) ;
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxnrGrid1_newrow( nRC_Grid1, nGXsfl_51_idx, sGXsfl_51_idx) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid1") == 0 )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0 ;
               Grid1_PageSize51 = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               AV6cTHDW_UBI_COD_ = (long)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cTHDW_UBI_COD_", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cTHDW_UBI_COD_), 10, 0)));
               AV7cRed_Id = (long)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cRed_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7cRed_Id), 10, 0)));
               AV8cRed_Descripcion = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cRed_Descripcion", AV8cRed_Descripcion);
               AV9cRed_DireccionDesdeB1 = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cRed_DireccionDesdeB1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9cRed_DireccionDesdeB1), 3, 0)));
               AV10cRed_DireccionDesdeB2 = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cRed_DireccionDesdeB2", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10cRed_DireccionDesdeB2), 3, 0)));
               AV11cRed_DireccionDesdeB3 = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cRed_DireccionDesdeB3", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11cRed_DireccionDesdeB3), 3, 0)));
               AV12cRed_DireccionDesdeB4 = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cRed_DireccionDesdeB4", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12cRed_DireccionDesdeB4), 3, 0)));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxgrGrid1_refresh( Grid1_PageSize51, AV6cTHDW_UBI_COD_, AV7cRed_Id, AV8cRed_Descripcion, AV9cRed_DireccionDesdeB1, AV10cRed_DireccionDesdeB2, AV11cRed_DireccionDesdeB3, AV12cRed_DireccionDesdeB4) ;
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
               AV13pTHDW_UBI_COD_ = (long)(NumberUtil.Val( gxfirstwebparm, ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pTHDW_UBI_COD_", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pTHDW_UBI_COD_), 10, 0)));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV14pRed_Id = (long)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14pRed_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14pRed_Id), 10, 0)));
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
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("promptmasterpage", "GeneXus.Programs.promptmasterpage", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
            MasterPageObj.setDataArea(this,true);
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
         PA4Q2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START4Q2( ) ;
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("gx0130.aspx") + "?" + UrlEncode("" +AV13pTHDW_UBI_COD_) + "," + UrlEncode("" +AV14pRed_Id)+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH_vCTHDW_UBI_COD_", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cTHDW_UBI_COD_), 10, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCRED_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7cRed_Id), 10, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCRED_DESCRIPCION", StringUtil.RTrim( AV8cRed_Descripcion));
         GxWebStd.gx_hidden_field( context, "GXH_vCRED_DIRECCIONDESDEB1", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9cRed_DireccionDesdeB1), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCRED_DIRECCIONDESDEB2", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10cRed_DireccionDesdeB2), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCRED_DIRECCIONDESDEB3", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11cRed_DireccionDesdeB3), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCRED_DIRECCIONDESDEB4", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12cRed_DireccionDesdeB4), 3, 0, ",", "")));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPTHDW_UBI_COD_", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13pTHDW_UBI_COD_), 10, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPRED_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14pRed_Id), 10, 0, ",", "")));
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
            WE4Q2( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT4Q2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override String GetPgmname( )
      {
         return "Gx0130" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List REDES" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("gx0130.aspx") + "?" + UrlEncode("" +AV13pTHDW_UBI_COD_) + "," + UrlEncode("" +AV14pRed_Id) ;
      }

      protected void WB4Q0( )
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
            wb_table1_2_4Q2( true) ;
         }
         else
         {
            wb_table1_2_4Q2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_4Q2e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START4Q2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "Selection List REDES", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP4Q0( ) ;
      }

      protected void WS4Q2( )
      {
         START4Q2( ) ;
         EVT4Q2( ) ;
      }

      protected void EVT4Q2( )
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
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTHDW_UBI_COD_"), ",", ".") != Convert.ToDecimal( AV6cTHDW_UBI_COD_ )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCRED_ID"), ",", ".") != Convert.ToDecimal( AV7cRed_Id )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCRED_DESCRIPCION"), AV8cRed_Descripcion) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCRED_DIRECCIONDESDEB1"), ",", ".") != Convert.ToDecimal( AV9cRed_DireccionDesdeB1 )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCRED_DIRECCIONDESDEB2"), ",", ".") != Convert.ToDecimal( AV10cRed_DireccionDesdeB2 )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCRED_DIRECCIONDESDEB3"), ",", ".") != Convert.ToDecimal( AV11cRed_DireccionDesdeB3 )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCRED_DIRECCIONDESDEB4"), ",", ".") != Convert.ToDecimal( AV12cRed_DireccionDesdeB4 )) )
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
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 4), "LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) )
                           {
                              nGXsfl_51_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                              sGXsfl_51_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_51_idx), 4, 0)), 4, "0") ;
                              edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
                              edtTHDW_UBI_COD__Internalname = "THDW_UBI_COD__"+sGXsfl_51_idx ;
                              edtRed_Id_Internalname = "RED_ID_"+sGXsfl_51_idx ;
                              edtRed_Descripcion_Internalname = "RED_DESCRIPCION_"+sGXsfl_51_idx ;
                              edtRed_DireccionDesdeB1_Internalname = "RED_DIRECCIONDESDEB1_"+sGXsfl_51_idx ;
                              edtRed_DireccionDesdeB2_Internalname = "RED_DIRECCIONDESDEB2_"+sGXsfl_51_idx ;
                              AV5LinkSelection = cgiGet( "GXimg"+edtavLinkselection_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", context.convertURL( AV5LinkSelection));
                              A306THDW_UBI_COD_ = (long)(context.localUtil.CToN( cgiGet( edtTHDW_UBI_COD__Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A306THDW_UBI_COD_", StringUtil.LTrim( StringUtil.Str( (decimal)(A306THDW_UBI_COD_), 10, 0)));
                              A300Red_Id = (long)(context.localUtil.CToN( cgiGet( edtRed_Id_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A300Red_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A300Red_Id), 10, 0)));
                              A301Red_Descripcion = cgiGet( edtRed_Descripcion_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A301Red_Descripcion", A301Red_Descripcion);
                              A308Red_DireccionDesdeB1 = (short)(context.localUtil.CToN( cgiGet( edtRed_DireccionDesdeB1_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A308Red_DireccionDesdeB1", StringUtil.LTrim( StringUtil.Str( (decimal)(A308Red_DireccionDesdeB1), 3, 0)));
                              A309Red_DireccionDesdeB2 = (short)(context.localUtil.CToN( cgiGet( edtRed_DireccionDesdeB2_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A309Red_DireccionDesdeB2", StringUtil.LTrim( StringUtil.Str( (decimal)(A309Red_DireccionDesdeB2), 3, 0)));
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E114Q2 */
                                    E114Q2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E124Q2 */
                                    E124Q2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false ;
                                       /* Set Refresh If Cthdw_ubi_cod_ Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTHDW_UBI_COD_"), ",", ".") != Convert.ToDecimal( AV6cTHDW_UBI_COD_ )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cred_id Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCRED_ID"), ",", ".") != Convert.ToDecimal( AV7cRed_Id )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cred_descripcion Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCRED_DESCRIPCION"), AV8cRed_Descripcion) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cred_direcciondesdeb1 Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCRED_DIRECCIONDESDEB1"), ",", ".") != Convert.ToDecimal( AV9cRed_DireccionDesdeB1 )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cred_direcciondesdeb2 Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCRED_DIRECCIONDESDEB2"), ",", ".") != Convert.ToDecimal( AV10cRed_DireccionDesdeB2 )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cred_direcciondesdeb3 Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCRED_DIRECCIONDESDEB3"), ",", ".") != Convert.ToDecimal( AV11cRed_DireccionDesdeB3 )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cred_direcciondesdeb4 Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCRED_DIRECCIONDESDEB4"), ",", ".") != Convert.ToDecimal( AV12cRed_DireccionDesdeB4 )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: E134Q2 */
                                          E134Q2 ();
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

      protected void WE4Q2( )
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

      protected void PA4Q2( )
      {
         if ( nDonePA == 0 )
         {
            GX_FocusControl = edtavCthdw_ubi_cod__Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGrid1_newrow( short nRC_Grid1 ,
                                       short nGXsfl_51_idx ,
                                       String sGXsfl_51_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
         edtTHDW_UBI_COD__Internalname = "THDW_UBI_COD__"+sGXsfl_51_idx ;
         edtRed_Id_Internalname = "RED_ID_"+sGXsfl_51_idx ;
         edtRed_Descripcion_Internalname = "RED_DESCRIPCION_"+sGXsfl_51_idx ;
         edtRed_DireccionDesdeB1_Internalname = "RED_DIRECCIONDESDEB1_"+sGXsfl_51_idx ;
         edtRed_DireccionDesdeB2_Internalname = "RED_DIRECCIONDESDEB2_"+sGXsfl_51_idx ;
         while ( nGXsfl_51_idx <= nRC_Grid1 )
         {
            sendrow_512( ) ;
            nGXsfl_51_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_51_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_51_idx+1)) ;
            sGXsfl_51_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_51_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
            edtTHDW_UBI_COD__Internalname = "THDW_UBI_COD__"+sGXsfl_51_idx ;
            edtRed_Id_Internalname = "RED_ID_"+sGXsfl_51_idx ;
            edtRed_Descripcion_Internalname = "RED_DESCRIPCION_"+sGXsfl_51_idx ;
            edtRed_DireccionDesdeB1_Internalname = "RED_DIRECCIONDESDEB1_"+sGXsfl_51_idx ;
            edtRed_DireccionDesdeB2_Internalname = "RED_DIRECCIONDESDEB2_"+sGXsfl_51_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int Grid1_PageSize51 ,
                                        long AV6cTHDW_UBI_COD_ ,
                                        long AV7cRed_Id ,
                                        String AV8cRed_Descripcion ,
                                        short AV9cRed_DireccionDesdeB1 ,
                                        short AV10cRed_DireccionDesdeB2 ,
                                        short AV11cRed_DireccionDesdeB3 ,
                                        short AV12cRed_DireccionDesdeB4 )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         subGrid1_Rows = (short)(Grid1_PageSize51) ;
         RF4Q2( ) ;
         enableOutput();
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxgrGrid1_refresh */
      }

      protected void Refresh( )
      {
         RF4Q2( ) ;
         /* End function Refresh */
      }

      protected void RF4Q2( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 51 ;
         nGXsfl_51_idx = 1 ;
         sGXsfl_51_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_51_idx), 4, 0)), 4, "0") ;
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
         edtTHDW_UBI_COD__Internalname = "THDW_UBI_COD__"+sGXsfl_51_idx ;
         edtRed_Id_Internalname = "RED_ID_"+sGXsfl_51_idx ;
         edtRed_Descripcion_Internalname = "RED_DESCRIPCION_"+sGXsfl_51_idx ;
         edtRed_DireccionDesdeB1_Internalname = "RED_DIRECCIONDESDEB1_"+sGXsfl_51_idx ;
         edtRed_DireccionDesdeB2_Internalname = "RED_DIRECCIONDESDEB2_"+sGXsfl_51_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
            edtTHDW_UBI_COD__Internalname = "THDW_UBI_COD__"+sGXsfl_51_idx ;
            edtRed_Id_Internalname = "RED_ID_"+sGXsfl_51_idx ;
            edtRed_Descripcion_Internalname = "RED_DESCRIPCION_"+sGXsfl_51_idx ;
            edtRed_DireccionDesdeB1_Internalname = "RED_DIRECCIONDESDEB1_"+sGXsfl_51_idx ;
            edtRed_DireccionDesdeB2_Internalname = "RED_DIRECCIONDESDEB2_"+sGXsfl_51_idx ;
            lV8cRed_Descripcion = StringUtil.PadR( StringUtil.RTrim( AV8cRed_Descripcion), 30, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cRed_Descripcion", AV8cRed_Descripcion);
            /* Using cursor H004Q2 */
            pr_default.execute(0, new Object[] {AV6cTHDW_UBI_COD_, AV7cRed_Id, lV8cRed_Descripcion, AV9cRed_DireccionDesdeB1, AV10cRed_DireccionDesdeB2, AV11cRed_DireccionDesdeB3, AV12cRed_DireccionDesdeB4});
            nGXsfl_51_idx = 1 ;
            GRID1_nEOF = 0 ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) ) )
            {
               A310Red_DireccionDesdeB3 = H004Q2_A310Red_DireccionDesdeB3[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A310Red_DireccionDesdeB3", StringUtil.LTrim( StringUtil.Str( (decimal)(A310Red_DireccionDesdeB3), 3, 0)));
               A315Red_DireccionDesdeB4 = H004Q2_A315Red_DireccionDesdeB4[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A315Red_DireccionDesdeB4", StringUtil.LTrim( StringUtil.Str( (decimal)(A315Red_DireccionDesdeB4), 3, 0)));
               A309Red_DireccionDesdeB2 = H004Q2_A309Red_DireccionDesdeB2[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A309Red_DireccionDesdeB2", StringUtil.LTrim( StringUtil.Str( (decimal)(A309Red_DireccionDesdeB2), 3, 0)));
               A308Red_DireccionDesdeB1 = H004Q2_A308Red_DireccionDesdeB1[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A308Red_DireccionDesdeB1", StringUtil.LTrim( StringUtil.Str( (decimal)(A308Red_DireccionDesdeB1), 3, 0)));
               A301Red_Descripcion = H004Q2_A301Red_Descripcion[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A301Red_Descripcion", A301Red_Descripcion);
               A300Red_Id = H004Q2_A300Red_Id[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A300Red_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A300Red_Id), 10, 0)));
               A306THDW_UBI_COD_ = H004Q2_A306THDW_UBI_COD_[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A306THDW_UBI_COD_", StringUtil.LTrim( StringUtil.Str( (decimal)(A306THDW_UBI_COD_), 10, 0)));
               /* Execute user event: E124Q2 */
               E124Q2 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0)) ;
            pr_default.close(0);
            wbEnd = 51 ;
            WB4Q0( ) ;
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
         lV8cRed_Descripcion = StringUtil.PadR( StringUtil.RTrim( AV8cRed_Descripcion), 30, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cRed_Descripcion", AV8cRed_Descripcion);
         /* Using cursor H004Q3 */
         pr_default.execute(1, new Object[] {AV6cTHDW_UBI_COD_, AV7cRed_Id, lV8cRed_Descripcion, AV9cRed_DireccionDesdeB1, AV10cRed_DireccionDesdeB2, AV11cRed_DireccionDesdeB3, AV12cRed_DireccionDesdeB4});
         GRID1_nRecordCount = H004Q3_AGRID1_nRecordCount[0] ;
         pr_default.close(1);
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

      protected void STRUP4Q0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E114Q2 */
         E114Q2 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ! context.localUtil.VCNumber( cgiGet( edtavCthdw_ubi_cod__Internalname), "ZZZZZZZZZ9") || ( context.localUtil.CToN( cgiGet( edtavCthdw_ubi_cod__Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavCthdw_ubi_cod__Internalname), ",", ".") > Convert.ToDecimal( 9999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vCTHDW_UBI_COD_");
               GX_FocusControl = edtavCthdw_ubi_cod__Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV6cTHDW_UBI_COD_ = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cTHDW_UBI_COD_", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cTHDW_UBI_COD_), 10, 0)));
            }
            else
            {
               AV6cTHDW_UBI_COD_ = (long)(context.localUtil.CToN( cgiGet( edtavCthdw_ubi_cod__Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cTHDW_UBI_COD_", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cTHDW_UBI_COD_), 10, 0)));
            }
            if ( ! context.localUtil.VCNumber( cgiGet( edtavCred_id_Internalname), "ZZZZZZZZZ9") || ( context.localUtil.CToN( cgiGet( edtavCred_id_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavCred_id_Internalname), ",", ".") > Convert.ToDecimal( 9999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vCRED_ID");
               GX_FocusControl = edtavCred_id_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV7cRed_Id = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cRed_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7cRed_Id), 10, 0)));
            }
            else
            {
               AV7cRed_Id = (long)(context.localUtil.CToN( cgiGet( edtavCred_id_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cRed_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7cRed_Id), 10, 0)));
            }
            AV8cRed_Descripcion = cgiGet( edtavCred_descripcion_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cRed_Descripcion", AV8cRed_Descripcion);
            if ( ! context.localUtil.VCNumber( cgiGet( edtavCred_direcciondesdeb1_Internalname), "ZZ9") || ( context.localUtil.CToN( cgiGet( edtavCred_direcciondesdeb1_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavCred_direcciondesdeb1_Internalname), ",", ".") > Convert.ToDecimal( 999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vCRED_DIRECCIONDESDEB1");
               GX_FocusControl = edtavCred_direcciondesdeb1_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV9cRed_DireccionDesdeB1 = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cRed_DireccionDesdeB1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9cRed_DireccionDesdeB1), 3, 0)));
            }
            else
            {
               AV9cRed_DireccionDesdeB1 = (short)(context.localUtil.CToN( cgiGet( edtavCred_direcciondesdeb1_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cRed_DireccionDesdeB1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9cRed_DireccionDesdeB1), 3, 0)));
            }
            if ( ! context.localUtil.VCNumber( cgiGet( edtavCred_direcciondesdeb2_Internalname), "ZZ9") || ( context.localUtil.CToN( cgiGet( edtavCred_direcciondesdeb2_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavCred_direcciondesdeb2_Internalname), ",", ".") > Convert.ToDecimal( 999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vCRED_DIRECCIONDESDEB2");
               GX_FocusControl = edtavCred_direcciondesdeb2_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV10cRed_DireccionDesdeB2 = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cRed_DireccionDesdeB2", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10cRed_DireccionDesdeB2), 3, 0)));
            }
            else
            {
               AV10cRed_DireccionDesdeB2 = (short)(context.localUtil.CToN( cgiGet( edtavCred_direcciondesdeb2_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cRed_DireccionDesdeB2", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10cRed_DireccionDesdeB2), 3, 0)));
            }
            if ( ! context.localUtil.VCNumber( cgiGet( edtavCred_direcciondesdeb3_Internalname), "ZZ9") || ( context.localUtil.CToN( cgiGet( edtavCred_direcciondesdeb3_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavCred_direcciondesdeb3_Internalname), ",", ".") > Convert.ToDecimal( 999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vCRED_DIRECCIONDESDEB3");
               GX_FocusControl = edtavCred_direcciondesdeb3_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV11cRed_DireccionDesdeB3 = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cRed_DireccionDesdeB3", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11cRed_DireccionDesdeB3), 3, 0)));
            }
            else
            {
               AV11cRed_DireccionDesdeB3 = (short)(context.localUtil.CToN( cgiGet( edtavCred_direcciondesdeb3_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cRed_DireccionDesdeB3", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11cRed_DireccionDesdeB3), 3, 0)));
            }
            if ( ! context.localUtil.VCNumber( cgiGet( edtavCred_direcciondesdeb4_Internalname), "ZZ9") || ( context.localUtil.CToN( cgiGet( edtavCred_direcciondesdeb4_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavCred_direcciondesdeb4_Internalname), ",", ".") > Convert.ToDecimal( 999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vCRED_DIRECCIONDESDEB4");
               GX_FocusControl = edtavCred_direcciondesdeb4_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV12cRed_DireccionDesdeB4 = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cRed_DireccionDesdeB4", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12cRed_DireccionDesdeB4), 3, 0)));
            }
            else
            {
               AV12cRed_DireccionDesdeB4 = (short)(context.localUtil.CToN( cgiGet( edtavCred_direcciondesdeb4_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cRed_DireccionDesdeB4", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12cRed_DireccionDesdeB4), 3, 0)));
            }
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ",", ".")) ;
            AV13pTHDW_UBI_COD_ = (long)(context.localUtil.CToN( cgiGet( "vPTHDW_UBI_COD_"), ",", ".")) ;
            AV14pRed_Id = (long)(context.localUtil.CToN( cgiGet( "vPRED_ID"), ",", ".")) ;
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
         /* Execute user event: E114Q2 */
         E114Q2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E114Q2( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Lista de Selección %1", "REDES", "", "", "", "", "", "", "", "") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption);
      }

      private void E124Q2( )
      {
         /* Load Routine */
         AV5LinkSelection = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", "Modern") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", context.convertURL( AV5LinkSelection));
         if ( ( subGrid1_Islastpage == 1 ) || ( 10 == 0 ) || ( ( GRID1_nCurrentRecord >= GRID1_nFirstRecordOnPage ) && ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) )
         {
            sendrow_512( ) ;
         }
         GRID1_nCurrentRecord = (int)(GRID1_nCurrentRecord+1) ;
      }

      public void GXEnter( )
      {
         /* Execute user event: E134Q2 */
         E134Q2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E134Q2( )
      {
         /* Enter Routine */
         AV13pTHDW_UBI_COD_ = A306THDW_UBI_COD_ ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pTHDW_UBI_COD_", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pTHDW_UBI_COD_), 10, 0)));
         AV14pRed_Id = A300Red_Id ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14pRed_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14pRed_Id), 10, 0)));
         context.setWebReturnParms(new Object[] {(long)AV13pTHDW_UBI_COD_,(long)AV14pRed_Id});
         context.nUserReturn = 1 ;
         returnInSub = true;
         if (true) return;
      }

      protected void wb_table1_2_4Q2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
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
            /* Control Group */
            ClassString = "FieldSet" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroup1_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Filters"+"</legend>") ;
            wb_table2_9_4Q2( true) ;
         }
         else
         {
            wb_table2_9_4Q2( false) ;
         }
         return  ;
      }

      protected void wb_table2_9_4Q2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Control Group */
            ClassString = "FieldSet" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroup2_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Lista de Selección"+"</legend>") ;
            wb_table3_48_4Q2( true) ;
         }
         else
         {
            wb_table3_48_4Q2( false) ;
         }
         return  ;
      }

      protected void wb_table3_48_4Q2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_4Q2e( true) ;
         }
         else
         {
            wb_table1_2_4Q2e( false) ;
         }
      }

      protected void wb_table3_48_4Q2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable3_Internalname, tblTable3_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"3\" >") ;
            /*  Grid Control  */
            Grid1Container.SetWrapped(nGXWrapped);
            if ( Grid1Container.GetWrapped() == 1 )
            {
               sStyleString = "" ;
               GxWebStd.gx_table_start( context, subGrid1_Internalname, subGrid1_Internalname, "", "Grid", 0, "", "", 1, 0, sStyleString, "", 0);
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
               context.SendWebValue( "Código de Ubicación de Red") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Id Red") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Descripción") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "IP Desde") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
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
               Grid1Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(0), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Backcolorstyle), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("CmpContext", "");
               Grid1Container.AddObjectProperty("InMasterPage", "false");
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", context.convertURL( AV5LinkSelection));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtavLinkselection_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A306THDW_UBI_COD_), 10, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A300Red_Id), 10, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A301Red_Descripcion));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtRed_Descripcion_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A308Red_DireccionDesdeB1), 3, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A309Red_DireccionDesdeB2), 3, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Allowselection", "false");
               Grid1Container.AddObjectProperty("Allowcollapsing", "false");
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 9, 0, ".", "")));
            }
         }
         if ( wbEnd == 51 )
         {
            wbEnd = 0 ;
            nRC_Grid1 = (short)(nGXsfl_51_idx-1) ;
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
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "right")+"\">") ;
            wb_table4_60_4Q2( true) ;
         }
         else
         {
            wb_table4_60_4Q2( false) ;
         }
         return  ;
      }

      protected void wb_table4_60_4Q2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_48_4Q2e( true) ;
         }
         else
         {
            wb_table3_48_4Q2e( false) ;
         }
      }

      protected void wb_table4_60_4Q2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable4_Internalname, tblTable4_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_cancel_Internalname, "Cancelar", "Cancelar", "", StyleString, ClassString, 1, 1, "rounded", 1, bttBtn_cancel_Jsonclick, "ECANCEL.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(51), 3, 0)+","+"null"+");", "", "HLP_Gx0130.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_60_4Q2e( true) ;
         }
         else
         {
            wb_table4_60_4Q2e( false) ;
         }
      }

      protected void wb_table2_9_4Q2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable2_Internalname, tblTable2_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockthdw_ubi_cod__Internalname, 1, 1, 0, "Código de Ubicación de Red", "", "", "", 0, lblTextblockthdw_ubi_cod__Jsonclick, "", StyleString, ClassString, "HLP_Gx0130.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCthdw_ubi_cod__Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cTHDW_UBI_COD_), 10, 0, ",", "")), "", 10, "chr", 1, "row", 10, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(AV6cTHDW_UBI_COD_), "ZZZZZZZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(14);\"", 0, edtavCthdw_ubi_cod__Jsonclick, "", 0, 1, -1, true, "right", "HLP_Gx0130.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockred_id_Internalname, 1, 1, 0, "Id de Red", "", "", "", 0, lblTextblockred_id_Jsonclick, "", StyleString, ClassString, "HLP_Gx0130.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCred_id_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7cRed_Id), 10, 0, ",", "")), "", 10, "chr", 1, "row", 10, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(AV7cRed_Id), "ZZZZZZZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(19);\"", 0, edtavCred_id_Jsonclick, "", 0, 1, -1, true, "right", "HLP_Gx0130.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockred_descripcion_Internalname, 1, 1, 0, "Descripción de Red", "", "", "", 0, lblTextblockred_descripcion_Jsonclick, "", StyleString, ClassString, "HLP_Gx0130.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 24,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCred_descripcion_Internalname, StringUtil.RTrim( AV8cRed_Descripcion), "", 30, "chr", 1, "row", 30, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV8cRed_Descripcion, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(24);\"", 0, edtavCred_descripcion_Jsonclick, "", 0, 1, -1, true, "left", "HLP_Gx0130.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockred_direcciondesdeb1_Internalname, 1, 1, 0, "Dirección IP Desde Byte 1", "", "", "", 0, lblTextblockred_direcciondesdeb1_Jsonclick, "", StyleString, ClassString, "HLP_Gx0130.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCred_direcciondesdeb1_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9cRed_DireccionDesdeB1), 3, 0, ",", "")), "", 3, "chr", 1, "row", 3, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(AV9cRed_DireccionDesdeB1), "ZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(29);\"", 0, edtavCred_direcciondesdeb1_Jsonclick, "", 0, 1, -1, true, "right", "HLP_Gx0130.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockred_direcciondesdeb2_Internalname, 1, 1, 0, "Dirección IP Desde Byte 2", "", "", "", 0, lblTextblockred_direcciondesdeb2_Jsonclick, "", StyleString, ClassString, "HLP_Gx0130.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCred_direcciondesdeb2_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10cRed_DireccionDesdeB2), 3, 0, ",", "")), "", 3, "chr", 1, "row", 3, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(AV10cRed_DireccionDesdeB2), "ZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(34);\"", 0, edtavCred_direcciondesdeb2_Jsonclick, "", 0, 1, -1, true, "right", "HLP_Gx0130.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockred_direcciondesdeb3_Internalname, 1, 1, 0, "Dirección IP Desde Byte 3", "", "", "", 0, lblTextblockred_direcciondesdeb3_Jsonclick, "", StyleString, ClassString, "HLP_Gx0130.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCred_direcciondesdeb3_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11cRed_DireccionDesdeB3), 3, 0, ",", "")), "", 3, "chr", 1, "row", 3, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(AV11cRed_DireccionDesdeB3), "ZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(39);\"", 0, edtavCred_direcciondesdeb3_Jsonclick, "", 0, 1, -1, true, "right", "HLP_Gx0130.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockred_direcciondesdeb4_Internalname, 1, 1, 0, "Dirección IP Desde Byte 4", "", "", "", 0, lblTextblockred_direcciondesdeb4_Jsonclick, "", StyleString, ClassString, "HLP_Gx0130.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCred_direcciondesdeb4_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12cRed_DireccionDesdeB4), 3, 0, ",", "")), "", 3, "chr", 1, "row", 3, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(AV12cRed_DireccionDesdeB4), "ZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(44);\"", 0, edtavCred_direcciondesdeb4_Jsonclick, "", 0, 1, -1, true, "right", "HLP_Gx0130.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_9_4Q2e( true) ;
         }
         else
         {
            wb_table2_9_4Q2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV13pTHDW_UBI_COD_ = Convert.ToInt64(getParm(obj,0)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pTHDW_UBI_COD_", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pTHDW_UBI_COD_), 10, 0)));
         AV14pRed_Id = Convert.ToInt64(getParm(obj,1)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14pRed_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14pRed_Id), 10, 0)));
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
         PA4Q2( ) ;
         WS4Q2( ) ;
         WE4Q2( ) ;
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
         AddThemeStyleSheetFile("", "Modern.css", "?19542497");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?11182070");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("gx0130.js", "?11182070");
         /* End function include_jscripts */
      }

      protected void sendrow_512( )
      {
         WB4Q0( ) ;
         if ( ( 10 * 1 == 0 ) || ( nGXsfl_51_idx <= subGrid1_Recordsperpage( ) * 1 ) )
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
               if ( ((int)(nGXsfl_51_idx) % (2)) == 0 )
               {
                  subGrid1_Backcolor = (int)(0x0) ;
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
            /* Static Bitmap Variable */
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A306THDW_UBI_COD_), 10, 0, ",", "")))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A300Red_Id), 10, 0, ",", "")))+"'"+"]);" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Link", edtavLinkselection_Link);
            ClassString = "Image" ;
            StyleString = "" ;
            Grid1Row.AddColumnProperties("bitmap", 2, isAjaxCallMode( ), new Object[] {(String)edtavLinkselection_Internalname,(String)"",(String)AV5LinkSelection,(String)"Modern",(short)-1,(short)1,(String)"",(String)"Seleccionar",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"",(short)0,(short)0,(String)edtavLinkselection_Link,(String)"",(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"''",(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTHDW_UBI_COD__Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A306THDW_UBI_COD_), 10, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)10,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A306THDW_UBI_COD_), "ZZZZZZZZZ9"),(String)"",(short)0,(String)edtTHDW_UBI_COD__Jsonclick,(String)"",(short)51,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtRed_Id_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A300Red_Id), 10, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)10,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A300Red_Id), "ZZZZZZZZZ9"),(String)"",(short)0,(String)edtRed_Id_Jsonclick,(String)"",(short)51,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            edtRed_Descripcion_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A306THDW_UBI_COD_), 10, 0, ",", "")))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A300Red_Id), 10, 0, ",", "")))+"'"+"]);" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtRed_Descripcion_Internalname, "Link", edtRed_Descripcion_Link);
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtRed_Descripcion_Internalname,StringUtil.RTrim( A301Red_Descripcion),(String)"Seleccionar",(short)0,(String)"px",(short)17,(String)"",(short)30,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)edtRed_Descripcion_Link,(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A301Red_Descripcion, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")),(String)"",(short)0,(String)edtRed_Descripcion_Jsonclick,(String)"",(short)51,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtRed_DireccionDesdeB1_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A308Red_DireccionDesdeB1), 3, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)3,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A308Red_DireccionDesdeB1), "ZZ9"),(String)"",(short)0,(String)edtRed_DireccionDesdeB1_Jsonclick,(String)"",(short)51,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtRed_DireccionDesdeB2_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A309Red_DireccionDesdeB2), 3, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)3,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A309Red_DireccionDesdeB2), "ZZ9"),(String)"",(short)0,(String)edtRed_DireccionDesdeB2_Jsonclick,(String)"",(short)51,(short)1,(short)1,(bool)true,(String)"right"});
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_51_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_51_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_51_idx+1)) ;
            sGXsfl_51_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_51_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
            edtTHDW_UBI_COD__Internalname = "THDW_UBI_COD__"+sGXsfl_51_idx ;
            edtRed_Id_Internalname = "RED_ID_"+sGXsfl_51_idx ;
            edtRed_Descripcion_Internalname = "RED_DESCRIPCION_"+sGXsfl_51_idx ;
            edtRed_DireccionDesdeB1_Internalname = "RED_DIRECCIONDESDEB1_"+sGXsfl_51_idx ;
            edtRed_DireccionDesdeB2_Internalname = "RED_DIRECCIONDESDEB2_"+sGXsfl_51_idx ;
         }
         /* End function sendrow_512 */
      }

      protected void init_default_properties( )
      {
         lblTextblockthdw_ubi_cod__Internalname = "TEXTBLOCKTHDW_UBI_COD_" ;
         edtavCthdw_ubi_cod__Internalname = "vCTHDW_UBI_COD_" ;
         lblTextblockred_id_Internalname = "TEXTBLOCKRED_ID" ;
         edtavCred_id_Internalname = "vCRED_ID" ;
         lblTextblockred_descripcion_Internalname = "TEXTBLOCKRED_DESCRIPCION" ;
         edtavCred_descripcion_Internalname = "vCRED_DESCRIPCION" ;
         lblTextblockred_direcciondesdeb1_Internalname = "TEXTBLOCKRED_DIRECCIONDESDEB1" ;
         edtavCred_direcciondesdeb1_Internalname = "vCRED_DIRECCIONDESDEB1" ;
         lblTextblockred_direcciondesdeb2_Internalname = "TEXTBLOCKRED_DIRECCIONDESDEB2" ;
         edtavCred_direcciondesdeb2_Internalname = "vCRED_DIRECCIONDESDEB2" ;
         lblTextblockred_direcciondesdeb3_Internalname = "TEXTBLOCKRED_DIRECCIONDESDEB3" ;
         edtavCred_direcciondesdeb3_Internalname = "vCRED_DIRECCIONDESDEB3" ;
         lblTextblockred_direcciondesdeb4_Internalname = "TEXTBLOCKRED_DIRECCIONDESDEB4" ;
         edtavCred_direcciondesdeb4_Internalname = "vCRED_DIRECCIONDESDEB4" ;
         tblTable2_Internalname = "TABLE2" ;
         grpGroup1_Internalname = "GROUP1" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         tblTable4_Internalname = "TABLE4" ;
         tblTable3_Internalname = "TABLE3" ;
         grpGroup2_Internalname = "GROUP2" ;
         tblTable1_Internalname = "TABLE1" ;
         Form.Internalname = "FORM" ;
         subGrid1_Internalname = "GRID1" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         edtRed_DireccionDesdeB2_Jsonclick = "" ;
         edtRed_DireccionDesdeB1_Jsonclick = "" ;
         edtRed_Descripcion_Jsonclick = "" ;
         edtRed_Id_Jsonclick = "" ;
         edtTHDW_UBI_COD__Jsonclick = "" ;
         edtavCred_direcciondesdeb4_Jsonclick = "" ;
         edtavCred_direcciondesdeb3_Jsonclick = "" ;
         edtavCred_direcciondesdeb2_Jsonclick = "" ;
         edtavCred_direcciondesdeb1_Jsonclick = "" ;
         edtavCred_descripcion_Jsonclick = "" ;
         edtavCred_id_Jsonclick = "" ;
         edtavCthdw_ubi_cod__Jsonclick = "" ;
         edtRed_Descripcion_Link = "" ;
         edtavLinkselection_Link = "" ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 2 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Selection List REDES" ;
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
         AV8cRed_Descripcion = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         GX_FocusControl = "" ;
         Form = new GXWebForm();
         sPrefix = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         edtavLinkselection_Internalname = "" ;
         edtTHDW_UBI_COD__Internalname = "" ;
         edtRed_Id_Internalname = "" ;
         edtRed_Descripcion_Internalname = "" ;
         edtRed_DireccionDesdeB1_Internalname = "" ;
         edtRed_DireccionDesdeB2_Internalname = "" ;
         AV5LinkSelection = "" ;
         A301Red_Descripcion = "" ;
         Grid1Container = new GXWebGrid( context);
         scmdbuf = "" ;
         lV8cRed_Descripcion = "" ;
         H004Q2_A310Red_DireccionDesdeB3 = new short[1] ;
         H004Q2_A315Red_DireccionDesdeB4 = new short[1] ;
         H004Q2_A309Red_DireccionDesdeB2 = new short[1] ;
         H004Q2_A308Red_DireccionDesdeB1 = new short[1] ;
         H004Q2_A301Red_Descripcion = new String[] {""} ;
         H004Q2_A300Red_Id = new long[1] ;
         H004Q2_A306THDW_UBI_COD_ = new long[1] ;
         H004Q3_AGRID1_nRecordCount = new int[1] ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         subGrid1_Linesclass = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char4 = "" ;
         Grid1Column = new GXWebColumn();
         GXt_char6 = "" ;
         GXt_char5 = "" ;
         TempTags = "" ;
         bttBtn_cancel_Jsonclick = "" ;
         lblTextblockthdw_ubi_cod__Jsonclick = "" ;
         lblTextblockred_id_Jsonclick = "" ;
         lblTextblockred_descripcion_Jsonclick = "" ;
         lblTextblockred_direcciondesdeb1_Jsonclick = "" ;
         lblTextblockred_direcciondesdeb2_Jsonclick = "" ;
         lblTextblockred_direcciondesdeb3_Jsonclick = "" ;
         lblTextblockred_direcciondesdeb4_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         ROClassString = "" ;
         GXt_char7 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx0130__default(),
            new Object[][] {
                new Object[] {
               H004Q2_A310Red_DireccionDesdeB3, H004Q2_A315Red_DireccionDesdeB4, H004Q2_A309Red_DireccionDesdeB2, H004Q2_A308Red_DireccionDesdeB1, H004Q2_A301Red_Descripcion, H004Q2_A300Red_Id, H004Q2_A306THDW_UBI_COD_
               }
               , new Object[] {
               H004Q3_AGRID1_nRecordCount
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_Grid1 ;
      private short nGXsfl_51_idx=1 ;
      private short AV9cRed_DireccionDesdeB1 ;
      private short AV10cRed_DireccionDesdeB2 ;
      private short AV11cRed_DireccionDesdeB3 ;
      private short AV12cRed_DireccionDesdeB4 ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short GRID1_nEOF ;
      private short wbEnd ;
      private short wbStart ;
      private short A308Red_DireccionDesdeB1 ;
      private short A309Red_DireccionDesdeB2 ;
      private short nDonePA ;
      private short subGrid1_Rows ;
      private short A310Red_DireccionDesdeB3 ;
      private short A315Red_DireccionDesdeB4 ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short subGrid1_Collapsed ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int Grid1_PageSize51 ;
      private int GRID1_nFirstRecordOnPage ;
      private int subGrid1_Islastpage ;
      private int GRID1_nCurrentRecord ;
      private int GRID1_nRecordCount ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private long AV6cTHDW_UBI_COD_ ;
      private long AV7cRed_Id ;
      private long AV13pTHDW_UBI_COD_ ;
      private long AV14pRed_Id ;
      private long A306THDW_UBI_COD_ ;
      private long A300Red_Id ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_51_idx="0001" ;
      private String AV8cRed_Descripcion ;
      private String sDynURL ;
      private String FormProcess ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavLinkselection_Internalname ;
      private String edtTHDW_UBI_COD__Internalname ;
      private String edtRed_Id_Internalname ;
      private String edtRed_Descripcion_Internalname ;
      private String edtRed_DireccionDesdeB1_Internalname ;
      private String edtRed_DireccionDesdeB2_Internalname ;
      private String A301Red_Descripcion ;
      private String edtavCthdw_ubi_cod__Internalname ;
      private String scmdbuf ;
      private String lV8cRed_Descripcion ;
      private String edtavCred_id_Internalname ;
      private String edtavCred_descripcion_Internalname ;
      private String edtavCred_direcciondesdeb1_Internalname ;
      private String edtavCred_direcciondesdeb2_Internalname ;
      private String edtavCred_direcciondesdeb3_Internalname ;
      private String edtavCred_direcciondesdeb4_Internalname ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String grpGroup1_Internalname ;
      private String grpGroup2_Internalname ;
      private String tblTable3_Internalname ;
      private String subGrid1_Internalname ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String GXt_char3 ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GXt_char4 ;
      private String edtavLinkselection_Link ;
      private String edtRed_Descripcion_Link ;
      private String GXt_char6 ;
      private String GXt_char5 ;
      private String tblTable4_Internalname ;
      private String TempTags ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblockthdw_ubi_cod__Internalname ;
      private String lblTextblockthdw_ubi_cod__Jsonclick ;
      private String edtavCthdw_ubi_cod__Jsonclick ;
      private String lblTextblockred_id_Internalname ;
      private String lblTextblockred_id_Jsonclick ;
      private String edtavCred_id_Jsonclick ;
      private String lblTextblockred_descripcion_Internalname ;
      private String lblTextblockred_descripcion_Jsonclick ;
      private String edtavCred_descripcion_Jsonclick ;
      private String lblTextblockred_direcciondesdeb1_Internalname ;
      private String lblTextblockred_direcciondesdeb1_Jsonclick ;
      private String edtavCred_direcciondesdeb1_Jsonclick ;
      private String lblTextblockred_direcciondesdeb2_Internalname ;
      private String lblTextblockred_direcciondesdeb2_Jsonclick ;
      private String edtavCred_direcciondesdeb2_Jsonclick ;
      private String lblTextblockred_direcciondesdeb3_Internalname ;
      private String lblTextblockred_direcciondesdeb3_Jsonclick ;
      private String edtavCred_direcciondesdeb3_Jsonclick ;
      private String lblTextblockred_direcciondesdeb4_Internalname ;
      private String lblTextblockred_direcciondesdeb4_Jsonclick ;
      private String edtavCred_direcciondesdeb4_Jsonclick ;
      private String ROClassString ;
      private String edtTHDW_UBI_COD__Jsonclick ;
      private String edtRed_Id_Jsonclick ;
      private String edtRed_Descripcion_Jsonclick ;
      private String edtRed_DireccionDesdeB1_Jsonclick ;
      private String edtRed_DireccionDesdeB2_Jsonclick ;
      private String GXt_char7 ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private String AV5LinkSelection ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] H004Q2_A310Red_DireccionDesdeB3 ;
      private short[] H004Q2_A315Red_DireccionDesdeB4 ;
      private short[] H004Q2_A309Red_DireccionDesdeB2 ;
      private short[] H004Q2_A308Red_DireccionDesdeB1 ;
      private String[] H004Q2_A301Red_Descripcion ;
      private long[] H004Q2_A300Red_Id ;
      private long[] H004Q2_A306THDW_UBI_COD_ ;
      private int[] H004Q3_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private long aP0_pTHDW_UBI_COD_ ;
      private long aP1_pRed_Id ;
      private GXWebForm Form ;
   }

   public class gx0130__default : DataStoreHelperBase, IDataStoreHelper
   {
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
          Object[] prmH004Q2 ;
          prmH004Q2 = new Object[] {
          new Object[] {"@AV6cTHDW_UBI_COD_",SqlDbType.Decimal,10,0} ,
          new Object[] {"@AV7cRed_Id",SqlDbType.Decimal,10,0} ,
          new Object[] {"@AV8cRed_Descripcion",SqlDbType.Char,30,0} ,
          new Object[] {"@AV9cRed_DireccionDesdeB1",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV10cRed_DireccionDesdeB2",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV11cRed_DireccionDesdeB3",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV12cRed_DireccionDesdeB4",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmH004Q3 ;
          prmH004Q3 = new Object[] {
          new Object[] {"@AV6cTHDW_UBI_COD_",SqlDbType.Decimal,10,0} ,
          new Object[] {"@AV7cRed_Id",SqlDbType.Decimal,10,0} ,
          new Object[] {"@AV8cRed_Descripcion",SqlDbType.Char,30,0} ,
          new Object[] {"@AV9cRed_DireccionDesdeB1",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV10cRed_DireccionDesdeB2",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV11cRed_DireccionDesdeB3",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV12cRed_DireccionDesdeB4",SqlDbType.SmallInt,3,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H004Q2", "SELECT [Red_DireccionDesdeB3], [Red_DireccionDesdeB4], [Red_DireccionDesdeB2], [Red_DireccionDesdeB1], [Red_Descripcion], [Red_Id], [THDW_UBI_COD_] FROM [THDW_REDES] WITH (NOLOCK) WHERE ([THDW_UBI_COD_] >= @AV6cTHDW_UBI_COD_ and [Red_Id] >= @AV7cRed_Id) AND ([Red_Descripcion] like @AV8cRed_Descripcion) AND ([Red_DireccionDesdeB1] >= @AV9cRed_DireccionDesdeB1) AND ([Red_DireccionDesdeB2] >= @AV10cRed_DireccionDesdeB2) AND ([Red_DireccionDesdeB3] >= @AV11cRed_DireccionDesdeB3) AND ([Red_DireccionDesdeB4] >= @AV12cRed_DireccionDesdeB4) ORDER BY [THDW_UBI_COD_], [Red_Id]  OPTION (FAST 11)",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH004Q2,11,0,false,false )
             ,new CursorDef("H004Q3", "SELECT COUNT(*) FROM [THDW_REDES] WITH (NOLOCK) WHERE ([THDW_UBI_COD_] >= @AV6cTHDW_UBI_COD_ and [Red_Id] >= @AV7cRed_Id) AND ([Red_Descripcion] like @AV8cRed_Descripcion) AND ([Red_DireccionDesdeB1] >= @AV9cRed_DireccionDesdeB1) AND ([Red_DireccionDesdeB2] >= @AV10cRed_DireccionDesdeB2) AND ([Red_DireccionDesdeB3] >= @AV11cRed_DireccionDesdeB3) AND ([Red_DireccionDesdeB4] >= @AV12cRed_DireccionDesdeB4) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH004Q3,1,0,false,false )
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
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 30) ;
                ((long[]) buf[5])[0] = rslt.getLong(6) ;
                ((long[]) buf[6])[0] = rslt.getLong(7) ;
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
       switch ( cursor )
       {
             case 0 :
                stmt.SetParameter(1, (long)parms[0]);
                stmt.SetParameter(2, (long)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                break;
             case 1 :
                stmt.SetParameter(1, (long)parms[0]);
                stmt.SetParameter(2, (long)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                break;
       }
    }

 }

}
