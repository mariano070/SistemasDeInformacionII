/*
               File: HSEG001
        Description: Agrega Sistemas
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/29/2014 16:46:35.64
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
   public class hseg001 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public hseg001( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public hseg001( IGxContext context )
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

      public void execute( ref String aP0_USUCOD )
      {
         this.AV6USUCOD = aP0_USUCOD;
         executePrivate();
         aP0_USUCOD=this.AV6USUCOD;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         chkavMarca = new GXCheckbox();
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
               nGXsfl_12_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               sGXsfl_12_idx = GetNextPar( ) ;
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxnrGrid1_newrow( nRC_Grid1, nGXsfl_12_idx, sGXsfl_12_idx) ;
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
               AV6USUCOD = gxfirstwebparm ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6USUCOD", AV6USUCOD);
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
         PA532( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START532( ) ;
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
         FormProcess = " onkeyup=\"gx.evt.onkeyup(event)\" onkeypress=\"gx.evt.onkeypress(event,false,false)\" onkeydown=\"gx.evt.onkeypress(null,false,false)\"" ;
         context.WriteHtmlText( "<body") ;
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            context.WriteHtmlText( " background=\""+context.convertURL( Form.Background)+"\"") ;
         }
         context.WriteHtmlText( " "+"class=\"Form\""+" "+" style=\"-moz-opacity:0;opacity:0;margin: 0px;"+"background-color:"+context.BuildHTMLColor( Form.Backcolor)+"\""+FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("hseg001.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV6USUCOD))+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH_vSISDES", StringUtil.RTrim( AV5SISDES));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vUSUCOD", StringUtil.RTrim( AV6USUCOD));
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
            WE532( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT532( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return false ;
      }

      public override String GetPgmname( )
      {
         return "HSEG001" ;
      }

      public override String GetPgmdesc( )
      {
         return "Agrega Sistemas" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("hseg001.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV6USUCOD)) ;
      }

      protected void WB530( )
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
            context.WriteHtmlText( "<pre>") ;
            wb_table1_3_532( true) ;
         }
         else
         {
            wb_table1_3_532( false) ;
         }
         return  ;
      }

      protected void wb_table1_3_532e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "<center/>") ;
            context.WriteHtmlText( "</pre>") ;
         }
         wbLoad = true ;
      }

      protected void START532( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "Agrega Sistemas", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP530( ) ;
      }

      protected void WS532( )
      {
         START532( ) ;
         EVT532( ) ;
      }

      protected void EVT532( )
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
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vSISDES"), AV5SISDES) != 0 )
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
                           else if ( StringUtil.StrCmp(sEvt, "'FIRST'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E11532 */
                              E11532 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'PREVIOUS'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E12532 */
                              E12532 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'NEXT'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E13532 */
                              E13532 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'LAST'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E14532 */
                              E14532 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'CONFIRMA'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E15532 */
                              E15532 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                           }
                        }
                        else
                        {
                           sEvtType = StringUtil.Right( sEvt, 4) ;
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4)) ;
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 4), "LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 10), "'CONFIRMA'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 7), "'FIRST'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 10), "'PREVIOUS'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "'NEXT'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "'LAST'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) )
                           {
                              nGXsfl_12_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                              sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0") ;
                              chkavMarca_Internalname = "vMARCA_"+sGXsfl_12_idx ;
                              edtSIS_DES_Internalname = "SIS_DES_"+sGXsfl_12_idx ;
                              edtSIS_COD_Internalname = "SIS_COD_"+sGXsfl_12_idx ;
                              AV7MARCA = ((StringUtil.StrCmp(cgiGet( chkavMarca_Internalname), "*")==0) ? "*" : "' '") ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7MARCA", AV7MARCA);
                              A259SIS_DES = StringUtil.Upper( cgiGet( edtSIS_DES_Internalname)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A259SIS_DES", A259SIS_DES);
                              A116SIS_COD = (short)(context.localUtil.CToN( cgiGet( edtSIS_COD_Internalname), ",", ".")) ;
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E16532 */
                                    E16532 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'CONFIRMA'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E15532 */
                                    E15532 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'FIRST'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E11532 */
                                    E11532 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'PREVIOUS'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E12532 */
                                    E12532 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'NEXT'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E13532 */
                                    E13532 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'LAST'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E14532 */
                                    E14532 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false ;
                                       /* Set Refresh If Sisdes Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vSISDES"), AV5SISDES) != 0 )
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

      protected void WE532( )
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

      protected void PA532( )
      {
         if ( nDonePA == 0 )
         {
            GXCCtl = "vMARCA_" + sGXsfl_12_idx ;
            chkavMarca.Name = GXCCtl ;
            chkavMarca.WebTags = "" ;
            chkavMarca.Caption = "" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavMarca_Internalname, "Caption", chkavMarca.Caption);
            chkavMarca.CheckedValue = "' '" ;
            GX_FocusControl = edtavSisdes_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGrid1_newrow( short nRC_Grid1 ,
                                       short nGXsfl_12_idx ,
                                       String sGXsfl_12_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         chkavMarca_Internalname = "vMARCA_"+sGXsfl_12_idx ;
         edtSIS_DES_Internalname = "SIS_DES_"+sGXsfl_12_idx ;
         edtSIS_COD_Internalname = "SIS_COD_"+sGXsfl_12_idx ;
         while ( nGXsfl_12_idx <= nRC_Grid1 )
         {
            sendrow_122( ) ;
            nGXsfl_12_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_12_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_12_idx+1)) ;
            sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0") ;
            chkavMarca_Internalname = "vMARCA_"+sGXsfl_12_idx ;
            edtSIS_DES_Internalname = "SIS_DES_"+sGXsfl_12_idx ;
            edtSIS_COD_Internalname = "SIS_COD_"+sGXsfl_12_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void Refresh( )
      {
         RF532( ) ;
         /* End function Refresh */
      }

      protected void RF532( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 12 ;
         nGXsfl_12_idx = 1 ;
         sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0") ;
         chkavMarca_Internalname = "vMARCA_"+sGXsfl_12_idx ;
         edtSIS_DES_Internalname = "SIS_DES_"+sGXsfl_12_idx ;
         edtSIS_COD_Internalname = "SIS_COD_"+sGXsfl_12_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            chkavMarca_Internalname = "vMARCA_"+sGXsfl_12_idx ;
            edtSIS_DES_Internalname = "SIS_DES_"+sGXsfl_12_idx ;
            edtSIS_COD_Internalname = "SIS_COD_"+sGXsfl_12_idx ;
            /* Using cursor H00532 */
            pr_default.execute(0, new Object[] {AV5SISDES});
            nGXsfl_12_idx = 1 ;
            GRID1_nEOF = 0 ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 9 == 0 ) || ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) ) )
            {
               A259SIS_DES = H00532_A259SIS_DES[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A259SIS_DES", A259SIS_DES);
               /* Execute user event: E16532 */
               E16532 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0)) ;
            pr_default.close(0);
            wbEnd = 12 ;
            WB530( ) ;
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
         /* Using cursor H00533 */
         pr_default.execute(1, new Object[] {AV5SISDES});
         GRID1_nRecordCount = H00533_AGRID1_nRecordCount[0] ;
         pr_default.close(1);
         return GRID1_nRecordCount ;
      }

      protected int subGrid1_Recordsperpage( )
      {
         if ( 9 > 0 )
         {
            if ( 1 > 0 )
            {
               return (int)(9*1) ;
            }
            else
            {
               return (int)(9) ;
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

      protected void STRUP530( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            AV5SISDES = StringUtil.Upper( cgiGet( edtavSisdes_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5SISDES", AV5SISDES);
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ",", ".")) ;
            AV6USUCOD = cgiGet( "vUSUCOD") ;
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

      private void E16532( )
      {
         /* Load Routine */
         AV7MARCA = " " ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7MARCA", AV7MARCA);
         if ( ( subGrid1_Islastpage == 1 ) || ( 9 == 0 ) || ( ( GRID1_nCurrentRecord >= GRID1_nFirstRecordOnPage ) && ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) )
         {
            sendrow_122( ) ;
         }
         GRID1_nCurrentRecord = (int)(GRID1_nCurrentRecord+1) ;
      }

      protected void E15532( )
      {
         /* 'Confirma' Routine */
         /* Start For Each Line */
         nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ",", ".")) ;
         nGXsfl_12_fel_idx = 0 ;
         while ( nGXsfl_12_fel_idx < nRC_Grid1 )
         {
            nGXsfl_12_fel_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_12_fel_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_12_fel_idx+1)) ;
            sGXsfl_12_fel_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_fel_idx), 4, 0)), 4, "0") ;
            chkavMarca_Internalname = "vMARCA_"+sGXsfl_12_fel_idx ;
            edtSIS_DES_Internalname = "SIS_DES_"+sGXsfl_12_fel_idx ;
            edtSIS_COD_Internalname = "SIS_COD_"+sGXsfl_12_fel_idx ;
            AV7MARCA = ((StringUtil.StrCmp(cgiGet( chkavMarca_Internalname), "*")==0) ? "*" : "' '") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7MARCA", AV7MARCA);
            A259SIS_DES = StringUtil.Upper( cgiGet( edtSIS_DES_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A259SIS_DES", A259SIS_DES);
            A116SIS_COD = (short)(context.localUtil.CToN( cgiGet( edtSIS_COD_Internalname), ",", ".")) ;
            if ( StringUtil.StrCmp(AV7MARCA, "*") == 0 )
            {
               new pseg000(context ).execute( ref  AV6USUCOD, ref  A116SIS_COD) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6USUCOD", AV6USUCOD);
            }
            /* End For Each Line */
         }
         if ( nGXsfl_12_fel_idx == 0 )
         {
            nGXsfl_12_idx = 1 ;
            sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0") ;
            chkavMarca_Internalname = "vMARCA_"+sGXsfl_12_idx ;
            edtSIS_DES_Internalname = "SIS_DES_"+sGXsfl_12_idx ;
            edtSIS_COD_Internalname = "SIS_COD_"+sGXsfl_12_idx ;
         }
         nGXsfl_12_fel_idx = 1 ;
         context.setWebReturnParms(new Object[] {(String)AV6USUCOD});
         context.nUserReturn = 1 ;
         returnInSub = true;
         if (true) return;
      }

      protected void E11532( )
      {
         /* 'First' Routine */
         subgrid1_firstpage( ) ;
      }

      protected void E12532( )
      {
         /* 'Previous' Routine */
         subgrid1_previouspage( ) ;
      }

      protected void E13532( )
      {
         /* 'Next' Routine */
         subgrid1_nextpage( ) ;
      }

      protected void E14532( )
      {
         /* 'Last' Routine */
         subgrid1_lastpage( ) ;
      }

      protected void wb_table1_3_532( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"2\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, 1, 1, 0, "Sistema:", "", "", "", 0, lblTextblock1_Jsonclick, "", StyleString, ClassString, "HLP_HSEG001.htm");
            context.WriteHtmlText( "&nbsp; ") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 7,'',false,'" + sGXsfl_12_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "font-family:'Courier New'; font-size:9.0pt; font-weight:normal; font-style:normal; color:#000000; background:#FFFFFF" ;
            GxWebStd.gx_single_line_edit( context, edtavSisdes_Internalname, StringUtil.RTrim( AV5SISDES), "", 15, "chr", 1, "row", 15, 1, edtavSisdes_Enabled, 0, 0, 1, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV5SISDES, "@!")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(7);\"", 0, edtavSisdes_Jsonclick, "", 0, 1, -1, true, "left", "HLP_HSEG001.htm");
            context.WriteHtmlText( "&nbsp;&nbsp;&nbsp;&nbsp; ") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 8,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "color:#000000" ;
            GxWebStd.gx_button_ctrl( context, 2, bttButton2_Internalname, "Buscar", "Buscar", "", StyleString, ClassString, 1, 1, "rounded", 7, bttButton2_Jsonclick, "'"+""+"'"+",false,"+"'"+"e17532_client"+"'", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(12), 3, 0)+","+"null"+");", "", "HLP_HSEG001.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+";height:243px\">") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            /*  Grid Control  */
            Grid1Container.SetWrapped(nGXWrapped);
            if ( Grid1Container.GetWrapped() == 1 )
            {
               sStyleString = "" ;
               sStyleString = sStyleString + " height: " + StringUtil.LTrim( StringUtil.Str( (decimal)(192), 10, 0)) + "" + ";" ;
               sStyleString = sStyleString + " width: " + StringUtil.LTrim( StringUtil.Str( (decimal)(288), 10, 0)) + "px" + ";" ;
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
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+"font-family:'Arial'; font-size:9.0pt; font-weight:bold; font-style:normal; color:#000000"+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+"font-family:'Arial'; font-size:9.0pt; font-weight:bold; font-style:normal; color:#000000"+"\" "+">") ;
               context.SendWebValue( "Sistema") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+"font-family:'Arial'; font-size:9.0pt; font-weight:bold; font-style:normal"+"\" "+">") ;
               context.SendWebValue( "CODIGO") ;
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
               Grid1Container.AddObjectProperty("Titlefont", StringUtil.RTrim( subGrid1_Titlefont));
               Grid1Container.AddObjectProperty("Linesfont", StringUtil.RTrim( subGrid1_Linesfont));
               Grid1Container.AddObjectProperty("Width", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Width), 9, 0, ".", "")));
               Grid1Container.AddObjectProperty("Height", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Height), 9, 0, ".", "")));
               Grid1Container.AddObjectProperty("CmpContext", "");
               Grid1Container.AddObjectProperty("InMasterPage", "false");
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( AV7MARCA));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A259SIS_DES));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A116SIS_COD), 3, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Allowselection", "false");
               Grid1Container.AddObjectProperty("Allowcollapsing", "false");
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 9, 0, ".", "")));
            }
         }
         if ( wbEnd == 12 )
         {
            wbEnd = 0 ;
            nRC_Grid1 = (short)(nGXsfl_12_idx-1) ;
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
            }
            else
            {
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
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'',0)\"" ;
            ClassString = "ActionButtons" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_first_Internalname, "|<", "|<", "", StyleString, ClassString, 1, 1, "rounded", 5, bttBtn_first_Jsonclick, "E\\'FIRST\\'.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(12), 3, 0)+","+"null"+");", "", "HLP_HSEG001.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"" ;
            ClassString = "ActionButtons" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_previous_Internalname, "<", "<", "", StyleString, ClassString, 1, 1, "rounded", 5, bttBtn_previous_Jsonclick, "E\\'PREVIOUS\\'.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(12), 3, 0)+","+"null"+");", "", "HLP_HSEG001.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"" ;
            ClassString = "ActionButtons" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_next_Internalname, ">", ">", "", StyleString, ClassString, 1, 1, "rounded", 5, bttBtn_next_Jsonclick, "E\\'NEXT\\'.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(12), 3, 0)+","+"null"+");", "", "HLP_HSEG001.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"" ;
            ClassString = "ActionButtons" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_last_Internalname, ">|", ">|", "", StyleString, ClassString, 1, 1, "rounded", 5, bttBtn_last_Jsonclick, "E\\'LAST\\'.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(12), 3, 0)+","+"null"+");", "", "HLP_HSEG001.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"2\"  style=\"text-align:"+context.GetCssProperty( "Align", "center")+";height:41px\">") ;
            wb_table2_25_532( true) ;
         }
         else
         {
            wb_table2_25_532( false) ;
         }
         return  ;
      }

      protected void wb_table2_25_532e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_3_532e( true) ;
         }
         else
         {
            wb_table1_3_532e( false) ;
         }
      }

      protected void wb_table2_25_532( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable2_Internalname, tblTable2_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "color:#000000" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttButton1_Internalname, "Confirma", "Confirma", "", StyleString, ClassString, 1, 1, "rounded", 5, bttButton1_Jsonclick, "E\\'CONFIRMA\\'.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(12), 3, 0)+","+"null"+");", "", "HLP_HSEG001.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 31,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "color:#000000" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_cancel_Internalname, "Salir", "Salir", "", StyleString, ClassString, 1, 1, "rounded", 1, bttBtn_cancel_Jsonclick, "ECANCEL.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(12), 3, 0)+","+"null"+");", "", "HLP_HSEG001.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_25_532e( true) ;
         }
         else
         {
            wb_table2_25_532e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV6USUCOD = (String)getParm(obj,0) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6USUCOD", AV6USUCOD);
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
         PA532( ) ;
         WS532( ) ;
         WE532( ) ;
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
         AddThemeStyleSheetFile("", "Modern.css", "?15564175");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?16463599");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("hseg001.js", "?16463599");
         /* End function include_jscripts */
      }

      protected void sendrow_122( )
      {
         WB530( ) ;
         if ( ( 9 * 1 == 0 ) || ( nGXsfl_12_idx <= subGrid1_Recordsperpage( ) * 1 ) )
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
               if ( ((int)(nGXsfl_12_idx) % (2)) == 0 )
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
            TempTags = " " + ((chkavMarca.Enabled!=0)&&(chkavMarca.Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 13,'',false,'"+sGXsfl_12_idx+"',12)\"" : " ") ;
            ClassString = "Attribute" ;
            StyleString = "font-family:'Courier New'; font-size:9.0pt; font-weight:normal; font-style:normal; color:#000000" ;
            Grid1Row.AddColumnProperties("checkbox", 1, isAjaxCallMode( ), new Object[] {(String)chkavMarca_Internalname,(String)AV7MARCA,(String)"",(short)-1,(short)1,(String)"*",(String)"",(String)StyleString,(String)ClassString,TempTags+((chkavMarca.Enabled!=0)&&(chkavMarca.Visible!=0) ? " onclick=\"gx.fn.checkboxClick(13, this, '*', '' '');gx.evt.onchange(this);\" " : " ")+((chkavMarca.Enabled!=0)&&(chkavMarca.Visible!=0) ? " onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(13);\"" : " ")});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "font-family:'Courier New'; font-size:9.0pt; font-weight:normal; font-style:normal; color:#000000" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSIS_DES_Internalname,StringUtil.RTrim( A259SIS_DES),(String)"",(short)216,(String)"px",(short)17,(String)"",(short)15,(short)-1,(short)0,(short)0,(short)0,(short)1,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A259SIS_DES, "@!")),(String)"",(short)0,(String)edtSIS_DES_Jsonclick,(String)"",(short)12,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "font-family:'Courier New'; font-size:9.0pt; font-weight:normal; font-style:normal" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSIS_COD_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A116SIS_COD), 3, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)3,(short)0,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A116SIS_COD), "ZZ9"),(String)"",(short)0,(String)edtSIS_COD_Jsonclick,(String)"",(short)12,(short)1,(short)1,(bool)true,(String)"right"});
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_12_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_12_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_12_idx+1)) ;
            sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0") ;
            chkavMarca_Internalname = "vMARCA_"+sGXsfl_12_idx ;
            edtSIS_DES_Internalname = "SIS_DES_"+sGXsfl_12_idx ;
            edtSIS_COD_Internalname = "SIS_COD_"+sGXsfl_12_idx ;
         }
         /* End function sendrow_122 */
      }

      protected void init_default_properties( )
      {
         lblTextblock1_Internalname = "TEXTBLOCK1" ;
         edtavSisdes_Internalname = "vSISDES" ;
         bttButton2_Internalname = "BUTTON2" ;
         bttBtn_first_Internalname = "BTN_FIRST" ;
         bttBtn_previous_Internalname = "BTN_PREVIOUS" ;
         bttBtn_next_Internalname = "BTN_NEXT" ;
         bttBtn_last_Internalname = "BTN_LAST" ;
         bttButton1_Internalname = "BUTTON1" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         tblTable2_Internalname = "TABLE2" ;
         tblTable1_Internalname = "TABLE1" ;
         Form.Internalname = "FORM" ;
         subGrid1_Internalname = "GRID1" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         edtSIS_COD_Jsonclick = "" ;
         edtSIS_DES_Jsonclick = "" ;
         chkavMarca.Visible = -1 ;
         chkavMarca.Enabled = 1 ;
         subGrid1_Height = 192 ;
         subGrid1_Width = 288 ;
         subGrid1_Linesfont = "font-family:Courier New;font-size:9pt;" ;
         subGrid1_Titlefont = "font-family:Arial;font-size:9pt;font-weight:bold;" ;
         subGrid1_Class = "WorkWith" ;
         subGrid1_Backcolorstyle = 3 ;
         edtavSisdes_Jsonclick = "" ;
         edtavSisdes_Backstyle = -1 ;
         edtavSisdes_Backcolor = (int)(0xFFFFFF) ;
         edtavSisdes_Enabled = 1 ;
         chkavMarca.Caption = "" ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Agrega Sistemas" ;
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
         wcpOAV6USUCOD = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         AV5SISDES = "" ;
         GX_FocusControl = "" ;
         Form = new GXWebForm();
         sPrefix = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         chkavMarca_Internalname = "" ;
         edtSIS_DES_Internalname = "" ;
         edtSIS_COD_Internalname = "" ;
         AV7MARCA = "" ;
         A259SIS_DES = "" ;
         GXCCtl = "" ;
         Grid1Container = new GXWebGrid( context);
         scmdbuf = "" ;
         H00532_A126PRG_COD = new short[1] ;
         H00532_A259SIS_DES = new String[] {""} ;
         H00533_AGRID1_nRecordCount = new int[1] ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         lblTextblock1_Jsonclick = "" ;
         TempTags = "" ;
         bttButton2_Jsonclick = "" ;
         subGrid1_Linesclass = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         Grid1Column = new GXWebColumn();
         bttBtn_first_Jsonclick = "" ;
         bttBtn_previous_Jsonclick = "" ;
         bttBtn_next_Jsonclick = "" ;
         bttBtn_last_Jsonclick = "" ;
         bttButton1_Jsonclick = "" ;
         bttBtn_cancel_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         GXt_char3 = "" ;
         ROClassString = "" ;
         GXt_char4 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.hseg001__default(),
            new Object[][] {
                new Object[] {
               H00532_A126PRG_COD, H00532_A259SIS_DES
               }
               , new Object[] {
               H00533_AGRID1_nRecordCount
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_Grid1 ;
      private short nGXsfl_12_idx=1 ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short GRID1_nEOF ;
      private short wbEnd ;
      private short wbStart ;
      private short A116SIS_COD ;
      private short nDonePA ;
      private short nGXsfl_12_fel_idx=1 ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short subGrid1_Collapsed ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private short edtavSisdes_Backstyle ;
      private int GRID1_nFirstRecordOnPage ;
      private int subGrid1_Islastpage ;
      private int GRID1_nCurrentRecord ;
      private int GRID1_nRecordCount ;
      private int edtavSisdes_Enabled ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int subGrid1_Width ;
      private int subGrid1_Height ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private int edtavSisdes_Backcolor ;
      private String AV6USUCOD ;
      private String wcpOAV6USUCOD ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_12_idx="0001" ;
      private String sDynURL ;
      private String FormProcess ;
      private String AV5SISDES ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String chkavMarca_Internalname ;
      private String edtSIS_DES_Internalname ;
      private String edtSIS_COD_Internalname ;
      private String AV7MARCA ;
      private String A259SIS_DES ;
      private String GXCCtl ;
      private String edtavSisdes_Internalname ;
      private String scmdbuf ;
      private String sGXsfl_12_fel_idx="0001" ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
      private String TempTags ;
      private String edtavSisdes_Jsonclick ;
      private String bttButton2_Internalname ;
      private String bttButton2_Jsonclick ;
      private String subGrid1_Internalname ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String subGrid1_Titlefont ;
      private String subGrid1_Linesfont ;
      private String bttBtn_first_Internalname ;
      private String bttBtn_first_Jsonclick ;
      private String bttBtn_previous_Internalname ;
      private String bttBtn_previous_Jsonclick ;
      private String bttBtn_next_Internalname ;
      private String bttBtn_next_Jsonclick ;
      private String bttBtn_last_Internalname ;
      private String bttBtn_last_Jsonclick ;
      private String tblTable2_Internalname ;
      private String bttButton1_Internalname ;
      private String bttButton1_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String GXt_char3 ;
      private String ROClassString ;
      private String edtSIS_DES_Jsonclick ;
      private String edtSIS_COD_Jsonclick ;
      private String GXt_char4 ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private String aP0_USUCOD ;
      private GXCheckbox chkavMarca ;
      private IDataStoreProvider pr_default ;
      private short[] H00532_A126PRG_COD ;
      private String[] H00532_A259SIS_DES ;
      private int[] H00533_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXWebForm Form ;
   }

   public class hseg001__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH00532 ;
          prmH00532 = new Object[] {
          new Object[] {"@AV5SISDES",SqlDbType.Char,15,0}
          } ;
          Object[] prmH00533 ;
          prmH00533 = new Object[] {
          new Object[] {"@AV5SISDES",SqlDbType.Char,15,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00532", "SELECT [PRG_COD], [SIS_DES] FROM [SEG001] WITH (NOLOCK) WHERE [SIS_DES] >= @AV5SISDES ORDER BY [SIS_DES]  OPTION (FAST 10)",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00532,10,1,true,false )
             ,new CursorDef("H00533", "SELECT COUNT(*) FROM [SEG001] WITH (NOLOCK) WHERE [SIS_DES] >= @AV5SISDES ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00533,1,1,true,false )
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
                ((String[]) buf[1])[0] = rslt.getString(2, 15) ;
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
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
       }
    }

 }

}
