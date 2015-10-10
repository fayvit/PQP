using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class bancoDeTextos{

	public static readonly Dictionary<string,Dictionary<string,List<string>>> falacoes 
	= new Dictionary<string, Dictionary<string,List<string>>>()
		{
		{"pt-br",
			new Dictionary<string,List<string>>(){
				{"bomDia", new List<string>()
					{
						"bom dia pra você",
						"bom dia pra você",
						"bom diaaaaaaaaaaa....",
						"bom dia pra você"
					}},
				{"infinity1", new List<string>()
					{
						"A sul daqui existe uma cidade chamada Ive",
						"Lá existem varias lojas",
						"Talvez você encontre algo que lhe interesse por lá"
					}},
				{"infinity2", new List<string>()
					{
						"E essa roupinha ai rapaz?",
						"Está querendo enganar a quem?",
						"Se a <color=yellow>garra governamental</color> te pegar vestido assim não quero nem saber o que farão com você"
					}},
				{"infinity3", new List<string>()
					{
						"A sul daqui, em uma pequena montanha no meio do vale, você pode ver a <color=yellow>fortaleza Stealer</color>",
						"A muito tempo atrás, antes mesmo de <color=orange>Logan</color> ser imperador, essa planície era o leito do rio Mariinque",
						"Como o rio Mariinque tinha o leito largo e profundo, e além disso, desagua no mar",
						"Ele era uma porta aberta para que os conquistadores de outros continentes desembarcassem aqui no coração do nosso continente de Yoro",
						"A Fortaleza Stealer foi construída para defender Yoro desse tipo de ataque",
						"Hoje ela se tornou mais uma base a serviço dos imperialistas."
					}},
				{"infinity4", new List<string>()
					{
						"Rezam as lendas de Orion que o imperador é um escolhido dos próprios Deuses para liderar seu povo nos caminhos do Universo.",
						"E a <color=yellow>Torre da Vida Eterna</color> é uma prova disso",
						"A Torre da Vida Eterna é uma fortaleza fechada pelo acordo dos Deuses de Orion",
						"Ao que parece, só existem duas formas de entrar na Torre",
						"A primeira é ter a permissão do próprio imperador",
						"A segunda é juntando oito dos medalhões dos Deuses",
						"Juntando oito dos medalhões dos deuses e colocando os medalhões no painel a frente da Torre da Vida Eterna a porta se abrirá",
						"Ao menos dizem!! Pois não conheço nenhum possuidor de oito medalhões de Deuses. O máximo que já vi com uma única pessoa foram cinco."
					}},
				{"infinity5", new List<string>()
					{
						"Seguindo a oeste da cidade de Ive você irá de encontro com o Rio Mariinque",
						"Depois da construção da represa o curso do rio foi mudado.\r\n A mudança no curso do rio enfureceu o deus <color=cyan>Drag</color>, deus das águas.",
						"Para dar uma lição aos mortais que brincaram de deuses mudando o curso de uma obra da natureza, Drag fez com que o novo Rio Mariinque fosse ainda mais profundo que o anterior e sua margem ainda mais ampla.",
						"No fundo do Rio os seguidores de Drag construiram uma arena divina",
						"Na <color=yellow>Arena divina de Drag</color> você pode conseguir o medalhão das águas."
					}},
				{"infinity6",new List<string>()
					{
					"Bem-vindo forasteiro, aqui é a cidade de <color=yellow>Infinity</color>",
					"Esta cidade é conhecida por ser o ponto de partida de vários aventureiros",
					"Você já deve ter ouvido falar do treinador Alpha, do treinador Beta e do Treinador Epsolon, não??",
					"Certeza que não?",
					"Não mesmo?",
					"Pelo menos você deve ter ouvido falar dos Criatureiros de Atílio: Dantas, Boni, Grids e Lara.",
					"Também não!!?? Pelos Deuses!! Em que mundo você vive?",
					"Você é mesmo um cidadão de Orion?"
					}},
				{"infinity7",new List<string>()
					{
						"Você vai sair em viagem pelas planícies de Infinity?",
						"Você não sabe que os Criatures estão enfurecidos e estão atacando os viajantes?",
						"Você está confiando que seus Criatures podem te defender dos Criatures espalhados pelas planícies?",
						"A melhor coisa que você faz e não sair daqui de Infinity!!  Vai por mim!!",
						"Você não vai querer levar uma chifrada de Marak!",
						"Nâo vai conseguir sentar por vários dias!!"
					}},
				{"infinity8",new List<string>()
					{
						"O Imperador <color=orange>Logan</color> durante muitos anos (quase todo o seu império) foi um homem justo e que levou o povo da Yoro de Orion a prosperidade",
						"De alguns anos pra cá que os rumos do império mudaram.",
						"A obsessão por <color=cyan>gemas Laranges</color> levou Logan a adotar a escravidão como mão de obra nas minas",
						"A maioria dos prisioneiros foram levados para as minas de <color=yellow>AxeOdion</color>, bandidos, assaltantes, assassinos, todo o tipo de criminoso.",
						"Mas isso não sanou a ganancia do imperador.",
						"Ele aumentou a cobrança dos impostos nas cidades do império.\n\r Isso levou cidadãos a inadimplência, o que os levou a prisão, e mais tarde, alguns foram levados a trabalhos forçados nas minas.",
						"Assim o imperador conseguiu mais escravos.",
						"Tenho medo de um dia chegar a minha vez!!"
					}},
				{"infinity9",new List<string>()
					{
						"No deserto da predominância existe uma grande Universidade.\n\r Nela existem grandes estudiosos de renome em Orion",
						"Enquanto a maioria das pessoas acredita que a repentina ganancia que despertou no Imperador nesses últimos anos tem origens místicas.\n\r Os cientistas sociais da Universidade tem outra explicação",
						"Eles dizem que nós notamos essa ganância no imperador apenas agora porque estamos passando por um momento de acirramento das lutas de classe",
						"A elite do império quer cada vez mais <color=cyan>gemas Laranges</color> e outras pedras preciosas, isso causa uma demanda cada vez maior por mão de obra primária",
						"A necessidade de mão de obra levou o império a adotar a escravidão. E essas medidas impopulares levaram as classes baixas a se organizarem contra a tirania deste império.",
						"Dizem também que:\n\r A história da humanidade até os dias de hoje é a história da luta de classes.",
						"Eu não entendo muito bem sobre isso, mas isso faz muito sentido quando a gente ouve um estudioso falando."
					}},
				{"infinity10",new List<string>()
					{
						"Você quer entrar na <color=yellow>Torre da Vida Eterna</color>? E encarar <color=orange>Logan</color> para questionar os males da escravidão e da ganancia que ele dispara contra nós?",
						"Eu não posso dizer nada a mais do que: Você é um sonhador.",
						"Eu sei que você não é o único e não é difícil de me imaginar sonhando junto com vocês por um mundo que seja um só",
						"Mas precisamos levar nossas vidas, temos nossos empregos, nossas contas, nossas famílias. Não da pra simplesmente sair no mundo peitando um imperador que lidera um exercito.",
						"Mas se você quer mesmo lançar-se numa busca por medalhões e encarar Logan, eu tenho uma dica para te dar",
						"Existe um caminho para a arena de <color=cyan>Drag</color> a partir das tubulações de esgoto.",
						"A leste da <color=yellow>Fortaleza Stealer</color> você pode encontrar uma imensa saída dos esgotos",
						"Acredito que seja esse o primeiro rumo que você deva tomar."
					}},
				{"infinity11",new List<string>()
					{
						"O responsável pela <color=yellow>Fortaleza Stealler</color> é o general <color=orange>Potus Ramos</color>. Abaixo dele na hierarquia militar da fortaleza estão dois capitães",
						"Um deles é conhecido como <color=orange>Capitão Espinha de Peixe</color>. Atualmente o capitão Espinha de Peixe está cumprindo sua missão de cuidar do <color=yellow>Cruzador de Guerra</color> aportado no rio Mariinque.",
						"O outro é o <color=orange>Capitão Atos Aramis</color> que foi enviado para uma missão dentro da <color=yellow>pirâmide</color> que fica no deserto de <color=yellow>Jadme</color>",
						"Ambos os capitães carregam condecorações que entregam a cidadãos que fazem honra ao mérito.\n\r Os cidadãos que tem as condecorações do capitão Espinha de Peixe e do capitão Aramis tem acesso livre para entrar na fortaleza."
					}},
				{"infinity12",new List<string>()
					{
						"Hoje em dia todas as crianças já nascem brincando com as tecnologias oferecidas por <color=cyan>Armagedom</color>.",
						"mas nem sempre foi assim!!\n\r No meu tempo nem todos utilizavam as <color=cyan>Luvas de Guarde</color>",
						"A invenção de <color=orange>Jack Bandit</color> mudou a forma como as pessoas se relacionam e até a nossa maneira de viver em Orion.",
						"Mais tarde vieram as <color=cyan>Cartas Luvas</color>.\r\n Pequenas cartas que quando encaixadas na Luva de Guarde aumentam a potencia da <color=cyan>Gema Laranje</color>.",
						"Esse aumento de potencia é utilizado pelos colecionadores/treinadores de Criatures para aprisionar novos Criatures",
						"Você já aprisionou um Criature utilizando uma Carta Luva??"
					}},
				{"infinity12respostas",new List<string>()
					{
						"Para te ajudar na sua primeira captura eu tenho algo pra você.\r\n <color=yellow>5</color> cartas luva",
						"É emocionante fazer uma captura não é?",
						"Estranho... Me parece que você só tem esse Criature que está andando atrás de você",
						"Você é malandrinho né? Está tentando me enganar!!",
						"Espero que você consiga capturar muitos Criatures.\r\n Boa sorte na sua jornada"
					}},
				{"simOuNao",new List<string>()
					{
						"Sim",
						"Não"
					}},
				{"ive1",new List<string>()
					{
						"Se você seguir para oeste daqui você chegará ao <color=yellow>rio Mariinque.</color>",
						"Assim que você ultrapassar as montanhas logo verá a<color=yellow>Torre da Vida Eterna</color>",
						"No alto da torre fica o castelo do imperador",
						"Certeza que é lá que você quer ir?"
					}},
				{"ive2",new List<string>()
					{
						"Bem-vindo a cidade de <color=yellow>Ive</color>",
						"Nossa cidade sempre foi próspera devido a rota comercial que liga a cidade de <color=yellow>Afarenga</color> dentro do vulcão do outro lado do rio Mariinque,",
						"à cidade de <color=yellow>Ofawing</color> que fica além da ferrovida de <color=yellow>Jadme</color>.",
						"Mas parece que os ventos não sopram a favor da nossa cidade",
						"Alguns anos atrás <color=orange>Logan</color> mandou fechar a ferrovia de Jadme",
						"Isso reduziu o fluxo de viajantes, pois não poderiam mais chegar a Ofawing por essa rota",
						"E há pouco tempo um deslizamento fechou a entrada do vulcão que dava acesso a Afarenga",
						"Nossa rota comercial está indo de mal a pior."
					}},
				{"ive3",new List<string>()
					{
						"No meio do <color=yellow>rio Mariinque</color> existe uma plataforma de extração de petróleo.",
						"A <color=yellow>Petrolífera</color> é responsável pelo abastecimento de combustível de várias planícies de Orion",
						"Mas ultimamente eles atravessam sérios problemas.",
						"Alguns compartimentos da petrolífera foram tomados por Criatures <color=orange>Iziculos</color>.",
						"Iziculos são pequenos criatures insetos cortadores que gostam de viver em lugares úmidos e escuros",
						"carregam um bastão e com esse bastão podem aprender habilidades cortantes fortes o suficiente para cortar barras de aço",
						"Eu acho que a Petrolífera está em sérios apuros"
					}},
				{"ive4",new List<string>()
					{
						"Os esgotos que correm por baixo dessa planície são o abrigo de Criatures asquerosos.",
						"Viajantes que utilizaram a estrada leste da <color=yellow>Fortaleza</color> sempre tem histórias para contar sobre insetos que saiam das tubulações de esgoto por aqueles lados.",
						"Em vista desse problema, a administração pública da <color=yellow>Garra Governamental</color> colocou grades nos tubos de esgoto para os Criatures não sairem de lá",
						"Mas isso não resolveu completamente o problema",
						"Alguns criatures que carregam bastões pode utilizar a habilidade <color=cyan>Sabre de Bastão</color> e com ela cortar as barras de isolamento do esgoto",
						"A Garra Governamental está sempre repondo as grades do esgoto, mas de tempos em tempos aparece uma nova abertura provocada por Criatures."
					}},
				{"ive5",new List<string>()
					{
						"Atracado nas margens do <color=yellow>rio Mariinque</color> está o <color=yellow>Cruzador de Guerra </color>.",
						"O cruzador de guerra é um navio construido para defender o continente de Yoro das invasões dos outros continentes.",
						"Com o prolongar dos tempos de paz, o Cruzador se tornou pouco útil para questões de defesa territorial.",
						"Então os militares resolveram abrir o Cruzador para visitação por 100 CRISTAIS.",
						"Eles querem nos enganar dizendo que é para a população conhecer os aparelhos de segurança que nos protegem, mas eu acredito que estão mesmo é querendo ganhar uns trocos",
						"Possivelmente estão passando por uma crise financeira já que mantém um equipamento de guerra precisando de manutenção e praticamente sem utilidade."
					}},
				{"ive6",new List<string>()
					{
						"A tecnologia <color=cyan>Armagedom</color> foi criada a algumas décadas pelo próprio imperador <color=orange>Logan</color> quando ele era estudante da universidade no deserto da predominância.",
						"Com Armagedom's podemos transportar nossos itens de um Armagedom para outro nas várias sedes que estão espalhadas por Orion.",
						"Isso é fascinaste!!",
						"Tudo isso utilizando da energia única fornecida por um mineral bastante encontrado em Orion: as <color=cyan>gemas Laranges</color>.",
						"Depois de Logan, muitos cientistas trabalharam em aprimoramentos para Armagedom.",
						"A massa possível de ser transportada foi ampliada e o sistema de comunicação entre Armagedom's evoluiu muito desde Logan",
						"mas a maior contribuição da tecnologia Armagedom, sem sombra de duvidas, foi feita por um jovem cientista e atual milhonário: <color=orange>Jack Bandit</color>","a invenção dele foi, nada mais nada menos que, a <color=cyan>Luva de Guarde</color>.",
						"Com a luva de Guarde podemos carregar nossos itens dentro de uma Gema Larange posicionada em nossas luvas.",
						"E a coisa mais surpreendente das luvas de Guarde é a capacidade de carregar um certo número de Criatures vivos",
						"Não é à toa que todo mundo em Orion é obrigado a utilizar Luvas de Guarde"
					}},
				{"ive7",new List<string>()
					{
						"Se você seguir por entre as montanhas do leste você chegará até a cidade de <color=yellow>Hadjek</color>.",
						"Hadjek é passagem obrigatória para todos os viajantes que seguem o destino de <color=yellow>Jadme</color>.",
						"No deserto de Jadme existe uma pirâmide bastante curiosa. Dizem os mais velhos que ela é na verdade um templo para <color=cyan>Turabá</color>, o deus dos Mistérios.",
						"O <color=orange>capitão Aramis</color> foi enviando numa missão dentro da pirâmide.",
						"Eu desconfio que ele está procurando algum sacerdote de Turabá lá dentro. Seria a busca da revelação sobre o mistério do comportamento atípico do imperador?"
					}},
				{"ive8",new List<string>()
					{
						"No fundo do rio Mariinque os clérigos de <color=cyan>Drag</color> construiram uma arena para o deus das águas.",
						"O responsável pela <color=yellow>arena de Drag</color> é <color=orange>Omar Water</color>.",
						"Dizem as lendas de Orion, que após o desvio do curso do rio Mariinque para a construção da represa, Drag invocou seus seguidores para a construção de monumentos no fundo do rio.",
						"Pela vontade de Drag, o novo rio, o rio desviado de seu curso, se tornou mais profundo e mais largo que o anterior.",
						"Algumas gerações passaram desde o acontecido e então Omar chegou para ficar a frente da arena",
						"Dizem que ele e sua esposa ouviram a própria voz de Drag lhes delegando a responsabilidade de reger a arena do Rio Mariinque ",
						"Eu sou muito cética com relação a religiões, acredito que essas histórias só reforçam o mito dos deuses para manter seus seguidores."
					}},
				{"ive9",new List<string>()
					{
						"O caminho para o castelo do imperador, a <color=yellow>Torre da Vida Eterna</color>, é fechada pelo acordo dos deus de Orion em proteger o imperador que é o responsável por levar seu povo a prosperidade",
						"No entando, os deuses não deram ao imperador uma proteção inabalável",
						"Pela vontade dos deuses, um cidadão de Orion que possuir oito dos medalhões dos deuses pode abrir os portões da Torre da Vida Eterna e subir a torre para encontrar com o imperador",
						"Para ganhar os medalhões dos deuses só existe uma maneira: Procurar as arenas dos deuses e desafiar seus regentes para uma luta entre Criatures",
						"Vencendo um regente de arena, na arena de um deus, você pode ganhar o medalhão desse Deus.",
						"Os deuses deram essa possibilidade para que um cidadão digno pudesse destituir um imperador não digno",
						"Mas eu acho que eles esqueceram da parte que o imperador lidera um exercito!!"
					}},
				{"ive10",new List<string>()
					{
						"A <color=yellow>Represa</color> que fica a leste da cidade de <color=yellow>Infinity</color> é responsável pelo abastecimento de água da maioria das planícies de Orion, ela abastece todas as planícies de Yoro.",
						"No rio Mariinque, existe uma grande <color=yellow>tubulação</color> fechada por um registro. Esses tubos se prolongam muito por Orion.",
						"Talvez por dentro das tubulações você consiga chegar a planícies que não são acessíveis viajando por terra.",
						"O controle dos registros das tubulações de Orion ficam na sede da <color=yellow>Garra Governamental</color>."
					}},
				{"ive11",new List<string>()
				{
					"O caminho para a cidade de <color=yellow>Afarenga</color> foi obstruído por um deslizamento de terra há algum tempo.",
					"O exercito do imperador <color=orange>Logan</color> em conjunto com as seções de serviços públicos da <color=yellow>Garra Governamental</color> estão se mobilizando para desobstruir o caminho",
					"De acordo com as noticias que correm em Orion, o general <color=orange>Potus Ramos</color> da Fortaleza Stealer já tem a disposição dele uma quantidade de explosivos suficiente para a realizar a tarefa",
					"O que impede o serviço é um impasse entre as entidades imperialistas de Orion, o exército liderado por Ramos espera mão de obra da Garra Governamental e a Garra Governamental espera que a mão de obra seja aplicada pelo exercito",
					"Como o material está com o General Ramos, talvez ele só precise delegar essa função a alguém de confiança",
					"Você não quer se candidatar?"
				}},
				{"ive12",new List<string>()
				{
					" A história da construção da <color=yellow>fortaleza Stealer </color> é uma história muito antiga e que passa de geração para geração.",
					" Por isso muitas versões tem informações que se desencontram.",
					" Os mais velhos contam que o nome da fortaleza \" Stealer\" é em homenagem ao Criature de mesmo nome,",
					" pois a floresta em volta da fortaleza era cheia desses Criatures",
					" Porém, os Stealer\'s lançavam Relampagos contra os viajantes que atravessavam a floresta",
					" Por esse motivo, desde a construção da fortaleza passando pelo tempo de atividade militar dela, Stealers foram caçados e exterminados.",
					"Hoje não existem mais Stealers na floresta da fortaleza.",
					"Curioso que o Criature que deu nome a fortaleza foi exterminado justamente por causa da existencia da fortaleza",
					"Algumas pessoas dizem ter visto Criatures Eletricos na floresta da Fortaleza, mas a maioria das pessoas não acreditam nesses boatos",
					"As pessoas que repetem isso normalmente ganham fama de mentirosas."
				}},
				{"armagedomDeInfinity",new List<string>()
				{
					"Olá estranho!!\r\n Bem vindo ao Armagedom de Infinity.\r\n No que posso te ajudar?",
					"Não há nenhum Criature seu guardado no Armagedom no momento."
				}},
				{"opcoesDeArmagedom1",new List<string>()
				{
					"Curar Criatures","Seus Criatures no Armagedom","Cancela"
				}},
				{"falasDeArmagedom",new List<string>()
				{
					" Você retirou <color=yellow>",
					"</color> Nível: ",
					" do seu grupo de Criature e inseriu <color=yellow>"
				}},
				{"Shop1",new List<string>()
				{
					"Olá Estranho!! Eu tenho excelentes mercadorias para você",
					"Muito obrigado por sua visita e volte sempre à nossa loja.",
					"<color=red>OPS!!</color>\r\n Você não tem dinheiro suficiente para comprar esse item",
					"Ao observar pela forma como você está vestido, acredito que você não se interessaria por esse item.",
					"Insisto! Esse item não é para você. Espero que não me questione mais",
					"Ja te disse... Esse item não é para você",
					"Rapaz... Você é insistente ein... Tudo bem, se você quer tanto assim pode leva-lo",
					"Cesar Corean recebe a <color=cyan>Estatua Misteriosa</color>",
					"Excelente compra!! Estranho.\r\n Gostaria de levar mais alguma coisa estranho?"
				}},
				{"hospital",new List<string>()
				{
					"Olá Estranho!! Eu posso curar os seus Criatures feridos.\r\n Você gostaria de cura-los por ",
					" Cristais",
					"Você não tem Cristais suficiente no momento. Mas não se preocupe estaremos aqui prontos para cumprir o juramento médico assim que você conseguir a quantia necessária",
					"Ao que me parece a saúde de seus Criatures está perfeita. Você está de parabéns pelo bom trabalho em cuidar de seus Criatures",
					"Espero ve-lo novamente, estranho!!"
				}},
				{"igreja",new List<string>()
				{
					"Olá Estranho!! Eu posso fazer uma garrafada arretada que pode acordar seus Criatures desmaiados.\r\n Gostaria de aplicar em algum de seus Criatures??",
					" O Criature que tu me apontaste não está desmaiado. Ele não precisa de uma garrafada para despertar",
					"A garrafada para esse Criature custa ",
					" Cristais",
					"Espero ve-lo novamente, estranho!!",
					"Se tu não tens recursos terá de consegui-los para me pagar",
					"O seu Criature ",
					" está acordado e com ",
					" pontos de Vida"
				}},
				{"mensLuta",new List<string>()
				{
					"Você não pode usar esse item nesse momento.",
					"Cesar Corean usa ",
					"{0} não precisa usar esse item nesse momento"
				}},
				{"encontros",new List<string>()
				{
					"Qual Criature saira para continuar a batalha?",
					" foi derrotado ",
					" esta desmaiado e  não pode continuar a luta",
					"Todos os Criatures de Cesar Corean foram derrotados. \r\n\r\n Cesar Corean deve agora retornar ao Armagedom para renovar as energias de seus Criatures e voltar para sua aventura",
					"<color=red>OPS!</color> \r\n Você não tem PE suficiente."
				}},
				{"tentaCapturar",new List<string>()
				{
					" resistiu a tentativa de Captura.",
					"A luva de guarde de Cesar Corean so pode carregar ",
					"Então: ",
					" Nível ",
					"foi enviado para o ",
					"Cesar Corean conseguiu capturar um "
				}},
				{"menuPausa",new List<string>()
				{"Retornar ao Jogo",
				 "Botões",
				 "Voltar ao Título",
				 "Fechar o Jogo"
				}},
				{"semHadjek",new List<string>()
				{
					"Esse é o caminho para a cidade de <color=yellow>Hadjek</color>",
					"Porém, nessa versão ALPHA esse mapa ainda não foi implementado"
				}},
				{"semMariinque",new List<string>()
				{
					"Esse é o caminho para o <color=yellow>Rio Mariinque</color>",
					"Porém, nessa versão ALPHA esse mapa ainda não foi implementado"
				}},
				{"entradinha",new List<string>()
				{
					"Então... . É você que veio juntar-se a  nós?",
					"Sinto que há algo errado com o rumo que as coisas estão tomando e isso não me deixa em paz para seguir o rumo natural da minha vida.",
					"Por isso decidi me juntar a vocês",
					"Nós estamos tentando abrir a <color=yellow>Torre da Vida Eterna</color> e encarar <color=orange>Logan</color> para mudar o destino de Orion",
					"O caminho para isso é muito longo e muito difícil, você precisa de muita determinação para percorrer todo o caminho",
					"Nós estamos apenas no meio do caminho um tanto quanto sem rumo mas já temos algumas lições para tirar da nossa trajetória.",
					"Rapaz, todos os que querem fazer uma tarefa difícil tem um começo.\r\n E só quem já está no meio do caminho sabe como é dificil começar.",
					"Por isso vamos te ajudar",
					"Vou te indicar o caminho do <color=yellow>Armagedom de Infinity</color>, lá você poderá pegar um CRIATURE e iniciar sua jornada"
				}},
				{"apresentaFim",new List<string>()
				{
					" venceu!!",
					" pela vitoria ",
					" recebeu",
					"<color=#FFD700> pontos de experiencia.</color>",
					"e",
					" recebeu ",
					"<color=#FF4500> CRISTAIS</color>",
					" conseguiu ",
					"alcançar o ",
					"<color=yellow> Nivel ",
					"</color>",
					" aprendeu:",
					"Tempo de Reuso: ",
					"s\r\n Ataque Basico: ",
					"\r\n Custo de PE: ",
					" pode Aprender:",
					" <color=orange>Para isso deve esquecer um ataque!!</color> "
				}},
				{"encontrosScript",new List<string>()
				{
					" <color=orange>Não aprender</color> ",
					" esquecerá para aprender <color=yellow>",
					" esqueceu ",
					" não aprendeu ",
					" O Criature {0} deixou <color=cyan>{1}</color>"
				}},
				{"Hadjek1",new List<string>()
				{
					"Hoje os mais jovens reclamam que a mão do imperador está ficando cada vez mais pesada",
					"Dizem que o imperador está numa fase de restrições dos direitos individuais",
					"Dizem que muitos são presos e/ou agredidos pelos guardas imperiais",
					"Eu acredito que quem está sendo preso ou apanhando é porque é vagabundo mesmo",
					"Vejam só...\r\n Eu que sou um homem de bem não tenho nada do que me queixar sobre império de <color=orange>Logan</color> e da ação da <color=orange>Garra Governamental</color>",
					"Eu sou dono de alguns imóveis que estão alugados e com o dinheiro do aluguel pago os impostos e levo minha vida modesta",
					"Quem apanhou dos soldados do império é porque é vagabundo e quer viver sem trabalhar",
					"Eu quero mais é que o império de Logan dure por mais longos anos e esses revolucionarioszinhos sustentados por mamãe vão parar no presidio de <color=yellow>Cyzor</color>"
				}},
				{"Hadjek2",new List<string>()
				{
					"Bem-Vindo a cidade de <color=yellow>Hadjek</color> forasteiro!!",
					"Até bem pouco tempo, nós recebiamos turistas e estudiosos que vinham conhecer nossa água.",
					"As historias que passam de geração para geração é que nossas aguas tem propriedades medicinais porque são uma benção dada por <color=cyan>Ananda</color> Deusa da pureza e das vírtudes humanas",
					"Nenhum cientista que viajou da universidade no deserto da Predôminancia até aqui conseguiu concluir nada sobre a agua de Hadjek",
					"Todos eles sempre concluem que nossa água é comum, igual a água de qualquer Oasis no deserto",
					"Mas cientistas são céticos e talvez por isso não consigam aceitar a grandeza que é a benção de um Deus sobre a vida das pessoas menos afortunadas."
				}},
				{"Hadjek3",new List<string>()
				{
					"Tenho muito medo de seguir para o Norte",
					"O caminho entre a cidade de <color=yellow>Hadjek</color> e a cidade de <color=yellow>Jadme</color> se tornou um lugar perigoso",
					"Alguns bandidos que fugiram dos trabalhos forçados nas minas de <color=yellow>AxeOdion</color> encontraram esconderijos entre as montanhas do deserto",
					"Suspeita-se que reunem-se no esgoto",
					"Esse grupo de criminosos se auto proclama <color=orange>Tatus Peçonhentos</color> e costumam abordar viajantes no caminho de Jadme",
					"Se for para o Norte tome muito cuidado"
				}},
				{"Hadjek4",new List<string>()
				{
					"A norte daqui existe uma grande <color=yellow>Piramide.</color> Alguns mais idosos dizem que é um Templo para <color=cyan>Turabá</color> o Deus dos Mistérios",
					"Porém, poucos tentam entrar na piramide por causa das armadilhas e dos cachorros mumia",
					"Sim!! Cachorros mumia, eu não estou brincando com você! Sou uma pessoa muito séria",
					"Na verdade eles são Criatures do tipo gás.",
					"Nesses últimos anos com o surto de agressividade dos Criatures, eles começaram a sair da pirâmide e atacar viajantes que passam próximos",
					"Tenho medo deles, mumias me lembram morte e morte me lembra fantasmas. Não quero ser uma pessoa assombradas por entidades de outros mundos."
				}},
				{"Hadjek5",new List<string>()
				{
					"Sempre fui um grande devoto dos deuses de Orion e admiro muito <color=cyan>Turabá</color> o deus dos mistérios",
					"Quando viajo para <color=yellow>Jadme</color> sempre desvio um pouco a minha rota para a <color=yellow>Piramide</color> para orar em honra a Turabá",
					"Nunca entrei na piramide, sempre tive vontade de encontrar o sacerdote de Turabá que vive lá dentro",
					"Você deve estar se perguntando por que eu nunca entrei lá, e a verdade é, eu nunca achei que escaparia das armadilhas da piramide sem me ferir",
					"Sempre tive medo até de morrer no percurso. Com esse medo a idade foi chegando e agora mesmo que tenha vontade não tenho mais energia para encarar os desafios da piramide",
					"E existe mais uma complicação: A porta da piramide sempre esteve aberta e convidativa para quem quisesse adentra-la",
					"mas nas últimas viagens que fiz até lá a porta estava fechada",
					"além disso a estatua que ficava na frente da porta da piramide desapareceu, dizem que foi obra dos <color=orange>Tatus Peçonhentos</color>.",
					"Parece que a estatua foi roubada e vendida para um mercador mercenário de <color=yellow>Jadme</color>",
					"Hoje em dia se faz tudo por dinheiro não é?",
					"Eu gostaria de ver novamente a estatua na frente da piramide....\r\n Espero que consiga... "
				}},
				{"Hadjek6",new List<string>()
				{
					"Eu conheci pessoalmente o capitão <color=orange>Atos Aramis</color>. E te digo uma coisa rapaz:",
					"Posso ter sido uma das últimas pessoas que o viu",
					"Ele foi enviado numa missão ultrasecreta dentro da piramide e passou por aqui a caminho de lá",
					"Eu o vi partir de <color=yellow>Hadjek</color>, ele rumou para a piramide, já fazem vários dias. Desde então, ninguém mais o viu",
					"Não quero ser agoro de ninguém, mas...",
					"Todos já pensam no pior",
					"Eu sei que uma curiosidade lhe corroi.\r\n Eu sei porque também me corroeria.\r\n Somos humanos e sucestiveis a curiosidades não é?",
					"A duvida que pode lhe deixar aflito é: Qual era a missão ultrasecreta que levou Atos Aramis até a piramide?",
					"Hora... É ultrasecreta... ninguém deve saber!!",
					"Pois bem...\r\n Eu sei!!",
					"Tudo bem vou te contar. \r\n Ele me contou antes de partir na direção da piramide",
					"Mas te peço uma coisa ein...\r\n Não conte para mais ninguém!",
					"É o seguinte... \r\n Os militares já desconfiam da sanidade do imperador",
					"Sim... da sanidade!! Tanto o exercito quanto a <color=orange>Garra Governamental</color> tem recebido ordens estranhas do imperador",
					"A obcessão do imperador por <color=cyan>Gemas Laranjes</color> preocupa muito as entidades imperialistas",
					"Então... Atos Aramis foi tentar encontrar o Sacerdote dos mistérios para que todos tenham uma luz nos caminhos de Orion",
					"Aparentemente, os militares vão tentar tomar o poder caso sejam convencidos da insanidade do imperador",
					"Isso me assusta!! Não asusta você?"
				}},
				{"Hadjek7",new List<string>()
				{
					"Estou vendo que você está se aventurando a ser um treinador de Criatures",
					"Como bom treinador que você deve ser já deve saber que alguns tipos de Criatures são mais fortes lutando contra um tipo especifico",
					"Se você vai segui viagem pelo deserto é bom saber que os tipos água e planta são fortes contra os tipos pedra e terra",
					"outra coisa importante que você deve saber é que água é forte contra veneno",
					" e veneno é forte contra voadores e insetos.",
					" guarde bem essas informações, com certeza elas lhe serão úteis!!"
				}},
				{"Hadjek8",new List<string>()
				{
					"Pelos Deuses!!! Você veio cobrar os impostos de novo!!",
					"Não eu não vim, não sou um cobrador de impostos",
					"Você não devia dar esse susto nas pessoas! Você não deveria sair abordando as pessoas vestido desse jeito.",
					"Só essa sua roupa me causa calafrios.",
					"Estamos sendo muito abusados pelos impostos do império.\r\n Eu não entendo por que quem tem mais do que precisa ter quase sempre se convence que não tem o bastante",
					"Essa semana dois foram levados pelo império. Não puderam mais pagar os altos impostos para os imperialistas.",
					"Foram transformados em mão de obra para as minerações de <color=yellow>AxeOdion</color>.\r\n Esse é o destino de quem não pode pagar:  Tornar-se mão de obra escrava para essa obcessão por <color=cyan>Gemas Laranges</color>",
					"E se você continuar andando por ai vestido desse jeito vai acabar indo para lá também"
				}},
				{"Hadjek9",new List<string>()
				{
					"Você já andou de trem?",
					"É muito bom andar de trem.\r\n Podemos assistir o mundo passando pela janela do trem",
					"É quase como se assistissimos uma programação de televisão",
					"É uma pena que a televisão ainda tenha melhores programas que o mundo real passando na janela do trem.",
					"Em <color=yellow>Jadme</color> existe uma ferrovia que liga a cidade até o deserto de <color=yellow>Ofawing</color>.",
					"No deserto de Ofawing fica o prédio <color=yellow>sede da Garra Governamental</color>.",
					"Talvez você queira fazer uma viagem de trem para visitar a Garra Governamental"
				}},
				{"Hadjek10",new List<string>()
				{
					"O prefeito da cidade de <color=yellow>Jadme</color> é um politico muito habilidoso e um dos poucos líderes institucionais que é conhecidamente hostil aos imperialistas",
					"O prefeito de Jadme tem ideias muito assustadoras que incluem acabar com o império.",
					"Em Orion nós sempre vivemos sobre o regime imperialista. O imperador sempre foi o responsável por dar a última palavra nas decisões que envolviam uma grande parcela da população",
					"Não consigo imaginar uma forma de organização social que não seja a imperialista.",
					"O prefeito de Jadme diz que o ideal era que o líder máximo de um continente, estado, principado, país ou até cidade fosse colocado em votação para aprovação da população.",
					"Diz também que as pessoas deveriam escolher seus líderes de tempos em tempos.",
					"Eu acho isso absurdo! O império sempre esteve ai cuidando da Yoro de Orion. É assim que nascemos conhecendo o mundo, isso não pode ser mudado assim de uma hora pra outra",
					"Os apoiadores dessa ideia a chamam de Democracia.\r\n Eu não consigo imaginar um mundo organizado dessa forma."
				}},
				{"Hadjek11",new List<string>()
				{
					"O imperador mandou fechar a <color=yellow>ferrovia de Jadme</color> já faz algum tempo",
					"Isso mudou a rotina das cidades que ficam nessa região de Orion",
					"Muitos empregos eram mantidos pela funcionalidade da ferrovia",
					"Depois de fechada a ferrovia, muitas pessoas ficaram sem trabalhar, outras, como é o caso dos comerciantes, tiveram sua remuneração reduzida pela queda no fluxo de clientes.",
					"Isso trouxe muita tristeza e depressão para os trabalhadores, principalmente os de Jadme e especialmente um trabalhador",
					"<color=orange>Salmo Sadol</color> !!\r\n Ele era o maquinista do trem que fazia a rota Jadme / Ofawing",
					"Depois do fim de seu emprego como maquinista, teve dificuldades pra encontrar outra ocupação. Com o agravamento das dívidas, ele se entregou a bebedeira e sua esposa o abandonou.",
					"Dizem que ela mudou para a casa de parentes numa cidade  ao Norte do vulcão com seu filho pequeno.",
					"Hoje Salmo Sadol é sempre encontrado caido bebado em algum canto da cidade de Jadme. As pessoas que o conhecem dizem que ficou louco e não fala mais coisa com coisa",
					"História triste não?"
				}},
				{"Hadjek12",new List<string>()
				{
					"Em Orion, os responsáveis por escrever os pergaminhos mágicos vendidos nos Shopings são os sacerdotes de <color=cyan>Log</color>",
					"Log, é o deus do conhecimento e da sabedoria. Durante toda uma era de ouro, seus sacerdotes eram muito respeitados e admirados em Orion",
					"Ainda hoje é parecido, mas ... \r\n as vendas de pergaminhos trazem  a desconfiança das pessoas sobre os sacerdotes de Log.",
					"Na verdade... \r\n Ao sacerdote de Log",
					"<color=orange>Baltasar Gladist</color> é o último sacerdote em atividade do deus Log",
					"Os sacerdotes de Log normalmente são muito idosos e nesses últimos anos, a maioria deles veio a falecer.",
					"Milenarmente eles passam de geração para geração a arte de escrever os pergaminhos que podem ser utilizados em conjunto com os Criatures,",
					"mas foi Baltazar quem tornou a venda de pergaminhos um grande negocio rentável impulsionado pela popularização das luvas de Guarde",
					"Curiosamente Baltazar é relativamente jovem em relação aos outros clérigos de Log",
					"Ele aparenta ter por volta de 35~40 anos.",
					"Dizem que ele vive numa luxuosa mansão próxima da cidade de <color=yellow>Cyzor</color>.",
					"Não me parece atitude digna de um sacerdote sagrado se entregar as tentações da riqueza. O que você acha?"
				}},
				{"Hadjek13",new List<string>()
				{
					"<color=orange>Guto Jander</color> é o prefeito da cidade que fica do outro lado do deserto,<color=yellow>Jadme</color>",
					"Sujeitinho Sórdido",
					"Ele está encabeçando um movimento de desestabilizações do nosso amado império liderado por <color=orange>Logan</color>",
					"Na minha luva de guarde recebi várias reportagens falando de ideias que pretendem arruinar o nosso modo de viver em Orion",
					"Eles chamam essa ideia de democracia, dizem que o povo deve estar no poder para decidir por ele mesmo qual caminho tomar",
					"Mas na verdade, o que eles não dizem é que esses lideres nessa chamada democracia serão eles mesmos",
					"O atual prefeito de Jadme pretende acender ao poder ele mesmo e os seus",
					"Hipócritas de uma figa!!"
				}},
				{"prefeitoDeJadme",new List<string>()
				{
					"Seja muito bem vindo a cidade de Jadme estranho!! Meu nome é <color= orange>Guto Jander </color> sou o prefeito da cidade",
					"Olá... Eu sou <color=cyan>Cesar Corean</color>, nas cidades em que passei falam muito de você",
					" Imagino que sim ... Sou um dos poucos líderes em Orion que aponta uma alternativa ao império de <color=orange>Logan</color>",
					" Por causa das minhas ideias de democracia o império e seus simpatizantes colocam toda a maquina de propaganda que tem a disposição para tentar destruir a  minha imagem politica.",
					" Mas a queda do império é inevitável",
					" Eles podem até esmagar uma flor, mas jamais poderão deter a primaveira"
				}},
				{"prefeitoDeJadme2",new List<string>()
				{
					" Por causa das minhas ideias de democracia o império e seus simpatizantes colocam toda a maquina de propaganda que tem a disposição para tentar destruir a  minha imagem politica.",
					" Mas a queda do império é inevitável",
					" Eles podem até esmagar uma flor, mas jamais poderão deter a primaveira"
				}},
				{"perguntasParaOPrefeito",new List<string>()
				{
					" Por que você está contra o império?",
					" Como você se tornou um líder politico tão notável em Orion?",
					" O que é a maquina de propaganda do império?",
					" O que é a democracia?",
					" Eu posso me juntar a vocês?",
					" <color=orange>Terminar a conversa</color>"
				}},
				{"oPorQueDeJander",new List<string>()
				{
					" Moro em Jadme desde jovem... \r\n Ví o fechamento da ferrovia e o desespero dos desempregados",
					" Depois de um tempo os desempregados foram levados para se tornarem mão de obra escrava nas minas de <color=yellow>AxeOdion</color>",
					" Meus pais foram levados...",
					" Depois de um tempo eu soube do acidente... ",
					" Um desmoronamento matou um grupo de trabalhadores nas minas do imperador",
					" Meus pais estavam entre eles",
					" Desde então trabalhei entre as pessoas de Jadme para mudar a nossa realidade",
					" E mudar a nossa realidade é mudar tudo o que o império de Logan representa. Ou seja, precisamos inicialmente derrubar o império"
				}},
				{"liderNotavel",new List<string>()
				{
					" Agradeço pelo adjetivo de notável.",
					" O fato do meu nome ser conhecido em Orion se deve principalmente à minha objeção ao império de <color=orange>Logan</color>",
					" Na maioria das cidades deste continente os prefeitos são indicados pelo imperador.",
					" Apenas em algumas cidades a população vota para dar reconhecimento ao prefeito que geralmente não tem candidato de oposição",
					" Isso acontecia em Jadme também",
					" Mas a insatisfação das pessoas de Jadme com o império, principalmente pelo fechamento da ferrovia fez com que o aparecimento de uma oposição fosse natural",
					" Então eu assumi esse destino que foi imposto a minha frente, me candidatei e venci as eleições para prefeito",
					" Desde então tenho mostrado resistencia aos impostos abusivos e novas prisões para a escravidão",
					" E o que mais preocupa o Imperador são as ideias de democracia"
				}},
				{"maquinaDePropaganda",new List<string>()
				{
					"A maquina de propaganda do império é a forma como o imperador controla a opinião pública",
					" As <color=cyan>Luvas de Guarde</color> que eu e você usamos nesse momento se tornaram itens de uso obrigatorio, primeiro em Yoro e depois em toda a Orion",
					" Elas tem muitas utilidades como você deve saber. Uma dessas é transmitir informações editadas por canais autorizados",
					" O imperador é quem cede autorização para que informações sejam transmitidas",
					" A consequencia disso é que as informações são sempre transmitidas para serem favoráveis ao império",
					" Isso acontece tanto nas regiões dominadas por Logan, quanto nas que estão além de Yoro",
					" O controle da informação faz com que as revoltas contra as injustiças sejam entendidas como terrorismo ou baderna",
					" Se você não tomar cuidado com as informações que chegam a sua luva de Guarde...",
					" ...a sua luva de Guarde fará você amar os opressores e odiar os oprimidos"
				}},
				{"democraciaDeJander",new List<string>()
				{
					" Democracia é uma palavra que etimologicamente quer dizer poder ao povo",
					" Nossa corrente democratica quer o fim do império e que as intituições públicas/governamentais sejam coordenadas por comites populares",
					" O próprio povo a frente da administração de todo o coletivo",
					" Queremos o fim do poder centralizado e o fim de um império, país ou nação impondo-se sobre todo e qualquer povo",
					" Não podemos mais continuar sendo escravos dos imperialistas e aceitar isso como se não houvesse alternativa",
					" Temos que ser uma alternativa para nossos próprios destinos. E as ideias de democracia são essa alternativa."
				}},
				{"possoMeJuntarAJander",new List<string>()
				{
					" Se você treme de indignação perante uma injustiça no mundo, então somos companheiros",
					" O seu caminho tem uma direção voltada ao confronto e o movimento democrata está numa rota politica organizada",
					" Chegará uma hora que nossos caminhos irão se juntar para derrotar Logan.",
					" Por enquanto seu objetivo é juntar oito dos medalhões dos deuses, abrir a torre da vida eterna e derrotar Logan.",
					" Nós lhe daremos todo o apoio politico que precisar."
				}},
				{"Jadme1",new List<string>()
				{
					"Seja muito bem vindo a cidade de <color=yellow>Jadme</color>.",
					"Eu amo muito essa cidade! \r\n E poderia amar mais se não fosse um bebado vagabundo que fica se esgueirando na parte escura da cidade",
					"Tem um desocupado que me incomoda muito, ele se chama <color=orange>Salmo Sadol</color> era o maquinista do trem que levava a <color=yellow>Ofawing</color>.",
					"Depois da desativação da ferrovia algum tempo atrás ele não quis mais saber de trabalhar",
					"Esse tipo de gente me da nojo!!"
				}},
				{"Jadme2",new List<string>()
				{
					"Depois de atravessar o <color=yellow>Rio Mariinque</color> você pode encontrar a entrada do vulcão que é o caminho para a cidade de <color=yellow>Afarenga</color>",
					"Dentro do vulcão, ao norte de Afarenga, existe uma grande <color=yellow>Carvoaria</color>",
					"Nós de Jadme tinhamos muitas relações comerciais com o pessoal da carvoaria",
					"Foi uma lástima o fechamento da ferrovia."
				}},
				{"Jadme3",new List<string>()
				{
					"Ao norte de <color=yellow>Afarenga</color>, a cidade do vulcão, existe um curioso caminho de pontes que formam uma especie de Labirinto",
					"Esse caminho de pontes é conhecido por muitos como <color=yellow>O Segredo dos Sóis</color>",
					"Esse nome é devido a um mecanismo que pode mudar a direção para onde algumas pontes estão apontando. A chave que dispara esse mecanismo tem o formato de um Sol.",
					"O Segredo dos Sóis é o caminho para a <color=cyan>Arena de Laurense</color> o deus da força e da coragem",
					"Na Arena de Laurense você pode ganhar o medalhão da forja que representa o Deus da força."
				}},
				{"Jadme4",new List<string>()
				{
					"<color=orange>Guto Jander</color> é um heroi para nós de <color=yellow>Jadme</color>. \r\n Ele assumiu a cidade numa época muito conturbada, com vários problemas causados pelo fechamento da ferrovia",
					"Ele parecia um iluminado. Com seu discurso feroz contra o império e a proposta de cada povo ser o senhor de seu destino",
					"Eu adimiro muito o prefeito de Jadme e sua teoria da Democracia"
				}},
				{"Jadme5",new List<string>()
				{
					"Tem um sujeitinho meio pirado da cabeça que costumar dormir embaixo do viaduto do trem",
					"Eu sou novo na cidade, mas os mais velhos dizem que ele ficou louco depois que a esposa o abandonou",
					"Ele está sempre jogado em algum canto da cidade mesmo ele tendo uma casa por aqui.",
					"Tentei conversar com ele uma vez, mas ele não fala coisa com coisa.",
					"Começa a misturar histórias de trêm com alienigenas. É uma pena... ",
					"Um pobre homem, jovém e cheio de energia, assim afastado das suas capacidades mentais."
				}},
				{"Jadme6",new List<string>()
				{
					"Dentro do vulcão, ao norte da cidade de <color=yellow>Afarenga</color> fica a <color=yellow>Arena de Laurense</color>",
					"O clérigo de Laurense responsável pela arena é <color=orange>Drooper Rooligan</color>",
					"Ele é conhecido por ser um sujeito acido e altamente leal ao imperador <color=orange>Logan</color>",
					"sua especialidade são Criatures do tipo fogo",
					"Para ganhar o medalhão da forja, que homenageia Laurense, você deve derrotar Drooper numa batalha entre Criatures."
				}},
				{"Jadme7",new List<string>()
				{
				"Desde de o surgimento de <color=cyan>Armagedom</color> muitas coisas mudaram em Orion",
					"Ainda me lembro como se fosse ontem, as primeiras transmissões de informação pelos Armagedom's",
					"Hoje em dia os jornais impressos estão quase desaparecendo, naquela época eles eram unanimidade para que pudessemos nos informar sobre o que ocorria em Yoro e em todo Orion",
					"Hoje em dia com o advento das <color=cyan>Luvas de Guarde</color> não precisamos mais parar em frente a uma conexão com Armagedom para recebermos informações,",
					"podemos simplesmente usar nossas luvas de guarde para nos conectar às redes de informação disponivel, ler e assistir as noticias do mundo",
					"Mas junto com o poder de acesso a informação que veio com Armagedom nasceu também uma grande sombra pairando sobre os caminhos de Orion",
					"Para transmitir informação pela rede Armagedom era necessário uma licença expedida pelos imperialistas",
					"Para receber a licença dos imperialistas era necessário ser simpático ao império",
					"Graças a isso pouca informação critica ao império é disseminada por via de Armagedom",
					"<color=orange>Logan</color> e a administração da <color=orange>Garra Governamental</color> controlam quase todos os canais de transmissão de informação disponiveis",
					"Existe um canal controlado por <color=orange>Jack Bandit</color> o inventor das Luva de Guarde e das cartas Luva mas ele também é simpático aos imperialistas.",
					"Assim eles controlam a opinião publica",
					"Afinal ... Quem controla a opinião publicada, controla a opinião pública"
				}},
				{"Salmo1",new List<string>()
				{
					"Você veio me acompanhar?",
					"Pegue... Tome um gole você também",
					"Não vim beber com você. Fiquei sabendo que você é o maquinista do Trêm",
					"Eu era... Bons tempos aqueles...",
					"Minha alegria era quando o trem já estava chegando... \r\n Vinha Chegando na estação...",
					"Era o trem das 11 horas,\r\n O último na minha mão",
					"Tudo acabou quando eu o vi. Aquela luz",
					"parecia um sujeitinho esquisito.\r\n",
					"Acho que ele era alienigena",
					"Eu vi ele descendo do céu",
					"Essa desordem.. Eu sabia que isso iria acontecer.",
					"Ele desceu acima da <color=yellow>Torre da Vida Eterna</color>"
				}},
				{"Salmo2",new List<string>()
				{
					"Rapaz, andam dizendo por ai que fiquei louco",
					"Andam dizendo por ai que eu não bato bem. ",
					"Andam dizendo por ai que eu sou um estorvo para a sociedade",
					"Mas eu digo uma coisa rapaz:",
					"A arte de ser um louco é jamais cometer a loucura de ser um sujeito normal."
				}},
				{"Salmo3",new List<string>()
				{
					"Eu gostava muito de andar de trêm. Saldades S2",
					"Isso é bom Salmo. Por que preciso que você me leve para <color=yellow>Ofawing</color>",
					"Acho que eu não aguento te carregar nas costas daqui até lá não...\n\r Acho que estou muito bebado pra isso",
					"Não!!! Você está maluco? O que eu quero é que você me leve de trêm",
					"Eu tenho um segredo pra te contar!!!",
					"Faz alguns anos ...",
					"O imperador proibiu as viagens de trem na Ferrovia de Jadme",
					"Eu sei disso, mas preciso chegar até lá e me disseram que você é um dos poucos com conhecimento tecnico para operar o trêm",
					"Agora eu me emocionei ein... Nunca alguem combinou  as palavras conhecimento tecnico com a minha pessoa antes",
					"Vou até desenterrar uma garrafa de bebida que escondi aqui na areia pra comemorar isso",
					"Assim que eu lembrar onde enterrei a garrafa",
					"Como será que os cães fazem pra se lembrar?",
					"Então você  vai me ajudar com o trêm?",
					"Posso tentar , mas antes você precisa me arranjar uma boa quantidade de carvão",
					"É o combustivél do trêm!!",
					"Se eu não bebi de mais e minha memória ainda não foi destruída, acho que traziam isso da cidade de <color=yellow>Afarenga</color>",
					"Então vá até Afarenga compre uma boa quantidade de carvão e traga pra mim. Então eu irei te levar para Ofawing."
				}},
				{"Salmo4",new List<string>()
				{
					"Tudo bem, eu te ajudo a chegar a <color=yellow>Ofawing</color> de trêm",
					"Mas eu preciso que você vá para <color=yellow>Afarenga</color> compre e traga uma boa quantidade de carvão para abastecer o trêm"
				}},
				{"mustafAefik",new List<string>()
				{
					" Ola estranho!! Não é comum eu receber visitas por aqui",
					" Quem é você?",
					" Meu nome é <color=orange>Mustaf Aefik</color>, sou o sacerdote de <color=cyan>Turabá</color> o deus dos mistérios",
					" Posso sentir que há um deus em teu coração. Mas você duvida se esse deus ainda olha por ti e teme que ele não esteja satisfeito com você",
					" Eu vim aqui pelo capitão Aramis, preciso da condecoração que só ele pode me dar",
					" Foi um mistério você coincidir de procura-lo aqui e me encontrar",
					" Também é um misterio o teu destino. Se você for em frente muitos deuses olharão para você",
					" Por enquanto deve se concentrar na sua tarefa de encontrar o capitão, mas logo terá contato com grandes deuses",
					" Espere um momento, se você é um sacerdote de um deus deve ter um medalhão dele para me dar",
					" Apenas clérigos de arena podem lhe dar medalhões dos Deuses",
					" Esses são mistérios que voce ainda terá de descobrir",
					" Consiga a condecoração com o capitão que está dentro da piramide e siga o seu destino"
				}},
				{"AtosAramis",new List<string>()
				{
					" Vejam só... Surge alguém no meio desse breu!",
					" Estou procurando pelo capitão <color=orange>Atos Aramis</color>",
					" Sou eu... Quem é você? E por que está a minha procura?",
					" Sou Cesar Corean, preciso conversar com o Corenel <color=orange>Potus Ramos</color>, mas antes preciso de duas condecorações militares",
					" Me disseram que você poderiam me dar uma condecoração das duas que eu preciso",
					" Você é um sujeitinho muito valente Cesar Corean. Atravessar essa pirâmide não é pra qualquer um!!",
					" Aqueles Escorpions e Escorpireys me deram muita dor de cabeça!!",
					" Mas para receber a condecoração Alpha você deve me derrotar numa batalha de Criatures",
					" Você está pronto para me enfrentar??"
				}},
				{"AramisConversado",new List<string>()
				{
					" Para receber a condecoração Alpha você deve me derrotar numa batalha de Criatures",
					" Você está pronto para me enfrentar??"
				}},
				{"AramisNoMOmentoDaDerrota",new List<string>()
				{
					" Você é um treinador bastante habilidoso Cesar Corean. Faz honra ao mérito de receber a minha condecoração militar",
					" Cesar Corean recebe a <color=cyan>condecoração Alpha</color>",
					" Se você quer mesmo encontrar com o general <color=orange>Potus Ramos</color> na <color=yellow>Fortaleza de Infinity</color>",
					" Vá até lá com as condecorações Alpha e Beta que você conseguirá o que quer",
					" Boa sorte em sua missão soldado!!!"
				}},
				{"AramisDepoisDeDerrotado",new List<string>()
				{
					" Você é um treinador bastante habilidoso Cesar Corean. Faz honra ao mérito de receber a minha condecoração militar"
				}},
				{"conversaNaRepresa",new List<string>()
				{
					" Essa é a grande represa da Yoro de Orion.",
					" Ela é responsável pelo abastecimento de [agua de grande parte das planícies de Orion ",
					" Passamos por alguns problemas desde a ascensão das <color=cyan>gemas laranges</color> e as obcessões do imperador",
					" Uma grande parte das minas de Gemas ficam próximas à cidade de <color=yellow>AexeOdion</color> que fica ás margens do rio atrás da represa",
					" E a poluição das minas está contaminando a nossa água",
					" Parece mesmo que <color=orange>Logan</color> realmente enlouqueceu.",
					" Infelizmente não podemos deixar você entrar. A represa é administrada pela <color=yellow>Garra Governamental</color>",
					" Sem a permissão deles, você não pode entrar."
				}},
				{"manutencaoDasTubulacoes",new List<string>()
				{
					"Essa é a porta utilizada pela equipe de manutenção para entrar nas tubulações submersas no rio",
					"Para abrir essa porta eles tem um cartão magnetico que foi expedido pela <color=yellow>Garra Governamental</color>"
				}},
				{"entradaDaPetrolifera",new List<string>()
				{
					"Parece que um dos operarios da Petrolifera começou a se sentir sozinho e para suprir sua solidão começou a criar insetos.",
					"Porém... Os insetos começaram a se multiplicar e se espalharam por toda a petrolifera",
					"A situação ficou critica quando o cara arrumou alguns pergaminhos que ensinam a habilidade Sabre para os Criatures que podem aprender",
					"Depois de ensinar essa habilidade para alguns <color=cyan>Iziculos</color> eles começaram a cortar o metal da Petrolifera",
					"Não sabemos o que fazer com esse problema!!"
				}},
				{"entrarNoCruzador",new List<string>()
				{
					"O Cruzador de Guerra está aberto para visitações.",
					" Gostaria de fazer uma visita ao cruzador de guerra por <color=cyan>100 Cristais</color>?"
				}},
				{"trancaRua",new List<string>()
				{
					"parece que o mundo acabou aqui"
				}},
				{"parteFunda",new List<string>()
				{
					"<color=yellow>OPS!!</color> \r\n É melhor tomar cuidado para não cair na parte profunda do rio"
				}},
				{"menuPreJogo",new List<string>()
				{
					"Novo Jogo","Carrega Jogo","Fechar o Jogo"
				}},
				{"mitPrincipal",new List<string>()
				{
					"Status","Itens","Suporte","Organizaçao","Salvar"
				}},
				{"mitOrg",new List<string>()
				{
					"Criatures","Golpes","Itens Rapidos"
				}},
				{"mitSoltos",new List<string>()
				{
					"<color=orange>novo Save</color>",
					"O criature ",
					" esta desmaiado e não pode caminhar ao teu lado",
					"Esse Criature não tem nenhuma habilidade de Suporte",
					"Você nao tem nenhum item no momento.",
					"CRISTAIS: \r\n ",
					"O processo de save foi realizado",
					"Você não tem outros Criatures para Organizar"
				}},
				{"painelStatus",new List<string>()
				{
					"Tipo:   ",
					"tempo de Reaçao: ",
					"Status:     ",
					"     Nv: ",
					"PV : ",
					"PE : ",
					"Poder : ",
					"Forca : ",
					"Defesa : ",
					"Nivel : "
				}},
				{"nomeieSave",new List<string>()
				{
					"Escolha um nome para seu Save",
					"Click na caixa de Texto",
					"cancela",
					"Click no botao ou press ESC no teclado",
					"Click no botao para confirmar o SAVE",
					"confirma",
					"não nomeado"
				}},
				{"itens",new List<string>()
				{
					"Voce não pode usar esse item nesse momento.",
					"Ele não precisa usar esse item nesse momento.",
					"O criature {0} está desmaiado e não pode usar esse item nesse momento.",//O {0} será substituito pelo nome do Criature
					"Somente Criatures do tipo "," podem usar esse item",
					"O criature {0} não pode usar o item {1} pois ele já sabe o golpe {2}",
					"O Criature {0} não pode aprender o golpe {1}",
					"{0} não usou o item {1}",
					"Tem certeza que deseja usar o item {0} ?",
					" Cesar Corean não pode usar esse item nesse local"
				}},
				{"apresentaInimigo",new List<string>()
				{
					"Voce encontrou um ",
					"</color> nivel: ",
					"PV: ",
					"PE: ",
					" O treinador {0} vai utilizar um"
				}},
				{"listaDeItens",new List<string>()
				{
					/*ID==0*/"Maçã", "Burguer", "Carta Luva",
					"Gasolina","Água Tônica",/*ID==5*/"Regador","Estrela","Quartzo","Adubo",
					"Seiva",/*ID==10*/"Inseticida","Aura","Repolho com Ovo","Ventilador","Pilha",
					/*ID==15*/"Gelo Seco","Pergaminho de Fuga","Segredo","Estatua Misteriosa",
					"Cristais","Pergaminho de Perfeição","Antidoto","Amuleto da Coragem","Tônico",/*ID = 24*/
					"Perg. Rajada de Agua","Pergaminho de Saída","Condecoração Alpha"
				}},
				{"shopInfoItem",new List<string>()
				{
					" Maçã recupera 10 PV de um Criature",
					" Burguer recupera 40 PV de um Criature",
					" Carta Luva é usada para tentar capturar novos Criatures",
					" Gasolina recupera 40 PE de um Criature do tipo Fogo",
					" Água Tônica recupera 40 PE de um Criature do tipo Água",
					" Regador recupera 40 PE de um Criature do tipo Planta",
					" Estrela recupera 40 PE de um Criature do tipo Normal",
					" Quartzo recupera 40 PE de um Criature do tipo Pedra",
					" Adubo recupera 40 PE de um Criature do tipo Terra",
					" Seiva recupera 40 PE de um Criature do tipo Inseto",
					" Inseticida recupera 40 PE de um Criature do tipo Inseto",
					" Aura recupera 40 PE de um Criature do tipo Psiquico",
					" Repolho com Ovo recupera 40 PE de um Criature do tipo Gás",
					" Ventilador recupera 40 PE de um Criature do tipo Voador",
					" Pilha recupera 40 PE de um Criature do tipo Eletrico",
					" Gelo Seco recupera 40 PE de um Criature do tipo Gelo",
					" Quando lido esse pergaminho invoca uma magia para expulsar o oponente da luta ",
					" Um item muito suspeito encostado no fundo da loja",
					" Uma estatua feita de pedra amarelada em pose imponente",
					" É o dim dim do jogo",
					" Quando lido esse pergaminho o criature alvo recupera totalmente os PVs e os PEs além de remover os status negativos ",
					" O Antidoto cura Criatures que estão envenenados ",
					" O Amuleto devolve a coragem para Criatures amedrontados ",
					" O Tônico cura Criatures paralisados",
					" O pergaminho de Rajada de Agua ajuda um Criature do tipo Agua a aprender o golpe Rajada de Agua",
					" Pode ser usado em lugares fechado para te teletransportar para fora",
					" A condecoração que Cesar Corean recebeu do Capitão Atos Aramis."
				}},
				{"entradinhaPlus",new List<string>()
				{
					"Ele Chegou!",
					"Então... . É você que veio juntar-se a  nós?",
					"Olá! Eu sou <color=orange>Cesar Corean</color>.\r\n Sinto que há algo errado com o rumo que as coisas estão tomando e isso não me deixa em paz para seguir o caminho natural da minha vida.",
					"Por isso decidi me juntar a vocês",
					"Meu nome é <color=orange> Caesar Palace</color>. Sou o líder do levante popular contra o imperador que começou na <color=yellow>cidade de Infinity</color>",
					"Os dois que estão comigo são importantes membros da resistencia ao império",
					"Esse é <color=orange>Lance Lutz</color>. Lance é um importante estudioso formado na universidade da predominância",
					"É um sociologo, cientista social e pessoa muito influente entre os pensadores e movimentos sociais de Orion",
					"Esse é <color=orange>Random Hooligan</color>. Ele é membro de uma tradicional familia aristocratica de Orion. Seu irmão é um clérigo da coragem e regente de uma arena de Criatures.",
					"Nós estamos tentando abrir a <color=yellow>Torre da Vida Eterna</color> e encarar <color=orange>o imperador Logan</color> para mudar o destino de Orion",
					"O caminho para isso é muito longo e muito difícil, você precisa de muita determinação para percorrer todo o caminho",
					"Nós estamos apenas no meio do caminho um tanto quanto sem rumo mas já temos algumas lições para tirar da nossa trajetória.",
					"Rapaz, todos os que querem fazer uma tarefa difícil tem um começo.\r\n E só quem já está no meio do caminho sabe como é dificil começar.",
					"Por isso vamos te ajudar",
					"Vou te indicar o caminho do <color=yellow>Armagedom de Infinity</color>, lá você poderá pegar um CRIATURE e iniciar sua jornada",
					"Venha Conosco!",
					"Vamos nos dividir agora!",
					"Lance está indo para a cidade <color=yellow>Ofawing</color> conversar com nossa base social proxima das administrações governamentais",
					"Hooligan irá para <color=color>Afarenga</color> organizar as massas religiosas que estão insatisfeitas com o imperio",
					"Você continua comigo, estamos indo para a cidade de <color=yellow>Infinity</color>.",
					"Por enquanto vou passar um dos meus Criatures para a sua luva, essa caverna é perigosa e é bom que você se defenda.",
					"Venha comigo.",
					"Continue me seguindo!! Estamos perto do tunel que leva a <color=yellow>Infinity</color>",
					"Quem é ele?",
					"Cesar Corean, vou precisar que você me devolva os Criatures. \r\n Faça isso e continue em frente. Esse caminho te levará até a cidade de Infinity",
					"Ele é perigoso?",
					"Esse é <color=orange>Glark Ganovan</color>, ele é responsável por caçar, prender e/ou eliminar os inimigos do império.",
					"Então...\n\r Você é o famoso Caesar... Ratos como você sempre podem ser encontrados no subterrânio",
					"Vá Corean. Você deve contar para os outros sobre esse encontro, caso eu não consiga.",
					"Não posso te deixar enfrenta-lo sozinho",
					"Não me entrego sem lutar!!",
					"Você não terá tempo para lutar!!"
				}},
				{"tuto",new List<string>()
				{
					"Seu CRIATURE FelixCat sofreu um dano alto! Você pode usar uma maçã para recuperar seus pontos de Vida",
					"nao use esse item ainda",
					"Vampire ficou com apenas 1 ponto de Vida, você pode tentar captura-lo. Selecione o item <color=cyan>Carta Luva</color>",
					"Utilize a Energia de Garras",
					"Selecione a Carta Luva utilizando:",
					"Pressione para usar a Carta Luva",
					"Muito Bem Cesar Corean. Você capturou um novo Criature"
				}},
				{"entradinha_elaborada",new List<string>()
				{
					"Cesar Corean sobreviveu à queda...",
					"... mas Caesar não teve a mesma sorte.",
					"Foi esmagado pelas pedras que desmoronaram",
					"Ainda na ponte Caesar disse a Cesar que a cidade de Infinity estava próxima.",
					"E em Infinity, Corean poderia pegar um Criature no Armagedom para iniciar sua trajetoria em direção de abrir a <color=yellow>Torre da Vida Eterna</color> e confrontar o imperador <color=orange>Logan</color>",
					"Cesar Corean então segue em direção a <color=yellow>Infinity</color>"
				}},
				{"estatuaMisteriosa",new List<string>()
				{
					"Cesar Corean coloca a estatua misteriosa na base a frente da pirâmide",
					"A porta da Pirâmide se abre",
					"Parece a base de uma estatua",
					"Então é a estatua que mantém a porta aberta"
				}},
				{"bau",new List<string>()
				{
					"Você encontrou um báu. Quer abri-lo?",
					"O báu está vazio",
					"Dentro do báu Cesar Corean consegue <color=cyan>{0} {1}</color>"
				}},
				{"status",new List<string>()
				{
					"<color=orange>Atenção</color>\r\n Seu Criature {0} desmaiou por envenenamento",
					"Seu Criature {0} sofreu {1} PV de dano por envenenamento",
					"O criature Inimigo sofreu {0} PV de dano por envenenamento"
				}},
				{"movimentoBasico",new List<string>()
				{
					"O uso de item está recarregando. Próximo uso de item em {0}",
					"Golpe em tempo de recarga. \r\n{0}\r\n até o próximo uso. ",
					"{0} esta desmaiado e nao pode sair para continuar a luta"
				}},
				{"ive",new List<string>()
				{
					
				}}
				
			}
		},
		{"en-google",
			new Dictionary<string,List<string>>(){
				{"bomDia", new List<string>()
					{
						"Good Morning to you",
						"Good Morning to you",
						"Good Morning ",
						"Good Morning to you"
					}},
				{"infinity1", new List<string>()
					{
						"The south of here there is a town called Ive",
						"There are some stores",
						"Maybe you'll find something that interests you there"
					}},
				{"infinity2", new List<string>()
					{
						"What's with this outfit boy?",
						"who are you trying to fool?",
						"If the <color=yellow> government claw </color> get dressed so you do not even want to know what will make you"
					}},
				{"infinity3", new List<string>()
					{
						"If you head south from here, in a small mountain in the middle of the valley, you can see the <color=yellow> Stealer fortress </color>",
						"A long time ago, even before <color=orange> Logan </color> become the emperor, this plain was the bed of the river Mariinque",
						"As the river Mariinque had wide and deep bed, and besides, flows into the sea",
						"It was an open door for the conquerors of other continents,that landed here in the heart of our continent Yoro",
						"The Stealer Fortress was built to defend Yoro from this type of attack,",
						"Today it has became one more a base at the service of the imperialists."
					}},
				{"infinity4", new List<string>()
					{
						"The legends of Orion say that the emperor is one chosen from the Gods themselves to lead his people in the universe paths.",
						"And the <color=yellow> Tower of Eternal Life </color> is the proof of that,",
						"The Tower of Eternal Life is a fortress that was closed by the choice of the Gods of Orion",
						"Apparently, there are only two ways to enter the Tower",
						"The first is to have the permission of the emperor himself,",
						"The second way is joining eight medallions of the Gods",
						"Joining eight of medallions of the gods and putting the medallions on the front panel of Eternal Life Tower the door will open,",
						"At least that is what they say !! I know of no possessor of eight medallions of the Gods. The most I have ever seen with a single person were five.",
					}},
				{"infinity5", new List<string>()
					{
						"Following to the west of the city Ive you will meet with the River Mariinque",
						"After the construction of the dam the river's course was changed. \r \n The change in the course of the river angered God <color=cyan> Drag </color>, the waters of God.",
						"To give a lesson to the mortals who played god changing the course of a work of nature, Drag caused the New River Mariinque was even deeper than the last and its margin even wider.",
						"In the depth of the river the followers of Drag built a divine arena",
						"In the <color=yellow> divine Arena Drag </color> you can get the medallion of the waters."
					}},
				{"infinity6",new List<string>()
					{
					"Welcome stranger, here is the city of <color=yellow> Infinity </color>",
					"This city is known for being the starting point for many adventurers",
					"You may have heard of Alpha coach, Beta coach and Epsolon Coach, haven't you??",
					"No I haven't",
					"Not really?",
					"At least you must have heard of Criature tamers of Atilio:. Dantas, Boni, Grids and Lara",
					"No I Haven't !! ?? !! For Gods sake In what world do you live?",
					"Are you realy a citizen of Orion?"
					}},
				{"infinity7",new List<string>()
					{
						"You're going out on a journey across the plains of Infinity?",
						"Don't you know that the Criatures are angry and are attacking travelers?",
						"You are trusting that their Criatures can defend you from Criatures scattered across the plains?",
						"Is best for you not to get out from Infinity !! Trust me !!",
						"You will not want to be hit by Marak!",
						"It will not able to sit for several days !!"
					}},
				{"infinity8",new List<string>()
					{
						"The Emperor <color=orange> Logan </color> for many years (almost all of its empire) was a righteous man and led the people of Yoro Orion to prosperity",
						"A couple of years ago the course of the empire changed.",
						"The obsession with <color=cyan> Laranges gems </color> took Logan to adopt slavery as labor in the mines,",
						"Most of the prisoners were taken to the mine <color=yellow> AxeOdion </color>, bandits, robbers, murderers, all types of criminal.",
						"But that didn't fulfilled the emperor greed.",
						"He increased the collection of taxes in the cities of the empire. \r\n This led citizens to misery, which led them to prison, and later, some were taken to forced labor in the mines.",
						"So the emperor could more slaves.",
						"I'm afraid that one day my time come !!"
					}},
				{"infinity9",new List<string>()
					{
						"In the predominance of the desert there is a great University. \r\n In it there are large renowned scholars in Orion",
						"While most people believe that the sudden greed that sparked the Emperor in recent years has mystical origins. \r\n The social scientists at the University has another explanation,",
						"They say we noticed that the emperor greed just now because we are going through a time of intensification of class struggles",
						"The elite of the empire increasingly want <color=cyan> Laranges gems </color> and other precious stones, this causes a growing demand for primary hand work",
						"The need for labor led the empire to adopt slavery. And these unpopular measures led the lower classes to organize against the tyranny of the empire.",
						"They tell you: \n \r The history of mankind until the present day is the history of class struggle.",
						"I do not quite understand about it, but it makes a lot of sense when we hear a scholar talking about.",
					}},
				{"infinity10",new List<string>()
					{
						"You want to enter the <color=yellow> Tower of Eternal Life </color>? And face <color=orange> Logan </color> to question the evils of slavery and greed he shoots against us?",
						"I can not say anything more than that: You are a dreamer.",
						"I know you're not the only and is not difficult to imagine dreaming along with you for a world that is fair",
						"But we need to take our lives, we have our jobs, our bills, our families. I can not really just go out in the world squaring off against an emperor who leads an army.",
						"But if you really want to embark on a search for medallions and face Logan, I have a tip to give you",
						"There is a way to the arena of <color=cyan> Drag </color> from the sewage pipes.",
						"East of the <color=yellow> Stealer  fortress </color> you can find a huge departure from the sewers",
						"I believe that this is the first course that you should take."
					}},
				{"infinity11",new List<string>()
					{
						"The person responsible for <color=yellow> Stealer  fortress </color> is the general <color=orange> Potus Ramos </color>. Below him in the military hierarchy of the fortress are two captains",
						"One is known as <color=orange> Captain Herringbone </color>. Currently the Herringbone captain is fulfilling its mission of taking care of the <color=yellow> War Cruiser </color> that is coming to Mariinque river. ",
						"The other is the <color=orange> Captain Atos Aramis </color> that was sent to a mission inside the <color=yellow> pyramid </color> which is in the desert <color=yellow> Jadme </color> ",
						"Both captains carry decorations that deliver citizens who do honor to the substance. \n\r Citizens who have the decorations of the Herringbone Captain and captain Aramis has free access to enter the fortress."
					}},
				{"infinity12",new List<string>()
					{
						"Today all children are born playing with the technologies offered by <color=cyan> Armageddon </color>.",
						"but was not always like !! \n \r In my time not all used the <color=cyan> Store gloves </color>",
						"The invention of <color=orange> Jack Bandit </color> changed the way people relate and even the way we live in Orion.",
						"Later came the <color=cyan>Gloves Card</color>. \r \n Small letters when embedded in the glove Save increase the power of <color=cyan> Laranje Gem </color>.",
						"This increase in power is used by collectors/Criatures coaches to trap new Criatures",
						"You already imprisoned one Criature using a Glove Card??"
					}},
				{"infinity12respostas",new List<string>()
					{
						"To help you in your first catch I have something for you. \r\n <color=yellow> 5 </color> glove card",
						"It's exciting to be a catch right?",
						"Strange ... It seems to me that you only have this Criature who is walking behind you,",
						"You rascal right? Are you trying to trick me !!",
						"I hope you can capture many Criatures. \r \n Good luck on your journey"
					}},
				{"simOuNao",new List<string>()
					{
						"Yes",
						"No"
					}},
				{"ive1",new List<string>()
					{
						"If you go west of here you will arrive at <color=yellow> Mariinque river. </color>",
						"Once you go over the mountains will soon see the <color=yellow> Tower of Eternal Life </color>",
						"On top of the tower stands the castle of the emperor",
						"Sure that's where you want to go?"
					}},
				{"ive2",new List<string>()
					{
						"Welcome to the city of <color=yellow> Ive </color>",
						"Our city has always been prosperous due to the trade route connecting the city of <color=yellow> Afarenga </color> inside the volcano across the river Mariinque,",
						"the city of <color=yellow> Ofawing </color> which is beyond the railway of <color=yellow> Jadme </color>.",
						"But it seems that the winds blow does not blow in our city favor,",
						"A few years ago <color=orange> Logan </color> ordered the closing of the railway Jadme",
						"This reduced the flow of travelers, as they could no longer reach Ofawing by this route,",
						"And recently a landslide closed the volcano entrance that led to the Afarenga",
						"Our trade route has gone from bad to worse."
					}},
				{"ive3",new List<string>()
					{
						"In the middle of the <color=yellow> river Mariinque </color> there is an oil-drilling platform.",
						"The <color=yellow> Oil-drilling platform </color> is responsible for fueling several plains of Orion",
						"But lately they go through serious problems.",
						"Some compartments of oil were taken by Criatures <color=orange> Iziculos </color>.",
						"Iziculos are small insects criatures cutters who like to live in damp, dark places",
						"carry a bat and the bat can learn powerful skills sharp enough to cut steel bars",
						"I think the Oil is in serious trouble",
					}},
				{"ive4",new List<string>()
					{
						"The sewers that run beneath this plain are home for disgusting Criatures.",
						"Travellers who used the east road of the <color=yellow> Fortress </color> always have stories to tell about insects that leave the sewer pipes in those parts.",
						"In view of this problem, the public administration of <color=yellow> Government Claw </color> put bars in sewer pipes for Criatures not come out of there,",
						"But that does not completely solve the problem,",
						"Some criatures bearing canes can use the ability <color=cyan> Cane Sabre </color> and with it cut the sewer isolation bars",
						"The Claw Government is always replacing the sewer grates, but from time to time appears a new opening caused by Criatures."
					}},
				{"ive5",new List<string>()
					{
						"Moored on the banks of <color=yellow> river Mariinque </color> is the <color=yellow> War Cruiser </color>.",
						"The cruiser war is a ship built to defend the continent of Yoro invasions of other continents.",
						"With the extend of peacetime, the Cruiser became less useful for territorial defense issues.",
						"So the military decided to open the Cruiser for visitation by 100 CRYSTALS.",
						"They want to fool us saying it's for the people to know the safety devices that protect us, but I believe they are the same is wanting to earn some change",
						"Possibly are going through a financial crisis as it keeps a war equipment needing maintenance and virtually useless."
					}},
				{"ive6",new List<string>()
					{
						"The technology <color=cyan> Armagedom </color> was created a few decades by the emperor himself <color=orange> Logan </color> when he was a student of the university in the desert of predominance.",
						"With Armageddon's we carry our items a Armageddon to another in the various offices that are scattered Orion.",
						"This is fascinating !!",
						"All this using only the energy provided by a mineral found in very Orion: the <color=cyan> Laranges gems </color>.",
						"After Logan, many scientists worked on improvements for Armageddon.",
						"The possible mass being transported was expanded and the communication system between Armageddon's evolved much since Logan",
						"But the greatest contribution of Armagedom technology, without a doubt, was made by a young scientist and current millionaire: <color=orange> Jack Bandit </color>", "his invention was nothing more nor less than the <color=cyan> Store Glove </color>. ",
						"With the glove Store we carry our items within a Larange Gem positioned in our gloves.",
						"And the most amazing thing of Save gloves is the ability to upload a number of live Criatures",
						"No wonder everyone in Orion is required to use Store gloves "
					}},
				{"ive7",new List<string>()
					{
						"If you follow through the eastern mountains you will come to the city of <color=yellow> Hadjek </color>.",
						"Hadjek is obligatory passage for all travelers who follow the target <color=yellow> Jadme </color>.",
						"In Jadme desert there is a rather curious pyramid. They say the older she is actually a temple to <color=cyan> Turabá </color>, the god of the Mysteries.",
						"The <color=orange> Captain Aramis </color> was sending a mission inside the pyramid.",
						"I suspect he is looking for some Turabá priest there. It would be the search of the revelation of the mystery of the unusual behavior of the emperor?"
					}},
				{"ive8",new List<string>()
					{
						"At the bottom of the river Mariinque clerics <color=cyan> Drag </color> built an arena for the god of the waters.",
						"The person responsible for <color=yellow> arena Drag </color> is <color=orange> Omar Water </color>.",
						"They say the legends of Orion, which after switch travel Mariinque river to the dam's construction, Drag invoked his followers to build monuments on the river bottom.",
						"By the will of Drag, the New River, the river diverted from its course, became deeper and wider than the previous one.",
						"A few generations have passed since the incident and then Omar is here to stay ahead of the arena",
						"They say he and his wife heard the voice of Drag them delegating the responsibility of governing the arena of Rio Mariinque",
						"I am very skeptical about religion, I believe these stories only reinforce the myth of the gods to keep their followers."
					}},
				{"ive9",new List<string>()
					{
						"The path to the castle of the emperor, the <color=yellow> Tower of Eternal Life </color>, is closed by the agreement of the god Orion to protect the emperor who is responsible for lead your people to prosperity",
						"However, the gods did not give the emperor unwavering protection,",
						"By the will of the gods, a citizen of Orion that have eight medallions of the gods can open the gates of the Tower of Eternal Life and climb the tower to meet the emperor",
						"To gain the medallions of the gods only one way: Find the arenas of the gods and challenge their rulers for a fight between Criatures",
						"Win one arena regent, in the arena of a god, you can make the medallion of God.",
						"The gods gave the chance for a decent citizen could dismiss one not worthy emperor",
						"But I think they forgot the part that the emperor leads an army !!"
					}},
				{"ive10",new List<string>()
					{
						"The <color=yellow> Dam </color> that is east of the city of <color=yellow> Infinity </color> is responsible for the water supply of most plains of Orion, it supplies all the plains of Yoro. ",
						"In Mariinque river, there is a <color = yellow> pipe </ color> closed by a record. These tubes extend much for Orion.",
						"Maybe inside the pipes you can reach the plains that are not accessible traveling by land.",
						"The control of records of pipes Orion are at the headquarters of <color=yellow> Government Claw </color>."
					}},
				{"ive11",new List<string>()
				{
					"The road to the city of <color=yellow> Afarenga </color> has been blocked by a landslide in a while.",
					"The emperor's army <color=orange> Logan </color> together with the utility sections of <color=yellow> Government Claw </color> are mobilizing to clear the way",
					"According to the news flowing in Orion, General <color = orange> Potus Ramos </ color> Fortress Stealer already has his disposal a sufficient quantity of explosives to carry out the task",
					"What prevents the service is a standoff between the imperialist entities Orion, the army led by Ramos expects labor of Governmental and Governmental Claw Claw expects the labor is applied by the army",
					"As the material is with General Ramos, maybe he needs only delegate that responsibility to someone you trust",
					"You do not want to apply?"
				}},
				{"ive12",new List<string>()
				{
					"The history of the construction of the <color=yellow> Stealer fortress </color> is very old and passing from generation to generation.",
					"So many versions have information that do not agree.",
					"The elders say that the name of the fortress \" Stealer \" is named after the eponymous Criature,",
					"Because the forest around the fortress was full of these Criatures",
					"However, the Stealer \'s cast lightning against travelers crossing the forest",
					"Therefore, since the construction of the fortress through the military uptime her Stealers were rounded up and exterminated.",
					"Today there are more Stealers in forest fortress.",
					"Curious that Criature who named the fortress was destroyed precisely because of the existence of the fortress",
					"Some people say they have seen electric Criatures in forest Fortress, but most people do not believe these rumors,",
					"People who say this usually are lying to gain fame."
				}},
				{"armagedomDeInfinity",new List<string>()
				{
					"Hello stranger !! \r \n Welcome to Infinity of Armagedom. \r \n How can I help you?",
					"There is no Criature of your saved at Armagedom at the time."
				}},
				{"opcoesDeArmagedom1",new List<string>()
				{
					"Heal Criatures ", "Your Criatures at Armagedom ", "Cancel"
				}},
				{"falasDeArmagedom",new List<string>()
				{
					"You withdrew <color=yellow>",
					"</color> Level: ",
					" Criature of your group and entered <color=yellow>"
				}},
				{"Shop1",new List<string>()
				{
					"Hello Stranger !! I have excellent goods to you,",
					"Thank you for your visit and come back to our store.",
					"<color=red> OPS !! </color> \r \n You do not have enough money to buy this item"
				}},
				{"hospital",new List<string>()
				{
					"Hello Stranger !! I can heal their wounded Criatures. \r \n Would you like to cure them by",
					"Crystals",
					"You do not have enough crystals at the time. But do not worry we are here ready to meet the medical oath so you get the amount needed",
					"It seems to me the health of their Criatures is perfect. You are to be congratulated for good work in caring for their Criatures",
					"I hope to see him again, weird !!"
				}},
				{"igreja",new List<string>()
				{
					"Hello Stranger !! I can make a mixture of herbs that can wake your Criatures passed out. \r \n Would you like to apply for any of your Criatures ??",
					"The Criature that you apontaste me is not passed out. He does not need a garrafada to awaken",
					" A cost mixture for this Criature ",
					" Crystals ",
					" I hope to see him again, weird !! ",
					" If you have no resources will have to get them to pay me ",
					" Your Criature ",
					" Awake and ",
					" Life points "
				}},
				{"mensLuta",new List<string>()
				{
					"You can not use this item at this time.",
					"Cesar Corean uses "
				}},
				{"encontros",new List<string>()
				{
					"What Criature go out to continue the battle?",
					" Was defeated ",
					" Fainted and this can not continue the fight, ",
					"All Criatures Cesar Corean were defeated. \r \n \r \n Cesar Corean must now return to Armageddon to renew the energies of their Criatures and return to your adventure",
					"<color=red>OPS!</color> \r\n You do not have EP Enough ."
				}},
				{"tentaCapturar",new List<string>()
				{
					" Resisted the attempt to capture. ",
					" The glove save Cesar Corean so can carry, ",
					" Then: ",
					" Level ",
					" was sent to ",
					" Cesar Corean managed to capture a "
				}},
				{"menuPausa",new List<string>()
				{"Return to Game",
				"Buttons",
				"Back to the Title",
				"Closing the Game"
				}},
				{"semHadjek",new List<string>()
				{
					"This is the path to the city of <color=yellow> Hadjek </color>",
					"However, this version ALPHA this map is not yet implemented"
				}},
				{"semMariinque",new List<string>()
				{
					"This is the path to the <color=yellow> Rio Mariinque </color>",
					"However, this version ALPHA this map is not yet implemented"
				}},
				{"entradinha",new List<string>()
				{
					"So .... It is you who came to join us?",
					"I feel there is something wrong with the way things are going and it does not leave me alone to follow the natural course of my life.",
					"So I decided to join you,",
					"We are trying to open the <color=yellow> Tower of Eternal Life </color> and face <color=orange> Logan </color> to change the Orion destination",
					"The road to it is very long and very difficult, you need a lot of determination to go all the way",
					"We're only halfway somewhat aimlessly but we already have some lessons to take our history.",
					"Boy, all they want to do a difficult task has a beginning. \r \n And who is now only halfway know how difficult start.",
					"So we'll help you,",
					"I'll show the way the <color=yellow> Infinity Armagedom </color>, there you can catch a CRIATURE and start your journey"
				}},
				{"apresentaFim",new List<string>()
				{
					" Won !! ",
					" The victory ",
					" Received ",
					" <color=#FFD700> experience points. </color> ",
					" and ",
					" Received ",
					" <color=#FF4500> CRYSTALS </color> ",
					" Could ",
					" achieve ",
					" <color=yellow> Level ",
					" </color> ",
					" Learned ",
					" Reuse time: ",
					" s \r \n Basico Attack: ",
					" \r \n PE Cost: ",
					" Can Learn: ",
					" <color=orange> To this must forget an attack !! </color>",
				}},
				{"encontrosScript",new List<string>()
				{
					"<color=orange> Not learning </color>",
					" Forget to learn <color = yellow>",
					" Forgot	",
					"	Not learned	"
				}},
				{"Hadjek1",new List<string>()
				{
					"Hoje os mais jovens reclamam que a mão do imperador está ficando cada vez mais pesada",
					"Dizem que o imperador está numa fase de restrições dos direitos individuais",
					"Dizem que muitos são presos e/ou agredidos pelos guardas imperiais",
					"Eu acredito que quem está sendo preso ou apanhando é porque é vagabundo mesmo",
					"Vejam só...\r\n Eu que sou um homem de bem não tenho nada do que me queixar sobre império de <color=orange>Logan</color> e da ação da <color=orange>Garra Governamental</color>",
					"Eu sou dono de alguns imóveis que estão alugados e com o dinheiro do aluguel pago os impostos e levo minha vida modesta",
					"Quem apanhou dos soldados do império é porque é vagabundo e quer viver sem trabalhar",
					"Eu quero mais é que o império de Logan dure por mais longos anos e esses revolucionarioszinhos sustentados por mamãe vão parar no presidio de <color=yellow>Cyzor</color>"
				}},
				{"Hadjek2",new List<string>()
				{
					"Bem-Vindo a cidade de <color=yellow>Hadjek</color> forasteiro!!",
					"Até bem pouco tempo, nós recebiamos turistas e estudiosos que vinham conhecer nossa água.",
					"As historias que passam de geração para geração é que nossas aguas tem propriedades medicinais porque são uma benção dada por <color=cyan>Ananda</color> Deusa da pureza e das vírtudes humanas",
					"Nenhum cientista que viajou da universidade no deserto da Predôminancia até aqui conseguiu concluir nada sobre a agua de Hadjek",
					"Todos eles sempre concluem que nossa água é comum, igual a água de qualquer Oasis no deserto",
					"Mas cientistas são céticos e talvez por isso não consigam aceitar a grandeza que é a benção de um Deus sobre a vida das pessoas menos afortunadas."
				}},
				{"Hadjek3",new List<string>()
				{
					"Tenho muito medo de seguir para o Norte",
					"O caminho entre a cidade de <color=yellow>Hadjek</color> e a cidade de <color=yellow>Jadme</color> se tornou um lugar perigoso",
					"Alguns bandidos que fugiram dos trabalhos forçados nas minas de <color=yellow>AxeOdion</color> encontraram esconderijos entre as montanhas do deserto",
					"Suspeita-se que reunem-se no esgoto",
					"Esse grupo de criminosos se auto proclama <color=orange>Tatus Peçonhentos</color> e costumam abordar viajantes no caminho de Jadme",
					"Se for para o Norte tome muito cuidado"
				}},
				{"Hadjek4",new List<string>()
				{
					"A norte daqui existe uma grande <color=yellow>Piramide.</color> Alguns mais idosos dizem que é um Templo para <color=cyan>Turabá</color> o Deus dos Mistérios",
					"Porém, poucos tentam entrar na piramide por causa das armadilhas e dos cachorros mumia",
					"Sim!! Cachorros mumia, eu não estou brincando com você! Sou uma pessoa muito séria",
					"Na verdade eles são Criatures do tipo gás.",
					"Nesses últimos anos com o surto de agressividade dos Criatures, eles começaram a sair da pirâmide e atacar viajantes que passam próximos",
					"Tenho medo deles, mumias me lembram morte e morte me lembra fantasmas. Não quero ser uma pessoa assombradas por entidades de outros mundos."
				}},
				{"Hadjek5",new List<string>()
				{
					"Sempre fui um grande devoto dos deuses de Orion e admiro muito <color=cyan>Turabá</color> o deus dos mistérios",
					"Quando viajo para <color=yellow>Jadme</color> sempre desvio um pouco a minha rota para a <color=yellow>Piramide</color> para orar em honra a Turabá",
					"Nunca entrei na piramide, sempre tive vontade de encontrar o sacerdote de Turabá que vive lá dentro",
					"Você deve estar se perguntando por que eu nunca entrei lá, e a verdade é, eu nunca achei que escaparia das armadilhas da piramide sem me ferir",
					"Sempre tive medo até de morrer no percurso. Com esse medo a idade foi chegando e agora mesmo que tenha vontade não tenho mais energia para encarar os desafios da piramide",
					"E existe mais uma complicação: A porta da piramide sempre esteve aberta e convidativa para quem quisesse adentra-la",
					"mas nas últimas viagens que fiz até lá a porta estava fechada",
					"além disso a estatua que ficava na frente da porta da piramide desapareceu, dizem que foi obra dos <color=orange>Tatus Peçonhentos</color>.",
					"Parece que a estatua foi roubada e vendida para um mercador mercenário de <color=yellow>Jadme</color>",
					"Hoje em dia se faz tudo por dinheiro não é?",
					"Eu gostaria de ver novamente a estatua na frente da piramide....\r\n Espero que consiga... "
				}},
				{"Hadjek6",new List<string>()
				{
					"Eu conheci pessoalmente o capitão <color=orange>Atos Aramis</color>. E te digo uma coisa rapaz:",
					"Posso ter sido uma das últimas pessoas que o viu",
					"Ele foi enviado numa missão ultrasecreta dentro da piramide e passou por aqui a caminho de lá",
					"Eu o vi partir de <color=yellow>Hadjek</color>, ele rumou para a piramide, já fazem vários dias. Desde então, ninguém mais o viu",
					"Não quero ser agoro de ninguém, mas...",
					"Todos já pensam no pior",
					"Eu sei que uma curiosidade lhe corroi.\r\n Eu sei porque também me corroeria.\r\n Somos humanos e sucestiveis a curiosidades não é?",
					"A duvida que pode lhe deixar aflito é: Qual era a missão ultrasecreta que levou Atos Aramis até a piramide?",
					"Hora... É ultrasecreta... ninguém deve saber!!",
					"Pois bem...\r\n Eu sei!!",
					"Tudo bem vou te contar. \r\n Ele me contou antes de partir na direção da piramide",
					"Mas te peço uma coisa ein...\r\n Não conte para mais ninguém!",
					"É o seguinte... \r\n Os militares já desconfiam da sanidade do imperador",
					"Sim... da sanidade!! Tanto o exercito quanto a <color=orange>Garra Governamental</color> tem recebido ordens estranhas do imperador",
					"A obcessão do imperador por <color=cyan>Gemas Laranjes</color> preocupa muito as entidades imperialistas",
					"Então... Atos Aramis foi tentar encontrar o Sacerdote dos mistérios para que todos tenham uma luz nos caminhos de Orion",
					"Aparentemente, os militares vão tentar tomar o poder caso sejam convencidos da insanidade do imperador",
					"Isso me assusta!! Não asusta você?"
				}},
				{"Hadjek7",new List<string>()
				{
					"Desde de o surgimento de <color=cyan>Armagedom</color> muitas coisas mudaram em Orion",
					"Ainda me lembro como se fosse ontem, as primeiras transmissões de informação pelos Armagedom's",
					"Hoje em dia os jornais impressos estão quase desaparecendo, naquela época eles eram unanimidade para que pudessemos nos informar sobre o que ocorria em Yoro e em todo Orion",
					"Hoje em dia com o advento das <color=cyan>Luvas de Guarde</color> não precisamos mais parar em frente a uma conexão com Armagedom para recebermos informações,",
					"podemos simplesmente usar nossas luvas de guarde para nos conectar às redes de informação disponivel, ler e assistir as noticias do mundo",
					"Mas junto com o poder de acesso a informação que veio com Armagedom nasceu também uma grande sombra pairando sobre os caminhos de Orion",
					"Para transmitir informação pela rede Armagedom era necessário uma licença expedida pelos imperialistas",
					"Para receber a licença dos imperialistas era necessário ser simpático ao império",
					"Graças a isso pouca informação critica ao império é disseminada por via de Armagedom",
					"<color=orange>Logan</color> e a administração da <color=orange>Garra Governamental</color> controlam quase todos os canais de transmissão de informação disponiveis",
					"Existe um canal controlado por <color=orange>Jack Bandit</color> o inventor das Luva de Guarde e das cartas Luva mas ele também é simpático aos imperialistas.",
					"Assim eles controlam a opinião publica",
					"Afinal ... Quem controla a opinião publicada, controla a opinião pública"
				}},
				{"Hadjek8",new List<string>()
				{
					"Pelos Deuses!!! Você veio cobrar os impostos de novo!!",
					"Não eu não vim, não sou um cobrador de impostos",
					"Você não devia dar esse susto nas pessoas! Você não deveria sair abordando as pessoas vestido desse jeito.",
					"Só essa sua roupa me causa calafrios.",
					"Estamos sendo muito abusados pelos impostos do império.\r\n Eu não entendo por que quem tem mais do que precisa ter quase sempre se convence que não tem o bastante",
					"Essa semana dois foram levados pelo império. Não puderam mais pagar os altos impostos para os imperialistas.",
					"Foram transformados em mão de obra para as minerações de <color=yellow>AxeOdion</color>.\r\n Esse é o destino de quem não pode pagar:  Tornar-se mão de obra escrava para essa obcessão por <color=cyan>Gemas Laranges</color>",
					"E se você continuar andando por ai vestido desse jeito vai acabar indo para lá também"
				}},
				{"Hadjek9",new List<string>()
				{
					"Você já andou de trem?",
					"É muito bom andar de trem.\r\n Podemos assistir o mundo passando pela janela do trem",
					"É quase como se assistissimos uma programação de televisão",
					"É uma pena que a televisão ainda tenha melhores programas que o mundo real passando na janela do trem.",
					"Em <color=yellow>Jadme</color> existe uma ferrovia que liga a cidade até o deserto de <color=yellow>Ofawing</color>.",
					"No deserto de Ofawing fica o prédio <color=yellow>sede da Garra Governamental</color>.",
					"Talvez você queira fazer uma viagem de trem para visitar a Garra Governamental"
				}},
				{"Hadjek10",new List<string>()
				{
					"O prefeito da cidade de <color=yellow>Jadme</color> é um politico muito habilidoso e um dos poucos líderes institucionais que é conhecidamente hostil aos imperialistas",
					"O prefeito de Jadme tem ideias muito assustadoras que incluem acabar com o império.",
					"Em Orion nós sempre vivemos sobre o regime imperialista. O imperador sempre foi o responsável por dar a última palavra nas decisões que envolviam uma grande parcela da população",
					"Não consigo imaginar uma forma de organização social que não seja a imperialista.",
					"O prefeito de Jadme diz que o ideal era que o líder máximo de um continente, estado, principado, país ou até cidade fosse colocado em votação para aprovação da população.",
					"Diz também que as pessoas deveriam escolher seus líderes de tempos em tempos.",
					"Eu acho isso absurdo! O império sempre esteve ai cuidando da Yoro de Orion. É assim que nascemos conhecendo o mundo, isso não pode ser mudado assim de uma hora pra outra",
					"Os apoiadores dessa ideia a chamam de Democracia.\r\n Eu não consigo imaginar um mundo organizado dessa forma."
				}},
				{"Hadjek11",new List<string>()
				{
					"O imperador mandou fechar a <color=yellow>ferrovia de Jadme</color> já faz algum tempo",
					"Isso mudou a rotina das cidades que ficam nessa região de Orion",
					"Muitos empregos eram mantidos pela funcionalidade da ferrovia",
					"Depois de fechada a ferrovia, muitas pessoas ficaram sem trabalhar, outras, como é o caso dos comerciantes, tiveram sua remuneração reduzida pela queda no fluxo de clientes.",
					"Isso trouxe muita tristeza e depressão para os trabalhadores, principalmente os de Jadme e especialmente um trabalhador",
					"<color=orange>Salmo Sadol</color> !!\r\n Ele era o maquinista do trem que fazia a rota Jadme / Ofawing",
					"Depois do fim de seu emprego como maquinista, teve dificuldades pra encontrar outra ocupação. Com o agravamento das dívidas, ele se entregou a bebedeira e sua esposa o abandonou.",
					"Dizem que ela mudou para a casa de parentes numa cidade  ao Norte do vulcão com seu filho pequeno.",
					"Hoje Salmo Sadol é sempre encontrado caido bebado em algum canto da cidade de Jadme. As pessoas que o conhecem dizem que ficou louco e não fala mais coisa com coisa",
					"História triste não?"
				}},
				{"Hadjek12",new List<string>()
				{
					"Em Orion, os responsáveis por escrever os pergaminhos mágicos vendidos nos Shopings são os sacerdotes de <color=cyan>Log</color>",
					"Log, é o deus do conhecimento e da sabedoria. Durante toda uma era de ouro, seus sacerdotes eram muito respeitados e admirados em Orion",
					"Ainda hoje é parecido, mas ... \r\n as vendas de pergaminhos trazem  a desconfiança das pessoas sobre os sacerdotes de Log.",
					"Na verdade... \r\n Ao sacerdote de Log",
					"<color=orange>Baltasar Gladist</color> é o último sacerdote em atividade do deus Log",
					"Os sacerdotes de Log normalmente são muito idosos e nesses últimos anos, a maioria deles veio a falecer.",
					"Milenarmente eles passam de geração para geração a arte de escrever os pergaminhos que podem ser utilizados em conjunto com os Criatures,",
					"mas foi Baltazar quem tornou a venda de pergaminhos um grande negocio rentável impulsionado pela popularização das luvas de Guarde",
					"Curiosamente Baltazar é relativamente jovem em relação aos outros clérigos de Log",
					"Ele aparenta ter por volta de 35~40 anos.",
					"Dizem que ele vive numa luxuosa mansão próxima da cidade de <color=yellow>Cyzor</color>.",
					"Não me parece atitude digna de um sacerdote sagrado se entregar as tentações da riqueza. O que você acha?"
				}},
				{"Hadjek13",new List<string>()
				{
					"<color=orange>Guto Jander</color> é o prefeito da cidade que fica do outro lado do deserto,<color=yellow>Jadme</color>",
					"Sujeitinho Sórdido",
					"Ele está encabeçando um movimento de desestabilizações do nosso amado império liderado por <color=orange>Logan</color>",
					"Na minha luva de guarde recebi várias reportagens falando de ideias que pretendem arruinar o nosso modo de viver em Orion",
					"Eles chamam essa ideia de democracia, dizem que o povo deve estar no poder para decidir por ele mesmo qual caminho tomar",
					"Mas na verdade, o que eles não dizem é que esses lideres nessa chamada democracia serão eles mesmos",
					"O atual prefeito de Jadme pretende acender ao poder ele mesmo e os seus",
					"Hipócritas de uma figa!!"
				}},
				{"Jadme1",new List<string>()
				{
					"Seja muito bem vindo a cidade de <color=yellow>Jadme</color>.",
					"Eu amo muito essa cidade! \r\n E poderia amar mais se não fosse um bebado vagabundo que fica se esgueirando na parte escura da cidade",
					"Tem um desocupado que me incomoda muito, ele se chama <color=orange>Salmo Sadol</color> era o maquinista do trem que levava a <color=yellow>Ofawing</color>.",
					"Depois da desativação da ferrovia algum tempo atrás ele não quis mais saber de trabalhar",
					"Esse tipo de gente me da nojo!!"
				}},
				{"Jadme2",new List<string>()
				{
					"Depois de atravessar o <color=yellow>Rio Mariinque</color> você pode encontrar a entrada do vulcão que é o caminho para a cidade de <color=yellow>Afarenga</color>",
					"Dentro do vulcão, ao norte de Afarenga, existe uma grande <color=yellow>Carvoaria</color>",
					"Nós de Jadme tinhamos muitas relações comerciais com o pessoal da carvoaria",
					"Foi uma lástima o fechamento da ferrovia."
				}},
				{"Jadme3",new List<string>()
				{
					"Ao norte de <color=yellow>Afarenga</color>, a cidade do vulcão, existe um curioso caminho de pontes que formam uma especie de Labirinto",
					"Esse caminho de pontes é conhecido por muitos como <color=yellow>O Segredo dos Sóis</color>",
					"Esse nome é devido a um mecanismo que pode mudar a direção para onde algumas pontes estão apontando. A chave que dispara esse mecanismo tem o formato de um Sol.",
					"O Segredo dos Sóis é o caminho para a <color=cyan>Arena de Laurense</color> o deus da força e da coragem",
					"Na Arena de Laurense você pode ganhar o medalhão da forja que representa o Deus da força."
				}},
				{"Jadme4",new List<string>()
				{
					"<color=orange>Guto Jander</color> é um heroi para nós de <color=yellow>Jadme</color>. \r\n Ele assumiu a cidade numa época muito conturbada, com vários problemas causados pelo fechamento da ferrovia",
					"Ele parecia um iluminado. Com seu discurso feroz contra o império e a proposta de cada povo ser o senhor de seu destino",
					"Eu adimiro muito o prefeito de Jadme e sua teoria da Democracia"
				}},
				{"Jadme5",new List<string>()
				{
					"Tem um sujeitinho meio pirado da cabeça que costumar dormir embaixo do viaduto do trem",
					"Eu sou novo na cidade, mas os mais velhos dizem que ele ficou louco depois que a esposa o abandonou",
					"Ele está sempre jogado em algum canto da cidade mesmo ele tendo uma casa por aqui.",
					"Tentei conversar com ele uma vez, mas ele não fala coisa com coisa.",
					"Começa a misturar histórias de trêm com alienigenas. É uma pena... ",
					"Um pobre homem, jovém e cheio de energia, assim afastado das suas capacidades mentais."
				}},
				{"Jadme6",new List<string>()
				{
					"Dentro do vulcão, ao norte da cidade de <color=yellow>Afarenga</color> fica a <color=yellow>Arena de Laurense</color>",
					"O clérigo de Laurense responsável pela arena é <color=orange>Drooper Rooligan</color>",
					"Ele é conhecido por ser um sujeito acido e altamente leal ao imperador <color=orange>Logan</color>",
					"sua especialidade são Criatures do tipo fogo",
					"Para ganhar o medalhão da forja, que homenageia Laurense, você deve derrotar Drooper numa batalha entre Criatures."
				}},
				{"menuPreJogo",new List<string>()
				{
					"New Game","Load Game","Exit"
				}},
				{"mitPrincipal",new List<string>()
				{
					"Status","Items","Support","Organization","Save"
				}},
				{"mitOrg",new List<string>()
				{
					"Criatures","Attacks","Items"
				}},
				{"mitSoltos",new List<string>()
				{
					"<color=orange>new Save</color>",
					"The criature ",
					" this unconscious and can not walk beside you",
					"This Criature has no ability Support",
					"You do not have any items right now.",
					"CRYSTALS: \r\n ",
					"The save process was carried out"
				}},
				{"painelStatus",new List<string>()
				{
					"Type:   ",
					"reaction time ",
					"Status: ",
					" Lv ",
					"LP : ",
					"EP : ",
					"Power : ",
					"Force : ",
					"Defense : ",
					"Level"
				}},
				{"nomeieSave",new List<string>()
				{
					"Choose a name for your Save",
					"Click in the text box",
					"cancels",
					"Click the button or press ESC on the keyboard",
					"Click the button to confirm the SAVE",
					"confirms",
					"unnamed"
				}},
				{"itens",new List<string>()
				{
					"You can not use this item at this time.",
					"He did not need to use this item at this time.",
					"You can not use this item at this time.",
					"Only Criatures the Type",""
				}},
				{"apresentaInimigo",new List<string>()
				{
					"You found a ",
					"</color> level: ",
					"LP: ",
					"EP: "
				}},
				{"listaDeItens",new List<string>()
				{
					/*ID==0*/"Apple", "Burguer", "Glove Card",
					"Gasolina","Água Tônica",/*ID==5*/"Regador","Estrela","Quartzo","Adubo",
					"Seiva",/*ID==10*/"Inseticida","Aura","Repolho com Ovo","Ventilador","Pilha",
					/*ID==15*/"Gelo Seco","Pergaminho de Fuga","Segredo","Estatua Misteriosa",/*ID==19*/"Crystals"
				}},
				{"shopInfoItem",new List<string>()
				{
					" Maçã recupera 10 PV de um Criature",
					" Burguer recupera 40 PV de um Criature",
					" Carta Luva é usada para tentar capturar novos Criatures",
					" Gasolina recupera 40 PE de um Criature do tipo Fogo",
					" Água Tônica recupera 40 PE de um Criature do tipo Água",
					" Regador recupera 40 PE de um Criature do tipo Planta",
					" Estrela recupera 40 PE de um Criature do tipo Normal",
					" Quartzo recupera 40 PE de um Criature do tipo Pedra",
					" Adubo recupera 40 PE de um Criature do tipo Terra",
					" Seiva recupera 40 PE de um Criature do tipo Inseto",
					" Inseticida recupera 40 PE de um Criature do tipo Veneno",
					" Aura recupera 40 PE de um Criature do tipo Psiquico",
					" Repolho com Ovo recupera 40 PE de um Criature do tipo Gás",
					" Ventilador recupera 40 PE de um Criature do tipo Voador",
					" Pilha recupera 40 PE de um Criature do tipo Eletrico",
					" Gelo Seco recupera 40 PE de um Criature do tipo Gelo"
				}},
				{"ive",new List<string>()
				{
				
				}}
				
			}
		}
	};

	public static void verificaChaves(string primeiro,string segundo)
	{
		if(falacoes.ContainsKey(primeiro)&&falacoes.ContainsKey(segundo))
		{
			Dictionary<string,List<string>>.KeyCollection keys = falacoes[primeiro].Keys;

			foreach(string k in keys)
			{
				if(falacoes[segundo].ContainsKey(k))
				{
					if(falacoes[segundo][k].Count!=falacoes[primeiro][k].Count)
					{
						Debug.Log("As listas de mensagem no indice "+k+" tem tamanhos diferentes");
					}
				}else
				{
					Debug.Log("A lista "+segundo+" nao contem a chave: "+k);
				}
			}
		}else
		{
			Debug.Log("Ele nao contem alguma das chaves");
		}
	}

	/*
	public Dictionary<string,Dictionary<string,int>> nome 
	= new Dictionary<string, Dictionary<string,int>>()
		{{"nome",
			new Dictionary<string,int>(){{"nome2",1}} }};
*/
}
