/*
               File: Gx00P0
        Description: Selection List Auxiliar de bienes de uso
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/30/2014 17:20:36.71
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
   public class gx00p0 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx00p0( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public gx00p0( IGxContext context )
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

      public void execute( out short aP0_pBUS_AUX_ID )
      {
         this.AV13pBUS_AUX_ID = 0 ;
         executePrivate();
         aP0_pBUS_AUX_ID=this.AV13pBUS_AUX_ID;
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
               AV6cBUS_AUX_ID = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cBUS_AUX_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cBUS_AUX_ID), 4, 0)));
               AV7cBUS_AUX_RUB = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cBUS_AUX_RUB", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7cBUS_AUX_RUB), 4, 0)));
               AV8cBUS_AUX_DES = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cBUS_AUX_DES", AV8cBUS_AUX_DES);
               AV9cBUS_AUX_FAL = context.localUtil.ParseDateParm( GetNextPar( )) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cBUS_AUX_FAL", context.localUtil.Format(AV9cBUS_AUX_FAL, "99/99/9999"));
               AV10cBUS_AUX_FAD = context.localUtil.ParseDateParm( GetNextPar( )) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cBUS_AUX_FAD", context.localUtil.Format(AV10cBUS_AUX_FAD, "99/99/9999"));
               AV11cBUS_AUX_NCO = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cBUS_AUX_NCO", AV11cBUS_AUX_NCO);
               AV12cBUS_AUX_COM = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cBUS_AUX_COM", AV12cBUS_AUX_COM);
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxgrGrid1_refresh( Grid1_PageSize51, AV6cBUS_AUX_ID, AV7cBUS_AUX_RUB, AV8cBUS_AUX_DES, AV9cBUS_AUX_FAL, AV10cBUS_AUX_FAD, AV11cBUS_AUX_NCO, AV12cBUS_AUX_COM) ;
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
               AV13pBUS_AUX_ID = (short)(NumberUtil.Val( gxfirstwebparm, ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pBUS_AUX_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pBUS_AUX_ID), 4, 0)));
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
         PA302( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START302( ) ;
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("gx00p0.aspx") + "?" + UrlEncode("" +AV13pBUS_AUX_ID)+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH_vCBUS_AUX_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cBUS_AUX_ID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCBUS_AUX_RUB", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7cBUS_AUX_RUB), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCBUS_AUX_DES", StringUtil.RTrim( AV8cBUS_AUX_DES));
         GxWebStd.gx_hidden_field( context, "GXH_vCBUS_AUX_FAL", context.localUtil.Format(AV9cBUS_AUX_FAL, "99/99/9999"));
         GxWebStd.gx_hidden_field( context, "GXH_vCBUS_AUX_FAD", context.localUtil.Format(AV10cBUS_AUX_FAD, "99/99/9999"));
         GxWebStd.gx_hidden_field( context, "GXH_vCBUS_AUX_NCO", StringUtil.RTrim( AV11cBUS_AUX_NCO));
         GxWebStd.gx_hidden_field( context, "GXH_vCBUS_AUX_COM", StringUtil.RTrim( AV12cBUS_AUX_COM));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPBUS_AUX_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13pBUS_AUX_ID), 4, 0, ",", "")));
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
            WE302( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT302( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override String GetPgmname( )
      {
         return "Gx00P0" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List Auxiliar de bienes de uso" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("gx00p0.aspx") + "?" + UrlEncode("" +AV13pBUS_AUX_ID) ;
      }

      protected void WB300( )
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
            wb_table1_2_302( true) ;
         }
         else
         {
            wb_table1_2_302( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_302e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START302( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "Selection List Auxiliar de bienes de uso", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP300( ) ;
      }

      protected void WS302( )
      {
         START302( ) ;
         EVT302( ) ;
      }

      protected void EVT302( )
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
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCBUS_AUX_ID"), ",", ".") != Convert.ToDecimal( AV6cBUS_AUX_ID )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCBUS_AUX_RUB"), ",", ".") != Convert.ToDecimal( AV7cBUS_AUX_RUB )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCBUS_AUX_DES"), AV8cBUS_AUX_DES) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( context.localUtil.CToD( cgiGet( "GXH_vCBUS_AUX_FAL"), 4) != AV9cBUS_AUX_FAL )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( context.localUtil.CToD( cgiGet( "GXH_vCBUS_AUX_FAD"), 4) != AV10cBUS_AUX_FAD )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCBUS_AUX_NCO"), AV11cBUS_AUX_NCO) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCBUS_AUX_COM"), AV12cBUS_AUX_COM) != 0 )
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
                              edtBUS_AUX_ID_Internalname = "BUS_AUX_ID_"+sGXsfl_51_idx ;
                              edtBUS_AUX_RUB_Internalname = "BUS_AUX_RUB_"+sGXsfl_51_idx ;
                              edtBUS_AUX_DES_Internalname = "BUS_AUX_DES_"+sGXsfl_51_idx ;
                              edtBUS_AUX_FAL_Internalname = "BUS_AUX_FAL_"+sGXsfl_51_idx ;
                              edtBUS_AUX_COM_Internalname = "BUS_AUX_COM_"+sGXsfl_51_idx ;
                              AV5LinkSelection = cgiGet( "GXimg"+edtavLinkselection_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", context.convertURL( AV5LinkSelection));
                              A352BUS_AUX_ID = (short)(context.localUtil.CToN( cgiGet( edtBUS_AUX_ID_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A352BUS_AUX_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A352BUS_AUX_ID), 4, 0)));
                              A353BUS_AUX_RUB = (short)(context.localUtil.CToN( cgiGet( edtBUS_AUX_RUB_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A353BUS_AUX_RUB", StringUtil.LTrim( StringUtil.Str( (decimal)(A353BUS_AUX_RUB), 4, 0)));
                              A354BUS_AUX_DES = cgiGet( edtBUS_AUX_DES_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A354BUS_AUX_DES", A354BUS_AUX_DES);
                              A355BUS_AUX_FAL = context.localUtil.CToD( cgiGet( edtBUS_AUX_FAL_Internalname), 4) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A355BUS_AUX_FAL", context.localUtil.Format(A355BUS_AUX_FAL, "99/99/9999"));
                              A358BUS_AUX_COM = cgiGet( edtBUS_AUX_COM_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A358BUS_AUX_COM", A358BUS_AUX_COM);
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E11302 */
                                    E11302 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E12302 */
                                    E12302 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false ;
                                       /* Set Refresh If Cbus_aux_id Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCBUS_AUX_ID"), ",", ".") != Convert.ToDecimal( AV6cBUS_AUX_ID )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cbus_aux_rub Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCBUS_AUX_RUB"), ",", ".") != Convert.ToDecimal( AV7cBUS_AUX_RUB )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cbus_aux_des Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCBUS_AUX_DES"), AV8cBUS_AUX_DES) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cbus_aux_fal Changed */
                                       if ( context.localUtil.CToD( cgiGet( "GXH_vCBUS_AUX_FAL"), 4) != AV9cBUS_AUX_FAL )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cbus_aux_fad Changed */
                                       if ( context.localUtil.CToD( cgiGet( "GXH_vCBUS_AUX_FAD"), 4) != AV10cBUS_AUX_FAD )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cbus_aux_nco Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCBUS_AUX_NCO"), AV11cBUS_AUX_NCO) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cbus_aux_com Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCBUS_AUX_COM"), AV12cBUS_AUX_COM) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: E13302 */
                                          E13302 ();
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

      protected void WE302( )
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

      protected void PA302( )
      {
         if ( nDonePA == 0 )
         {
            GX_FocusControl = edtavCbus_aux_id_Internalname ;
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
         edtBUS_AUX_ID_Internalname = "BUS_AUX_ID_"+sGXsfl_51_idx ;
         edtBUS_AUX_RUB_Internalname = "BUS_AUX_RUB_"+sGXsfl_51_idx ;
         edtBUS_AUX_DES_Internalname = "BUS_AUX_DES_"+sGXsfl_51_idx ;
         edtBUS_AUX_FAL_Internalname = "BUS_AUX_FAL_"+sGXsfl_51_idx ;
         edtBUS_AUX_COM_Internalname = "BUS_AUX_COM_"+sGXsfl_51_idx ;
         while ( nGXsfl_51_idx <= nRC_Grid1 )
         {
            sendrow_512( ) ;
            nGXsfl_51_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_51_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_51_idx+1)) ;
            sGXsfl_51_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_51_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
            edtBUS_AUX_ID_Internalname = "BUS_AUX_ID_"+sGXsfl_51_idx ;
            edtBUS_AUX_RUB_Internalname = "BUS_AUX_RUB_"+sGXsfl_51_idx ;
            edtBUS_AUX_DES_Internalname = "BUS_AUX_DES_"+sGXsfl_51_idx ;
            edtBUS_AUX_FAL_Internalname = "BUS_AUX_FAL_"+sGXsfl_51_idx ;
            edtBUS_AUX_COM_Internalname = "BUS_AUX_COM_"+sGXsfl_51_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int Grid1_PageSize51 ,
                                        short AV6cBUS_AUX_ID ,
                                        short AV7cBUS_AUX_RUB ,
                                        String AV8cBUS_AUX_DES ,
                                        DateTime AV9cBUS_AUX_FAL ,
                                        DateTime AV10cBUS_AUX_FAD ,
                                        String AV11cBUS_AUX_NCO ,
                                        String AV12cBUS_AUX_COM )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         subGrid1_Rows = (short)(Grid1_PageSize51) ;
         RF302( ) ;
         enableOutput();
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxgrGrid1_refresh */
      }

      protected void Refresh( )
      {
         RF302( ) ;
         /* End function Refresh */
      }

      protected void RF302( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 51 ;
         nGXsfl_51_idx = 1 ;
         sGXsfl_51_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_51_idx), 4, 0)), 4, "0") ;
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
         edtBUS_AUX_ID_Internalname = "BUS_AUX_ID_"+sGXsfl_51_idx ;
         edtBUS_AUX_RUB_Internalname = "BUS_AUX_RUB_"+sGXsfl_51_idx ;
         edtBUS_AUX_DES_Internalname = "BUS_AUX_DES_"+sGXsfl_51_idx ;
         edtBUS_AUX_FAL_Internalname = "BUS_AUX_FAL_"+sGXsfl_51_idx ;
         edtBUS_AUX_COM_Internalname = "BUS_AUX_COM_"+sGXsfl_51_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
            edtBUS_AUX_ID_Internalname = "BUS_AUX_ID_"+sGXsfl_51_idx ;
            edtBUS_AUX_RUB_Internalname = "BUS_AUX_RUB_"+sGXsfl_51_idx ;
            edtBUS_AUX_DES_Internalname = "BUS_AUX_DES_"+sGXsfl_51_idx ;
            edtBUS_AUX_FAL_Internalname = "BUS_AUX_FAL_"+sGXsfl_51_idx ;
            edtBUS_AUX_COM_Internalname = "BUS_AUX_COM_"+sGXsfl_51_idx ;
            lV8cBUS_AUX_DES = StringUtil.PadR( StringUtil.RTrim( AV8cBUS_AUX_DES), 50, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cBUS_AUX_DES", AV8cBUS_AUX_DES);
            lV11cBUS_AUX_NCO = StringUtil.PadR( StringUtil.RTrim( AV11cBUS_AUX_NCO), 12, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cBUS_AUX_NCO", AV11cBUS_AUX_NCO);
            lV12cBUS_AUX_COM = StringUtil.PadR( StringUtil.RTrim( AV12cBUS_AUX_COM), 2, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cBUS_AUX_COM", AV12cBUS_AUX_COM);
            /* Using cursor H00302 */
            pr_default.execute(0, new Object[] {AV6cBUS_AUX_ID, AV7cBUS_AUX_RUB, lV8cBUS_AUX_DES, AV9cBUS_AUX_FAL, AV10cBUS_AUX_FAD, lV11cBUS_AUX_NCO, lV12cBUS_AUX_COM});
            nGXsfl_51_idx = 1 ;
            GRID1_nEOF = 0 ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) ) )
            {
               A356BUS_AUX_FAD = H00302_A356BUS_AUX_FAD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A356BUS_AUX_FAD", context.localUtil.Format(A356BUS_AUX_FAD, "99/99/9999"));
               A357BUS_AUX_NCO = H00302_A357BUS_AUX_NCO[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A357BUS_AUX_NCO", A357BUS_AUX_NCO);
               A358BUS_AUX_COM = H00302_A358BUS_AUX_COM[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A358BUS_AUX_COM", A358BUS_AUX_COM);
               A355BUS_AUX_FAL = H00302_A355BUS_AUX_FAL[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A355BUS_AUX_FAL", context.localUtil.Format(A355BUS_AUX_FAL, "99/99/9999"));
               A354BUS_AUX_DES = H00302_A354BUS_AUX_DES[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A354BUS_AUX_DES", A354BUS_AUX_DES);
               A353BUS_AUX_RUB = H00302_A353BUS_AUX_RUB[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A353BUS_AUX_RUB", StringUtil.LTrim( StringUtil.Str( (decimal)(A353BUS_AUX_RUB), 4, 0)));
               A352BUS_AUX_ID = H00302_A352BUS_AUX_ID[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A352BUS_AUX_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A352BUS_AUX_ID), 4, 0)));
               /* Execute user event: E12302 */
               E12302 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0)) ;
            pr_default.close(0);
            wbEnd = 51 ;
            WB300( ) ;
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
         lV8cBUS_AUX_DES = StringUtil.PadR( StringUtil.RTrim( AV8cBUS_AUX_DES), 50, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cBUS_AUX_DES", AV8cBUS_AUX_DES);
         lV11cBUS_AUX_NCO = StringUtil.PadR( StringUtil.RTrim( AV11cBUS_AUX_NCO), 12, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cBUS_AUX_NCO", AV11cBUS_AUX_NCO);
         lV12cBUS_AUX_COM = StringUtil.PadR( StringUtil.RTrim( AV12cBUS_AUX_COM), 2, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cBUS_AUX_COM", AV12cBUS_AUX_COM);
         /* Using cursor H00303 */
         pr_default.execute(1, new Object[] {AV6cBUS_AUX_ID, AV7cBUS_AUX_RUB, lV8cBUS_AUX_DES, AV9cBUS_AUX_FAL, AV10cBUS_AUX_FAD, lV11cBUS_AUX_NCO, lV12cBUS_AUX_COM});
         GRID1_nRecordCount = H00303_AGRID1_nRecordCount[0] ;
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

      protected void STRUP300( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E11302 */
         E11302 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ! context.localUtil.VCNumber( cgiGet( edtavCbus_aux_id_Internalname), "ZZZ9") || ( context.localUtil.CToN( cgiGet( edtavCbus_aux_id_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavCbus_aux_id_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vCBUS_AUX_ID");
               GX_FocusControl = edtavCbus_aux_id_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV6cBUS_AUX_ID = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cBUS_AUX_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cBUS_AUX_ID), 4, 0)));
            }
            else
            {
               AV6cBUS_AUX_ID = (short)(context.localUtil.CToN( cgiGet( edtavCbus_aux_id_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cBUS_AUX_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cBUS_AUX_ID), 4, 0)));
            }
            if ( ! context.localUtil.VCNumber( cgiGet( edtavCbus_aux_rub_Internalname), "ZZZ9") || ( context.localUtil.CToN( cgiGet( edtavCbus_aux_rub_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavCbus_aux_rub_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vCBUS_AUX_RUB");
               GX_FocusControl = edtavCbus_aux_rub_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV7cBUS_AUX_RUB = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cBUS_AUX_RUB", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7cBUS_AUX_RUB), 4, 0)));
            }
            else
            {
               AV7cBUS_AUX_RUB = (short)(context.localUtil.CToN( cgiGet( edtavCbus_aux_rub_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cBUS_AUX_RUB", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7cBUS_AUX_RUB), 4, 0)));
            }
            AV8cBUS_AUX_DES = cgiGet( edtavCbus_aux_des_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cBUS_AUX_DES", AV8cBUS_AUX_DES);
            if ( context.localUtil.VCDate( cgiGet( edtavCbus_aux_fal_Internalname), 4) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"FECHA DE ALTA DEL BIEN"}), 1, "vCBUS_AUX_FAL");
               GX_FocusControl = edtavCbus_aux_fal_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV9cBUS_AUX_FAL = DateTime.MinValue ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cBUS_AUX_FAL", context.localUtil.Format(AV9cBUS_AUX_FAL, "99/99/9999"));
            }
            else
            {
               AV9cBUS_AUX_FAL = context.localUtil.CToD( cgiGet( edtavCbus_aux_fal_Internalname), 4) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cBUS_AUX_FAL", context.localUtil.Format(AV9cBUS_AUX_FAL, "99/99/9999"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavCbus_aux_fad_Internalname), 4) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"FECHA DE ADQUISICIÓN DEL BIEN"}), 1, "vCBUS_AUX_FAD");
               GX_FocusControl = edtavCbus_aux_fad_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV10cBUS_AUX_FAD = DateTime.MinValue ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cBUS_AUX_FAD", context.localUtil.Format(AV10cBUS_AUX_FAD, "99/99/9999"));
            }
            else
            {
               AV10cBUS_AUX_FAD = context.localUtil.CToD( cgiGet( edtavCbus_aux_fad_Internalname), 4) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cBUS_AUX_FAD", context.localUtil.Format(AV10cBUS_AUX_FAD, "99/99/9999"));
            }
            AV11cBUS_AUX_NCO = cgiGet( edtavCbus_aux_nco_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cBUS_AUX_NCO", AV11cBUS_AUX_NCO);
            AV12cBUS_AUX_COM = cgiGet( edtavCbus_aux_com_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cBUS_AUX_COM", AV12cBUS_AUX_COM);
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ",", ".")) ;
            AV13pBUS_AUX_ID = (short)(context.localUtil.CToN( cgiGet( "vPBUS_AUX_ID"), ",", ".")) ;
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
         /* Execute user event: E11302 */
         E11302 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E11302( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Lista de Selección %1", "Auxiliar de bienes de uso", "", "", "", "", "", "", "", "") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption);
      }

      private void E12302( )
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
         /* Execute user event: E13302 */
         E13302 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E13302( )
      {
         /* Enter Routine */
         AV13pBUS_AUX_ID = A352BUS_AUX_ID ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pBUS_AUX_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pBUS_AUX_ID), 4, 0)));
         context.setWebReturnParms(new Object[] {(short)AV13pBUS_AUX_ID});
         context.nUserReturn = 1 ;
         returnInSub = true;
         if (true) return;
      }

      protected void wb_table1_2_302( bool wbgen )
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
            wb_table2_9_302( true) ;
         }
         else
         {
            wb_table2_9_302( false) ;
         }
         return  ;
      }

      protected void wb_table2_9_302e( bool wbgen )
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
            wb_table3_48_302( true) ;
         }
         else
         {
            wb_table3_48_302( false) ;
         }
         return  ;
      }

      protected void wb_table3_48_302e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_302e( true) ;
         }
         else
         {
            wb_table1_2_302e( false) ;
         }
      }

      protected void wb_table3_48_302( bool wbgen )
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
               context.SendWebValue( "de auxiliar") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "DEL BIEN") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "DEL BIEN") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "DEL BIEN") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "DE COMPRA") ;
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
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A352BUS_AUX_ID), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A353BUS_AUX_RUB), 4, 0, ".", "")));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtBUS_AUX_RUB_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A354BUS_AUX_DES));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", context.localUtil.Format(A355BUS_AUX_FAL, "99/99/9999"));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A358BUS_AUX_COM));
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
            wb_table4_60_302( true) ;
         }
         else
         {
            wb_table4_60_302( false) ;
         }
         return  ;
      }

      protected void wb_table4_60_302e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_48_302e( true) ;
         }
         else
         {
            wb_table3_48_302e( false) ;
         }
      }

      protected void wb_table4_60_302( bool wbgen )
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
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_cancel_Internalname, "Cancelar", "Cancelar", "", StyleString, ClassString, 1, 1, "rounded", 1, bttBtn_cancel_Jsonclick, "ECANCEL.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(51), 3, 0)+","+"null"+");", "", "HLP_Gx00P0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_60_302e( true) ;
         }
         else
         {
            wb_table4_60_302e( false) ;
         }
      }

      protected void wb_table2_9_302( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_aux_id_Internalname, 1, 1, 0, "Id de auxiliar", "", "", "", 0, lblTextblockbus_aux_id_Jsonclick, "", StyleString, ClassString, "HLP_Gx00P0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCbus_aux_id_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cBUS_AUX_ID), 4, 0, ",", "")), "", 4, "chr", 1, "row", 4, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(AV6cBUS_AUX_ID), "ZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(14);\"", 0, edtavCbus_aux_id_Jsonclick, "", 0, 1, -1, true, "right", "HLP_Gx00P0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_aux_rub_Internalname, 1, 1, 0, "RUBRO DEL BIEN", "", "", "", 0, lblTextblockbus_aux_rub_Jsonclick, "", StyleString, ClassString, "HLP_Gx00P0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCbus_aux_rub_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7cBUS_AUX_RUB), 4, 0, ",", "")), "", 4, "chr", 1, "row", 4, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(AV7cBUS_AUX_RUB), "ZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(19);\"", 0, edtavCbus_aux_rub_Jsonclick, "", 0, 1, -1, true, "right", "HLP_Gx00P0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_aux_des_Internalname, 1, 1, 0, "DESCRIPCIÓN DEL BIEN", "", "", "", 0, lblTextblockbus_aux_des_Jsonclick, "", StyleString, ClassString, "HLP_Gx00P0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 24,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCbus_aux_des_Internalname, StringUtil.RTrim( AV8cBUS_AUX_DES), "", 50, "chr", 1, "row", 50, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV8cBUS_AUX_DES, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(24);\"", 0, edtavCbus_aux_des_Jsonclick, "", 0, 1, -1, true, "left", "HLP_Gx00P0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_aux_fal_Internalname, 1, 1, 0, "FECHA DE ALTA DEL BIEN", "", "", "", 0, lblTextblockbus_aux_fal_Jsonclick, "", StyleString, ClassString, "HLP_Gx00P0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtavCbus_aux_fal_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavCbus_aux_fal_Internalname, context.localUtil.Format(AV9cBUS_AUX_FAL, "99/99/9999"), "", 10, "chr", 1, "row", 10, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( AV9cBUS_AUX_FAL, "99/99/9999"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',0,24,'spa',false,0);"+";gx.evt.onblur(29);\"", 0, edtavCbus_aux_fal_Jsonclick, "", 0, 1, -1, true, "right", "HLP_Gx00P0.htm");
            GxWebStd.gx_bitmap( context, edtavCbus_aux_fal_Internalname+"_dp_trigger", "", "calendar-img.gif", "", ((1==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, "", "", 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_Gx00P0.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_aux_fad_Internalname, 1, 1, 0, "FECHA DE ADQUISICIÓN DEL BIEN", "", "", "", 0, lblTextblockbus_aux_fad_Jsonclick, "", StyleString, ClassString, "HLP_Gx00P0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtavCbus_aux_fad_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavCbus_aux_fad_Internalname, context.localUtil.Format(AV10cBUS_AUX_FAD, "99/99/9999"), "", 10, "chr", 1, "row", 10, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( AV10cBUS_AUX_FAD, "99/99/9999"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',0,24,'spa',false,0);"+";gx.evt.onblur(34);\"", 0, edtavCbus_aux_fad_Jsonclick, "", 0, 1, -1, true, "right", "HLP_Gx00P0.htm");
            GxWebStd.gx_bitmap( context, edtavCbus_aux_fad_Internalname+"_dp_trigger", "", "calendar-img.gif", "", ((1==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, "", "", 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_Gx00P0.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_aux_nco_Internalname, 1, 1, 0, "NUMERO DEL COMP. DE COMPRA", "", "", "", 0, lblTextblockbus_aux_nco_Jsonclick, "", StyleString, ClassString, "HLP_Gx00P0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCbus_aux_nco_Internalname, StringUtil.RTrim( AV11cBUS_AUX_NCO), "", 12, "chr", 1, "row", 12, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV11cBUS_AUX_NCO, "XXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(39);\"", 0, edtavCbus_aux_nco_Jsonclick, "", 0, 1, -1, true, "left", "HLP_Gx00P0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_aux_com_Internalname, 1, 1, 0, "COMPROBANTE DE COMPRA", "", "", "", 0, lblTextblockbus_aux_com_Jsonclick, "", StyleString, ClassString, "HLP_Gx00P0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCbus_aux_com_Internalname, StringUtil.RTrim( AV12cBUS_AUX_COM), "", 2, "chr", 1, "row", 2, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV12cBUS_AUX_COM, "XX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(44);\"", 0, edtavCbus_aux_com_Jsonclick, "", 0, 1, -1, true, "left", "HLP_Gx00P0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_9_302e( true) ;
         }
         else
         {
            wb_table2_9_302e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV13pBUS_AUX_ID = Convert.ToInt16(getParm(obj,0)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pBUS_AUX_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pBUS_AUX_ID), 4, 0)));
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
         PA302( ) ;
         WS302( ) ;
         WE302( ) ;
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
         AddThemeStyleSheetFile("", "Modern.css", "?15564175");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?17203735");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("gx00p0.js", "?17203735");
         /* End function include_jscripts */
      }

      protected void sendrow_512( )
      {
         WB300( ) ;
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
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A352BUS_AUX_ID), 4, 0, ",", "")))+"'"+"]);" ;
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
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBUS_AUX_ID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A352BUS_AUX_ID), 4, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)4,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A352BUS_AUX_ID), "ZZZ9"),(String)"",(short)0,(String)edtBUS_AUX_ID_Jsonclick,(String)"",(short)51,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            edtBUS_AUX_RUB_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A352BUS_AUX_ID), 4, 0, ",", "")))+"'"+"]);" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_AUX_RUB_Internalname, "Link", edtBUS_AUX_RUB_Link);
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBUS_AUX_RUB_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A353BUS_AUX_RUB), 4, 0, ",", "")),(String)"Seleccionar",(short)0,(String)"px",(short)17,(String)"",(short)4,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)edtBUS_AUX_RUB_Link,(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A353BUS_AUX_RUB), "ZZZ9"),(String)"",(short)0,(String)edtBUS_AUX_RUB_Jsonclick,(String)"",(short)51,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBUS_AUX_DES_Internalname,StringUtil.RTrim( A354BUS_AUX_DES),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)50,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A354BUS_AUX_DES, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")),(String)"",(short)0,(String)edtBUS_AUX_DES_Jsonclick,(String)"",(short)51,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBUS_AUX_FAL_Internalname,context.localUtil.Format(A355BUS_AUX_FAL, "99/99/9999"),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)10,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( A355BUS_AUX_FAL, "99/99/9999"),(String)"",(short)0,(String)edtBUS_AUX_FAL_Jsonclick,(String)"",(short)51,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBUS_AUX_COM_Internalname,StringUtil.RTrim( A358BUS_AUX_COM),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)2,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A358BUS_AUX_COM, "XX")),(String)"",(short)0,(String)edtBUS_AUX_COM_Jsonclick,(String)"",(short)51,(short)1,(short)1,(bool)true,(String)"left"});
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_51_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_51_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_51_idx+1)) ;
            sGXsfl_51_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_51_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
            edtBUS_AUX_ID_Internalname = "BUS_AUX_ID_"+sGXsfl_51_idx ;
            edtBUS_AUX_RUB_Internalname = "BUS_AUX_RUB_"+sGXsfl_51_idx ;
            edtBUS_AUX_DES_Internalname = "BUS_AUX_DES_"+sGXsfl_51_idx ;
            edtBUS_AUX_FAL_Internalname = "BUS_AUX_FAL_"+sGXsfl_51_idx ;
            edtBUS_AUX_COM_Internalname = "BUS_AUX_COM_"+sGXsfl_51_idx ;
         }
         /* End function sendrow_512 */
      }

      protected void init_default_properties( )
      {
         lblTextblockbus_aux_id_Internalname = "TEXTBLOCKBUS_AUX_ID" ;
         edtavCbus_aux_id_Internalname = "vCBUS_AUX_ID" ;
         lblTextblockbus_aux_rub_Internalname = "TEXTBLOCKBUS_AUX_RUB" ;
         edtavCbus_aux_rub_Internalname = "vCBUS_AUX_RUB" ;
         lblTextblockbus_aux_des_Internalname = "TEXTBLOCKBUS_AUX_DES" ;
         edtavCbus_aux_des_Internalname = "vCBUS_AUX_DES" ;
         lblTextblockbus_aux_fal_Internalname = "TEXTBLOCKBUS_AUX_FAL" ;
         edtavCbus_aux_fal_Internalname = "vCBUS_AUX_FAL" ;
         lblTextblockbus_aux_fad_Internalname = "TEXTBLOCKBUS_AUX_FAD" ;
         edtavCbus_aux_fad_Internalname = "vCBUS_AUX_FAD" ;
         lblTextblockbus_aux_nco_Internalname = "TEXTBLOCKBUS_AUX_NCO" ;
         edtavCbus_aux_nco_Internalname = "vCBUS_AUX_NCO" ;
         lblTextblockbus_aux_com_Internalname = "TEXTBLOCKBUS_AUX_COM" ;
         edtavCbus_aux_com_Internalname = "vCBUS_AUX_COM" ;
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
         edtBUS_AUX_COM_Jsonclick = "" ;
         edtBUS_AUX_FAL_Jsonclick = "" ;
         edtBUS_AUX_DES_Jsonclick = "" ;
         edtBUS_AUX_RUB_Jsonclick = "" ;
         edtBUS_AUX_ID_Jsonclick = "" ;
         edtavCbus_aux_com_Jsonclick = "" ;
         edtavCbus_aux_nco_Jsonclick = "" ;
         edtavCbus_aux_fad_Jsonclick = "" ;
         edtavCbus_aux_fal_Jsonclick = "" ;
         edtavCbus_aux_des_Jsonclick = "" ;
         edtavCbus_aux_rub_Jsonclick = "" ;
         edtavCbus_aux_id_Jsonclick = "" ;
         edtBUS_AUX_RUB_Link = "" ;
         edtavLinkselection_Link = "" ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 2 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Selection List Auxiliar de bienes de uso" ;
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
         AV8cBUS_AUX_DES = "" ;
         AV9cBUS_AUX_FAL = DateTime.MinValue ;
         AV10cBUS_AUX_FAD = DateTime.MinValue ;
         AV11cBUS_AUX_NCO = "" ;
         AV12cBUS_AUX_COM = "" ;
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
         edtBUS_AUX_ID_Internalname = "" ;
         edtBUS_AUX_RUB_Internalname = "" ;
         edtBUS_AUX_DES_Internalname = "" ;
         edtBUS_AUX_FAL_Internalname = "" ;
         edtBUS_AUX_COM_Internalname = "" ;
         AV5LinkSelection = "" ;
         A354BUS_AUX_DES = "" ;
         A355BUS_AUX_FAL = DateTime.MinValue ;
         A358BUS_AUX_COM = "" ;
         Grid1Container = new GXWebGrid( context);
         scmdbuf = "" ;
         lV8cBUS_AUX_DES = "" ;
         lV11cBUS_AUX_NCO = "" ;
         lV12cBUS_AUX_COM = "" ;
         H00302_A356BUS_AUX_FAD = new DateTime[] {DateTime.MinValue} ;
         H00302_A357BUS_AUX_NCO = new String[] {""} ;
         H00302_A358BUS_AUX_COM = new String[] {""} ;
         H00302_A355BUS_AUX_FAL = new DateTime[] {DateTime.MinValue} ;
         H00302_A354BUS_AUX_DES = new String[] {""} ;
         H00302_A353BUS_AUX_RUB = new short[1] ;
         H00302_A352BUS_AUX_ID = new short[1] ;
         A356BUS_AUX_FAD = DateTime.MinValue ;
         A357BUS_AUX_NCO = "" ;
         H00303_AGRID1_nRecordCount = new int[1] ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         subGrid1_Linesclass = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char4 = "" ;
         Grid1Column = new GXWebColumn();
         TempTags = "" ;
         bttBtn_cancel_Jsonclick = "" ;
         lblTextblockbus_aux_id_Jsonclick = "" ;
         lblTextblockbus_aux_rub_Jsonclick = "" ;
         lblTextblockbus_aux_des_Jsonclick = "" ;
         lblTextblockbus_aux_fal_Jsonclick = "" ;
         lblTextblockbus_aux_fad_Jsonclick = "" ;
         GXt_char6 = "" ;
         GXt_char5 = "" ;
         lblTextblockbus_aux_nco_Jsonclick = "" ;
         lblTextblockbus_aux_com_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         ROClassString = "" ;
         GXt_char7 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx00p0__default(),
            new Object[][] {
                new Object[] {
               H00302_A356BUS_AUX_FAD, H00302_A357BUS_AUX_NCO, H00302_A358BUS_AUX_COM, H00302_A355BUS_AUX_FAL, H00302_A354BUS_AUX_DES, H00302_A353BUS_AUX_RUB, H00302_A352BUS_AUX_ID
               }
               , new Object[] {
               H00303_AGRID1_nRecordCount
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
      private short AV6cBUS_AUX_ID ;
      private short AV7cBUS_AUX_RUB ;
      private short AV13pBUS_AUX_ID ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short GRID1_nEOF ;
      private short wbEnd ;
      private short wbStart ;
      private short A352BUS_AUX_ID ;
      private short A353BUS_AUX_RUB ;
      private short nDonePA ;
      private short subGrid1_Rows ;
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
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_51_idx="0001" ;
      private String AV8cBUS_AUX_DES ;
      private String AV11cBUS_AUX_NCO ;
      private String AV12cBUS_AUX_COM ;
      private String sDynURL ;
      private String FormProcess ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavLinkselection_Internalname ;
      private String edtBUS_AUX_ID_Internalname ;
      private String edtBUS_AUX_RUB_Internalname ;
      private String edtBUS_AUX_DES_Internalname ;
      private String edtBUS_AUX_FAL_Internalname ;
      private String edtBUS_AUX_COM_Internalname ;
      private String A354BUS_AUX_DES ;
      private String A358BUS_AUX_COM ;
      private String edtavCbus_aux_id_Internalname ;
      private String scmdbuf ;
      private String lV8cBUS_AUX_DES ;
      private String lV11cBUS_AUX_NCO ;
      private String lV12cBUS_AUX_COM ;
      private String A357BUS_AUX_NCO ;
      private String edtavCbus_aux_rub_Internalname ;
      private String edtavCbus_aux_des_Internalname ;
      private String edtavCbus_aux_fal_Internalname ;
      private String edtavCbus_aux_fad_Internalname ;
      private String edtavCbus_aux_nco_Internalname ;
      private String edtavCbus_aux_com_Internalname ;
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
      private String edtBUS_AUX_RUB_Link ;
      private String tblTable4_Internalname ;
      private String TempTags ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblockbus_aux_id_Internalname ;
      private String lblTextblockbus_aux_id_Jsonclick ;
      private String edtavCbus_aux_id_Jsonclick ;
      private String lblTextblockbus_aux_rub_Internalname ;
      private String lblTextblockbus_aux_rub_Jsonclick ;
      private String edtavCbus_aux_rub_Jsonclick ;
      private String lblTextblockbus_aux_des_Internalname ;
      private String lblTextblockbus_aux_des_Jsonclick ;
      private String edtavCbus_aux_des_Jsonclick ;
      private String lblTextblockbus_aux_fal_Internalname ;
      private String lblTextblockbus_aux_fal_Jsonclick ;
      private String edtavCbus_aux_fal_Jsonclick ;
      private String lblTextblockbus_aux_fad_Internalname ;
      private String lblTextblockbus_aux_fad_Jsonclick ;
      private String GXt_char6 ;
      private String edtavCbus_aux_fad_Jsonclick ;
      private String GXt_char5 ;
      private String lblTextblockbus_aux_nco_Internalname ;
      private String lblTextblockbus_aux_nco_Jsonclick ;
      private String edtavCbus_aux_nco_Jsonclick ;
      private String lblTextblockbus_aux_com_Internalname ;
      private String lblTextblockbus_aux_com_Jsonclick ;
      private String edtavCbus_aux_com_Jsonclick ;
      private String ROClassString ;
      private String edtBUS_AUX_ID_Jsonclick ;
      private String edtBUS_AUX_RUB_Jsonclick ;
      private String edtBUS_AUX_DES_Jsonclick ;
      private String edtBUS_AUX_FAL_Jsonclick ;
      private String edtBUS_AUX_COM_Jsonclick ;
      private String GXt_char7 ;
      private DateTime AV9cBUS_AUX_FAL ;
      private DateTime AV10cBUS_AUX_FAD ;
      private DateTime A355BUS_AUX_FAL ;
      private DateTime A356BUS_AUX_FAD ;
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
      private DateTime[] H00302_A356BUS_AUX_FAD ;
      private String[] H00302_A357BUS_AUX_NCO ;
      private String[] H00302_A358BUS_AUX_COM ;
      private DateTime[] H00302_A355BUS_AUX_FAL ;
      private String[] H00302_A354BUS_AUX_DES ;
      private short[] H00302_A353BUS_AUX_RUB ;
      private short[] H00302_A352BUS_AUX_ID ;
      private int[] H00303_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private short aP0_pBUS_AUX_ID ;
      private GXWebForm Form ;
   }

   public class gx00p0__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH00302 ;
          prmH00302 = new Object[] {
          new Object[] {"@AV6cBUS_AUX_ID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV7cBUS_AUX_RUB",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV8cBUS_AUX_DES",SqlDbType.Char,50,0} ,
          new Object[] {"@AV9cBUS_AUX_FAL",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV10cBUS_AUX_FAD",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV11cBUS_AUX_NCO",SqlDbType.Char,12,0} ,
          new Object[] {"@AV12cBUS_AUX_COM",SqlDbType.Char,2,0}
          } ;
          Object[] prmH00303 ;
          prmH00303 = new Object[] {
          new Object[] {"@AV6cBUS_AUX_ID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV7cBUS_AUX_RUB",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV8cBUS_AUX_DES",SqlDbType.Char,50,0} ,
          new Object[] {"@AV9cBUS_AUX_FAL",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV10cBUS_AUX_FAD",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV11cBUS_AUX_NCO",SqlDbType.Char,12,0} ,
          new Object[] {"@AV12cBUS_AUX_COM",SqlDbType.Char,2,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00302", "SELECT [BUS_AUX_FAD], [BUS_AUX_NCO], [BUS_AUX_COM], [BUS_AUX_FAL], [BUS_AUX_DES], [BUS_AUX_RUB], [BUS_AUX_ID] FROM [TBUS000_AUX] WITH (NOLOCK) WHERE ([BUS_AUX_ID] >= @AV6cBUS_AUX_ID) AND ([BUS_AUX_RUB] >= @AV7cBUS_AUX_RUB) AND ([BUS_AUX_DES] like @AV8cBUS_AUX_DES) AND ([BUS_AUX_FAL] >= @AV9cBUS_AUX_FAL) AND ([BUS_AUX_FAD] >= @AV10cBUS_AUX_FAD) AND ([BUS_AUX_NCO] like @AV11cBUS_AUX_NCO) AND ([BUS_AUX_COM] like @AV12cBUS_AUX_COM) ORDER BY [BUS_AUX_ID]  OPTION (FAST 11)",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00302,11,0,false,false )
             ,new CursorDef("H00303", "SELECT COUNT(*) FROM [TBUS000_AUX] WITH (NOLOCK) WHERE ([BUS_AUX_ID] >= @AV6cBUS_AUX_ID) AND ([BUS_AUX_RUB] >= @AV7cBUS_AUX_RUB) AND ([BUS_AUX_DES] like @AV8cBUS_AUX_DES) AND ([BUS_AUX_FAL] >= @AV9cBUS_AUX_FAL) AND ([BUS_AUX_FAD] >= @AV10cBUS_AUX_FAD) AND ([BUS_AUX_NCO] like @AV11cBUS_AUX_NCO) AND ([BUS_AUX_COM] like @AV12cBUS_AUX_COM) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00303,1,0,false,false )
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
                ((DateTime[]) buf[0])[0] = rslt.getGXDate(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 12) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 2) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDate(4) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 50) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
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
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (DateTime)parms[3]);
                stmt.SetParameter(5, (DateTime)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                break;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (DateTime)parms[3]);
                stmt.SetParameter(5, (DateTime)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                break;
       }
    }

 }

}
