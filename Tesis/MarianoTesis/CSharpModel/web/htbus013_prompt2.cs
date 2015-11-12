/*
               File: HTBUS013_prompt2
        Description: Seleccionar Responsable
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 4/2/2014 19:29:26.56
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
   public class htbus013_prompt2 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public htbus013_prompt2( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public htbus013_prompt2( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( out String aP0_pTTBUS7_CodResp )
      {
         this.AV6pTTBUS7_CodResp = "" ;
         executePrivate();
         aP0_pTTBUS7_CodResp=this.AV6pTTBUS7_CodResp;
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
               nGXsfl_20_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               sGXsfl_20_idx = GetNextPar( ) ;
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxnrGrid1_newrow( nRC_Grid1, nGXsfl_20_idx, sGXsfl_20_idx) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid1") == 0 )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0 ;
               edtavTtbus7_codresp_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTtbus7_codresp_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTtbus7_codresp_Enabled), 5, 0)));
               edtavTtbus7_desresp_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTtbus7_desresp_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTtbus7_desresp_Enabled), 5, 0)));
               Grid1_PageSize20 = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               A36TTBUS7_DesResp = GetNextPar( ) ;
               n36TTBUS7_DesResp = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36TTBUS7_DesResp", A36TTBUS7_DesResp);
               A35TTBUS7_CodResp = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35TTBUS7_CodResp", A35TTBUS7_CodResp);
               AV11Pos = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxgrGrid1_refresh( Grid1_PageSize20, A36TTBUS7_DesResp, A35TTBUS7_CodResp, AV11Pos) ;
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
               AV6pTTBUS7_CodResp = gxfirstwebparm ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6pTTBUS7_CodResp", AV6pTTBUS7_CodResp);
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
         PA1W2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START1W2( ) ;
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("htbus013_prompt2.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV6pTTBUS7_CodResp))+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPTTBUS7_CODRESP", StringUtil.RTrim( AV6pTTBUS7_CodResp));
         GxWebStd.gx_hidden_field( context, "TTBUS7_DESRESP", StringUtil.RTrim( A36TTBUS7_DesResp));
         GxWebStd.gx_hidden_field( context, "TTBUS7_CODRESP", StringUtil.RTrim( A35TTBUS7_CodResp));
         GxWebStd.gx_hidden_field( context, "vPOS", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11Pos), 3, 0, ",", "")));
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
            WE1W2( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT1W2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override String GetPgmname( )
      {
         return "HTBUS013_prompt2" ;
      }

      public override String GetPgmdesc( )
      {
         return "Seleccionar Responsable" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("htbus013_prompt2.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV6pTTBUS7_CodResp)) ;
      }

      protected void WB1W0( )
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
            wb_table1_2_1W2( true) ;
         }
         else
         {
            wb_table1_2_1W2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_1W2e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START1W2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "Seleccionar Responsable", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP1W0( ) ;
      }

      protected void WS1W2( )
      {
         START1W2( ) ;
         EVT1W2( ) ;
      }

      protected void EVT1W2( )
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
                           else if ( StringUtil.StrCmp(sEvt, "'BUSCAR'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E111W2 */
                              E111W2 ();
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
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 10), "GRID1.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 8), "'BUSCAR'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) )
                           {
                              nGXsfl_20_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                              sGXsfl_20_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_20_idx), 4, 0)), 4, "0") ;
                              edtavLink_selection_Internalname = "vLINK_SELECTION_"+sGXsfl_20_idx ;
                              edtavTtbus7_codresp_Internalname = "vTTBUS7_CODRESP_"+sGXsfl_20_idx ;
                              edtavTtbus7_desresp_Internalname = "vTTBUS7_DESRESP_"+sGXsfl_20_idx ;
                              AV5Link_Selection = cgiGet( "GXimg"+edtavLink_selection_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLink_selection_Internalname, "Bitmap", context.convertURL( AV5Link_Selection));
                              AV7TTBUS7_CodResp = StringUtil.Upper( cgiGet( edtavTtbus7_codresp_Internalname)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7TTBUS7_CodResp", AV7TTBUS7_CodResp);
                              AV8TTBUS7_DesResp = StringUtil.Upper( cgiGet( edtavTtbus7_desresp_Internalname)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8TTBUS7_DesResp", AV8TTBUS7_DesResp);
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E121W2 */
                                    E121W2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID1.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E131W2 */
                                    E131W2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false ;
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: E141W2 */
                                          E141W2 ();
                                       }
                                       dynload_actions( ) ;
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'BUSCAR'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E111W2 */
                                    E111W2 ();
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

      protected void WE1W2( )
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

      protected void PA1W2( )
      {
         if ( nDonePA == 0 )
         {
            GX_FocusControl = edtavFttbus7_desresp_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGrid1_newrow( short nRC_Grid1 ,
                                       short nGXsfl_20_idx ,
                                       String sGXsfl_20_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         edtavLink_selection_Internalname = "vLINK_SELECTION_"+sGXsfl_20_idx ;
         edtavTtbus7_codresp_Internalname = "vTTBUS7_CODRESP_"+sGXsfl_20_idx ;
         edtavTtbus7_desresp_Internalname = "vTTBUS7_DESRESP_"+sGXsfl_20_idx ;
         while ( nGXsfl_20_idx <= nRC_Grid1 )
         {
            sendrow_202( ) ;
            nGXsfl_20_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_20_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_20_idx+1)) ;
            sGXsfl_20_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_20_idx), 4, 0)), 4, "0") ;
            edtavLink_selection_Internalname = "vLINK_SELECTION_"+sGXsfl_20_idx ;
            edtavTtbus7_codresp_Internalname = "vTTBUS7_CODRESP_"+sGXsfl_20_idx ;
            edtavTtbus7_desresp_Internalname = "vTTBUS7_DESRESP_"+sGXsfl_20_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int Grid1_PageSize20 ,
                                        String A36TTBUS7_DesResp ,
                                        String A35TTBUS7_CodResp ,
                                        short AV11Pos )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         subGrid1_Rows = (short)(Grid1_PageSize20) ;
         RF1W2( ) ;
         enableOutput();
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxgrGrid1_refresh */
      }

      protected void Refresh( )
      {
         RF1W2( ) ;
         /* End function Refresh */
      }

      protected void RF1W2( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 20 ;
         nGXsfl_20_idx = 1 ;
         sGXsfl_20_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_20_idx), 4, 0)), 4, "0") ;
         edtavLink_selection_Internalname = "vLINK_SELECTION_"+sGXsfl_20_idx ;
         edtavTtbus7_codresp_Internalname = "vTTBUS7_CODRESP_"+sGXsfl_20_idx ;
         edtavTtbus7_desresp_Internalname = "vTTBUS7_DESRESP_"+sGXsfl_20_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtavLink_selection_Internalname = "vLINK_SELECTION_"+sGXsfl_20_idx ;
            edtavTtbus7_codresp_Internalname = "vTTBUS7_CODRESP_"+sGXsfl_20_idx ;
            edtavTtbus7_desresp_Internalname = "vTTBUS7_DESRESP_"+sGXsfl_20_idx ;
            /* Execute user event: E131W2 */
            E131W2 ();
            wbEnd = 20 ;
            WB1W0( ) ;
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

      protected void STRUP1W0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         edtavTtbus7_codresp_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTtbus7_codresp_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTtbus7_codresp_Enabled), 5, 0)));
         edtavTtbus7_desresp_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTtbus7_desresp_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTtbus7_desresp_Enabled), 5, 0)));
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E121W2 */
         E121W2 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            AV9fTTBUS7_DesResp = StringUtil.Upper( cgiGet( edtavFttbus7_desresp_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9fTTBUS7_DesResp", AV9fTTBUS7_DesResp);
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ",", ".")) ;
            AV6pTTBUS7_CodResp = cgiGet( "vPTTBUS7_CODRESP") ;
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
         /* Execute user event: E121W2 */
         E121W2 ();
         if (returnInSub) return;
      }

      protected void E121W2( )
      {
         /* Start Routine */
         AV11Pos = (short)(NumberUtil.Val( AV12SESION.Get("Pos"), ".")) ;
      }

      protected void E111W2( )
      {
         /* 'Buscar' Routine */
         AV10bTTBUS7_DesResp = "%" + StringUtil.Trim( AV9fTTBUS7_DesResp) + "%" ;
      }

      private void E131W2( )
      {
         /* Grid1_Load Routine */
         AV5Link_Selection = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", "Modern") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLink_selection_Internalname, "Bitmap", context.convertURL( AV5Link_Selection));
         if ( AV11Pos == 0 )
         {
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV9fTTBUS7_DesResp ,
                                                 A36TTBUS7_DesResp ,
                                                 AV10bTTBUS7_DesResp },
                                                 new int[] {
                                                 TypeConstants.STRING, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING
                                                 }
            });
            /* Using cursor H001W2 */
            pr_default.execute(0, new Object[] {AV10bTTBUS7_DesResp});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A36TTBUS7_DesResp = H001W2_A36TTBUS7_DesResp[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36TTBUS7_DesResp", A36TTBUS7_DesResp);
               n36TTBUS7_DesResp = H001W2_n36TTBUS7_DesResp[0] ;
               A35TTBUS7_CodResp = H001W2_A35TTBUS7_CodResp[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35TTBUS7_CodResp", A35TTBUS7_CodResp);
               A36TTBUS7_DesResp = H001W2_A36TTBUS7_DesResp[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36TTBUS7_DesResp", A36TTBUS7_DesResp);
               n36TTBUS7_DesResp = H001W2_n36TTBUS7_DesResp[0] ;
               AV7TTBUS7_CodResp = A35TTBUS7_CodResp ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7TTBUS7_CodResp", AV7TTBUS7_CodResp);
               AV8TTBUS7_DesResp = A36TTBUS7_DesResp ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8TTBUS7_DesResp", AV8TTBUS7_DesResp);
               /* Load Method */
               if ( wbStart != -1 )
               {
                  wbStart = 20 ;
               }
               if ( ( subGrid1_Islastpage == 1 ) || ( 10 == 0 ) || ( ( GRID1_nCurrentRecord >= GRID1_nFirstRecordOnPage ) && ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) )
               {
                  sendrow_202( ) ;
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
               pr_default.readNext(0);
            }
            pr_default.close(0);
         }
         else
         {
            /* Using cursor H001W3 */
            pr_default.execute(1, new Object[] {AV11Pos});
            while ( (pr_default.getStatus(1) != 101) )
            {
               A33TTBUS7_Pos = H001W3_A33TTBUS7_Pos[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
               A36TTBUS7_DesResp = H001W3_A36TTBUS7_DesResp[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36TTBUS7_DesResp", A36TTBUS7_DesResp);
               n36TTBUS7_DesResp = H001W3_n36TTBUS7_DesResp[0] ;
               A35TTBUS7_CodResp = H001W3_A35TTBUS7_CodResp[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35TTBUS7_CodResp", A35TTBUS7_CodResp);
               A36TTBUS7_DesResp = H001W3_A36TTBUS7_DesResp[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36TTBUS7_DesResp", A36TTBUS7_DesResp);
               n36TTBUS7_DesResp = H001W3_n36TTBUS7_DesResp[0] ;
               AV7TTBUS7_CodResp = A35TTBUS7_CodResp ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7TTBUS7_CodResp", AV7TTBUS7_CodResp);
               AV8TTBUS7_DesResp = A36TTBUS7_DesResp ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8TTBUS7_DesResp", AV8TTBUS7_DesResp);
               /* Load Method */
               if ( wbStart != -1 )
               {
                  wbStart = 20 ;
               }
               if ( ( subGrid1_Islastpage == 1 ) || ( 10 == 0 ) || ( ( GRID1_nCurrentRecord >= GRID1_nFirstRecordOnPage ) && ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) )
               {
                  sendrow_202( ) ;
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
               pr_default.readNext(1);
            }
            pr_default.close(1);
         }
      }

      public void GXEnter( )
      {
         /* Execute user event: E141W2 */
         E141W2 ();
         if (returnInSub) return;
      }

      protected void E141W2( )
      {
         /* Enter Routine */
         AV6pTTBUS7_CodResp = AV7TTBUS7_CodResp ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6pTTBUS7_CodResp", AV6pTTBUS7_CodResp);
         context.setWebReturnParms(new Object[] {(String)AV6pTTBUS7_CodResp});
         context.nUserReturn = 1 ;
         returnInSub = true;
         if (true) return;
      }

      protected void wb_table1_2_1W2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            sStyleString = sStyleString + " height: " + StringUtil.LTrim( StringUtil.Str( (decimal)(304), 10, 0)) + "px" + ";" ;
            sStyleString = sStyleString + " width: " + StringUtil.LTrim( StringUtil.Str( (decimal)(462), 10, 0)) + "px" + ";" ;
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
            wb_table2_8_1W2( true) ;
         }
         else
         {
            wb_table2_8_1W2( false) ;
         }
         return  ;
      }

      protected void wb_table2_8_1W2e( bool wbgen )
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
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Cod. Responsable") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Apellido y Nombre") ;
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
               Grid1Column.AddObjectProperty("Value", context.convertURL( AV5Link_Selection));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( AV7TTBUS7_CodResp));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavTtbus7_codresp_Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( AV8TTBUS7_DesResp));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavTtbus7_desresp_Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Allowselection", "false");
               Grid1Container.AddObjectProperty("Allowcollapsing", "false");
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 9, 0, ".", "")));
            }
         }
         if ( wbEnd == 20 )
         {
            wbEnd = 0 ;
            nRC_Grid1 = (short)(nGXsfl_20_idx-1) ;
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
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_1W2e( true) ;
         }
         else
         {
            wb_table1_2_1W2e( false) ;
         }
      }

      protected void wb_table2_8_1W2( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, 1, 1, 0, "Apellido y Nombre:", "", "", "", 0, lblTextblock1_Jsonclick, "", StyleString, ClassString, "HLP_HTBUS013_prompt2.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'" + sGXsfl_20_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavFttbus7_desresp_Internalname, StringUtil.RTrim( AV9fTTBUS7_DesResp), "", 50, "chr", 1, "row", 50, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV9fTTBUS7_DesResp, "@!")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(13);\"", 0, edtavFttbus7_desresp_Jsonclick, "", 0, 1, -1, true, "left", "HLP_HTBUS013_prompt2.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttButton1_Internalname, "Buscar", "Buscar", "", StyleString, ClassString, 1, 1, "rounded", 5, bttButton1_Jsonclick, "E\\'BUSCAR\\'.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(20), 3, 0)+","+"null"+");", "", "HLP_HTBUS013_prompt2.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_8_1W2e( true) ;
         }
         else
         {
            wb_table2_8_1W2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV6pTTBUS7_CodResp = (String)getParm(obj,0) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6pTTBUS7_CodResp", AV6pTTBUS7_CodResp);
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
         PA1W2( ) ;
         WS1W2( ) ;
         WE1W2( ) ;
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
         AddThemeStyleSheetFile("", "Modern.css", "?2051812");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?19292679");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("htbus013_prompt2.js", "?19292679");
         /* End function include_jscripts */
      }

      protected void sendrow_202( )
      {
         WB1W0( ) ;
         if ( ( 10 * 1 == 0 ) || ( nGXsfl_20_idx <= subGrid1_Recordsperpage( ) * 1 ) )
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
               if ( ((int)(nGXsfl_20_idx) % (2)) == 0 )
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
            TempTags = " " + ((edtavLink_selection_Enabled!=0)&&(edtavLink_selection_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 21,'',false,'',20)\"" : " ") ;
            ClassString = "Image" ;
            StyleString = "" ;
            Grid1Row.AddColumnProperties("bitmap", 2, isAjaxCallMode( ), new Object[] {(String)edtavLink_selection_Internalname,(String)"",(String)AV5Link_Selection,(String)"Modern",(short)-1,(short)1,(String)"",(String)"",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"",(short)0,(short)0,(String)"",(String)"",(short)5,(String)edtavLink_selection_Jsonclick,"EENTER."+sGXsfl_20_idx,(String)StyleString,(String)ClassString,(String)"",(String)""+TempTags,(String)"''",(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            TempTags = " " + ((edtavTtbus7_codresp_Enabled!=0)&&(edtavTtbus7_codresp_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 22,'',false,'"+sGXsfl_20_idx+"',20)\"" : " ") ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavTtbus7_codresp_Internalname,StringUtil.RTrim( AV7TTBUS7_CodResp),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)16,(short)-1,(int)edtavTtbus7_codresp_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( AV7TTBUS7_CodResp, "@!")),TempTags+((edtavTtbus7_codresp_Enabled!=0)&&(edtavTtbus7_codresp_Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((edtavTtbus7_codresp_Enabled!=0)&&(edtavTtbus7_codresp_Visible!=0) ? " onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(22);\"" : " "),(short)0,(String)edtavTtbus7_codresp_Jsonclick,(String)"",(short)20,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            TempTags = " " + ((edtavTtbus7_desresp_Enabled!=0)&&(edtavTtbus7_desresp_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 23,'',false,'"+sGXsfl_20_idx+"',20)\"" : " ") ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavTtbus7_desresp_Internalname,StringUtil.RTrim( AV8TTBUS7_DesResp),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)50,(short)-1,(int)edtavTtbus7_desresp_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( AV8TTBUS7_DesResp, "@!")),TempTags+((edtavTtbus7_desresp_Enabled!=0)&&(edtavTtbus7_desresp_Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((edtavTtbus7_desresp_Enabled!=0)&&(edtavTtbus7_desresp_Visible!=0) ? " onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(23);\"" : " "),(short)0,(String)edtavTtbus7_desresp_Jsonclick,(String)"",(short)20,(short)1,(short)1,(bool)true,(String)"left"});
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_20_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_20_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_20_idx+1)) ;
            sGXsfl_20_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_20_idx), 4, 0)), 4, "0") ;
            edtavLink_selection_Internalname = "vLINK_SELECTION_"+sGXsfl_20_idx ;
            edtavTtbus7_codresp_Internalname = "vTTBUS7_CODRESP_"+sGXsfl_20_idx ;
            edtavTtbus7_desresp_Internalname = "vTTBUS7_DESRESP_"+sGXsfl_20_idx ;
         }
         /* End function sendrow_202 */
      }

      protected void init_default_properties( )
      {
         lblTextblock1_Internalname = "TEXTBLOCK1" ;
         edtavFttbus7_desresp_Internalname = "vFTTBUS7_DESRESP" ;
         bttButton1_Internalname = "BUTTON1" ;
         tblTable2_Internalname = "TABLE2" ;
         tblTable1_Internalname = "TABLE1" ;
         Form.Internalname = "FORM" ;
         subGrid1_Internalname = "GRID1" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         edtavTtbus7_desresp_Jsonclick = "" ;
         edtavTtbus7_desresp_Visible = -1 ;
         edtavTtbus7_codresp_Jsonclick = "" ;
         edtavTtbus7_codresp_Visible = -1 ;
         edtavLink_selection_Jsonclick = "" ;
         edtavLink_selection_Visible = -1 ;
         edtavLink_selection_Enabled = 1 ;
         edtavFttbus7_desresp_Jsonclick = "" ;
         edtavTtbus7_desresp_Enabled = 1 ;
         edtavTtbus7_codresp_Enabled = 1 ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 3 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Seleccionar Responsable" ;
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
         edtavTtbus7_codresp_Internalname = "" ;
         edtavTtbus7_desresp_Internalname = "" ;
         A36TTBUS7_DesResp = "" ;
         A35TTBUS7_CodResp = "" ;
         AV6pTTBUS7_CodResp = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         GX_FocusControl = "" ;
         Form = new GXWebForm();
         sPrefix = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         edtavLink_selection_Internalname = "" ;
         AV5Link_Selection = "" ;
         AV7TTBUS7_CodResp = "" ;
         AV8TTBUS7_DesResp = "" ;
         Grid1Container = new GXWebGrid( context);
         AV9fTTBUS7_DesResp = "" ;
         AV12SESION = new GxWebSession( context);
         AV10bTTBUS7_DesResp = "" ;
         scmdbuf = "" ;
         H001W2_A36TTBUS7_DesResp = new String[] {""} ;
         H001W2_n36TTBUS7_DesResp = new bool[] {false} ;
         H001W2_A35TTBUS7_CodResp = new String[] {""} ;
         H001W3_A33TTBUS7_Pos = new short[1] ;
         H001W3_A36TTBUS7_DesResp = new String[] {""} ;
         H001W3_n36TTBUS7_DesResp = new bool[] {false} ;
         H001W3_A35TTBUS7_CodResp = new String[] {""} ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         subGrid1_Linesclass = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         Grid1Column = new GXWebColumn();
         lblTextblock1_Jsonclick = "" ;
         TempTags = "" ;
         bttButton1_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         ROClassString = "" ;
         GXt_char3 = "" ;
         GXt_char4 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.htbus013_prompt2__default(),
            new Object[][] {
                new Object[] {
               H001W2_A36TTBUS7_DesResp, H001W2_n36TTBUS7_DesResp, H001W2_A35TTBUS7_CodResp
               }
               , new Object[] {
               H001W3_A33TTBUS7_Pos, H001W3_A36TTBUS7_DesResp, H001W3_n36TTBUS7_DesResp, H001W3_A35TTBUS7_CodResp
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
         edtavTtbus7_codresp_Enabled = 0 ;
         edtavTtbus7_desresp_Enabled = 0 ;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_Grid1 ;
      private short nGXsfl_20_idx=1 ;
      private short AV11Pos ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short GRID1_nEOF ;
      private short wbEnd ;
      private short wbStart ;
      private short nDonePA ;
      private short subGrid1_Rows ;
      private short A33TTBUS7_Pos ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short subGrid1_Collapsed ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int Grid1_PageSize20 ;
      private int edtavTtbus7_codresp_Enabled ;
      private int edtavTtbus7_desresp_Enabled ;
      private int GRID1_nFirstRecordOnPage ;
      private int subGrid1_Islastpage ;
      private int GRID1_nCurrentRecord ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private int edtavLink_selection_Enabled ;
      private int edtavLink_selection_Visible ;
      private int edtavTtbus7_codresp_Visible ;
      private int edtavTtbus7_desresp_Visible ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_20_idx="0001" ;
      private String edtavTtbus7_codresp_Internalname ;
      private String edtavTtbus7_desresp_Internalname ;
      private String A36TTBUS7_DesResp ;
      private String A35TTBUS7_CodResp ;
      private String AV6pTTBUS7_CodResp ;
      private String sDynURL ;
      private String FormProcess ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavLink_selection_Internalname ;
      private String AV7TTBUS7_CodResp ;
      private String AV8TTBUS7_DesResp ;
      private String edtavFttbus7_desresp_Internalname ;
      private String AV9fTTBUS7_DesResp ;
      private String AV10bTTBUS7_DesResp ;
      private String scmdbuf ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String subGrid1_Internalname ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String tblTable2_Internalname ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
      private String TempTags ;
      private String edtavFttbus7_desresp_Jsonclick ;
      private String bttButton1_Internalname ;
      private String bttButton1_Jsonclick ;
      private String edtavLink_selection_Jsonclick ;
      private String ROClassString ;
      private String edtavTtbus7_codresp_Jsonclick ;
      private String GXt_char3 ;
      private String edtavTtbus7_desresp_Jsonclick ;
      private String GXt_char4 ;
      private bool entryPointCalled ;
      private bool n36TTBUS7_DesResp ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private String AV5Link_Selection ;
      private GxWebSession AV12SESION ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] H001W2_A36TTBUS7_DesResp ;
      private bool[] H001W2_n36TTBUS7_DesResp ;
      private String[] H001W2_A35TTBUS7_CodResp ;
      private short[] H001W3_A33TTBUS7_Pos ;
      private String[] H001W3_A36TTBUS7_DesResp ;
      private bool[] H001W3_n36TTBUS7_DesResp ;
      private String[] H001W3_A35TTBUS7_CodResp ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private String aP0_pTTBUS7_CodResp ;
      private GXWebForm Form ;
   }

   public class htbus013_prompt2__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H001W2( String AV9fTTBUS7_DesResp ,
                                             String A36TTBUS7_DesResp ,
                                             String AV10bTTBUS7_DesResp )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int5 ;
         GXv_int5 = new short [1] ;
         Object[] GXv_Object6 ;
         GXv_Object6 = new Object [2] ;
         scmdbuf = "SELECT DISTINCT T2.[USU_DES] AS TTBUS7_DesResp, T1.[TTBUS7_CodResp] AS TTBUS7_CodResp FROM ([TTBUS007] T1 WITH (NOLOCK) INNER JOIN [SEG002] T2 WITH (NOLOCK) ON T2.[USU_COD] = T1.[TTBUS7_CodResp])" ;
         if ( StringUtil.StrCmp(StringUtil.Trim( AV9fTTBUS7_DesResp), "") != 0 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (UPPER(T2.[USU_DES]) = UPPER(@AV10bTTBUS7_DesResp))" ;
            }
            else
            {
               sWhereString = sWhereString + " (UPPER(T2.[USU_DES]) = UPPER(@AV10bTTBUS7_DesResp))" ;
            }
         }
         else
         {
            GXv_int5[0] = 1 ;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE " + sWhereString ;
         }
         scmdbuf = scmdbuf + " ORDER BY T1.[TTBUS7_CodResp]" ;
         GXv_Object6[0] = scmdbuf ;
         GXv_Object6[1] = (Object)(GXv_int5) ;
         return GXv_Object6 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_H001W2( (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] );
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
          Object[] prmH001W3 ;
          prmH001W3 = new Object[] {
          new Object[] {"@AV11Pos",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmH001W2 ;
          prmH001W2 = new Object[] {
          new Object[] {"@AV10bTTBUS7_DesResp",SqlDbType.Char,50,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H001W2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001W2,100,0,false,false )
             ,new CursorDef("H001W3", "SELECT DISTINCT T1.[TTBUS7_Pos], T2.[USU_DES] AS TTBUS7_DesResp, T1.[TTBUS7_CodResp] AS TTBUS7_CodResp FROM ([TTBUS007] T1 WITH (NOLOCK) INNER JOIN [SEG002] T2 WITH (NOLOCK) ON T2.[USU_COD] = T1.[TTBUS7_CodResp]) WHERE T1.[TTBUS7_Pos] = @AV11Pos ORDER BY T1.[TTBUS7_CodResp] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001W3,100,0,false,false )
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
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getString(2, 16) ;
                break;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getString(3, 16) ;
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
                stmt.SetParameter(1, (short)parms[0]);
                break;
       }
    }

 }

}
