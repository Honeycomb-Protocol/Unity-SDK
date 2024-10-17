using HplEdgeClient.Responses;
using HplEdgeClient.Params;

using System.Threading.Tasks;

namespace HplEdgeClient.Client
{
  public class HplClient
  {
    public GraphQLClient graphQLClient { get; set; }

    public HplClient(string endpoint)
    {
        graphQLClient = new GraphQLClient(endpoint);
    }

    public async Task<FindCompressedAccountsReturn> FindCompressedAccounts(FindCompressedAccountsParams parameters, string authToken = null)
    {
        string query = @"query findCompressedAccounts(  $addresses: [Bytes!]!  $identity: DisrcriminatorFilter  $leaves: [TreeLeaf!]  $parsedData: JSON) {  compressedAccount(    addresses: $addresses    identity: $identity    leaves: $leaves    parsedData: $parsedData  ) {    leaf_idx    parsed_data    raw_data    schema_validated    tree_id  }}";
        var response = await graphQLClient.Query<FindCompressedAccountsReturn, FindCompressedAccountsParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<FetchProofsReturn> FetchProofs(FetchProofsParams parameters, string authToken = null)
    {
        string query = @"query fetchProofs($leaves: [TreeLeaf!]!) {  proof(leaves: $leaves) {    root    proof    maxDepth    node_index    leaf    leaf_index    tree_id    canopy_depth  }}";
        var response = await graphQLClient.Query<FetchProofsReturn, FetchProofsParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<FindAccountsReturn> FindAccounts(FindAccountsParams parameters, string authToken = null)
    {
        string query = @"query findAccounts(  $programId: Bytes!  $discriminator: Bytes  $parsedData: JSON) {  account(    programId: $programId    discriminator: $discriminator    parsedData: $parsedData  ) {    address    program_id    discriminator    parsed_data  }}";
        var response = await graphQLClient.Query<FindAccountsReturn, FindAccountsParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<SendTransactionBundlesReturn> SendTransactionBundles(SendTransactionBundlesParams parameters, string authToken = null)
    {
        string query = @"query sendTransactionBundles(  $txs: [Bytes!]!  $blockhash: String!  $lastValidBlockHeight: Int!  $options: SendTransactionBundlesOptions) {  sendTransactionBundles(    txs: $txs    blockhash: $blockhash    lastValidBlockHeight: $lastValidBlockHeight    options: $options  ) @stream {    bundleId    responses {      signature      error      status    }  }}";
        var response = await graphQLClient.Query<SendTransactionBundlesReturn, SendTransactionBundlesParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<SignWithShadowSignerAndSendTransactionBundlesReturn> SignWithShadowSignerAndSendTransactionBundles(SignWithShadowSignerAndSendTransactionBundlesParams parameters, string authToken = null)
    {
        string query = @"query signWithShadowSignerAndSendTransactionBundles(  $txs: [Bytes!]!  $blockhash: String!  $lastValidBlockHeight: Int!  $authToken: String!  $options: SendTransactionBundlesOptions) {  signWithShadowSignerAndSendTransactionBundles(    txs: $txs    blockhash: $blockhash    lastValidBlockHeight: $lastValidBlockHeight    authToken: $authToken    options: $options  ) @stream {    bundleId    responses {      signature      error      status    }  }}";
        var response = await graphQLClient.Query<SignWithShadowSignerAndSendTransactionBundlesReturn, SignWithShadowSignerAndSendTransactionBundlesParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<SendBulkTransactionsReturn> SendBulkTransactions(SendBulkTransactionsParams parameters, string authToken = null)
    {
        string query = @"query sendBulkTransactions(  $txs: [Bytes!]!  $blockhash: String!  $lastValidBlockHeight: Int!  $options: SendTransactionBundlesOptions) {  sendBulkTransactions(    txs: $txs    blockhash: $blockhash    lastValidBlockHeight: $lastValidBlockHeight    options: $options  ) {    signature    error    status  }}";
        var response = await graphQLClient.Query<SendBulkTransactionsReturn, SendBulkTransactionsParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<SignWithShadowSignerAndSendBulkTransactionsReturn> SignWithShadowSignerAndSendBulkTransactions(SignWithShadowSignerAndSendBulkTransactionsParams parameters, string authToken = null)
    {
        string query = @"query signWithShadowSignerAndSendBulkTransactions(  $txs: [Bytes!]!  $blockhash: String!  $lastValidBlockHeight: Int!  $options: SendTransactionBundlesOptions) {  signWithShadowSignerAndSendBulkTransactions(    txs: $txs    blockhash: $blockhash    lastValidBlockHeight: $lastValidBlockHeight    options: $options  ) {    signature    error    status  }}";
        var response = await graphQLClient.Query<SignWithShadowSignerAndSendBulkTransactionsReturn, SignWithShadowSignerAndSendBulkTransactionsParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<AuthRequestReturn> AuthRequest(AuthRequestParams parameters, string authToken = null)
    {
        string query = @"query authRequest($wallet: String!, $useTx: Boolean, $useRpc: String) {  authRequest(wallet: $wallet, useTx: $useTx, useRpc: $useRpc) {    message    tx  }}";
        var response = await graphQLClient.Query<AuthRequestReturn, AuthRequestParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<AuthConfirmReturn> AuthConfirm(AuthConfirmParams parameters, string authToken = null)
    {
        string query = @"query authConfirm($wallet: String!, $signature: String!) {  authConfirm(wallet: $wallet, signature: $signature) {    accessToken    user {      address      id      info {        bio        name        pfp      }      wallets {        shadow        wallets      }    }  }}";
        var response = await graphQLClient.Query<AuthConfirmReturn, AuthConfirmParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<FindGlobalReturn> FindGlobal(FindGlobalParams parameters, string authToken = null)
    {
        string query = @"query findGlobal($env: String) {  global(env: $env) {    address    bump    config    userTrees {      active      merkle_trees      schema    }    totalUsers  }}";
        var response = await graphQLClient.Query<FindGlobalReturn, FindGlobalParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<FindProjectsReturn> FindProjects(FindProjectsParams parameters, string authToken = null)
    {
        string query = @"query findProjects(  $addresses: [Bytes!]  $names: [String!]  $authorities: [Pubkey!]) {  project(addresses: $addresses, names: $names, authorities: $authorities) {    associatedPrograms {      address      trustedActions {        kind      }    }    authority    bump    driver    address    key    name    profileDataConfig {      achievements      customDataFields    }    profileTrees {      active      merkle_trees      schema    }    badgeCriteria {      index      condition      endTime      startTime    }    services {      kind      params {        ... on ServiceParamsAssembler {          assemblerId        }        ... on ServiceParamsAssetManager {          assetManagerId        }        ... on ServiceParamsStaking {          poolId        }        ... on ServiceParamsMissions {          poolId        }        ... on ServiceParamsRaffles {          poolId        }        ... on ServiceParamsGuildKit {          kitId        }      }    }    subsidyFees  }}";
        var response = await graphQLClient.Query<FindProjectsReturn, FindProjectsParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<FindDelegateAuthorityReturn> FindDelegateAuthority(FindDelegateAuthorityParams parameters, string authToken = null)
    {
        string query = @"query findDelegateAuthority(  $addresses: [Bytes!]  $delegates: [Pubkey!]  $projects: [Pubkey!]) {  delegateAuthority(    addresses: $addresses    delegates: $delegates    projects: $projects  ) {    authority    bump    delegations {      kind      index      permission    }  }}";
        var response = await graphQLClient.Query<FindDelegateAuthorityReturn, FindDelegateAuthorityParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<FindUsersReturn> FindUsers(FindUsersParams parameters, string authToken = null)
    {
        string query = @"query findUsers(  $addresses: [Bytes!]  $ids: [Int!]  $wallets: [Pubkey!]  $includeProof: Boolean  $includeProjectProfiles: [Pubkey]) {  user(    addresses: $addresses    ids: $ids    wallets: $wallets    includeProof: $includeProof    includeProjectProfiles: $includeProjectProfiles  ) {    address    id    info {      bio      name      pfp      username    }    socialInfo {      discord      twitter      civic {        expiry        gatekeeperNetwork        walletIndex      }      steam    }    wallets {      shadow      wallets    }    profiles {      customData      address      identity      info {        bio        name        pfp      }      platformData {        achievements        custom        xp      }      project      userId      leaf_idx      tree_id      proof {        leaf        leaf_index        node_index        proof        maxDepth        root        tree_id        canopy_depth      }    }    leaf_idx    tree_id    proof {      leaf      leaf_index      node_index      maxDepth      proof      root      tree_id      canopy_depth    }  }}";
        var response = await graphQLClient.Query<FindUsersReturn, FindUsersParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<FindProfilesReturn> FindProfiles(FindProfilesParams parameters, string authToken = null)
    {
        string query = @"query findProfiles(  $addresses: [Bytes!]  $projects: [Pubkey!]  $userIds: [Int!]  $identities: [String!]  $includeProof: Boolean  $includeUsers: Boolean) {  profile(    addresses: $addresses    projects: $projects    userIds: $userIds    identities: $identities    includeProof: $includeProof    includeUsers: $includeUsers  ) {    customData    address    identity    info {      bio      name      pfp    }    platformData {      achievements      custom      xp    }    project    userId    leaf_idx    tree_id    proof {      leaf      leaf_index      node_index      proof      maxDepth      root      tree_id      canopy_depth    }    user {      address      id      info {        bio        name        pfp        username      }      socialInfo {        discord        twitter        civic {          expiry          gatekeeperNetwork          walletIndex        }        steam      }      wallets {        shadow        wallets      }      leaf_idx      tree_id      proof {        leaf        leaf_index        node_index        maxDepth        proof        root        tree_id        canopy_depth      }    }  }}";
        var response = await graphQLClient.Query<FindProfilesReturn, FindProfilesParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<CreateNewUserTransactionReturn> CreateNewUserTransaction(CreateNewUserTransactionParams parameters, string authToken = null)
    {
        string query = @"query createNewUserTransaction(  $wallet: String!  $info: UserInfoInput  $payer: String  $lutAddresses: [String!]  $computeUnitPrice: Int) {  createNewUserTransaction(    wallet: $wallet    info: $info    payer: $payer    lutAddresses: $lutAddresses    computeUnitPrice: $computeUnitPrice  ) {    blockhash    lastValidBlockHeight    transaction  }}";
        var response = await graphQLClient.Query<CreateNewUserTransactionReturn, CreateNewUserTransactionParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<CreateNewUserBulkTransactionReturn> CreateNewUserBulkTransaction(CreateNewUserBulkTransactionParams parameters, string authToken = null)
    {
        string query = @"query createNewUserBulkTransaction(  $wallet: [String!]!  $info: [UserInfoInput!]!  $payer: String!  $lutAddresses: [String!]  $computeUnitPrice: Int) {  createNewUserBulkTransaction(    wallet: $wallet    info: $info    payer: $payer    lutAddresses: $lutAddresses    computeUnitPrice: $computeUnitPrice  ) {    blockhash    lastValidBlockHeight    transactions  }}";
        var response = await graphQLClient.Query<CreateNewUserBulkTransactionReturn, CreateNewUserBulkTransactionParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<CreateUpdateUserTransactionReturn> CreateUpdateUserTransaction(CreateUpdateUserTransactionParams parameters, string authToken = null)
    {
        string query = @"query createUpdateUserTransaction(  $info: PartialUserInfoInput  $wallets: UpdateWalletInput  $payer: String!  $populateCivic: Boolean  $removeSocials: [RemoveSocialsInput!]  $lutAddresses: [String!]  $computeUnitPrice: Int) {  createUpdateUserTransaction(    info: $info    wallets: $wallets    payer: $payer    populateCivic: $populateCivic    removeSocials: $removeSocials    lutAddresses: $lutAddresses    computeUnitPrice: $computeUnitPrice  ) {    blockhash    lastValidBlockHeight    transaction  }}";
        var response = await graphQLClient.Query<CreateUpdateUserTransactionReturn, CreateUpdateUserTransactionParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<CreateCreateProjectTransactionReturn> CreateCreateProjectTransaction(CreateCreateProjectTransactionParams parameters, string authToken = null)
    {
        string query = @"query createCreateProjectTransaction(  $authority: String!  $name: String!  $driver: String  $associatedPrograms: [AssociatedProgramInput!]  $profileDataConfig: ProfileDataConfigInput  $subsidizeFees: Boolean  $payer: String  $lutAddresses: [String!]  $computeUnitPrice: Int) {  createCreateProjectTransaction(    authority: $authority    name: $name    driver: $driver    associatedPrograms: $associatedPrograms    profileDataConfig: $profileDataConfig    subsidizeFees: $subsidizeFees    payer: $payer    lutAddresses: $lutAddresses    computeUnitPrice: $computeUnitPrice  ) {    project    tx {      blockhash      lastValidBlockHeight      transaction    }  }}";
        var response = await graphQLClient.Query<CreateCreateProjectTransactionReturn, CreateCreateProjectTransactionParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<CreateChangeProjectDriverTransactionReturn> CreateChangeProjectDriverTransaction(CreateChangeProjectDriverTransactionParams parameters, string authToken = null)
    {
        string query = @"query createChangeProjectDriverTransaction(  $project: String!  $driver: String!  $authority: String!  $payer: String  $lutAddresses: [String!]  $computeUnitPrice: Int) {  createChangeProjectDriverTransaction(    project: $project    driver: $driver    authority: $authority    payer: $payer    lutAddresses: $lutAddresses    computeUnitPrice: $computeUnitPrice  ) {    transaction    blockhash    lastValidBlockHeight  }}";
        var response = await graphQLClient.Query<CreateChangeProjectDriverTransactionReturn, CreateChangeProjectDriverTransactionParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<CreateCreateDelegateAuthorityTransactionReturn> CreateCreateDelegateAuthorityTransaction(CreateCreateDelegateAuthorityTransactionParams parameters, string authToken = null)
    {
        string query = @"query createCreateDelegateAuthorityTransaction(  $project: String!  $delegate: String!  $serviceDelegations: ServiceDelegationInput!  $authority: String!  $payer: String  $lutAddresses: [String!]  $computeUnitPrice: Int) {  createCreateDelegateAuthorityTransaction(    project: $project    delegate: $delegate    serviceDelegations: $serviceDelegations    authority: $authority    payer: $payer    lutAddresses: $lutAddresses    computeUnitPrice: $computeUnitPrice  ) {    transaction    blockhash    lastValidBlockHeight  }}";
        var response = await graphQLClient.Query<CreateCreateDelegateAuthorityTransactionReturn, CreateCreateDelegateAuthorityTransactionParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<CreateModifyDelegationTransactionReturn> CreateModifyDelegationTransaction(CreateModifyDelegationTransactionParams parameters, string authToken = null)
    {
        string query = @"query createModifyDelegationTransaction(  $project: String!  $delegate: String!  $modifyDelegation: ModifyDelegationInput!  $authority: String!  $payer: String  $lutAddresses: [String!]  $computeUnitPrice: Int) {  createModifyDelegationTransaction(    project: $project    delegate: $delegate    modifyDelegation: $modifyDelegation    authority: $authority    payer: $payer    lutAddresses: $lutAddresses    computeUnitPrice: $computeUnitPrice  ) {    transaction    blockhash    lastValidBlockHeight  }}";
        var response = await graphQLClient.Query<CreateModifyDelegationTransactionReturn, CreateModifyDelegationTransactionParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<CreateCreateProfilesTreeTransactionReturn> CreateCreateProfilesTreeTransaction(CreateCreateProfilesTreeTransactionParams parameters, string authToken = null)
    {
        string query = @"query createCreateProfilesTreeTransaction(  $treeConfig: TreeSetupConfig!  $project: String!  $payer: String!  $lutAddresses: [String!]  $computeUnitPrice: Int) {  createCreateProfilesTreeTransaction(    treeConfig: $treeConfig    project: $project    payer: $payer    lutAddresses: $lutAddresses    computeUnitPrice: $computeUnitPrice  ) {    tx {      blockhash      lastValidBlockHeight      transaction    }    treeAddress    proofBytes    space    cost    maxTreeCapacity  }}";
        var response = await graphQLClient.Query<CreateCreateProfilesTreeTransactionReturn, CreateCreateProfilesTreeTransactionParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<CreateNewProfileTransactionReturn> CreateNewProfileTransaction(CreateNewProfileTransactionParams parameters, string authToken = null)
    {
        string query = @"query createNewProfileTransaction(  $project: String!  $identity: String  $info: ProfileInfoInput  $payer: String!  $lutAddresses: [String!]  $computeUnitPrice: Int) {  createNewProfileTransaction(    project: $project    identity: $identity    info: $info    payer: $payer    lutAddresses: $lutAddresses    computeUnitPrice: $computeUnitPrice  ) {    blockhash    lastValidBlockHeight    transaction  }}";
        var response = await graphQLClient.Query<CreateNewProfileTransactionReturn, CreateNewProfileTransactionParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<CreateUpdateProfileTransactionReturn> CreateUpdateProfileTransaction(CreateUpdateProfileTransactionParams parameters, string authToken = null)
    {
        string query = @"query createUpdateProfileTransaction(  $profile: String!  $payer: String!  $info: ProfileInfoInput  $customData: CustomDataInput  $lutAddresses: [String!]  $computeUnitPrice: Int) {  createUpdateProfileTransaction(    profile: $profile    payer: $payer    info: $info    customData: $customData    lutAddresses: $lutAddresses    computeUnitPrice: $computeUnitPrice  ) {    blockhash    lastValidBlockHeight    transaction  }}";
        var response = await graphQLClient.Query<CreateUpdateProfileTransactionReturn, CreateUpdateProfileTransactionParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<CreateUpdatePlatformDataTransactionReturn> CreateUpdatePlatformDataTransaction(CreateUpdatePlatformDataTransactionParams parameters, string authToken = null)
    {
        string query = @"query createUpdatePlatformDataTransaction(  $profile: String!  $authority: String!  $delegateAuthority: String  $payer: String  $platformData: PlatformDataInput  $lutAddresses: [String!]  $computeUnitPrice: Int) {  createUpdatePlatformDataTransaction(    profile: $profile    authority: $authority    delegateAuthority: $delegateAuthority    payer: $payer    platformData: $platformData    lutAddresses: $lutAddresses    computeUnitPrice: $computeUnitPrice  ) {    blockhash    lastValidBlockHeight    transaction  }}";
        var response = await graphQLClient.Query<CreateUpdatePlatformDataTransactionReturn, CreateUpdatePlatformDataTransactionParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<CreateNewUserWithProfileTransactionReturn> CreateNewUserWithProfileTransaction(CreateNewUserWithProfileTransactionParams parameters, string authToken = null)
    {
        string query = @"query createNewUserWithProfileTransaction(  $project: String!  $wallet: String!  $payer: String  $userInfo: UserInfoInput!  $profileIdentity: String  $lutAddresses: [String!]  $computeUnitPrice: Int) {  createNewUserWithProfileTransaction(    project: $project    wallet: $wallet    userInfo: $userInfo    profileIdentity: $profileIdentity    payer: $payer    lutAddresses: $lutAddresses    computeUnitPrice: $computeUnitPrice  ) {    blockhash    lastValidBlockHeight    transaction  }}";
        var response = await graphQLClient.Query<CreateNewUserWithProfileTransactionReturn, CreateNewUserWithProfileTransactionParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<FindAssemblerConfigReturn> FindAssemblerConfig(FindAssemblerConfigParams parameters, string authToken = null)
    {
        string query = @"query findAssemblerConfig(  $addresses: [Bytes!]  $tickers: [String!]  $characterModel: [Bytes!]  $project: [Pubkey!]) {  assemblerConfig(    addresses: $addresses    tickers: $tickers    characterModel: $characterModel    project: $project  ) {    address    program_id    discriminator    ticker    project    order    merkle_trees {      active      merkle_trees      schema    }  }}";
        var response = await graphQLClient.Query<FindAssemblerConfigReturn, FindAssemblerConfigParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<FindCharacterTraitsReturn> FindCharacterTraits(FindCharacterTraitsParams parameters, string authToken = null)
    {
        string query = @"query findCharacterTraits(  $addresses: [Bytes!]  $trees: [Bytes!]  $includeProof: Boolean) {  characterTrait(    addresses: $addresses    trees: $trees    includeProof: $includeProof  ) {    address    label    leaf_idx    name    proof {      root      proof      node_index      leaf      maxDepth      leaf_index      tree_id      canopy_depth    }    tree_id    uri  }}";
        var response = await graphQLClient.Query<FindCharacterTraitsReturn, FindCharacterTraitsParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<FindCharacterModelsReturn> FindCharacterModels(FindCharacterModelsParams parameters, string authToken = null)
    {
        string query = @"query findCharacterModels(  $addresses: [Bytes!]  $project: Pubkey  $assemblerConfigs: [Pubkey!]) {  characterModel(    addresses: $addresses    project: $project    assemblerConfigs: $assemblerConfigs  ) {    address    program_id    discriminator    bump    key    project    attributes    merkle_trees {      active      merkle_trees      schema    }    config {      ... on CharacterConfigWrapped {        criterias {          kind          params        }        kind      }      ... on CharacterConfigAssembled {        kind        assemblerConfig        name        symbol        description        creators {          address          share        }        sellerFeeBasisPoints        collectionName        mintAs {          kind          params {            ... on MintAsParamsMplBubblegum {              merkleTree            }          }        }      }    }  }}";
        var response = await graphQLClient.Query<FindCharacterModelsReturn, FindCharacterModelsParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<FindCharactersReturn> FindCharacters(FindCharactersParams parameters, string authToken = null)
    {
        string query = @"query findCharacters(  $includeProof: Boolean  $addresses: [Bytes!]  $filters: CharactersFilter  $trees: [Bytes!]  $wallets: [Pubkey!]  $mints: [Pubkey!]  $attributeHashes: [Pubkey!]) {  character(    includeProof: $includeProof    addresses: $addresses    filters: $filters    trees: $trees    wallets: $wallets    mints: $mints    attributeHashes: $attributeHashes  ) {    source {      kind      params {        ... on Wrapped {          mint          criteria {            kind            params          }          kind        }        ... on Assembled {          hash          mint          uri          attributes          assemblerConfig        }      }      kind    }    owner    proof {      leaf      leaf_index      node_index      maxDepth      proof      root      tree_id      canopy_depth    }    usedBy {      kind      params {        ... on UsedByStaking {          pool          staker          stakedAt          claimedAt        }        ... on UsedByMission {          missionId          participationId          rewards {            delta            rewardIdx            collected          }          endTime        }        ... on UsedByGuild {          id          role {            kind          }          order        }        ... on UsedByEjected {          mint        }        ... on UsedByCustom {          user          data        }      }    }    leaf_idx    tree_id    address    asset  }}";
        var response = await graphQLClient.Query<FindCharactersReturn, FindCharactersParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<FetchCharacterHistoryReturn> FetchCharacterHistory(FetchCharacterHistoryParams parameters, string authToken = null)
    {
        string query = @"query fetchCharacterHistory($addresses: [Bytes!]!, $event: [String!]) {  characterHistory(addresses: $addresses, event: $event) {    address    event    event_data    time  }}";
        var response = await graphQLClient.Query<FetchCharacterHistoryReturn, FetchCharacterHistoryParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<CreateCreateAssemblerConfigTransactionReturn> CreateCreateAssemblerConfigTransaction(CreateCreateAssemblerConfigTransactionParams parameters, string authToken = null)
    {
        string query = @"query createCreateAssemblerConfigTransaction(  $treeConfig: TreeSetupConfig!  $ticker: String!  $order: [String!]!  $project: String!  $authority: String!  $payer: String  $lutAddresses: [String!]  $computeUnitPrice: Int) {  createCreateAssemblerConfigTransaction(    treeConfig: $treeConfig    ticker: $ticker    order: $order    project: $project    authority: $authority    payer: $payer    lutAddresses: $lutAddresses    computeUnitPrice: $computeUnitPrice  ) {    tx {      blockhash      lastValidBlockHeight      transaction    }    assemblerConfig    treeAddress    proofBytes    space    cost    maxTreeCapacity  }}";
        var response = await graphQLClient.Query<CreateCreateAssemblerConfigTransactionReturn, CreateCreateAssemblerConfigTransactionParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<CreateAddCharacterTraitsTransactionsReturn> CreateAddCharacterTraitsTransactions(CreateAddCharacterTraitsTransactionsParams parameters, string authToken = null)
    {
        string query = @"query createAddCharacterTraitsTransactions(  $assemblerConfig: String!  $traits: [CharacterTraitInput!]!  $authority: String!  $payer: String  $lutAddresses: [String!]  $computeUnitPrice: Int) {  createAddCharacterTraitsTransactions(    assemblerConfig: $assemblerConfig    traits: $traits    authority: $authority    payer: $payer    lutAddresses: $lutAddresses    computeUnitPrice: $computeUnitPrice  ) {    blockhash    lastValidBlockHeight    transactions  }}";
        var response = await graphQLClient.Query<CreateAddCharacterTraitsTransactionsReturn, CreateAddCharacterTraitsTransactionsParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<CreateRemoveCharacterTraitsTransactionsReturn> CreateRemoveCharacterTraitsTransactions(CreateRemoveCharacterTraitsTransactionsParams parameters, string authToken = null)
    {
        string query = @"query createRemoveCharacterTraitsTransactions(  $assemblerConfig: String!  $traitsAddresses: [String!]!  $authority: String!  $payer: String  $lutAddresses: [String!]  $computeUnitPrice: Int) {  createRemoveCharacterTraitsTransactions(    assemblerConfig: $assemblerConfig    traitsAddresses: $traitsAddresses    authority: $authority    payer: $payer    lutAddresses: $lutAddresses    computeUnitPrice: $computeUnitPrice  ) {    blockhash    lastValidBlockHeight    transactions  }}";
        var response = await graphQLClient.Query<CreateRemoveCharacterTraitsTransactionsReturn, CreateRemoveCharacterTraitsTransactionsParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<CreateCreateCharacterModelTransactionReturn> CreateCreateCharacterModelTransaction(CreateCreateCharacterModelTransactionParams parameters, string authToken = null)
    {
        string query = @"query createCreateCharacterModelTransaction(  $config: CharacterConfigInput!  $project: String!  $authority: String!  $attributes: VecMapGeneric  $mintAs: MintAsInput  $payer: String  $lutAddresses: [String!]  $computeUnitPrice: Int) {  createCreateCharacterModelTransaction(    config: $config    project: $project    authority: $authority    attributes: $attributes    mintAs: $mintAs    payer: $payer    lutAddresses: $lutAddresses    computeUnitPrice: $computeUnitPrice  ) {    characterModel    tx {      blockhash      lastValidBlockHeight      transaction    }  }}";
        var response = await graphQLClient.Query<CreateCreateCharacterModelTransactionReturn, CreateCreateCharacterModelTransactionParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<CreateCreateCharactersTreeTransactionReturn> CreateCreateCharactersTreeTransaction(CreateCreateCharactersTreeTransactionParams parameters, string authToken = null)
    {
        string query = @"query createCreateCharactersTreeTransaction(  $treeConfig: TreeSetupConfig!  $project: String!  $characterModel: String!  $authority: String!  $payer: String  $lutAddresses: [String!]  $computeUnitPrice: Int) {  createCreateCharactersTreeTransaction(    treeConfig: $treeConfig    project: $project    characterModel: $characterModel    authority: $authority    payer: $payer    lutAddresses: $lutAddresses    computeUnitPrice: $computeUnitPrice  ) {    tx {      blockhash      lastValidBlockHeight      transaction    }    treeAddress    proofBytes    space    cost    maxTreeCapacity  }}";
        var response = await graphQLClient.Query<CreateCreateCharactersTreeTransactionReturn, CreateCreateCharactersTreeTransactionParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<CreateAssembleCharacterTransactionReturn> CreateAssembleCharacterTransaction(CreateAssembleCharacterTransactionParams parameters, string authToken = null)
    {
        string query = @"query createAssembleCharacterTransaction(  $attributes: VecMapGeneric!  $project: String!  $assemblerConfig: String!  $characterModel: String!  $owner: String!  $authority: String!  $payer: String  $lutAddresses: [String!]  $computeUnitPrice: Int) {  createAssembleCharacterTransaction(    attributes: $attributes    project: $project    assemblerConfig: $assemblerConfig    characterModel: $characterModel    owner: $owner    authority: $authority    payer: $payer    lutAddresses: $lutAddresses    computeUnitPrice: $computeUnitPrice  ) {    blockhash    lastValidBlockHeight    transaction  }}";
        var response = await graphQLClient.Query<CreateAssembleCharacterTransactionReturn, CreateAssembleCharacterTransactionParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<CreateUpdateCharacterTraitsTransactionReturn> CreateUpdateCharacterTraitsTransaction(CreateUpdateCharacterTraitsTransactionParams parameters, string authToken = null)
    {
        string query = @"query createUpdateCharacterTraitsTransaction(  $characterAddress: String!  $attributes: VecMapGeneric!  $project: String!  $assemblerConfig: String!  $characterModel: String!  $authority: String!  $payer: String  $lutAddresses: [String!]  $computeUnitPrice: Int) {  createUpdateCharacterTraitsTransaction(    characterAddress: $characterAddress    attributes: $attributes    project: $project    assemblerConfig: $assemblerConfig    characterModel: $characterModel    authority: $authority    payer: $payer    lutAddresses: $lutAddresses    computeUnitPrice: $computeUnitPrice  ) {    blockhash    lastValidBlockHeight    transaction  }}";
        var response = await graphQLClient.Query<CreateUpdateCharacterTraitsTransactionReturn, CreateUpdateCharacterTraitsTransactionParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<CreatePopulateCharacterTransactionReturn> CreatePopulateCharacterTransaction(CreatePopulateCharacterTransactionParams parameters, string authToken = null)
    {
        string query = @"query createPopulateCharacterTransaction(  $attributes: VecMapGeneric  $project: String!  $assemblerConfig: String  $characterModel: String!  $mint: String!  $owner: String!  $updateAuthority: String!  $payer: String!  $lutAddresses: [String!]  $computeUnitPrice: Int) {  createPopulateCharacterTransaction(    attributes: $attributes    project: $project    assemblerConfig: $assemblerConfig    characterModel: $characterModel    mint: $mint    owner: $owner    updateAuthority: $updateAuthority    payer: $payer    lutAddresses: $lutAddresses    computeUnitPrice: $computeUnitPrice  ) {    blockhash    lastValidBlockHeight    transaction  }}";
        var response = await graphQLClient.Query<CreatePopulateCharacterTransactionReturn, CreatePopulateCharacterTransactionParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<CreateWrapAssetsToCharacterTransactionsReturn> CreateWrapAssetsToCharacterTransactions(CreateWrapAssetsToCharacterTransactionsParams parameters, string authToken = null)
    {
        string query = @"query createWrapAssetsToCharacterTransactions(  $project: String!  $characterModel: String!  $wallet: String!  $mintList: [String!]!  $libreplexDeployment: String  $lutAddresses: [String!]  $computeUnitPrice: Int) {  createWrapAssetsToCharacterTransactions(    project: $project    characterModel: $characterModel    wallet: $wallet    mintList: $mintList    libreplexDeployment: $libreplexDeployment    lutAddresses: $lutAddresses    computeUnitPrice: $computeUnitPrice  ) {    transactions    blockhash    lastValidBlockHeight  }}";
        var response = await graphQLClient.Query<CreateWrapAssetsToCharacterTransactionsReturn, CreateWrapAssetsToCharacterTransactionsParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<CreateUnwrapAssetsFromCharacterTransactionsReturn> CreateUnwrapAssetsFromCharacterTransactions(CreateUnwrapAssetsFromCharacterTransactionsParams parameters, string authToken = null)
    {
        string query = @"query createUnwrapAssetsFromCharacterTransactions(  $project: String!  $characterAddresses: [String!]!  $characterModel: String!  $wallet: String!  $libreplexDeployment: String  $lutAddresses: [String!]  $computeUnitPrice: Int) {  createUnwrapAssetsFromCharacterTransactions(    characterAddresses: $characterAddresses    characterModel: $characterModel    project: $project    wallet: $wallet    libreplexDeployment: $libreplexDeployment    lutAddresses: $lutAddresses    computeUnitPrice: $computeUnitPrice  ) {    blockhash    lastValidBlockHeight    transactions  }}";
        var response = await graphQLClient.Query<CreateUnwrapAssetsFromCharacterTransactionsReturn, CreateUnwrapAssetsFromCharacterTransactionsParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<FindStakingPoolsReturn> FindStakingPools(FindStakingPoolsParams parameters, string authToken = null)
    {
        string query = @"query findStakingPools(  $addresses: [Bytes!]  $projects: [Pubkey!]  $names: [String!]) {  stakingPools(addresses: $addresses, projects: $projects, names: $names) {    allowedMints    bump    characterModels    cooldownDuration    resource    endTime    key    lockType {      kind    }    maxRewardsDuration    minStakeDuration    name    project    resetStakeDuration    rewardsDuration    rewardsPerDuration    startTime    totalStaked    address  }}";
        var response = await graphQLClient.Query<FindStakingPoolsReturn, FindStakingPoolsParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<FindStakersReturn> FindStakers(FindStakersParams parameters, string authToken = null)
    {
        string query = @"query findStakers(  $addresses: [Bytes!]  $stakingPools: [Pubkey!]  $wallets: [Pubkey!]) {  stakers(    addresses: $addresses    stakingPools: $stakingPools    wallets: $wallets  ) {    bump    stakingPool    totalStaked    wallet  }}";
        var response = await graphQLClient.Query<FindStakersReturn, FindStakersParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<FindMultipliersReturn> FindMultipliers(FindMultipliersParams parameters, string authToken = null)
    {
        string query = @"query findMultipliers($addresses: [Bytes!], $stakingPools: [Pubkey!]) {  multipliers(addresses: $addresses, stakingPools: $stakingPools) {    bump    collectionMultipliers {      multiplierType {        kind        params {          ... on MultiplierTypeParamsStakeDuration {            minDuration          }          ... on MultiplierTypeParamsNFTCount {            minCount          }          ... on MultiplierTypeParamsCreator {            creator          }          ... on MultiplierTypeParamsCollection {            collection          }        }      }      value    }    countMultipliers {      multiplierType {        kind        params {          ... on MultiplierTypeParamsStakeDuration {            minDuration          }          ... on MultiplierTypeParamsNFTCount {            minCount          }          ... on MultiplierTypeParamsCreator {            creator          }          ... on MultiplierTypeParamsCollection {            collection          }        }      }      value    }    creatorMultipliers {      multiplierType {        kind        params {          ... on MultiplierTypeParamsStakeDuration {            minDuration          }          ... on MultiplierTypeParamsNFTCount {            minCount          }          ... on MultiplierTypeParamsCreator {            creator          }          ... on MultiplierTypeParamsCollection {            collection          }        }      }      value    }    decimals    durationMultipliers {      multiplierType {        kind        params {          ... on MultiplierTypeParamsStakeDuration {            minDuration          }          ... on MultiplierTypeParamsNFTCount {            minCount          }          ... on MultiplierTypeParamsCreator {            creator          }          ... on MultiplierTypeParamsCollection {            collection          }        }      }      value    }    address    stakingPool  }}";
        var response = await graphQLClient.Query<FindMultipliersReturn, FindMultipliersParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<CreateCreateStakingPoolTransactionReturn> CreateCreateStakingPoolTransaction(CreateCreateStakingPoolTransactionParams parameters, string authToken = null)
    {
        string query = @"query createCreateStakingPoolTransaction(  $project: String!  $resource: String!  $metadata: CreateStakingPoolMetadataInput!  $authority: String!  $multiplier: InitStakingMultiplierMetadataInput  $delegateAuthority: String  $payer: String  $lutAddresses: [String!]  $computeUnitPrice: Int) {  createCreateStakingPoolTransaction(    project: $project    resource: $resource    metadata: $metadata    authority: $authority    multiplier: $multiplier    delegateAuthority: $delegateAuthority    payer: $payer    lutAddresses: $lutAddresses    computeUnitPrice: $computeUnitPrice  ) {    transactions {      transactions      blockhash      lastValidBlockHeight    }    stakingPoolAddress    multipliersAddress  }}";
        var response = await graphQLClient.Query<CreateCreateStakingPoolTransactionReturn, CreateCreateStakingPoolTransactionParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<CreateUpdateStakingPoolTransactionReturn> CreateUpdateStakingPoolTransaction(CreateUpdateStakingPoolTransactionParams parameters, string authToken = null)
    {
        string query = @"query createUpdateStakingPoolTransaction(  $project: String!  $stakingPool: String!  $metadata: UpdateStakingPoolMetadataInput  $authority: String!  $characterModel: String  $resource: String  $delegateAuthority: String  $payer: String  $lutAddresses: [String!]  $computeUnitPrice: Int) {  createUpdateStakingPoolTransaction(    project: $project    stakingPool: $stakingPool    metadata: $metadata    authority: $authority    characterModel: $characterModel    resource: $resource    delegateAuthority: $delegateAuthority    payer: $payer    lutAddresses: $lutAddresses    computeUnitPrice: $computeUnitPrice  ) {    transaction    blockhash    lastValidBlockHeight  }}";
        var response = await graphQLClient.Query<CreateUpdateStakingPoolTransactionReturn, CreateUpdateStakingPoolTransactionParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<CreateInitMultipliersTransactionReturn> CreateInitMultipliersTransaction(CreateInitMultipliersTransactionParams parameters, string authToken = null)
    {
        string query = @"query createInitMultipliersTransaction(  $project: String!  $stakingPool: String!  $decimals: Int!  $multipliers: [AddMultiplierMetadataInput]!  $authority: String!  $delegateAuthority: String  $payer: String  $lutAddresses: [String!]  $computeUnitPrice: Int) {  createInitMultipliersTransaction(    project: $project    stakingPool: $stakingPool    decimals: $decimals    multipliers: $multipliers    authority: $authority    delegateAuthority: $delegateAuthority    payer: $payer    lutAddresses: $lutAddresses    computeUnitPrice: $computeUnitPrice  ) {    tx {      transaction      blockhash      lastValidBlockHeight    }    multipliersAddress  }}";
        var response = await graphQLClient.Query<CreateInitMultipliersTransactionReturn, CreateInitMultipliersTransactionParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<CreateAddMultiplierTransactionReturn> CreateAddMultiplierTransaction(CreateAddMultiplierTransactionParams parameters, string authToken = null)
    {
        string query = @"query createAddMultiplierTransaction(  $project: String!  $multiplier: String!  $metadata: AddMultiplierMetadataInput!  $authority: String!  $delegateAuthority: String  $payer: String  $lutAddresses: [String!]  $computeUnitPrice: Int) {  createAddMultiplierTransaction(    project: $project    multiplier: $multiplier    metadata: $metadata    authority: $authority    delegateAuthority: $delegateAuthority    payer: $payer    lutAddresses: $lutAddresses    computeUnitPrice: $computeUnitPrice  ) {    transaction    blockhash    lastValidBlockHeight  }}";
        var response = await graphQLClient.Query<CreateAddMultiplierTransactionReturn, CreateAddMultiplierTransactionParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<CreateStakeCharactersTransactionsReturn> CreateStakeCharactersTransactions(CreateStakeCharactersTransactionsParams parameters, string authToken = null)
    {
        string query = @"query createStakeCharactersTransactions(  $characterAddresses: [String!]!  $characterModel: String!  $stakingPool: String!  $project: String!  $feePayer: String  $lutAddresses: [String!]  $computeUnitPrice: Int) {  createStakeCharactersTransactions(    characterAddresses: $characterAddresses    characterModel: $characterModel    stakingPool: $stakingPool    project: $project    feePayer: $feePayer    lutAddresses: $lutAddresses    computeUnitPrice: $computeUnitPrice  ) {    blockhash    lastValidBlockHeight    transactions  }}";
        var response = await graphQLClient.Query<CreateStakeCharactersTransactionsReturn, CreateStakeCharactersTransactionsParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<CreateClaimStakingRewardsTransactionsReturn> CreateClaimStakingRewardsTransactions(CreateClaimStakingRewardsTransactionsParams parameters, string authToken = null)
    {
        string query = @"query createClaimStakingRewardsTransactions(  $characterAddresses: [String!]!  $characterModel: String!  $feePayer: String  $lutAddresses: [String!]  $computeUnitPrice: Int) {  createClaimStakingRewardsTransactions(    characterAddresses: $characterAddresses    characterModel: $characterModel    feePayer: $feePayer    lutAddresses: $lutAddresses    computeUnitPrice: $computeUnitPrice  ) {    blockhash    lastValidBlockHeight    transactions  }}";
        var response = await graphQLClient.Query<CreateClaimStakingRewardsTransactionsReturn, CreateClaimStakingRewardsTransactionsParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<CreateUnstakeCharactersTransactionsReturn> CreateUnstakeCharactersTransactions(CreateUnstakeCharactersTransactionsParams parameters, string authToken = null)
    {
        string query = @"query createUnstakeCharactersTransactions(  $characterAddresses: [String!]!  $characterModel: String!  $feePayer: String  $lutAddresses: [String!]  $computeUnitPrice: Int) {  createUnstakeCharactersTransactions(    characterAddresses: $characterAddresses    characterModel: $characterModel    feePayer: $feePayer    lutAddresses: $lutAddresses    computeUnitPrice: $computeUnitPrice  ) {    blockhash    lastValidBlockHeight    transactions  }}";
        var response = await graphQLClient.Query<CreateUnstakeCharactersTransactionsReturn, CreateUnstakeCharactersTransactionsParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<FindMissionsReturn> FindMissions(FindMissionsParams parameters, string authToken = null)
    {
        string query = @"query findMissions($addresses: [Bytes!], $missionPools: [Pubkey!]) {  mission(addresses: $addresses, missionPools: $missionPools) {    address    program_id    discriminator    bump    missionPool    name    minXp    cost {      amount      resource_address    }    requirement {      ... on TimeRequirement {        kind        params {          duration        }      }    }    rewards {      min      max      rewardType {        ... on XpRewardType {          kind        }        ... on ResourceRewardType {          kind          params {            address          }        }      }    }  }}";
        var response = await graphQLClient.Query<FindMissionsReturn, FindMissionsParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<FindMissionPoolsReturn> FindMissionPools(FindMissionPoolsParams parameters, string authToken = null)
    {
        string query = @"query findMissionPools($addresses: [Bytes!], $project: Pubkey) {  missionPool(addresses: $addresses, project: $project) {    address    program_id    discriminator    bump    project    name    factionsMerkleRoot    randomizerRound    characterModels    guildKits  }}";
        var response = await graphQLClient.Query<FindMissionPoolsReturn, FindMissionPoolsParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<CreateCreateMissionPoolTransactionReturn> CreateCreateMissionPoolTransaction(CreateCreateMissionPoolTransactionParams parameters, string authToken = null)
    {
        string query = @"query createCreateMissionPoolTransaction(  $data: NewMissionPoolData!  $lutAddresses: [String!]  $computeUnitPrice: Int) {  createCreateMissionPoolTransaction(    data: $data    lutAddresses: $lutAddresses    computeUnitPrice: $computeUnitPrice  ) {    tx {      transaction      blockhash      lastValidBlockHeight    }    missionPoolAddress  }}";
        var response = await graphQLClient.Query<CreateCreateMissionPoolTransactionReturn, CreateCreateMissionPoolTransactionParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<CreateUpdateMissionPoolTransactionReturn> CreateUpdateMissionPoolTransaction(CreateUpdateMissionPoolTransactionParams parameters, string authToken = null)
    {
        string query = @"query createUpdateMissionPoolTransaction(  $data: UpdateMissionPoolData!  $lutAddresses: [String!]  $computeUnitPrice: Int) {  createUpdateMissionPoolTransaction(    data: $data    lutAddresses: $lutAddresses    computeUnitPrice: $computeUnitPrice  ) {    tx {      transaction      blockhash      lastValidBlockHeight    }  }}";
        var response = await graphQLClient.Query<CreateUpdateMissionPoolTransactionReturn, CreateUpdateMissionPoolTransactionParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<CreateCreateMissionTransactionReturn> CreateCreateMissionTransaction(CreateCreateMissionTransactionParams parameters, string authToken = null)
    {
        string query = @"query createCreateMissionTransaction(  $data: NewMissionData!  $lutAddresses: [String!]  $computeUnitPrice: Int) {  createCreateMissionTransaction(    data: $data    lutAddresses: $lutAddresses    computeUnitPrice: $computeUnitPrice  ) {    tx {      transaction      blockhash      lastValidBlockHeight    }    missionAddress  }}";
        var response = await graphQLClient.Query<CreateCreateMissionTransactionReturn, CreateCreateMissionTransactionParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<CreateUpdateMissionTransactionReturn> CreateUpdateMissionTransaction(CreateUpdateMissionTransactionParams parameters, string authToken = null)
    {
        string query = @"query createUpdateMissionTransaction(  $missionAddress: String!  $authority: String!  $params: UpdateMissionInput!  $payer: String  $delegateAuthority: String  $lutAddresses: [String!]  $computeUnitPrice: Int) {  createUpdateMissionTransaction(    missionAddress: $missionAddress    authority: $authority    params: $params    payer: $payer    delegateAuthority: $delegateAuthority    lutAddresses: $lutAddresses    computeUnitPrice: $computeUnitPrice  ) {    transaction    blockhash    lastValidBlockHeight  }}";
        var response = await graphQLClient.Query<CreateUpdateMissionTransactionReturn, CreateUpdateMissionTransactionParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<CreateSendCharactersOnMissionTransactionReturn> CreateSendCharactersOnMissionTransaction(CreateSendCharactersOnMissionTransactionParams parameters, string authToken = null)
    {
        string query = @"query createSendCharactersOnMissionTransaction(  $data: ParticipateOnMissionData!  $lutAddresses: [String!]  $computeUnitPrice: Int) {  createSendCharactersOnMissionTransaction(    data: $data    lutAddresses: $lutAddresses    computeUnitPrice: $computeUnitPrice  ) {    transactions    blockhash    lastValidBlockHeight  }}";
        var response = await graphQLClient.Query<CreateSendCharactersOnMissionTransactionReturn, CreateSendCharactersOnMissionTransactionParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<CreateRecallCharactersTransactionReturn> CreateRecallCharactersTransaction(CreateRecallCharactersTransactionParams parameters, string authToken = null)
    {
        string query = @"query createRecallCharactersTransaction(  $data: RecallFromMissionData!  $lutAddresses: [String!]  $computeUnitPrice: Int) {  createRecallCharactersTransaction(    data: $data    lutAddresses: $lutAddresses    computeUnitPrice: $computeUnitPrice  ) {    transactions    blockhash    lastValidBlockHeight  }}";
        var response = await graphQLClient.Query<CreateRecallCharactersTransactionReturn, CreateRecallCharactersTransactionParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<FindResourcesReturn> FindResources(FindResourcesParams parameters, string authToken = null)
    {
        string query = @"query findResources(  $addresses: [Bytes!]  $projects: [Pubkey!]  $mints: [Pubkey!]) {  resources(addresses: $addresses, projects: $projects, mints: $mints) {    address    bump    kind {      kind      params {        ... on ResourceKindParamsHplFungible {          __typename          decimals        }        ... on ResourceKindParamsWrappedFungible {          __typename          decimals          custody {            kind            params {              burnerDestination            }          }        }        ... on ResourceKindParamsHplNonFungible {          __typename          characteristics        }        ... on ResourceKindParamsWrappedMplCore {          __typename          characteristics        }      }    }    mint    project    storage {      params {        promiseSupply        merkle_trees {          active          merkle_trees          schema        }      }      kind    }  }}";
        var response = await graphQLClient.Query<FindResourcesReturn, FindResourcesParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<FindResourcesBalanceReturn> FindResourcesBalance(FindResourcesBalanceParams parameters, string authToken = null)
    {
        string query = @"query findResourcesBalance(  $addresses: [String!]  $projects: [String!]  $mints: [String!]  $wallets: [String!]) {  resourcesBalance(    projects: $projects    wallets: $wallets    mints: $mints    addresses: $addresses  ) {    address    amount    mint    wallet    resourceStorage  }}";
        var response = await graphQLClient.Query<FindResourcesBalanceReturn, FindResourcesBalanceParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<FindFaucetsReturn> FindFaucets(FindFaucetsParams parameters, string authToken = null)
    {
        string query = @"query findFaucets(  $addresses: [Bytes!]  $projects: [Pubkey!]  $resources: [Pubkey!]) {  faucets(addresses: $addresses, projects: $projects, resources: $resources) {    resource    repeatInterval    project    amount    lastClaimed    address  }}";
        var response = await graphQLClient.Query<FindFaucetsReturn, FindFaucetsParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<FindRecipesReturn> FindRecipes(FindRecipesParams parameters, string authToken = null)
    {
        string query = @"query findRecipes($addresses: [Bytes!], $projects: [Pubkey!]) {  recipes(addresses: $addresses, projects: $projects) {    address    bump    ingredients {      amount      resourceAddress    }    key    meal {      amount      resourceAddress    }    project    xp  }}";
        var response = await graphQLClient.Query<FindRecipesReturn, FindRecipesParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<FindHoldingsReturn> FindHoldings(FindHoldingsParams parameters, string authToken = null)
    {
        string query = @"query findHoldings(  $addresses: [Bytes!]  $holders: [Pubkey]  $trees: [Bytes!]  $includeProof: Boolean) {  holdings(    addresses: $addresses    holders: $holders    trees: $trees    includeProof: $includeProof  ) {    address    balance    characteristics    holder    leaf_idx    tree_id    proof {      canopy_depth      leaf      leaf_index      maxDepth      node_index      proof      root      tree_id    }  }}";
        var response = await graphQLClient.Query<FindHoldingsReturn, FindHoldingsParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<CreateCreateNewResourceTransactionReturn> CreateCreateNewResourceTransaction(CreateCreateNewResourceTransactionParams parameters, string authToken = null)
    {
        string query = @"query createCreateNewResourceTransaction(  $project: String!  $authority: String!  $params: InitResourceInput!  $delegateAuthority: String  $payer: String  $lutAddresses: [String!]  $computeUnitPrice: Int) {  createCreateNewResourceTransaction(    project: $project    authority: $authority    params: $params    delegateAuthority: $delegateAuthority    payer: $payer    lutAddresses: $lutAddresses    computeUnitPrice: $computeUnitPrice  ) {    tx {      transaction      blockhash      lastValidBlockHeight    }    resource  }}";
        var response = await graphQLClient.Query<CreateCreateNewResourceTransactionReturn, CreateCreateNewResourceTransactionParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<CreateImportFungibleResourceTransactionReturn> CreateImportFungibleResourceTransaction(CreateImportFungibleResourceTransactionParams parameters, string authToken = null)
    {
        string query = @"query createImportFungibleResourceTransaction(  $params: ImportResourceInput!  $lutAddresses: [String!]  $computeUnitPrice: Int) {  createImportFungibleResourceTransaction(    params: $params    lutAddresses: $lutAddresses    computeUnitPrice: $computeUnitPrice  ) {    resource    tx {      blockhash      lastValidBlockHeight      transaction    }  }}";
        var response = await graphQLClient.Query<CreateImportFungibleResourceTransactionReturn, CreateImportFungibleResourceTransactionParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<CreateExportFungibleResourceTransactionReturn> CreateExportFungibleResourceTransaction(CreateExportFungibleResourceTransactionParams parameters, string authToken = null)
    {
        string query = @"query createExportFungibleResourceTransaction(  $resource: String!  $authority: String!  $delegateAuthority: String  $lutAddresses: [String!]  $computeUnitPrice: Int) {  createExportFungibleResourceTransaction(    resource: $resource    authority: $authority    delegateAuthority: $delegateAuthority    lutAddresses: $lutAddresses    computeUnitPrice: $computeUnitPrice  ) {    blockhash    lastValidBlockHeight    transaction  }}";
        var response = await graphQLClient.Query<CreateExportFungibleResourceTransactionReturn, CreateExportFungibleResourceTransactionParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<CreateCreateNewResourceTreeTransactionReturn> CreateCreateNewResourceTreeTransaction(CreateCreateNewResourceTreeTransactionParams parameters, string authToken = null)
    {
        string query = @"query createCreateNewResourceTreeTransaction(  $project: String!  $resource: String!  $authority: String!  $treeConfig: TreeSetupConfig!  $delegateAuthority: String  $payer: String  $lutAddresses: [String!]  $computeUnitPrice: Int) {  createCreateNewResourceTreeTransaction(    project: $project    resource: $resource    authority: $authority    treeConfig: $treeConfig    delegateAuthority: $delegateAuthority    payer: $payer    lutAddresses: $lutAddresses    computeUnitPrice: $computeUnitPrice  ) {    tx {      blockhash      lastValidBlockHeight      transaction    }    treeAddress    proofBytes    space    cost    maxTreeCapacity  }}";
        var response = await graphQLClient.Query<CreateCreateNewResourceTreeTransactionReturn, CreateCreateNewResourceTreeTransactionParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<CreateMintResourceTransactionReturn> CreateMintResourceTransaction(CreateMintResourceTransactionParams parameters, string authToken = null)
    {
        string query = @"query createMintResourceTransaction(  $resource: String!  $owner: String!  $authority: String!  $amount: BigInt!  $delegateAuthority: String  $payer: String  $lutAddresses: [String!]  $computeUnitPrice: Int) {  createMintResourceTransaction(    resource: $resource    owner: $owner    authority: $authority    amount: $amount    delegateAuthority: $delegateAuthority    payer: $payer    lutAddresses: $lutAddresses    computeUnitPrice: $computeUnitPrice  ) {    transaction    blockhash    lastValidBlockHeight  }}";
        var response = await graphQLClient.Query<CreateMintResourceTransactionReturn, CreateMintResourceTransactionParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<CreateBurnResourceTransactionReturn> CreateBurnResourceTransaction(CreateBurnResourceTransactionParams parameters, string authToken = null)
    {
        string query = @"query createBurnResourceTransaction(  $resource: String!  $amount: BigInt!  $authority: String!  $owner: String  $delegateAuthority: String  $payer: String  $lutAddresses: [String!]  $computeUnitPrice: Int) {  createBurnResourceTransaction(    resource: $resource    amount: $amount    authority: $authority    owner: $owner    payer: $payer    delegateAuthority: $delegateAuthority    lutAddresses: $lutAddresses    computeUnitPrice: $computeUnitPrice  ) {    transaction    blockhash    lastValidBlockHeight  }}";
        var response = await graphQLClient.Query<CreateBurnResourceTransactionReturn, CreateBurnResourceTransactionParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<CreateTransferResourceTransactionReturn> CreateTransferResourceTransaction(CreateTransferResourceTransactionParams parameters, string authToken = null)
    {
        string query = @"query createTransferResourceTransaction(  $resource: String!  $owner: String!  $recipient: String!  $amount: BigInt!  $payer: String  $lutAddresses: [String!]  $computeUnitPrice: Int) {  createTransferResourceTransaction(    resource: $resource    owner: $owner    recipient: $recipient    amount: $amount    payer: $payer    lutAddresses: $lutAddresses    computeUnitPrice: $computeUnitPrice  ) {    transaction    blockhash    lastValidBlockHeight  }}";
        var response = await graphQLClient.Query<CreateTransferResourceTransactionReturn, CreateTransferResourceTransactionParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<CreateCreateWrapHoldingTransactionReturn> CreateCreateWrapHoldingTransaction(CreateCreateWrapHoldingTransactionParams parameters, string authToken = null)
    {
        string query = @"query createCreateWrapHoldingTransaction(  $resource: String!  $amount: BigInt!  $authority: String!  $payer: String  $lutAddresses: [String!]  $computeUnitPrice: Int) {  createCreateWrapHoldingTransaction(    resource: $resource    amount: $amount    authority: $authority    payer: $payer    lutAddresses: $lutAddresses    computeUnitPrice: $computeUnitPrice  ) {    transaction    blockhash    lastValidBlockHeight  }}";
        var response = await graphQLClient.Query<CreateCreateWrapHoldingTransactionReturn, CreateCreateWrapHoldingTransactionParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<CreateCreateUnwrapHoldingTransactionReturn> CreateCreateUnwrapHoldingTransaction(CreateCreateUnwrapHoldingTransactionParams parameters, string authToken = null)
    {
        string query = @"query createCreateUnwrapHoldingTransaction(  $resource: String!  $amount: BigInt!  $authority: String!  $payer: String  $lutAddresses: [String!]  $computeUnitPrice: Int) {  createCreateUnwrapHoldingTransaction(    resource: $resource    amount: $amount    authority: $authority    payer: $payer    lutAddresses: $lutAddresses    computeUnitPrice: $computeUnitPrice  ) {    transaction    blockhash    lastValidBlockHeight  }}";
        var response = await graphQLClient.Query<CreateCreateUnwrapHoldingTransactionReturn, CreateCreateUnwrapHoldingTransactionParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<CreateInitializeRecipeTransactionReturn> CreateInitializeRecipeTransaction(CreateInitializeRecipeTransactionParams parameters, string authToken = null)
    {
        string query = @"query createInitializeRecipeTransaction(  $project: String!  $xp: BigInt!  $ingredients: [IngredientsInput!]!  $meal: MealInput!  $authority: String!  $delegateAuthority: String  $payer: String  $lutAddresses: [String!]  $computeUnitPrice: Int) {  createInitializeRecipeTransaction(    project: $project    xp: $xp    ingredients: $ingredients    meal: $meal    authority: $authority    delegateAuthority: $delegateAuthority    payer: $payer    lutAddresses: $lutAddresses    computeUnitPrice: $computeUnitPrice  ) {    recipe    transactions {      transactions      blockhash      lastValidBlockHeight    }  }}";
        var response = await graphQLClient.Query<CreateInitializeRecipeTransactionReturn, CreateInitializeRecipeTransactionParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<CreateAddIngredientsTransactionReturn> CreateAddIngredientsTransaction(CreateAddIngredientsTransactionParams parameters, string authToken = null)
    {
        string query = @"query createAddIngredientsTransaction(  $recipe: String!  $ingredients: [IngredientsInput!]!  $authority: String!  $delegateAuthority: String  $payer: String  $lutAddresses: [String!]  $computeUnitPrice: Int) {  createAddIngredientsTransaction(    recipe: $recipe    ingredients: $ingredients    authority: $authority    delegateAuthority: $delegateAuthority    payer: $payer    lutAddresses: $lutAddresses    computeUnitPrice: $computeUnitPrice  ) {    transactions    blockhash    lastValidBlockHeight  }}";
        var response = await graphQLClient.Query<CreateAddIngredientsTransactionReturn, CreateAddIngredientsTransactionParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<CreateRemoveIngredientsTransactionReturn> CreateRemoveIngredientsTransaction(CreateRemoveIngredientsTransactionParams parameters, string authToken = null)
    {
        string query = @"query createRemoveIngredientsTransaction(  $recipe: String!  $ingredients: [String!]!  $authority: String!  $delegateAuthority: String  $payer: String  $lutAddresses: [String!]  $computeUnitPrice: Int) {  createRemoveIngredientsTransaction(    recipe: $recipe    ingredients: $ingredients    authority: $authority    delegateAuthority: $delegateAuthority    payer: $payer    lutAddresses: $lutAddresses    computeUnitPrice: $computeUnitPrice  ) {    transactions    blockhash    lastValidBlockHeight  }}";
        var response = await graphQLClient.Query<CreateRemoveIngredientsTransactionReturn, CreateRemoveIngredientsTransactionParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<CreateInitializeFaucetTransactionReturn> CreateInitializeFaucetTransaction(CreateInitializeFaucetTransactionParams parameters, string authToken = null)
    {
        string query = @"query createInitializeFaucetTransaction(  $resource: String!  $amount: Int!  $repeatInterval: Int!  $authority: String!  $delegateAuthority: String  $payer: String  $lutAddresses: [String!]  $computeUnitPrice: Int) {  createInitializeFaucetTransaction(    resource: $resource    amount: $amount    repeatInterval: $repeatInterval    authority: $authority    delegateAuthority: $delegateAuthority    payer: $payer    lutAddresses: $lutAddresses    computeUnitPrice: $computeUnitPrice  ) {    tx {      transaction      blockhash      lastValidBlockHeight    }    faucet  }}";
        var response = await graphQLClient.Query<CreateInitializeFaucetTransactionReturn, CreateInitializeFaucetTransactionParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<CreateClaimFaucetTransactionReturn> CreateClaimFaucetTransaction(CreateClaimFaucetTransactionParams parameters, string authToken = null)
    {
        string query = @"query createClaimFaucetTransaction(  $faucet: String!  $owner: String!  $payer: String  $lutAddresses: [String!]  $computeUnitPrice: Int) {  createClaimFaucetTransaction(    faucet: $faucet    owner: $owner    payer: $payer    lutAddresses: $lutAddresses    computeUnitPrice: $computeUnitPrice  ) {    transaction    blockhash    lastValidBlockHeight  }}";
        var response = await graphQLClient.Query<CreateClaimFaucetTransactionReturn, CreateClaimFaucetTransactionParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<CreateInitCookingProcessTransactionsReturn> CreateInitCookingProcessTransactions(CreateInitCookingProcessTransactionsParams parameters, string authToken = null)
    {
        string query = @"query createInitCookingProcessTransactions(  $recipe: String!  $authority: String!  $payer: String  $computeUnitPrice: Int  $lutAddresses: [String!]) {  createInitCookingProcessTransactions(    authority: $authority    recipe: $recipe    payer: $payer    computeUnitPrice: $computeUnitPrice    lutAddresses: $lutAddresses  ) {    blockhash    lastValidBlockHeight    transactions  }}";
        var response = await graphQLClient.Query<CreateInitCookingProcessTransactionsReturn, CreateInitCookingProcessTransactionsParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<CreateInitializeBadgeCriteriaTransactionReturn> CreateInitializeBadgeCriteriaTransaction(CreateInitializeBadgeCriteriaTransactionParams parameters, string authToken = null)
    {
        string query = @"query createInitializeBadgeCriteriaTransaction(  $args: CreateBadgeCriteriaInput!  $lutAddresses: [String!]  $computeUnitPrice: Int) {  createInitializeBadgeCriteriaTransaction(    args: $args    lutAddresses: $lutAddresses    computeUnitPrice: $computeUnitPrice  ) {    transaction    blockhash    lastValidBlockHeight  }}";
        var response = await graphQLClient.Query<CreateInitializeBadgeCriteriaTransactionReturn, CreateInitializeBadgeCriteriaTransactionParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<CreateClaimBadgeCriteriaTransactionReturn> CreateClaimBadgeCriteriaTransaction(CreateClaimBadgeCriteriaTransactionParams parameters, string authToken = null)
    {
        string query = @"query createClaimBadgeCriteriaTransaction(  $args: ClaimBadgeCriteriaInput!  $lutAddresses: [String!]  $computeUnitPrice: Int) {  createClaimBadgeCriteriaTransaction(    args: $args    lutAddresses: $lutAddresses    computeUnitPrice: $computeUnitPrice  ) {    transaction    blockhash    lastValidBlockHeight  }}";
        var response = await graphQLClient.Query<CreateClaimBadgeCriteriaTransactionReturn, CreateClaimBadgeCriteriaTransactionParams>(query, parameters, authToken);
        return response.GetData();
    }

    public async Task<CreateUpdateBadgeCriteriaTransactionReturn> CreateUpdateBadgeCriteriaTransaction(CreateUpdateBadgeCriteriaTransactionParams parameters, string authToken = null)
    {
        string query = @"query createUpdateBadgeCriteriaTransaction(  $args: UpdateBadgeCriteriaInput!  $lutAddresses: [String!]  $computeUnitPrice: Int) {  createUpdateBadgeCriteriaTransaction(    args: $args    lutAddresses: $lutAddresses    computeUnitPrice: $computeUnitPrice  ) {    transaction    blockhash    lastValidBlockHeight  }}";
        var response = await graphQLClient.Query<CreateUpdateBadgeCriteriaTransactionReturn, CreateUpdateBadgeCriteriaTransactionParams>(query, parameters, authToken);
        return response.GetData();
    }

}

}

