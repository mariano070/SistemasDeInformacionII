/*
               File: Gx00F0
        Description: Selecci�n de Usuarios
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 3/17/2014 13:22:34.67
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
   public class gx00f0 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx00f0( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public gx00f0( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( out String aP0_pUSU_COD )
      {
         this.AV6pUSU_COD = "" ;
         executePrivate();
         aP0_pUSU_COD=this.AV6pUSU_COD;
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
               nGXsfl_14_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               sGXsfl_14_idx = GetNextPar( ) ;
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxnrGrid1_newrow( nRC_Grid1, nGXsfl_14_idx, sGXsfl_14_idx) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid1") == 0 )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0 ;
               Grid1_PageSize14 = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               AV8cUSU_DES = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cUSU_DES", AV8cUSU_DES);
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxgrGrid1_refresh( Grid1_PageSize14, AV8cUSU_DES) ;
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
               AV6pUSU_COD = gxfirstwebparm ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6pUSU_COD", AV6pUSU_COD);
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
         PA0U2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START0U2( ) ;
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("gx00f0.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV6pUSU_COD))+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH_vCUSU_DES", StringUtil.RTrim( AV8cUSU_DES));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPUSU_COD", StringUtil.RTrim( AV6pUSU_COD));
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
            WE0U2( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT0U2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override String GetPgmname( )
      {
         return "Gx00F0" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selecci�n de Usuarios" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("gx00f0.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV6pUSU_COD)) ;
      }

      protected void WB0U0( )
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
            wb_table1_2_0U2( true) ;
         }
         else
         {
            wb_table1_2_0U2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_0U2e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START0U2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "Selecci�n de Usuarios", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP0U0( ) ;
      }

      protected void WS0U2( )
      {
         START0U2( ) ;
         EVT0U2( ) ;
      }

      protected void EVT0U2( )
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
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCUSU_DES"), AV8cUSU_DES) != 0 )
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
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 4), "LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) )
                           {
                              nGXsfl_14_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                              sGXsfl_14_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_14_idx), 4, 0)), 4, "0") ;
                              edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_14_idx ;
                              edtUSU_COD_Internalname = "USU_COD_"+sGXsfl_14_idx ;
                              edtUSU_DES_Internalname = "USU_DES_"+sGXsfl_14_idx ;
                              AV7LinkSelection = cgiGet( "GXimg"+edtavLinkselection_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", context.convertURL( AV7LinkSelection));
                              A6USU_COD = StringUtil.Upper( cgiGet( edtUSU_COD_Internalname)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
                              A7USU_DES = StringUtil.Upper( cgiGet( edtUSU_DES_Internalname)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7USU_DES", A7USU_DES);
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false ;
                                       /* Set Refresh If Cusu_des Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCUSU_DES"), AV8cUSU_DES) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: E110U2 */
                                          E110U2 ();
                                       }
                                       dynload_actions( ) ;
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E120U2 */
                                    E120U2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E130U2 */
                                    E130U2 ();
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

      protected void WE0U2( )
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

      protected void PA0U2( )
      {
         if ( nDonePA == 0 )
         {
            GX_FocusControl = edtavCusu_des_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGrid1_newrow( short nRC_Grid1 ,
                                       short nGXsfl_14_idx ,
                                       String sGXsfl_14_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_14_idx ;
         edtUSU_COD_Internalname = "USU_COD_"+sGXsfl_14_idx ;
         edtUSU_DES_Internalname = "USU_DES_"+sGXsfl_14_idx ;
         while ( nGXsfl_14_idx <= nRC_Grid1 )
         {
            sendrow_142( ) ;
            nGXsfl_14_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_14_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_14_idx+1)) ;
            sGXsfl_14_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_14_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_14_idx ;
            edtUSU_COD_Internalname = "USU_COD_"+sGXsfl_14_idx ;
            edtUSU_DES_Internalname = "USU_DES_"+sGXsfl_14_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int Grid1_PageSize14 ,
                                        String AV8cUSU_DES )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         subGrid1_Rows = (short)(Grid1_PageSize14) ;
         RF0U2( ) ;
         enableOutput();
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxgrGrid1_refresh */
      }

      protected void Refresh( )
      {
         RF0U2( ) ;
         /* End function Refresh */
      }

      protected void RF0U2( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 14 ;
         nGXsfl_14_idx = 1 ;
         sGXsfl_14_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_14_idx), 4, 0)), 4, "0") ;
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_14_idx ;
         edtUSU_COD_Internalname = "USU_COD_"+sGXsfl_14_idx ;
         edtUSU_DES_Internalname = "USU_DES_"+sGXsfl_14_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_14_idx ;
            edtUSU_COD_Internalname = "USU_COD_"+sGXsfl_14_idx ;
            edtUSU_DES_Internalname = "USU_DES_"+sGXsfl_14_idx ;
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV8cUSU_DES ,
                                                 A7USU_DES },
                                                 new int[] {
                                                 TypeConstants.STRING, TypeConstants.STRING
                                                 }
            });
            lV8cUSU_DES = StringUtil.PadR( StringUtil.RTrim( AV8cUSU_DES), 50, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cUSU_DES", AV8cUSU_DES);
            /* Using cursor H000U2 */
            pr_default.execute(0, new Object[] {lV8cUSU_DES});
            nGXsfl_14_idx = 1 ;
            GRID1_nEOF = 0 ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) ) )
            {
               A7USU_DES = H000U2_A7USU_DES[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7USU_DES", A7USU_DES);
               A6USU_COD = H000U2_A6USU_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
               /* Execute user event: E120U2 */
               E120U2 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0)) ;
            pr_default.close(0);
            wbEnd = 14 ;
            WB0U0( ) ;
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
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              AV8cUSU_DES ,
                                              A7USU_DES },
                                              new int[] {
                                              TypeConstants.STRING, TypeConstants.STRING
                                              }
         });
         lV8cUSU_DES = StringUtil.PadR( StringUtil.RTrim( AV8cUSU_DES), 50, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cUSU_DES", AV8cUSU_DES);
         /* Using cursor H000U3 */
         pr_default.execute(1, new Object[] {lV8cUSU_DES});
         GRID1_nRecordCount = H000U3_AGRID1_nRecordCount[0] ;
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

      protected void STRUP0U0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E130U2 */
         E130U2 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            AV8cUSU_DES = StringUtil.Upper( cgiGet( edtavCusu_des_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cUSU_DES", AV8cUSU_DES);
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ",", ".")) ;
            AV6pUSU_COD = cgiGet( "vPUSU_COD") ;
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

      public void GXEnter( )
      {
         /* Execute user event: E110U2 */
         E110U2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E110U2( )
      {
         /* Enter Routine */
         AV6pUSU_COD = A6USU_COD ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6pUSU_COD", AV6pUSU_COD);
         context.setWebReturnParms(new Object[] {(String)AV6pUSU_COD});
         context.nUserReturn = 1 ;
         returnInSub = true;
         if (true) return;
      }

      private void E120U2( )
      {
         /* Load Routine */
         AV7LinkSelection = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", "Modern") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", context.convertURL( AV7LinkSelection));
         if ( ( subGrid1_Islastpage == 1 ) || ( 10 == 0 ) || ( ( GRID1_nCurrentRecord >= GRID1_nFirstRecordOnPage ) && ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) )
         {
            sendrow_142( ) ;
         }
         GRID1_nCurrentRecord = (int)(GRID1_nCurrentRecord+1) ;
      }

      protected void GXStart( )
      {
         /* Execute user event: E130U2 */
         E130U2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E130U2( )
      {
         /* Start Routine */
         lblSeteo_Caption = "<style><!--A:link {text-decoration: underline; color:#708090}A:visited {color:#708090}A:hover {text-decoration:bold; color:#008B8B}--></style>" ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblSeteo_Internalname, "Caption", lblSeteo_Caption);
         Form.Caption = StringUtil.Format( "Lista de Selecci�n %1", "Usuarios", "", "", "", "", "", "", "", "") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption);
      }

      protected void wb_table1_2_0U2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"2\"  style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            wb_table2_5_0U2( true) ;
         }
         else
         {
            wb_table2_5_0U2( false) ;
         }
         return  ;
      }

      protected void wb_table2_5_0U2e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblSeteo_Internalname, 1, 1, 1, lblSeteo_Caption, "", "", "", 0, lblSeteo_Jsonclick, "", StyleString, ClassString, "HLP_Gx00F0.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_cancel_Internalname, "Cancelar", "Cancelar", "", StyleString, ClassString, 1, 1, "rounded", 1, bttBtn_cancel_Jsonclick, "ECANCEL.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(14), 3, 0)+","+"null"+");", "", "HLP_Gx00F0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "right")+"\">") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_0U2e( true) ;
         }
         else
         {
            wb_table1_2_0U2e( false) ;
         }
      }

      protected void wb_table2_5_0U2( bool wbgen )
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
            StyleString = "font-family:'Verdana'; font-size:8.0pt; font-weight:bold; font-style:normal" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, 1, 1, 0, "Apellido y Nombre", "", "", "", 0, lblTextblock1_Jsonclick, "", StyleString, ClassString, "HLP_Gx00F0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'',false,'" + sGXsfl_14_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "font-family:'Verdana'; font-size:8.0pt; font-weight:normal; font-style:normal" ;
            GxWebStd.gx_single_line_edit( context, edtavCusu_des_Internalname, StringUtil.RTrim( AV8cUSU_DES), "", 50, "chr", 1, "row", 50, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV8cUSU_DES, "@!")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(10);\"", 0, edtavCusu_des_Jsonclick, "", 0, 1, -1, true, "left", "HLP_Gx00F0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "right")+"\">") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"3\" >") ;
            /*  Grid Control  */
            Grid1Container.SetWrapped(nGXWrapped);
            if ( Grid1Container.GetWrapped() == 1 )
            {
               sStyleString = "" ;
               GxWebStd.gx_table_start( context, subGrid1_Internalname, subGrid1_Internalname, "", "WorkWith", 0, "", "", 1, 2, sStyleString, "", 0);
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
               context.SendWebValue( "Cod Usuario") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Apellido y Nombre") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlTextNl( "</tr>") ;
            }
            else
            {
               Grid1Container.Clear();
               Grid1Container.SetWrapped(nGXWrapped);
               Grid1Container.AddObjectProperty("GridName", "Grid1");
               Grid1Container.AddObjectProperty("Class", "WorkWith");
               Grid1Container.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Backcolorstyle), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("CmpContext", "");
               Grid1Container.AddObjectProperty("InMasterPage", "false");
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", context.convertURL( AV7LinkSelection));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtavLinkselection_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A6USU_COD));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A7USU_DES));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Allowselection", "false");
               Grid1Container.AddObjectProperty("Allowcollapsing", "false");
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 9, 0, ".", "")));
            }
         }
         if ( wbEnd == 14 )
         {
            wbEnd = 0 ;
            nRC_Grid1 = (short)(nGXsfl_14_idx-1) ;
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
            wb_table2_5_0U2e( true) ;
         }
         else
         {
            wb_table2_5_0U2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV6pUSU_COD = (String)getParm(obj,0) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6pUSU_COD", AV6pUSU_COD);
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
         PA0U2( ) ;
         WS0U2( ) ;
         WE0U2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?13223490");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("gx00f0.js", "?13223490");
         /* End function include_jscripts */
      }

      protected void sendrow_142( )
      {
         WB0U0( ) ;
         if ( ( 10 * 1 == 0 ) || ( nGXsfl_14_idx <= subGrid1_Recordsperpage( ) * 1 ) )
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
               if ( ((int)(nGXsfl_14_idx) % (2)) == 0 )
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
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.RTrim( A6USU_COD))+"'"+"]);" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Link", edtavLinkselection_Link);
            ClassString = "Image" ;
            StyleString = "" ;
            Grid1Row.AddColumnProperties("bitmap", 2, isAjaxCallMode( ), new Object[] {(String)edtavLinkselection_Internalname,(String)"",(String)AV7LinkSelection,(String)"Modern",(short)-1,(short)1,(String)"",(String)"Seleccionar",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"",(short)0,(short)0,(String)edtavLinkselection_Link,(String)"",(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"''",(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtUSU_COD_Internalname,StringUtil.RTrim( A6USU_COD),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)16,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A6USU_COD, "@!")),(String)"",(short)0,(String)edtUSU_COD_Jsonclick,(String)"",(short)14,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtUSU_DES_Internalname,StringUtil.RTrim( A7USU_DES),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)50,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A7USU_DES, "@!")),(String)"",(short)0,(String)edtUSU_DES_Jsonclick,(String)"",(short)14,(short)1,(short)1,(bool)true,(String)"left"});
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_14_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_14_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_14_idx+1)) ;
            sGXsfl_14_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_14_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_14_idx ;
            edtUSU_COD_Internalname = "USU_COD_"+sGXsfl_14_idx ;
            edtUSU_DES_Internalname = "USU_DES_"+sGXsfl_14_idx ;
         }
         /* End function sendrow_142 */
      }

      protected void init_default_properties( )
      {
         lblTextblock1_Internalname = "TEXTBLOCK1" ;
         edtavCusu_des_Internalname = "vCUSU_DES" ;
         tblTable2_Internalname = "TABLE2" ;
         lblSeteo_Internalname = "SETEO" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         tblTable1_Internalname = "TABLE1" ;
         Form.Internalname = "FORM" ;
         subGrid1_Internalname = "GRID1" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         edtUSU_DES_Jsonclick = "" ;
         edtUSU_COD_Jsonclick = "" ;
         edtavLinkselection_Link = "" ;
         subGrid1_Class = "WorkWith" ;
         subGrid1_Backcolorstyle = 2 ;
         edtavCusu_des_Jsonclick = "" ;
         lblSeteo_Caption = "seteo" ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Selecci�n de Usuarios" ;
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
         AV8cUSU_DES = "" ;
         AV6pUSU_COD = "" ;
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
         edtUSU_COD_Internalname = "" ;
         edtUSU_DES_Internalname = "" ;
         AV7LinkSelection = "" ;
         A6USU_COD = "" ;
         A7USU_DES = "" ;
         Grid1Container = new GXWebGrid( context);
         scmdbuf = "" ;
         lV8cUSU_DES = "" ;
         H000U2_A7USU_DES = new String[] {""} ;
         H000U2_A6USU_COD = new String[] {""} ;
         H000U3_AGRID1_nRecordCount = new int[1] ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         lblSeteo_Jsonclick = "" ;
         TempTags = "" ;
         bttBtn_cancel_Jsonclick = "" ;
         lblTextblock1_Jsonclick = "" ;
         subGrid1_Linesclass = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         Grid1Column = new GXWebColumn();
         GXt_char3 = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         ROClassString = "" ;
         GXt_char4 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx00f0__default(),
            new Object[][] {
                new Object[] {
               H000U2_A7USU_DES, H000U2_A6USU_COD
               }
               , new Object[] {
               H000U3_AGRID1_nRecordCount
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_Grid1 ;
      private short nGXsfl_14_idx=1 ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short GRID1_nEOF ;
      private short wbEnd ;
      private short wbStart ;
      private short nDonePA ;
      private short subGrid1_Rows ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short subGrid1_Collapsed ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int Grid1_PageSize14 ;
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
      private String sGXsfl_14_idx="0001" ;
      private String AV8cUSU_DES ;
      private String AV6pUSU_COD ;
      private String sDynURL ;
      private String FormProcess ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavLinkselection_Internalname ;
      private String edtUSU_COD_Internalname ;
      private String edtUSU_DES_Internalname ;
      private String A6USU_COD ;
      private String A7USU_DES ;
      private String edtavCusu_des_Internalname ;
      private String scmdbuf ;
      private String lV8cUSU_DES ;
      private String lblSeteo_Caption ;
      private String lblSeteo_Internalname ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String lblSeteo_Jsonclick ;
      private String TempTags ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
      private String edtavCusu_des_Jsonclick ;
      private String subGrid1_Internalname ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String edtavLinkselection_Link ;
      private String GXt_char3 ;
      private String ROClassString ;
      private String edtUSU_COD_Jsonclick ;
      private String edtUSU_DES_Jsonclick ;
      private String GXt_char4 ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private String AV7LinkSelection ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] H000U2_A7USU_DES ;
      private String[] H000U2_A6USU_COD ;
      private int[] H000U3_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private String aP0_pUSU_COD ;
      private GXWebForm Form ;
   }

   public class gx00f0__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H000U2( String AV8cUSU_DES ,
                                             String A7USU_DES )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int5 ;
         GXv_int5 = new short [1] ;
         Object[] GXv_Object6 ;
         GXv_Object6 = new Object [2] ;
         scmdbuf = "SELECT [USU_DES], [USU_COD] FROM [SEG002] WITH (NOLOCK)" ;
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV8cUSU_DES)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (UPPER([USU_DES]) like '%' + UPPER(@AV8cUSU_DES))" ;
            }
            else
            {
               sWhereString = sWhereString + " (UPPER([USU_DES]) like '%' + UPPER(@AV8cUSU_DES))" ;
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
         scmdbuf = scmdbuf + " ORDER BY [USU_COD]" ;
         scmdbuf = scmdbuf + " OPTION (FAST 11)" ;
         GXv_Object6[0] = scmdbuf ;
         GXv_Object6[1] = (Object)(GXv_int5) ;
         return GXv_Object6 ;
      }

      protected Object[] conditional_H000U3( String AV8cUSU_DES ,
                                             String A7USU_DES )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int7 ;
         GXv_int7 = new short [1] ;
         Object[] GXv_Object8 ;
         GXv_Object8 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [SEG002] WITH (NOLOCK)" ;
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV8cUSU_DES)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (UPPER([USU_DES]) like '%' + UPPER(@AV8cUSU_DES))" ;
            }
            else
            {
               sWhereString = sWhereString + " (UPPER([USU_DES]) like '%' + UPPER(@AV8cUSU_DES))" ;
            }
         }
         else
         {
            GXv_int7[0] = 1 ;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE " + sWhereString ;
         }
         scmdbuf = scmdbuf + "" ;
         GXv_Object8[0] = scmdbuf ;
         GXv_Object8[1] = (Object)(GXv_int7) ;
         return GXv_Object8 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_H000U2( (String)dynConstraints[0] , (String)dynConstraints[1] );
               case 1 :
                     return conditional_H000U3( (String)dynConstraints[0] , (String)dynConstraints[1] );
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
          Object[] prmH000U2 ;
          prmH000U2 = new Object[] {
          new Object[] {"@AV8cUSU_DES",SqlDbType.Char,50,0}
          } ;
          Object[] prmH000U3 ;
          prmH000U3 = new Object[] {
          new Object[] {"@AV8cUSU_DES",SqlDbType.Char,50,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H000U2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000U2,11,0,false,false )
             ,new CursorDef("H000U3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000U3,1,0,false,false )
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
                ((String[]) buf[1])[0] = rslt.getString(2, 16) ;
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
